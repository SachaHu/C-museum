using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseeApi.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public DateTime StartDate{get;set;}
        public DateTime EndDate { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Limit { get; set; }

        public bool validate()
        {
            return EndDate > StartDate;
        }
        
        //public virtual ICollection<ActivityTag> ActivityTags { get; set; }
        //public virtual ICollection<UserActivity> UserActivities { get; set; }
        //public virtual ICollection<AreaActivity> AreaActivities { get; set; }
    }
}
