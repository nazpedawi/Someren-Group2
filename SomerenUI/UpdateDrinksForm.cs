using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace SomerenUI
{
    public partial class UpdateDrinksForm : Form
    {
        private Drink selectedDrink;

        // Constructor for initializing the form with the drink selected by the user
        public UpdateDrinksForm(Drink drink)
        {
            InitializeComponent();
            selectedDrink = drink;
            InitializeForm();
        }

        // Method to initialize and fiil the form with the details of the selected drink
        private void InitializeForm()
        {
            // fill the textboxes with the information of the selected drink
            DrinkNametxtbox.Text = selectedDrink.Name;
            DrinkPricetxtbox.Text = selectedDrink.Price.ToString();
            DrinkStockAmounttxtbox.Text = selectedDrink.StockAmount.ToString();

            // Set radio button based on the type of the selected drink
            if (selectedDrink.Type == "Alcoholic")
            {
                Alcoholicbtn.Checked = true;
                selectedDrink.VAT = 0.21m;
            }
            else
            {
                NonAlcoholicbtn.Checked = true;
                selectedDrink.VAT = 0.09m;
            }
        }

        // Event handler for when the update drink button is clicked
        private void UpdateDrinkbtn_Click(object sender, EventArgs e)
        {
            // Update selected drink details based on the input the user changed in the textboxes
            try
            {
                selectedDrink.Name = DrinkNametxtbox.Text;
                selectedDrink.Price = decimal.Parse(DrinkPricetxtbox.Text);
                selectedDrink.StockAmount = int.Parse(DrinkStockAmounttxtbox.Text);
                selectedDrink.Type = Alcoholicbtn.Checked ? "Alcoholic" : "Non-Alcoholic";
                DialogResult = DialogResult.OK;  // Set dialog result to OK
                Close(); // close the update drink form
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event handler for if the radio button was changed to alcoholic
        private void AlcoholicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Alcoholicbtn.Checked)
            {
                selectedDrink.VAT = 0.21m;
            }
        }

        // Event handler for if the radio button was changed to non-alcoholic
        private void NonAlcoholicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NonAlcoholicbtn.Checked)
            {
                selectedDrink.VAT = 0.09m;
            }
        }
    }
}