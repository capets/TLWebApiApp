using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TLWebApi.EntityConfigurations;
using TLWebApi.Models;

namespace TLWebApi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Trail> Trails { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<TrailCategory> TrailCategories { get; set; }
        public DbSet<AutoType> AutoTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {  
            builder.ApplyConfiguration(new TruckConfiguration());
            builder.ApplyConfiguration(new TrailConfiguration());
            builder.ApplyConfiguration(new VehicleCategoryConfiguration());
            builder.ApplyConfiguration(new AutoTypeConfiguration());           
            builder.ApplyConfiguration(new DriverConfiguration());           

            base.OnModelCreating(builder);
        }
    }
}