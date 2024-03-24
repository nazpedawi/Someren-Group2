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
        public AddDrinksForm()
        {
            drinkService = new DrinkService();
            InitializeComponent();
        }

        private void AddDrinkbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = DrinkNametxtbox.Text;

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter a drink name.");
                    return;
                }
                string type;
                decimal vat;

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
                if (string.IsNullOrEmpty(type))
                {
                    MessageBox.Show("Please select the type of drink.");
                    return;
                }
                decimal price = decimal.Parse(DrinkPricetxtbox.Text);
                if (string.IsNullOrEmpty(price.ToString()))
                {
                    MessageBox.Show("Please enter a price.");
                    return;
                }
                int stockAmount;
                if (!int.TryParse(DrinkStockAmounttxtbox.Text, out stockAmount))
                {
                    MessageBox.Show("Invalid stock amount format, Please enter an integer.");
                    return;
                }
                Drink drink = new Drink(0, name, type, price, vat, stockAmount);
                drinkService.AddDrink(drink);

                MessageBox.Show("Drink added Successfully!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
