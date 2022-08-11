using TLWebApi.Models;

namespace TLWebApi.Interfaces.Repositories
{
    public interface IVehicleCategoryRepository
    {
        void Add(VehicleCategory vehicleCategory);
        VehicleCategory VehicleCategory(int id);
        IEnumerable<VehicleCategory> VehicleCategories();
        void Remove(int id);
        void Remove(VehicleCategory vehicleCategory);
        void Update(VehicleCategory vehicleCategory);
    }
}