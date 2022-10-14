using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TLWebApi.Models;

namespace TLWebApi.EntityConfigurations
{
    public class TruckConfiguration : IEntityTypeConfiguration<Truck>
    {
        public void Configure(EntityTypeBuilder<Truck> builder)
        {
            builder.Property(x => x.VehicleCategoryId)
                .IsRequired();

            builder.Property(x => x.AutoTypeId)
                .IsRequired();                       

            //builder.HasOne(x => x.VehicleCategory)
            //    .WithOne()
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne(x => x.AutoType)
            //   .WithMany(x => x.Trucks)
            //   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
