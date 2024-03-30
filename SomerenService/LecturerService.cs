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
  
        public List<Lecturer> GetAllSupervisors(Activity activity)
        {
            return lecturerDAO .GetAllSupervisors(activity);
        }

        public List<Lecturer> GetAllNotSupervisors(Activity activity)
        {
            return lecturerDAO.GetAllNotSupervisors(activity);
        }

        public void AddSupervisor(Lecturer lecturer, Activity activity)
        {
             lecturerDAO.AddSupervisor(lecturer, activity);
        }
    }
}