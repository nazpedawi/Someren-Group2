using System;
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
using SomerenDAL;

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

        public void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Get start and end dates from date time picker
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;
            OrderDAO order = new OrderDAO();
            List<Order> orders;
            // Check if start date and end date are the same (single day)
            if (startDate.Date == endDate.Date)
            {
                orders = order.GetOrdersForSingleDay(startDate);
            }
            else
            {
                orders = order.GetOrdersWithinDateRange(startDate, endDate);
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

        private static int GetNumberOfCustomers(List<Order> orders)
        {
            HashSet<int> customerSet = new HashSet<int>();
            foreach (Order order in orders)
            {
                customerSet.Add(order.StudentNumber);
            }
            return customerSet.Count;
        }

        private static decimal GetDrinkPrice(int drinkId)
        {
            DrinkService drinkService = new DrinkService();
            return drinkService.GetDrinkPrice(drinkId);
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
