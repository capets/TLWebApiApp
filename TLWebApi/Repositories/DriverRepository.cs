using TLWebApi.Data;
using TLWebApi.Interfaces.Repositories;
using TLWebApi.Models;

namespace TLWebApi.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        private readonly ApplicationDbContext _context;

        public DriverRepository(ApplicationDbContext context)
        {
            _context = context;
        }
       
        public IEnumerable<Driver> GetDrivers()
        {
            return _context.Drivers.ToList();
        }

        public Driver GetDriver(int id)
        {
            return _context
                .Drivers
                .SingleOrDefault(x => x.Id == id);
        }

        public void Add(Driver driver)
        {
            _context.Drivers
                .Add(driver);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var old = _context.Drivers
                .SingleOrDefault(x => x.Id == id);
            _context.Remove(old);
            _context.SaveChanges();
        }

        public void Update(Driver driver)
        {
            var old = _context.Drivers
              .SingleOrDefault(x => x.Id == driver.Id);
            _context.Drivers.Remove(old);
            _context.Drivers.Add(driver);
            _context.SaveChanges();
        }
    }
}
