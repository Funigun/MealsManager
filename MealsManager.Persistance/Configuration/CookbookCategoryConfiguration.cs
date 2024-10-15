using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class CookbookCategoryConfiguration : IEntityTypeConfiguration<CookbookCategory>
    {
        public void Configure(EntityTypeBuilder<CookbookCategory> builder)
        {
            builder.Property(cc => cc.CookbookId).IsRequired();
            builder.Property(cc => cc.CategoryId).IsRequired();
            builder.Property(cc => cc.ChildCategoryId).IsRequired(false);

            builder.HasKey(cc => new { cc.CookbookId, cc.CategoryId, cc.ChildCategoryId });

            builder.HasOne(cc => cc.Cookbook)
                   .WithMany(c => c.Categories)
                   .HasForeignKey(cc => cc.CookbookId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(cc => cc.Category)
                   .WithMany(rc => rc.CookbookCategories)
                   .HasForeignKey(cc => cc.CategoryId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(cc => cc.Category)
                   .WithMany(rc => rc.CookbookCategories)
                   .HasForeignKey(p => p.ChildCategoryId)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
