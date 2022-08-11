using TLWebApi.Interfaces;

namespace TLWebApi.Models
{
    public class Vehicle : AutoBase, IAutoExtended
    {
        public double FuelConsumptionSummer { get; set; }
        public double FuelConsumptionWinter { get; set; }
        public int FuelTank { get; set; }
        public int VehicleCategoryId { get; set; }
        public VehicleCategory? VehicleCategory { get; set; }
    }
}
