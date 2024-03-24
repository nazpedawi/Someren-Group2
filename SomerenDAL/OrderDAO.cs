using Microsoft.Data.SqlClient;
using SomerenModel;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SomerenDAL
{
    public class OrderDAO
    {

        private SqlConnection dbConnection;
        public OrderDAO()
        {
            try
            {
                string connString = ConfigurationManager
                    .ConnectionStrings["DBConnectionString"]
                    .ConnectionString;

                dbConnection = new SqlConnection(connString);
            }
            catch (Exception ex)
            {
                throw new Exception("An Error occured while configuring database connection.", ex);
            }
        }
        public List<Order> GetAll()
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName, Age, PhoneNumber FROM Orderss", dbConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Order> Orders = new List<Order>();
                while (reader.Read())
                {
                    Order Order = ReadOrders(reader);
                    Orders.Add(Order);
                }
                reader.Close();
                return Orders;
            }
            catch (SqlException ex)
            {
                throw new Exception("An Error Occured While Retrieving 'Orderss' From The Database", ex);
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }
        private Order ReadOrders(SqlDataReader reader)
        {
            try
            {
                int studentNumber = (int)reader["StudentNumber"];
                int drinkId = (int)reader["DrinkId"];
                int numberOfDrinks = (int)reader["NumberOfDrinks"];

                return new Order(studentNumber, drinkId, numberOfDrinks);
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occured While Reading 'Orders' Data", ex);
            }
        }
        public Order AddOrder(Drink drink)
        {
            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Orders VALUES (@StudentNumber, @DrinkId, @NumberOfDrinks);"
                + "SELECT CAST(scope_identity() AS int)", dbConnection);
            cmd.Parameters.AddWithValue("@StudentNumber", drink.Name);
            cmd.Parameters.AddWithValue("@DrinkId", drink.Type);
            cmd.Parameters.AddWithValue("@NumberOfDrinks", drink.Price);

            dbConnection.Close();
            return new Order(studentNumber, drinkId, numberOfDrinks);
        }
    }
}
