namespace MuseeApi.Models
{
    public class ActivityTag
    {
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
        
    }
}