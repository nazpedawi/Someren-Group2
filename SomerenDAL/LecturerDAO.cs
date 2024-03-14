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
            string connString = ConfigurationManager
                .ConnectionStrings["DBConnectionString"]
                .ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<Lecturer> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Lecturers", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Lecturer> lecturers = new List<Lecturer>();
            while (reader.Read())
            {
                Lecturer lecturer = ReadLecturer(reader);
                lecturers.Add(lecturer);
            }
            reader.Close();
            dbConnection.Close();
            return lecturers;
        }

        private Lecturer ReadLecturer(SqlDataReader reader)
        {
            int lecturernumber = (int)reader["LecturerNumber"];
            string firstname = (string)reader["FirstName"];
            string lastname = (string)reader["LastName"];
            int age = (int)reader["Age"];
            int phonenumber = (int)reader["PhoneNumber"];
            int roomnumber = (int)reader["RoomNumber"];

            return new Lecturer(lecturernumber, firstname, lastname, age, phonenumber, roomnumber);
        }
    }
}
