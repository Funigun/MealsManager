using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class CookbookConfiguration : IEntityTypeConfiguration<Cookbook>
    {
        public void Configure(EntityTypeBuilder<Cookbook> builder)
        {
            builder.Property(p => p.Title).HasMaxLength(250).IsRequired();
        }
    }
}
