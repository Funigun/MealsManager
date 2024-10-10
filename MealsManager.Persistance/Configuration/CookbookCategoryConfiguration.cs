using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class CookbookCategoryConfiguration : IEntityTypeConfiguration<CookbookCategory>
    {
        public void Configure(EntityTypeBuilder<CookbookCategory> builder)
        {
            builder.Property(p => p.CookbookId).IsRequired();
            builder.Property(p => p.CategoryId).IsRequired();
            builder.Property(p => p.ChildCategoryId).IsRequired(false);
            builder.Property(p => p.RecipeId).IsRequired();
        }
    }
}
