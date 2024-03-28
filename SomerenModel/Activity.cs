using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int ActivityId { get; set; }

        public string ActivityName { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public Activity(int activityid, string activityname,  DateTime startDateTime, DateTime endDateTime)
        {
            ActivityId = activityid;
            ActivityName = activityname;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;

        }
    }
}
