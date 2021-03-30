using System.ComponentModel.DataAnnotations.Schema;

namespace MuseeApi.Models
{
    public class ExhibitTag
    {
        public int ExhibitId { get; set; }
        public virtual Exhibit Exhibit { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}