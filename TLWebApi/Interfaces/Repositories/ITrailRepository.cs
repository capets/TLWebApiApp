using TLWebApi.Models;

namespace TLWebApi.Interfaces.Repositories
{
    public interface ITrailRepository
    {
        void Add(Trail trail);
        Trail GetTrail(int id);
        IEnumerable<Trail> GetTrails();
        void Remove(int id);
        void Remove(Trail trail);
        void Update(Trail trail);
    }
}