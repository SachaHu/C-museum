using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musee_api.Models
{
    public class Exhibit
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float size_XF { get; set; }
        public float size_Y { get; set; }
        public float size_Z {get;set;}
    }
}
