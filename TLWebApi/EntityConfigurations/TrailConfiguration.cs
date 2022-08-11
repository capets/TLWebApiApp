using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TLWebApi.Models;

namespace TLWebApi.EntityConfigurations
{
    public class TrailConfiguration : IEntityTypeConfiguration<Trail>
    {
        public void Configure(EntityTypeBuilder<Trail> builder)
        {            
            builder.Property(x => x.AutoTypeId)
                .IsRequired();

            builder.HasOne(x => x.AutoType)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.TrailCategory)
               .WithMany()
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
