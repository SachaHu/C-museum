using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musee_api.Models
{
    public class Slot
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public float SizeX { get; set; }
        public float SizeY { get; set; }
        public float SizeZ { get; set; }
        public Area Area { get; set; }
        public virtual ICollection<Exhibit> Exhibits { get; set; }
        public Slot()
        {
            Exhibits = new List<Exhibit>(); 
        }
        
    }

}
