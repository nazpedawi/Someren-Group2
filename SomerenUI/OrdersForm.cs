using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            DisplayStudents(GetAllStudents());
            DisplayDrinks(GetAllDrinks());
        }
        public List<Student> GetAllStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetAll();
            return students;
        }
        public void DisplayStudents(List<Student> students)
        {
            ListViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.StudentNumber.ToString());
                item.Tag = student;
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.Class.ToString());
                item.SubItems.Add(student.PhoneNumber.ToString());

                ListViewStudents.Items.Add(item);
            }
        }
        public List<Drink> GetAllDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetAll();
            return drinks;
        }
        public void DisplayDrinks(List<Drink> drinks)
        {
            ListViewDrinks.Items.Clear();

            foreach (Drink drink in drinks)
            {
                ListViewItem item = new ListViewItem(drink.Name);
                item.Tag = drink;
                item.SubItems.Add(drink.Type);
                item.SubItems.Add(drink.Price.ToString());
                item.SubItems.Add(drink.StockAmount.ToString());
                string stockStatus = GetStockStatus(drink.StockAmount);
                item.SubItems.Add(stockStatus);

                ListViewDrinks.Items.Add(item);
            }
        }
        private string GetStockStatus(int stockAmount)
        {
            if (stockAmount < 1)
                return "Stock empty";
            else if (stockAmount < 10)
                return "Stock nearly depleted";
            else
                return "Stock sufficient";
        }
        private void PlaceOrderbtn_Click(object sender, EventArgs e)
        {
            if (ListViewStudents.SelectedItems.Count == 0 || ListViewDrinks.SelectedItems.Count == 0 || string.IsNullOrWhiteSpace(NumberOfDrinkstxtbox.Text))
            {
                MessageBox.Show("Please select a student, a drink, and enter the number of drinks.");
                return;
            }
            int NumberOfDrinks = Int32.Parse(NumberOfDrinkstxtbox.Text);
            if (NumberOfDrinks < 0)
            {
                MessageBox.Show("Please enter a valid number of drinks");
                return;
            }
            ListViewItem selectedItem = ListViewDrinks.SelectedItems[0];
            Drink drink = selectedItem.Tag as Drink;

            if (NumberOfDrinks > drink.StockAmount)
            {
                MessageBox.Show("Not enough stock available.");
                return;
            }
            decimal totalPrice = NumberOfDrinks * drink.Price;
            ListViewItem SelectedItem = ListViewStudents.SelectedItems[0];
            Student student = SelectedItem.Tag as Student;

            MessageBox.Show($"Order placed for: \n {student.FirstName} {student.LastName} \n \n Ordered Items: \n {drink.Name}   (x{NumberOfDrinks})  \n \n Total price:  €{totalPrice}");

            Order order = new Order(student.StudentNumber, drink.DrinkID, NumberOfDrinks, DateTime.Now);
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);

            orderService.UpdateOrder(drink, NumberOfDrinks);

            ListViewStudents.SelectedItems.Clear();
            ListViewDrinks.SelectedItems.Clear();
            NumberOfDrinkstxtbox.Clear();
        }
    }
}
