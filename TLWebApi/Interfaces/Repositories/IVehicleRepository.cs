using TLWebApi.Models;

namespace TLWebApi.Interfaces.Repositories
{
    public interface IVehicleRepository
    {
        void Add(Truck vehicle);
        Truck GetVehicle(int id);
        IEnumerable<Truck> GetVehicles();
        void Remove(int id);
        void Remove(Truck vehicle);
        void Update(Truck vehicle);
    }
}