using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MealsManager.Persistance.Configuration;

internal class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
{
    public void Configure(EntityTypeBuilder<Recipe> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(p => p.Title).HasMaxLength(250).IsRequired();
        builder.Property(p => p.Description).HasMaxLength(1000);
        builder.Property(p => p.Amount).IsRequired();
        builder.Property(p => p.NumberOfServings).IsRequired();
        builder.Property(p => p.CuisineId).IsRequired();   
    }
}
