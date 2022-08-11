using TLWebApi.Models;

namespace TLWebApi.Interfaces.Repositories
{
    public interface IVehicleRepository
    {
        void Add(Vehicle vehicle);
        Vehicle GetVehicle(int id);
        IEnumerable<Vehicle> GetVehicles();
        void Remove(int id);
        void Remove(Vehicle vehicle);
        void Update(Vehicle vehicle);
    }
}