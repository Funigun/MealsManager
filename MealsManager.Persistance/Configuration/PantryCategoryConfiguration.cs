using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class PantryCategoryConfiguration : IEntityTypeConfiguration<PantryCategory>
    {
        public void Configure(EntityTypeBuilder<PantryCategory> builder)
        {
            builder.HasKey(p => new { p.PantryId, p.CategoryId, p.ChildCategoryId });

            builder.HasOne(p => p.Pantry)
                   .WithMany(p => p.Categories)
                   .HasForeignKey(p => p.PantryId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Category)
                   .WithMany(p => p.PantryCategories)
                   .HasForeignKey(p => p.CategoryId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Category)
                   .WithMany(p => p.PantryCategories)
                   .HasForeignKey(p => p.ChildCategoryId)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
