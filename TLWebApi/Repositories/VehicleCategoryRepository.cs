using TLWebApi.Data;
using TLWebApi.Interfaces.Repositories;
using TLWebApi.Models;

namespace TLWebApi.Repositories
{
    public class VehicleCategoryRepository : IVehicleCategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public VehicleCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(VehicleCategory vehicleCategory)
        {
            _context.VehicleCategories.Add(vehicleCategory);
            _context.SaveChanges();
        }

        public VehicleCategory VehicleCategory(int id)
        {
            return _context.VehicleCategories.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<VehicleCategory> VehicleCategories()
        {
            return _context.VehicleCategories.ToList();
        }

        public void Remove(int id)
        {
            var old = _context.VehicleCategories.SingleOrDefault(x => x.Id == id);
            _context.VehicleCategories.Remove(old);
            _context.SaveChanges();
        }

        public void Remove(VehicleCategory vehicleCategory)
        {
            var old = _context.VehicleCategories.SingleOrDefault(x => x.Id == vehicleCategory.Id);
            _context.VehicleCategories.Remove(old);
            _context.SaveChanges();
        }

        public void Update(VehicleCategory vehicleCategory)
        {
            var old = _context.VehicleCategories.SingleOrDefault(x => x.Id == vehicleCategory.Id);
            _context.VehicleCategories.Remove(old);
            _context.VehicleCategories.Add(vehicleCategory);
            _context.SaveChanges();
        }
    }
}
