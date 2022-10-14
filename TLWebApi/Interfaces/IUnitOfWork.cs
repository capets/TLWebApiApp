using TLWebApi.Interfaces.Repositories;

namespace TLWebApi.Interfaces
{
    public interface IUnitOfWork
    {
        IVehicleRepository Vehicles { get; }
        ITrailRepository Trails { get; }
        IDriverRepository Drivers { get; }
        IAutoTypeRepository AutoTypes { get; }
        IVehicleCategoryRepository VehicleCategories { get; }
        ITrailCategoryRepository TrailCategories { get; }
    }
}