using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration;
internal class PantryCategoryConfiguration : IEntityTypeConfiguration<PantryCategory>
{
    public void Configure(EntityTypeBuilder<PantryCategory> builder)
    {
        builder.ToTable("PantryCategories");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
        builder.Property(p => p.IngredientId).IsRequired(false);

        builder.HasOne<PantryCategory>()
               .WithMany(p => p.Subcategories)
               .IsRequired(false)
               .HasForeignKey("SubcategoryId");

        builder.HasMany(p => p.Pantries)
               .WithMany(p => p.Categories);

        builder.HasOne(p => p.Ingredient)
               .WithMany()
               .IsRequired(false)
               .HasForeignKey(p => p.IngredientId);

        builder.HasOne(p => p.IngredientUnit)
               .WithMany()
               .IsRequired(false)
               .HasForeignKey(p => p.IngredientUnitId);
    }
}
