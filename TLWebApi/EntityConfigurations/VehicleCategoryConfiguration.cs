using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TLWebApi.Models;

namespace TLWebApi.EntityConfigurations
{
    public class VehicleCategoryConfiguration : IEntityTypeConfiguration<VehicleCategory>
    {
        public void Configure(EntityTypeBuilder<VehicleCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired()
                .HasMaxLength(255);
            builder.HasData(
                new VehicleCategory { Id = 1, Name = "Camion" },
                new VehicleCategory { Id = 2, Name = "Cap tractor" }
                );
        }
    }
}
