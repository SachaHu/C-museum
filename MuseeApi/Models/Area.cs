using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseeApi.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Serial { get; set; }
        
        public virtual ICollection<Slot> Slots { set; get; }
        public virtual ICollection<Activity> Activities { set; get; }
    }
}
