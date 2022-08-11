namespace TLWebApi.Models
{
    public abstract class AutoBase
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Vin { get; set; } = string.Empty;
        public string PlateNumber { get; set; } = string.Empty;
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Volum { get => Length * Width * Height; }
        public int LoadCapacity { get; set; }
        public int AutoTypeId { get; set; }
        public AutoType? AutoType { get; set; }
    }
}
