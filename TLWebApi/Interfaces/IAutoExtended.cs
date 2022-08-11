namespace TLWebApi.Interfaces
{
    public interface IAutoExtended
    {
        double FuelConsumptionSummer { get; set; }
        double FuelConsumptionWinter { get; set; }
        int FuelTank { get; set; }
    }
}