namespace TLWebApi.Models
{
    public class Trail : AutoBase
    {
        public int TrailCategoryId { get; set; }
        public TrailCategory? TrailCategory { get; set; }
    }
}
