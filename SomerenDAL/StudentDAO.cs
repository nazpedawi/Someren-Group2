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
    public class StudentDAO
    {
        private SqlConnection dbConnection;
        public StudentDAO()
        {
            string connString = ConfigurationManager
              .ConnectionStrings["DBConnectionString"]
              .ConnectionString;

            dbConnection = new SqlConnection(connString);
        }
        public List<Student> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT StudentNumber, FirstName, LastName, Class, PhoneNumber, RoomNumber FROM Students", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student student = ReadStudent(reader);
                students.Add(student);
            }
            reader.Close();
            dbConnection.Close();
            return students;
        }
        private Student ReadStudent(SqlDataReader reader)
        {
            int studentNumber = (int)reader["StudentNumber"];
            string firstName = (string)reader["FirstName"];
            string lastname = (string)reader["LastName"];
            int phonenumber = (int)reader["PhoneNumber"];
            string Class = (string)reader["Class"];
            int roomnumber = (int)reader["RoomNumber"];

            return new Student(studentNumber, firstName, lastname, phonenumber, Class, roomnumber);
        } 
    }
}