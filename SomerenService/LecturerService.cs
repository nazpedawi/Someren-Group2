using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class LecturerService
    {
        private LecturerDAO lecturerDAO;
        public LecturerService()
        {
            lecturerDAO = new LecturerDAO();
        }

        public List<Lecturer> GetAll()
        {
               return lecturerDAO.GetAll();
        }
    }
}