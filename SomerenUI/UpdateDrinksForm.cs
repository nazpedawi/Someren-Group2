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
        public UpdateDrinksForm(Drink drink)
        {
            InitializeComponent();
            selectedDrink = drink;
            InitializeForm();
        }
        private void InitializeForm()
        {
            DrinkNametxtbox.Text = selectedDrink.Name;
            DrinkPricetxtbox.Text = selectedDrink.Price.ToString();
            DrinkStockAmounttxtbox.Text = selectedDrink.StockAmount.ToString();

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
        private void UpdateDrinkbtn_Click(object sender, EventArgs e)
        {
            try
            {
                selectedDrink.Name = DrinkNametxtbox.Text;
                selectedDrink.Price = decimal.Parse(DrinkPricetxtbox.Text);
                selectedDrink.StockAmount = int.Parse(DrinkStockAmounttxtbox.Text);
                selectedDrink.Type = Alcoholicbtn.Checked ? "Alcoholic" : "Non-Alcoholic";
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AlcoholicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Alcoholicbtn.Checked)
            {
                selectedDrink.VAT = 0.21m;
            }
        }
        private void NonAlcoholicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NonAlcoholicbtn.Checked)
            {
                selectedDrink.VAT = 0.09m;
            }
        }
    }
}