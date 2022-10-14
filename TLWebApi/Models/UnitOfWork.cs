using TLWebApi.Data;
using TLWebApi.Interfaces;
using TLWebApi.Interfaces.Repositories;
using TLWebApi.Repositories;

namespace TLWebApi.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ApplicationDbContext context)
        {
            Vehicles = new TruckRepository(context);
            Trails = new TrailRepository(context);
            Drivers = new DriverRepository(context);
            AutoTypes = new AutoTypeRepository(context);
            VehicleCategories = new VehicleCategoryRepository(context);
            TrailCategories = new TrailCategoryRepository(context);
        }

        public IVehicleRepository Vehicles { get; private set; }
        public ITrailRepository Trails { get; private set; }
        public IDriverRepository Drivers { get; private set; }
        public IAutoTypeRepository AutoTypes { get; private set; }
        public IVehicleCategoryRepository VehicleCategories { get; private set; }
        public ITrailCategoryRepository TrailCategories { get; private set; }
    }
}
