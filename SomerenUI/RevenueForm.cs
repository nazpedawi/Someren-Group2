﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SomerenModel;
using SomerenService;
using System.Configuration;

namespace SomerenUI
{
    public partial class RevenueForm : Form
    {
        private OrderService orderService;
        private SqlConnection dbConnection;

        public RevenueForm()
        {
            InitializeComponent();
            orderService = new OrderService();

            dateTimePickerStartDate.CustomFormat = "yyyy-MM-dd";
            dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndDate.CustomFormat = "yyyy-MM-dd";
            dateTimePickerEndDate.Format = DateTimePickerFormat.Custom;

            // Initialize database connection
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Get start and end dates from date time picker
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;
            List<Order> orders;
            // Check if start date and end date are the same (single day)
            if (startDate.Date == endDate.Date)
            {
                // Get orders for the single day
                orders = GetOrdersForSingleDay(startDate);
            }
            else
            {
                // Get orders within the specified date range
                orders = GetOrdersWithinDateRange(startDate, endDate);
            }
                // Calculate report for date range
            int totalNumberOfDrinks = GetTotalNumberOfDrinks(orders);
            decimal totalTurnover = GetTotalTurnover(orders);
            int numberOfCustomers = GetNumberOfCustomers(orders);

            // Display report data for date range
            lblTotalNumberOfDrinks.Text = totalNumberOfDrinks.ToString();
            lblTotalTurnover.Text = totalTurnover.ToString("C"); // Format as currency
            lblNumberOfCustomers.Text = numberOfCustomers.ToString();
            
        }
        private List<Order> GetOrdersWithinDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentNumber, DrinkId, NumberOfDrinks, OrderDate FROM Orders WHERE OrderDate >= @StartDate AND OrderDate <= @EndDate", dbConnection);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Order> orders = new List<Order>();
                while (reader.Read())
                {
                    Order order = ReadOrder(reader);
                    orders.Add(order);
                }
                reader.Close();
                return orders;
            }
            catch (SqlException ex)
            {
                throw new Exception("An Error Occurred While Retrieving Orders Within Date Range From The Database", ex);
            }
            finally
            {
                dbConnection.Close();
            }
        }
        private List<Order> GetOrdersForSingleDay(DateTime date)
        {
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentNumber, DrinkId, NumberOfDrinks, OrderDate FROM Orders WHERE CONVERT(date, OrderDate) = @Date", dbConnection);
                cmd.Parameters.AddWithValue("@Date", date.Date);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Order> orders = new List<Order>();
                while (reader.Read())
                {
                    Order order = ReadOrder(reader);
                    orders.Add(order);
                }
                reader.Close();
                return orders;
            }
            catch (SqlException ex)
            {
                throw new Exception("An Error Occurred While Retrieving Orders for Single Day From The Database", ex);
            }
            finally
            {
                dbConnection.Close();
            }
        }
        private int GetTotalNumberOfDrinks(List<Order> orders)
        {
            int totalNumberOfDrinks = 0;
            foreach (Order order in orders)
            {
                totalNumberOfDrinks += order.NumberOfDrinks;
            }
            return totalNumberOfDrinks;
        }
        private decimal GetTotalTurnover(List<Order> orders)
        {
            decimal totalTurnover = 0;
            foreach (Order order in orders)
            {
                totalTurnover += order.NumberOfDrinks * GetDrinkPrice(order.DrinkId);
            }
            return totalTurnover;
        }
        private int GetNumberOfCustomers(List<Order> orders)
        {
            HashSet<int> customerSet = new HashSet<int>();
            foreach (Order order in orders)
            {
                customerSet.Add(order.StudentNumber);
            }
            return customerSet.Count;
        }
        private Order ReadOrder(SqlDataReader reader)
        {
            int studentNumber = (int)reader["StudentNumber"];
            int drinkId = (int)reader["DrinkId"];
            int numberOfDrinks = (int)reader["NumberOfDrinks"];
            DateTime date = (DateTime)reader["OrderDate"];
                

            return new Order(studentNumber, drinkId, numberOfDrinks, date);
        }
        private decimal GetDrinkPrice(int drinkId)
        {
            DrinkService drinkService = new DrinkService();
            return drinkService.GetDrinkPrice(drinkId);
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
