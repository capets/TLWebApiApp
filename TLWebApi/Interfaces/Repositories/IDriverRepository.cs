using TLWebApi.Models;

namespace TLWebApi.Interfaces.Repositories
{
    public interface IDriverRepository
    {
        void Add(Driver driver);
        Driver GetDriver(int id);
        IEnumerable<Driver> GetDrivers();
        void Remove(int id);
        void Update(Driver driver);
    }
}