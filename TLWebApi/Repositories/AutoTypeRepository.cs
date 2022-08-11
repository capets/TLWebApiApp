using TLWebApi.Data;
using TLWebApi.Interfaces.Repositories;
using TLWebApi.Models;

namespace TLWebApi.Repositories
{
    public class AutoTypeRepository : IAutoTypeRepository
    {
        private readonly ApplicationDbContext _context;
        public AutoTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(AutoType autoType)
        {
            _context.AutoTypes.Add(autoType);
            _context.SaveChanges();
        }

        public AutoType GetAutoType(int id)
        {
            return _context.AutoTypes.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<AutoType> GetAutoTypes()
        {
            return _context.AutoTypes.ToList();
        }

        public void Remove(int id)
        {
            var old = _context.AutoTypes.SingleOrDefault(x => x.Id == id);
            _context.AutoTypes.Remove(old);
            _context.SaveChanges();
        }

        public void Remove(AutoType autoType)
        {
            var old = _context.AutoTypes.SingleOrDefault(x => x.Id == autoType.Id);
            _context.AutoTypes.Remove(old);
            _context.SaveChanges();
        }

        public void Update(AutoType autoType)
        {
            var old = _context.AutoTypes.SingleOrDefault(x => x.Id == autoType.Id);
            _context.AutoTypes.Remove(old);
            _context.AutoTypes.Add(autoType);
            _context.SaveChanges();
        }
    }
}
