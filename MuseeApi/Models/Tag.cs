using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseeApi.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        
        //public virtual ICollection<ExhibitTag> ExhibitTags { get; set; }
        //public virtual ICollection<ActivityTag> ActivityTags { get; set; }
    }
}
