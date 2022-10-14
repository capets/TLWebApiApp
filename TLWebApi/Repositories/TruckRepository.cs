using Microsoft.EntityFrameworkCore;
using TLWebApi.Data;
using TLWebApi.Interfaces.Repositories;
using TLWebApi.Models;

namespace TLWebApi.Repositories
{
    public class TruckRepository : IVehicleRepository
    {
        private readonly ApplicationDbContext _context;
        public TruckRepository(ApplicationDbContext context)
        {
            _context = context;
        } 
        public IEnumerable<Truck> GetVehicles()
        {
            return _context.Trucks
                .Include(x => x.AutoType)
                .Include(x => x.VehicleCategory)
                .ToList();
        }

        public Truck GetVehicle(int id)
        {
            return _context.Trucks
                 .Include(x => x.AutoType)
                 .Include(x => x.VehicleCategory)
                 .SingleOrDefault(x => x.Id == id);
        }

        public void Add(Truck vehicle)
        {
            _context.Trucks.Add(vehicle);
            _context.SaveChanges();
        }

        public void Update(Truck vehicle)
        {
            var old = _context.Trucks
                .SingleOrDefault(x => x.Id == vehicle.Id);           
            _context.Trucks.Remove(old);
            vehicle.AutoType = null;
            vehicle.VehicleCategory = null;
            _context.Trucks.Add(vehicle);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var old = _context.Trucks
                .SingleOrDefault(x => x.Id == id);
            _context.Trucks.Remove(old);            
            _context.SaveChanges();
        }

        public void Remove(Truck vehicle)
        {
            var old = _context.Trucks
                .SingleOrDefault(x => x.Id == vehicle.Id);
            _context.Trucks.Remove(old);
            _context.SaveChanges();
        }
    }
}
