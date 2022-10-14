namespace TLWebApi.Models
{
    public abstract class Vehicle
    {
        protected Vehicle()
        {
        }
        public int Id { get; set; }
        public int AutoTypeId { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Vin { get; set; } = string.Empty;
        public string PlateNumber { get; set; } = string.Empty;
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Volum { get => Length * Width * Height; }
        public int LoadCapacity { get; set; }
        public DateTime? ItpExpDate { get; set; }
        public DateTime? CertCemtExpDate { get; set; }
        public DateTime? CertRcaExpDate { get; set; }
        public DateTime? CertAgrExpDate { get; set; }
        public DateTime? CertCVerdeExpDate { get; set; }
        public DateTime? CertCascoExpDate { get; set; }
        public DateTime? CertStingExpDate { get; set; }
        public AutoType? AutoType { get; set; }
    }
}
