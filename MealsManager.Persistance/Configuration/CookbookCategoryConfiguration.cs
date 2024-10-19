using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration;

internal class CookbookCategoryConfiguration : IEntityTypeConfiguration<CookbookCategory>
{
    public void Configure(EntityTypeBuilder<CookbookCategory> builder)
    {
        builder.Property(p => p.Name).HasMaxLength(100);


        builder.HasOne(cc => cc.Cookbook)
               .WithMany()
               .IsRequired()
               .HasForeignKey(cc => cc.CookbookId);

        builder.HasOne(cc => cc.Recipe)
               .WithMany()
               .IsRequired(false)
               .HasForeignKey(cc => cc.RecipeId);

        builder.HasOne<CookbookCategory>()
               .WithMany(c => c.Subcategories)
               .IsRequired(false)
               .HasForeignKey("SubcategoryId");

    }
}
