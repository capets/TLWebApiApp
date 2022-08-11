using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TLWebApi.Models;

namespace TLWebApi.EntityConfigurations
{
    public class AutoTypeConfiguration : IEntityTypeConfiguration<AutoType>
    {
        public void Configure(EntityTypeBuilder<AutoType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);          
            builder.HasData(
                new AutoType { Id = 1, Name = "Prelata" },
                new AutoType { Id = 2, Name = "Frigider" },
                new AutoType { Id = 3, Name = "Duba" }
                );
        }
    }
}
