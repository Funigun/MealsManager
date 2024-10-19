using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MealsManager.Persistance.Configuration;

internal class IngredientUnitConfiguration : IEntityTypeConfiguration<IngredientUnit>
{
    public void Configure(EntityTypeBuilder<IngredientUnit> builder)
    {
        builder.Property(p => p.Name).HasMaxLength(50);

        builder.HasMany(i => i.RecipeIngredients)
               .WithOne(p => p.IngredientUnit)
               .HasForeignKey(p =>  p.IngredientUnitId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(i => i.PantryIngredients)
               .WithOne(p => p.IngredientUnit)
               .HasForeignKey(p => p.IngredientUnitId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
    }
}
