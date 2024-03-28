using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivityDAO activityDAO;

        public ActivityService()
        {
            activityDAO = new ActivityDAO();
        }
        public List<Activity> GetAll()
        {
            return activityDAO.GetAll();
        }
    }
}
