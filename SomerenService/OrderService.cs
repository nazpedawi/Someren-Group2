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
            OrderDAO = new OrderDAO();
        }

        public List<Order> GetAll()
        {
            return OrderDAO.GetAll();
        }
    }
}
