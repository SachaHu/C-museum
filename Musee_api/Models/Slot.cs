using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musee_api.Models
{
    public class Slot
    {
        public int id { get; set; }
        public int number { get; set; }
        public float size_X { get; set; }
        public float size_Y { get; set; }
        public float size_Z { get; set; }
    }

}
