using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class OrderService
    {
        private OrderDAO orderDAO;
        public OrderService()
        {
            orderDAO = new OrderDAO();
        }

        public List<Order> GetAll()
        {
            return orderDAO.GetAll();
        }
        public void AddOrder(Order order)
        {
            orderDAO.AddOrder(order);
        }
        public void UpdateOrder(Drink drink, int NumberOfDrinks)
        {
            orderDAO.UpdateStock(drink, NumberOfDrinks);
        }
    }
}
