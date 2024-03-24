using Microsoft.Data.SqlClient;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace SomerenDAL
{
    public class DrinkDAO
    {
        private SqlConnection dbConnection;
        public DrinkDAO()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
                dbConnection = new SqlConnection(connString);
            }
            catch (Exception ex)
            {
                throw new Exception("An Error occured while configuring database connection.", ex);
            }
        }
        private void OpenConnection()
        {
            try
            {
                if (dbConnection.State != ConnectionState.Open)
                {
                    dbConnection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while opening database connection.", ex);
            }
        }
        private void CloseConnection()
        {
            try
            {
                if (dbConnection.State != ConnectionState.Closed)
                {
                    dbConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while closing database connection.", ex);
            }
        }

        public List<Drink> GetAll()
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT DrinkID, Name, Type, Price, VAT, StockAmount FROM Drinks", dbConnection);
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
                CloseConnection();
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
        public Drink AddDrink(Drink drink)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Drinks VALUES (@Name, @Type, @Price, @VAT, @StockAmount);"
                    + "SELECT CAST(scope_identity() AS int)", dbConnection);
                cmd.Parameters.AddWithValue("@Name", drink.Name);
                cmd.Parameters.AddWithValue("@Type", drink.Type);
                cmd.Parameters.AddWithValue("@Price", drink.Price);
                cmd.Parameters.AddWithValue("@VAT", drink.VAT);
                cmd.Parameters.AddWithValue("@StockAmount", drink.StockAmount);
                int id = (int)cmd.ExecuteScalar();
                dbConnection.Close();

                return new Drink(id, drink.Name, drink.Type, drink.Price, drink.VAT, drink.StockAmount);
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while adding the drink", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void DeleteDrink(Drink drink)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Drinks WHERE DrinkID = @DrinkID", dbConnection);
                cmd.Parameters.AddWithValue("@DrinkID", drink.DrinkID);
                cmd.ExecuteNonQuery();
                dbConnection.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while deleting the drink", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void UpdateDrink(Drink drink)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(
                   "UPDATE Drinks SET Name = @Name, Type = @Type,  Price = @Price, StockAmount = @StockAmount WHERE DrinkID = @DrinkID", dbConnection);
                cmd.Parameters.AddWithValue("@DrinkID", drink.DrinkID);
                cmd.Parameters.AddWithValue("@Name", drink.Name);
                cmd.Parameters.AddWithValue("@Type", drink.Type);
                cmd.Parameters.AddWithValue("@Price", drink.Price);
                cmd.Parameters.AddWithValue("@StockAmount", drink.StockAmount);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while updating the drink", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
