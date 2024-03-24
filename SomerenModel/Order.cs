using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int StudentNumber { get; }
        public int DrinkID { get; }
        public int NumberOfDrinks { get; }

        public Order(int studentID, int drinkID, int numberOfDrinks)
        {
            StudentNumber = studentID;
            DrinkID = drinkID;
            NumberOfDrinks = numberOfDrinks;
        }

        // Method to retrieve student's name
        public int GetStudentID(Student student)
        {
            return student.StudentNumber;
        }

        // Method to retrieve drink's details
        public (int, decimal) GetDrinkDetails(Drink drink)
        {
            return (drink.DrinkID, drink.Price);
        }
    }
}
