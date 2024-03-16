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
    }
}
