using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;
using SomerenModel;
using System.Data;

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
                SqlCommand cmd = new SqlCommand("SELECT StudentNumber, DrinkId, NumberOfDrinks FROM orders", dbConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Order> orders = new List<Order>();
                while (reader.Read())
                {
                    Order order = ReadOrder(reader);
                    orders.Add(order);
                }
                reader.Close();
                dbConnection.Close();
                return orders;
            }

            catch (SqlException ex)
            {
                throw new Exception("An Error Occured While Retrieving 'Orders' From The Database", ex);
            }
        }

        private Order ReadOrder(SqlDataReader reader)
        {
            try
            {
                int studentnumber = (int)reader["StudentNumber"];
                int drinkid = (int)reader["DrinkId"];
                int numberofdrinks = (int)reader["NumberOfDrinks"];

                return new Order(studentnumber, drinkid, numberofdrinks, DateTime.Now);
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occured While Reading 'Order' Data", ex);
            }
        }

        public Order AddOrder(Order order)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Orders (StudentNumber, DrinkId, NumberOfDrinks, OrderDate) VALUES (@StudentNumber, @DrinkId, @NumberOfDrinks, GETDATE()); SELECT CAST(scope_identity() AS int)", dbConnection);
                cmd.Parameters.AddWithValue("@StudentNumber", order.StudentNumber);
                cmd.Parameters.AddWithValue("@DrinkId", order.DrinkId);
                cmd.Parameters.AddWithValue("@NumberOfDrinks", order.NumberOfDrinks);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate); // Add OrderDate parameter
                cmd.ExecuteNonQuery();
                dbConnection.Close();
                return new Order(order.StudentNumber, order.DrinkId, order.NumberOfDrinks, order.OrderDate);
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occurred While Adding Order to Database", ex);
            }
        }

        public void UpdateStock(Drink drink, int NumberOfDrinks)
        {
            try {
                
                    dbConnection.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE drinks SET StockAmount = @StockAmount - @NumberOfDrinks WHERE DrinkId = @DrinkId;", dbConnection);
                    cmd.Parameters.AddWithValue("@NumberOfDrinks", NumberOfDrinks);
                    cmd.Parameters.AddWithValue("@DrinkId", drink.DrinkID);
                    cmd.ExecuteNonQuery();
                    dbConnection.Close();
                
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while updating the drink stock", ex);
            }
        }
    }
}
