using TLWebApi.Data;
using TLWebApi.Interfaces.Repositories;
using TLWebApi.Models;

namespace TLWebApi.Repositories
{
    public class TrailCategoryRepository : ITrailCategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public TrailCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(TrailCategory trailCategory)
        {
            _context.TrailCategories.Add(trailCategory);
            _context.SaveChanges();
        }

        public TrailCategory GetTrailCategory(int id)
        {
            return _context
                .TrailCategories
                .SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<TrailCategory> GetTrailCategories()
        {
            return _context
                .TrailCategories
                .ToList();
        }

        public void Remove(int id)
        {
            var old = _context
                .TrailCategories
                .SingleOrDefault(x => x.Id == id);
            _context.TrailCategories.Remove(old);
            _context.SaveChanges();
        }

        public void Remove(TrailCategory trailCategory)
        {
            var old = _context
                .TrailCategories
                .SingleOrDefault(x => x.Id == trailCategory.Id);
            _context.TrailCategories.Remove(old);
            _context.SaveChanges();
        }

        public void Update(TrailCategory trailCategory)
        {
            var old = _context
                .TrailCategories
                .SingleOrDefault(x => x.Id == trailCategory.Id);
            _context.TrailCategories.Remove(old);
            _context.TrailCategories.Add(trailCategory);
            _context.SaveChanges();
        }
    }
}
