using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class CuisineConfiguration : IEntityTypeConfiguration<Cuisine>
    {
        public void Configure(EntityTypeBuilder<Cuisine> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
        }
    }
}
