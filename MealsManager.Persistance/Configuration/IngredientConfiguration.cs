using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MealsManager.Persistance.Configuration
{
    internal class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(150).IsRequired();
        }
    }
}
