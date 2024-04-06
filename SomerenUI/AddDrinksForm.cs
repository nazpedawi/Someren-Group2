using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class AddDrinksForm : Form
    {
        DrinkService drinkService;

        // Constructor for initializing the form and DrinkService
        public AddDrinksForm()
        {
            drinkService = new DrinkService();
            InitializeComponent();
        }

        // Event handler for when add drink button is clicked
        private void AddDrinkbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve drink details from form inputs
                string name = DrinkNametxtbox.Text;

                // make sure name field is not empty
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter a drink name.");
                    return;
                }
                string type;
                decimal vat;

                // Determine drink type and VAT based on what radio button is selected
                if (Alcoholicbtn.Checked)
                {
                    type = "Alcoholic";
                    vat = 0.21m;
                }
                else
                {
                    type = "Non-Alcoholic";
                    vat = 0.09m;
                }

                // Check if a drink type is chosen
                if (string.IsNullOrEmpty(type))
                {
                    MessageBox.Show("Please select the type of drink.");
                    return;
                }

                // Checking if drink price is empty
                decimal price = decimal.Parse(DrinkPricetxtbox.Text);
                if (string.IsNullOrEmpty(price.ToString()))
                {
                    MessageBox.Show("Please enter a price.");
                    return;
                }

                // Parse stock amount and check if an integer was typed
                int stockAmount;
                if (!int.TryParse(DrinkStockAmounttxtbox.Text, out stockAmount))
                {
                    MessageBox.Show("Invalid stock amount format, Please enter an integer.");
                    return;
                }

                // Create a new Drink object based on the data given by the user then add the drink
                Drink drink = new Drink(0, name, type, price, vat, stockAmount);
                drinkService.AddDrink(drink);

                MessageBox.Show("Drink added Successfully!");  //to let the user know the drink they entered was added to the table
                Close(); // close the form
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddDrinksForm_Load(object sender, EventArgs e)
        {

        }
    }
}
