namespace MuseeApi.Models
{
    public class ExhibitTag
    {
        public int ExhibitId { get; set; }
        public Exhibit Exhibit { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}