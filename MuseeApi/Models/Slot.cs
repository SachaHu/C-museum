using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace MuseeApi.Models
{
    public class Slot
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public float SizeX { get; set; }
        public float SizeY { get; set; }
        public float SizeZ { get; set; }
        
        public int? AreaId { get; set; }
        public Area Area { get; set; }
        public virtual ICollection<Exhibit> Exhibits { get; set; }

        public bool validateSize(Exhibit newExhibit)
        {
            if (newExhibit.SizeZ > SizeZ) return false;
            float sX = newExhibit.SizeX;
            float sY = newExhibit.SizeZ;
            foreach (Exhibit exhibit in Exhibits)
            {
                sX += exhibit.SizeX;
                sY += exhibit.SizeY;
            }
            if (sX > SizeX || sY > SizeY) return false;
            return true;
        }
    }

}
