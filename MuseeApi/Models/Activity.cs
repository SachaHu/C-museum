using System;
using System.Collections.Generic;

namespace MuseeApi.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Limit { get; set; }

        public virtual IList<Tag> Tags { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
    }
}
