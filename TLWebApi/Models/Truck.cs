using TLWebApi.Interfaces;

namespace TLWebApi.Models
{
    public class Truck : Vehicle, IAutoExtended
    {
        public Truck()
        {
        }
        public double FuelConsumptionSummer { get; set; }
        public double FuelConsumptionWinter { get; set; }
        public int FuelTank { get; set; }
        public DateTime CertTahoExpDate { get; set; }
        public int VehicleCategoryId { get; set; }
        public VehicleCategory? VehicleCategory { get; set; }
    }
}
