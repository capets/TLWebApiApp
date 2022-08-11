using Microsoft.EntityFrameworkCore;
using TLWebApi.Data;
using TLWebApi.Interfaces.Repositories;
using TLWebApi.Models;

namespace TLWebApi.Repositories
{   
    public class TrailRepository : ITrailRepository
    {
        private readonly ApplicationDbContext _context;
        public TrailRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Trail trail)
        {
            _context.Trails.Add(trail);
            _context.SaveChanges();
        }

        public Trail GetTrail(int id)
        {
            return _context.Trails
                 .Include(x => x.AutoType)
                 .Include(x => x.TrailCategory)
                 .SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Trail> GetTrails()
        {
            return _context.Trails
               .Include(x => x.AutoType)
               .Include(x => x.TrailCategory)
               .ToList();
        }

        public void Remove(int id)
        {
            var old = _context.Trails.SingleOrDefault(x => x.Id == id);
            _context.Trails.Remove(old);
            _context.SaveChanges();
        }

        public void Remove(Trail trail)
        {
            _context.Trails.Remove(trail);
            _context.SaveChanges();
        }

        public void Update(Trail trail)
        {
            var old = _context.Trails.SingleOrDefault(x => x.Id == trail.Id);
            _context.Trails.Remove(old);
            _context.Add(trail);
            _context.SaveChanges();
        }
    }
}
