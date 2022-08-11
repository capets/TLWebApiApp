using Microsoft.EntityFrameworkCore;
using TLWebApi.Data;
using TLWebApi.Interfaces.Repositories;
using TLWebApi.Models;

namespace TLWebApi.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApplicationDbContext _context;
        public VehicleRepository(ApplicationDbContext context)
        {
            _context = context;
        } 
        public IEnumerable<Vehicle> GetVehicles()
        {
            return _context.Vehicles
                .Include(x => x.AutoType)
                .Include(x => x.VehicleCategory)
                .ToList();
        }

        public Vehicle GetVehicle(int id)
        {
            return _context.Vehicles
                 .Include(x => x.AutoType)
                 .Include(x => x.VehicleCategory)
                 .SingleOrDefault(x => x.Id == id);
        }

        public void Add(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
        }

        public void Update(Vehicle vehicle)
        {
            var old = _context.Vehicles.SingleOrDefault(x => x.Id == vehicle.Id);
            _context.Vehicles.Remove(old);
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var old = _context.Vehicles.SingleOrDefault(x => x.Id == id);
            _context.Vehicles.Remove(old);            
            _context.SaveChanges();
        }

        public void Remove(Vehicle vehicle)
        {
            var old = _context.Vehicles.SingleOrDefault(x => x.Id == vehicle.Id);
            _context.Vehicles.Remove(old);
            _context.SaveChanges();
        }
    }
}
