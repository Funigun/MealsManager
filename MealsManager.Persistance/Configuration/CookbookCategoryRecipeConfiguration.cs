using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class CookbookCategoryRecipeConfiguration : IEntityTypeConfiguration<CookbookCategoryRecipe>
    {
        public void Configure(EntityTypeBuilder<CookbookCategoryRecipe> builder)
        {
            builder.Property(p => p.CookbookId).IsRequired();
            builder.Property(p => p.CategoryId).IsRequired(false);
            builder.Property(p => p.RecipeId).IsRequired();

            builder.ToTable("CookbookRecipes");

            builder.HasKey(p => new { p.CookbookId, p.RecipeId });

            builder.HasOne(cc => cc.Cookbook)
                   .WithMany(c => c.CategoryRecipes)
                   .HasForeignKey(cc => cc.CookbookId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(cc => cc.RecipeCategory)
                   .WithMany(rc => rc.CookbookCategoryRecipes)
                   .HasForeignKey(cc => cc.CategoryId)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(cc => cc.Recipe)
                   .WithMany(r => r.CookbookCategoryRecipes)
                   .HasForeignKey(cc => cc.RecipeId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
