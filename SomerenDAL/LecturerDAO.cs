using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace SomerenDAL
{
    public class LecturerDAO
    {
        private SqlConnection dbConnection;
        public LecturerDAO()
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

        public List<Lecturer> GetAll()
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName, Age, PhoneNumber FROM Lecturers", dbConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Lecturer> lecturers = new List<Lecturer>();
                while (reader.Read())
                {
                    Lecturer lecturer = ReadLecturer(reader);
                    lecturers.Add(lecturer);
                }
                reader.Close();
                return lecturers;
            }
            catch (SqlException ex)
            {
               throw new Exception("An Error Occured While Retrieving 'Lecturers' From The Database", ex);
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }
        private Lecturer ReadLecturer(SqlDataReader reader)
        {
            try
            {
                string firstname = (string)reader["FirstName"];
                string lastname = (string)reader["LastName"];
                int age = (int)reader["Age"];
                int phonenumber = (int)reader["PhoneNumber"];

                return new Lecturer(firstname, lastname, age, phonenumber);
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occured While Reading 'Lecturer' Data", ex);
            }
        }
    }
}
