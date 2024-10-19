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
               .WithMany(c => c.Categories)
               .HasForeignKey(cc => cc.CookbookId)
               .IsRequired();

        builder.HasOne(cc => cc.Recipe)
               .WithMany()
               .HasForeignKey(cc => cc.RecipeId)
               .IsRequired(false);

        builder.HasOne(c => c.ParentCategory)
               .WithMany(c => c.Subcategories)
               .HasForeignKey(c => c.ParentCategoryId)
               .IsRequired(false);

    }
}
