namespace MuseeApi.Models
{
    public class AreaActivity
    {
        public int AreaId { get; set; }
        public Area Area { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        
    }
}