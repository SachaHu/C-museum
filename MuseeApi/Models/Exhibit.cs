using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseeApi.Models
{
    public class Exhibit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float SizeX { get; set; }
        public float SizeY { get; set; }
        public float SizeZ {get;set;}
        public virtual int? SlotId { get; set; }
        public virtual Slot Slot { get; set; }
        //public ICollection<ExhibitTag> ExhibitTags { get; set; }
    }
}
