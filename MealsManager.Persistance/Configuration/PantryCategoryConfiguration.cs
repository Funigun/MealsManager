using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration;
internal class PantryCategoryConfiguration : IEntityTypeConfiguration<PantryCategory>
{
    public void Configure(EntityTypeBuilder<PantryCategory> builder)
    {
        builder.Property(p => p.Name).HasMaxLength(100);

        builder.HasOne(p => p.ParentCategory)
               .WithMany(p => p.Subcategories)
               .HasForeignKey(p => p.ParentCategoryId)
               .IsRequired(false);

        builder.HasMany(p => p.Pantries)
               .WithMany(p => p.Categories);

        builder.HasOne(p => p.Ingredient)
               .WithOne(i => i.PantryCategory)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.IngredientUnit)
               .WithMany(i => i.PantryIngredients)
               .HasForeignKey(p => p.IngredientUnitId)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
