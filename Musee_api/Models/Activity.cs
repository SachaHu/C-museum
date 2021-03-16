using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musee_api.Models
{
    public class Activity
    {
        public int id { get; set; }
        public DateTime start_date{get;set;}
        public DateTime end_date { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public int limit { get; set; }
    }
}
