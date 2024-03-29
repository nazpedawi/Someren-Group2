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
//using System.Diagnostics;

namespace SomerenDAL
{
    public class ActivityDAO
    {
        private SqlConnection dbConnection;
        public ActivityDAO()
        {
            string connString = ConfigurationManager
              .ConnectionStrings["DBConnectionString"]
            .ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<Activity> GetAll()
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT ActivityID, ActivityName, StartDateTime, EnadDateTime FROM activities", dbConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Activity> activities = new List<Activity>();
                while (reader.Read())
                {
                    Activity activity = ReadActivities(reader);
                    activities.Add(activity);
                }
                
                reader.Close();
                dbConnection.Close();
                return activities;
            }
            catch (SqlException ex)
            {
                throw new Exception("An Error Occured While Retrieving 'Activities' From The Database", ex);
            }
        }

        public Activity ReadActivities(SqlDataReader reader)
        {
            try
            {
                int activityId = (int)reader["ActivityID"];
                string activityname = (string)reader["ActivityName"];
                DateTime startdatetime = (DateTime)reader["StartDateTime"];
                DateTime enddatetime = (DateTime)reader["EnadDateTime"];

                return new Activity(activityId, activityname, startdatetime, enddatetime);
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occured While Reading 'Activities' Data", ex);
            }
        }
    }
}
