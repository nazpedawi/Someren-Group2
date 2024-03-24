using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDAO drinkDAO;
        public DrinkService()
        {
            drinkDAO = new DrinkDAO();
        }

        public List<Drink> GetAll()
        {
            return drinkDAO.GetAll();
        }
        public void AddDrink (Drink drink) 
        {
            drinkDAO.AddDrink(drink);
        }

        public void DeleteDrink(Drink drink)
        {
            drinkDAO.DeleteDrink(drink);
        }

        public void UpdateDrink(Drink drink)
        {
            drinkDAO.UpdateDrink(drink);
        }
        public decimal GetDrinkPrice(int drinkId)
        {
            List<Drink> drinks = GetAll();
            Drink drink = drinks.FirstOrDefault(d => d.DrinkID == drinkId);
            if (drink != null)
            {
                return drink.Price;
            }
            else
            {
                throw new Exception("Drink not found.");
            }
        }
    }
}
