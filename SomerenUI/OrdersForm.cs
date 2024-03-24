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

                ListViewDrinks.Items.Add(item);
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListViewStudents.SelectedItems.Count == 0 || ListViewDrinks.SelectedItems.Count == 0 || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please select a student, a drink, and enter the number of drinks.");
                return;
            }
            int NumberOfDrinks = Int32.Parse(textBox1.Text);
            if (NumberOfDrinks < 0)
            {
                MessageBox.Show("Please enter a valid number of drinks");
                return;
            }
            ListViewItem selectedItem = ListViewDrinks.SelectedItems[0];
            Drink drink = selectedItem.Tag as Drink;
            if (NumberOfDrinks > drink.StockAmount) {
                MessageBox.Show("Not enough stock available.");
                return;
            }


        }

        private void ListViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewStudents.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ListViewStudents.SelectedItems[0];
                Student student = selectedItem.Tag as Student;
            }
        }

        private void ListViewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewDrinks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ListViewDrinks.SelectedItems[0];
                Drink drink = selectedItem.Tag as Drink;
            }
        }
    }
}
