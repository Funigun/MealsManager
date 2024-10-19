using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration;
internal class PantryCategoryConfiguration : IEntityTypeConfiguration<PantryCategory>
{
    public void Configure(EntityTypeBuilder<PantryCategory> builder)
    {
        builder.Property(p => p.Name).HasMaxLength(100);

        builder.HasOne<PantryCategory>()
               .WithMany(p => p.Subcategories)
               .HasForeignKey("SubcategoryId")
               .IsRequired(false);

        builder.HasMany(p => p.Pantries)
               .WithMany(p => p.Categories);

        builder.HasOne(p => p.Ingredient)
               .WithMany()
               .HasForeignKey(p => p.IngredientId)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.IngredientUnit)
               .WithMany()
               .HasForeignKey(p => p.IngredientUnitId)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
