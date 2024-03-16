using Microsoft.Data.SqlClient;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SomerenDAL
{
    public class DrinkDAO
    {
        private SqlConnection dbConnection;
        public DrinkDAO()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["DBConnectionString"]
                .ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<Drink> GetAll()
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Drinks", dbConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Drink> drinks = new List<Drink>();
                while (reader.Read())
                {
                    Drink drink = ReadDrink(reader);
                    drinks.Add(drink);
                }
                reader.Close();
                return drinks;
            }

            catch (SqlException ex)
            {
                throw new Exception("An Error Occured While Retrieving 'Drinks' From The Database", ex);
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }
        private Drink ReadDrink(SqlDataReader reader)
        {
            try
            {
                int drinkid = (int)reader["DrinkID"];
                string name = (string)reader["Name"];
                string type = (string)reader["Type"];
                decimal price = (decimal)reader["Price"];
                decimal vat = (decimal)reader["VAT"];
                int stockamount = (int)reader["StockAmount"];

                return new Drink(drinkid, name, type, price, vat, stockamount);
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occured While Reading 'Drink' Data", ex);
            }
        }
    }
}
