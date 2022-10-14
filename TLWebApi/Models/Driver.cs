namespace TLWebApi.Models
{
    public class Driver
    {
        public Driver()
        {
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? NationalId { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? LicExpDate { get; set; }
        public DateTime? TahoExpDate { get; set; }
        public DateTime? MedExpDate { get; set; }
        public DateTime? NationalExpDate { get; set; }
        public DateTime? PassportExpDate { get; set; }
    }
}
