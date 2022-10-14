namespace TLWebApi.Models
{
    public class Trail : Vehicle
    {
        public Trail()
        {
        }
        public int TrailCategoryId { get; set; }
        public TrailCategory? TrailCategory { get; set; }
    }
}
