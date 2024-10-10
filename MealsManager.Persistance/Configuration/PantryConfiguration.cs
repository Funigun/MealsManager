using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class PantryConfiguration : IEntityTypeConfiguration<Pantry>
    {
        public void Configure(EntityTypeBuilder<Pantry> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
        }
    }
}
