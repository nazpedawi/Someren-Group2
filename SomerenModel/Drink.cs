using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int DrinkID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public decimal VAT { get; set; }
        public int StockAmount { get; set; }

        public Drink(int drinkID, string name, string type, decimal price , decimal vat, int stockAmount)
        {
            DrinkID = drinkID;
            Name = name;
            Type = type;
            Price = price;
            VAT = vat;
            StockAmount = stockAmount;
        }
    }
}
