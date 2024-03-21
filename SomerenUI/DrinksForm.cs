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

namespace SomerenUI
{
    public partial class DrinksForm : Form
    {
        DrinkService DrinkService;
        public DrinksForm()
        {
            InitializeComponent();
            List<Drink> drinks = GetAllDrinks();
            DisplayDrinks(drinks);
        }
        public List<Drink> GetAllDrinks()
        {
            DrinkService = new DrinkService();
            List<Drink> drinks = DrinkService.GetAll();
            return drinks;
        }

        public void DisplayDrinks(List<Drink> drinks)
        {
            ListViewDrinks.Items.Clear();

            foreach (Drink drink in drinks)
            {
                ListViewItem item = new ListViewItem(drink.DrinkID.ToString());
                item.Tag = drink;
                item.SubItems.Add(drink.Name);
                item.SubItems.Add(drink.Type);
                item.SubItems.Add(drink.Price.ToString());
                item.SubItems.Add(drink.StockAmount.ToString());

                if (drink.StockAmount < 1)
                {
                    item.SubItems.Add("Stock empty");
                }
                else if (drink.StockAmount < 10)
                {
                    item.SubItems.Add("Stock nearly depleted");
                }
                else
                {
                    item.SubItems.Add("Stock sufficient");
                }
                ListViewDrinks.Items.Add(item);
            }
        }

        private void AddDrinkbtn_Click(object sender, EventArgs e)
        {
            string name = DrinkNametxtbox.Text;
            string type;
            decimal vat;

            if (Alcoholicbtn.Checked)
            {
                type = "Alcoholic";
                vat = 0.21m;
            }
            else {
                type = "Non-Alcoholic";
                vat = 0.09m;
            }
            
            decimal price = decimal.Parse(DrinkPricetxtbox.Text);
            int stockAmount = int.Parse(DrinkStocktxtbox.Text);

            Drink drink = new Drink(0,name,type,price,vat,stockAmount);
            DrinkService.AddDrink(drink);

            MessageBox.Show("New Drink Added!");
        }
    }
}
