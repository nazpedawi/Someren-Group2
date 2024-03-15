using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDAO roomDAO;
        public RoomService()
        {
            roomDAO = new RoomDAO();
        }

        public List<Room> GetAll()
        {
            return roomDAO.GetAll();
        }
    }
}
