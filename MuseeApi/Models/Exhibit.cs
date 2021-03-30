using System.Collections.Generic;

namespace MuseeApi.Models
{
    public class Exhibit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float SizeX { get; set; }
        public float SizeY { get; set; }
        public float SizeZ { get; set; }
        public int? SlotId { get; set; }
        public Slot Slot { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
