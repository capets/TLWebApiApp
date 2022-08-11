using TLWebApi.Models;

namespace TLWebApi.Interfaces.Repositories
{
    public interface ITrailCategoryRepository
    {
        void Add(TrailCategory trailCategory);
        TrailCategory GetTrailCategory(int id);
        IEnumerable<TrailCategory> GetTrailCategories();
        void Remove(int id);
        void Remove(TrailCategory trailCategory);
        void Update(TrailCategory trailCategory);
    }
}