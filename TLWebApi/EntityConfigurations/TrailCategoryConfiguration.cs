using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TLWebApi.Models;

namespace TLWebApi.EntityConfigurations
{
    public class TrailCategoryConfiguration : IEntityTypeConfiguration<TrailCategory>
    {
        public void Configure(EntityTypeBuilder<TrailCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.HasData(
                new TrailCategory { Id = 1, Name = "Remorca" },
                new TrailCategory { Id = 2, Name = "SemiRemorca" },
                new TrailCategory { Id = 3, Name = "Container" }
                );
        }
    }
}
