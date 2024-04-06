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
            string Class = (string)reader["Class"];
            int phonenumber = (int)reader["PhoneNumber"];
            int roomnumber = (int)reader["RoomNumber"];

            return new Student(studentNumber, firstName, lastname, Class, phonenumber, roomnumber);
        }

        public void DeleteStudent(Student student)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentNumber = @StudentNumber", dbConnection);
                cmd.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("An error occured while deleting student" + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public Student AddStudent(Student student)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Students VALUES (@StudentNumber, @FirstName, @LastName, @Class, @PhoneNumber, @RoomNumber)", dbConnection);
                cmd.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Class", student.Class);
                cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                cmd.Parameters.AddWithValue("@RoomNumber", student.RoomNumber);

                cmd.ExecuteNonQuery();
                return new Student(student.StudentNumber, student.FirstName, student.LastName, student.Class, student.PhoneNumber, student.RoomNumber);
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while adding the student" + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }
        public bool StudentNumberExists(int studentNumber)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Students WHERE StudentNumber = @StudentNumber", dbConnection);
                cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                int count = (int)cmd.ExecuteScalar();
                dbConnection.Close();
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while checking if the student number already exists" + ex.Message);
            }
        }
        public void UpdateStudent(Student student)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand(
                   "UPDATE Students SET StudentNumber = @StudentNumber, FirstName = @FirstName,  LastName = @LastName, Class = @Class, PhoneNumber = @PhoneNumber, RoomNumber = @RoomNumber WHERE StudentNumber = @StudentNumber", dbConnection);
                cmd.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Class", student.Class);
                cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                cmd.Parameters.AddWithValue("@RoomNumber", student.RoomNumber);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occured while updating student" + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }
        public List<Student> GetAllParticipants(Activity activity)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT s.StudentNumber, FirstName, LastName, Class, PhoneNumber, RoomNumber FROM participation as p JOIN students as s ON s.StudentNumber = p.StudentNumber JOIN activities as a ON p.ActivityID = a.ActivityID WHERE a.ActivityID = @ActivityID", dbConnection);
                cmd.Parameters.AddWithValue("@ActivityID", activity.ActivityId);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Student> participants = new List<Student>();
                while (reader.Read())
                {
                    Student participant = ReadStudent(reader);
                    participants.Add(participant);
                }
                reader.Close();
                return participants;
            }
            catch (SqlException ex)
            {
                throw new Exception("An Error Occurred While Retrieving participants From The Database", ex);
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }
        public List<Student> GetAllNotParticipants(Activity activity)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentNumber, FirstName, LastName, Class, PhoneNumber, RoomNumber FROM students WHERE StudentNumber NOT IN (SELECT StudentNumber FROM participation WHERE ActivityID = @ActivityID)", dbConnection);
                cmd.Parameters.AddWithValue("@ActivityID", activity.ActivityId);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Student> Notparticipants = new List<Student>();
                while (reader.Read())
                {
                    Student Notparticipant = ReadStudent(reader);
                    Notparticipants.Add(Notparticipant);
                }
                reader.Close();
                return Notparticipants;
            }
            catch (SqlException ex)
            {
                throw new Exception("An Error Occurred While Retrieving participants From The Database", ex);
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }
        public Student AddParticipant(Student Students, Activity activity)
        {
            try
            {
                dbConnection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO participation VALUES (@StudentNumber, @ActivityID);", dbConnection);
                cmd.Parameters.AddWithValue("@StudentNumber", Students.StudentNumber);
                cmd.Parameters.AddWithValue("@ActivityID", activity.ActivityId);
                cmd.ExecuteNonQuery();
                return new Student(Students.StudentNumber, Students.FirstName, Students.LastName, Students.Class, Students.PhoneNumber, Students.RoomNumber);
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while adding the participant", ex);
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }

        public void DeleteParticipant(Student Students, Activity activity)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM participation WHERE StudentNumber = @StudentNumber AND ActivityID = @ActivityID;", dbConnection);
                cmd.Parameters.AddWithValue("@StudentNumber", Students.StudentNumber);
                cmd.Parameters.AddWithValue("@ActivityID", activity.ActivityId);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while deleting the participant", ex);
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