using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TLWebApi.Models;

namespace TLWebApi.EntityConfigurations
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.Property(x => x.VehicleCategoryId)
                .IsRequired();

            builder.Property(x => x.AutoTypeId)
                .IsRequired();

            builder.HasOne(x => x.VehicleCategory)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.AutoType)
               .WithMany()
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
