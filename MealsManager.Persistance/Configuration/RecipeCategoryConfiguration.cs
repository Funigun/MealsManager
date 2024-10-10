using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class RecipeCategoryConfiguration : IEntityTypeConfiguration<RecipeCategory>
    {
        public void Configure(EntityTypeBuilder<RecipeCategory> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
        }
    }
}
