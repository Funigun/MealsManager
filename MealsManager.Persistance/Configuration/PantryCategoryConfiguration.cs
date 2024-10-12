using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class PantryCategoryConfiguration : IEntityTypeConfiguration<PantryCategory>
    {
        public void Configure(EntityTypeBuilder<PantryCategory> builder)
        {
            builder.Property(p => p.PantryId).IsRequired();
            builder.Property(p => p.CategoryId).IsRequired();
            builder.Property(p => p.ChildCategoryId).IsRequired(false);                
        }
    }
}
