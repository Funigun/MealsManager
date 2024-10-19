using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MealsManager.Persistance.Configuration;

internal class RecipeIngredientConfiguration : IEntityTypeConfiguration<RecipeIngredient>
{
    public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
    {
        builder.HasKey(p => new { p.RecipeId, p.IngredientId, p.IngredientUnitId });

        builder.HasOne(rc => rc.Recipe)
               .WithMany(r => r.Ingredients)
               .HasForeignKey(rc => rc.RecipeId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(rc => rc.Ingredient)
               .WithMany(r => r.RecipeIngredients)
               .HasForeignKey(rc => rc.IngredientId)
               .IsRequired()
               .OnDelete(DeleteBehavior.ClientCascade);

        builder.HasOne(rc => rc.IngredientUnit)
               .WithMany(r => r.RecipeIngredients)
               .HasForeignKey(rc => rc.IngredientUnitId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
    }
}
