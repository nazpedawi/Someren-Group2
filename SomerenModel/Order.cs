using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int StudentNumber {  get; set; }
        public int DrinkId { get; set; }
        public int NumberOfDrinks { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int studentNumber, int drinkId, int numberOfDrinks, DateTime orderDate)
        {
            StudentNumber = studentNumber;
            DrinkId = drinkId;
            NumberOfDrinks = numberOfDrinks;
            OrderDate = orderDate;
        }
    }
}
