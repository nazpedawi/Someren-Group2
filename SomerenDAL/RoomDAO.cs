using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.Configuration;

namespace SomerenDAL
{
    public class RoomDAO
    {
        private SqlConnection dbConnection;
        public RoomDAO()
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
        public List<Room> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT RoomNumber, BuildingName, RoomType, NumberOfBeds FROM Rooms", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Room> Rooms = new List<Room>();
            while (reader.Read())
            {
                Room Room = ReadRoom(reader);
                Rooms.Add(Room);
            }
            reader.Close();
            dbConnection.Close();
            return Rooms;
        }

        private Room ReadRoom(SqlDataReader reader)
        {
            int roomnumber = (int)reader["RoomNumber"];
            string buildingName = (string)reader["BuildingName"];
            string roomType = (string)reader["RoomType"];
            int numberOfBeds = (int)reader["NumberOfBeds"];

            return new Room(roomnumber, buildingName,  roomType, numberOfBeds);
        }
    }
}
