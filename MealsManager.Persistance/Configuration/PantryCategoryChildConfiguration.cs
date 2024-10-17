using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class PantryCategoryChildConfiguration : IEntityTypeConfiguration<PantryCategoryChild>
    {
        public void Configure(EntityTypeBuilder<PantryCategoryChild> builder)
        {
            builder.ToTable("PantryCategoryChildren");
            
            builder.HasKey(p => new { p.PantryId, p.CategoryId, p.ChildCategoryId });

            builder.HasOne(p => p.Pantry)
                   .WithMany(p => p.CategoryChildren)
                   .HasForeignKey(p => p.PantryId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Category)
                   .WithMany(p => p.PantryCategories)
                   .HasForeignKey(p => p.CategoryId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.ChildCategory)
                   .WithMany(p => p.PantryCategoryChildren)
                   .HasForeignKey(p => p.ChildCategoryId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
