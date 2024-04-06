using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SomerenDAL
{
    public class LecturerDAO
    {
        private SqlConnection dbConnection;


        // Constructor for initializing database connection
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

       

        // Retrieve all lecturers from the database
        public List<Lecturer> GetAll()
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT LecturerNumber, FirstName, LastName, Age, PhoneNumber FROM Lecturers", dbConnection);
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

        // Read lecturer data from SqlDataReader
        private Lecturer ReadLecturer(SqlDataReader reader)
        {
            try
            {
                int lecturernumber = (int)reader["LecturerNumber"];
                string firstname = (string)reader["FirstName"];
                string lastname = (string)reader["LastName"];
                int age = (int)reader["Age"];
                int phonenumber = (int)reader["PhoneNumber"];

                return new Lecturer(lecturernumber, firstname, lastname, age, phonenumber);
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occured While Reading 'Lecturer' Data", ex);
            }
        }
        public List<Lecturer> GetAllSupervisors(Activity activity)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT l.LecturerNumber, FirstName, LastName, Age, PhoneNumber FROM supervisation as s join  lecturers as l on l.LecturerNumber = s.LecturerNumber join activities as a on s.ActivityID = a.ActivityID WHERE a.ActivityID = @ActivityID", dbConnection);
                cmd.Parameters.AddWithValue("@ActivityID", activity.ActivityId);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Lecturer> supervisors = new List<Lecturer>();
                while (reader.Read())
                {
                    Lecturer supervisor = ReadLecturer(reader);
                    supervisors.Add(supervisor);
                }
                reader.Close();
                return supervisors;
            }
            catch (SqlException ex)
            {
                throw new Exception("An Error Occurred While Retrieving Supervisors From The Database", ex);
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }
        public List<Lecturer> GetAllNotSupervisors(Activity activity)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT LecturerNumber, FirstName, LastName, Age, PhoneNumber FROM lecturers WHERE LecturerNumber NOT IN (SELECT LecturerNumber FROM supervisation WHERE ActivityID = @ActivityID)", dbConnection);
                cmd.Parameters.AddWithValue("@ActivityID", activity.ActivityId);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Lecturer> NotSupervisors = new List<Lecturer>();
                while (reader.Read())
                {
                    Lecturer NotSupervisor = ReadLecturer(reader);
                    NotSupervisors.Add(NotSupervisor);
                }
                reader.Close();
                return NotSupervisors;
            }
            catch (SqlException ex)
            {
                throw new Exception("An Error Occurred While Retrieving Supervisors From The Database", ex);
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }
        public Lecturer AddSupervisor(Lecturer lecturer, Activity activity)
        {
            try
            {
                dbConnection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO supervisation VALUES (@LecturerNumber, @ActivityID);" , dbConnection);
                cmd.Parameters.AddWithValue("@LecturerNumber", lecturer.LecturerNumber);
                cmd.Parameters.AddWithValue("@ActivityID", activity.ActivityId);
                cmd.ExecuteNonQuery();
                return new Lecturer(lecturer.LecturerNumber, lecturer.FirstName, lecturer.LastName, lecturer.Age, lecturer.PhoneNumber);
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while adding the supervisor", ex);
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }

        public void DeleteSupervisor(Lecturer lecturer, Activity activity)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM supervisation WHERE LecturerNumber = @LecturerNumber AND ActivityID = @ActivityID;", dbConnection);
                cmd.Parameters.AddWithValue("@LecturerNumber", lecturer.LecturerNumber);
                cmd.Parameters.AddWithValue("@ActivityID", activity.ActivityId);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while deleting the supervisor", ex);
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }
    }
}
