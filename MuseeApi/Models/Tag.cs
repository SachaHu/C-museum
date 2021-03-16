using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseeApi.Models
{
    public class Tag
    {
        public int id { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        
        public virtual ICollection<Exhibit> Exhibits { get; set; }
        public virtual IList<Activity> Activities { get; set; }
    }
}
