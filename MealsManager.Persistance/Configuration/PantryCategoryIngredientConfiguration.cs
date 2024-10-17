using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class PantryCategoryIngredientConfiguration : IEntityTypeConfiguration<PantryCategoryIngredient>
    {
        public void Configure(EntityTypeBuilder<PantryCategoryIngredient> builder)
        {
            builder.Property(p => p.PantryId).IsRequired();
            builder.Property(p => p.IngredientCategoryId).IsRequired(false);
            builder.Property(p => p.IngredientUnitId).IsRequired();
            builder.Property(p => p.IngredientId).IsRequired();
            builder.Property(p => p.Amount).IsRequired();

            builder.HasKey(p => new { p.PantryId, p.IngredientCategoryId, p.IngredientId, p.IngredientUnitId });

            builder.HasOne(p => p.Pantry)
                   .WithMany(p => p.CategoryIngredients)
                   .HasForeignKey(p => p.PantryId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.IngredientCategory)
                   .WithMany(p => p.PantryCategoryIngredients)
                   .HasForeignKey(p => p.IngredientCategoryId)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(p => p.Ingredient)
                   .WithOne(p => p.PantryCategory)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(p => p.IngredientUnit)
                   .WithMany(i => i.PantryIngredients)
                   .HasForeignKey(p => p.IngredientUnitId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
