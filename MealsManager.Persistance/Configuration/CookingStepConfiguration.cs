using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealsManager.Persistance.Configuration
{
    internal class CookingStepConfiguration : IEntityTypeConfiguration<CookingStep>
    {
        public void Configure(EntityTypeBuilder<CookingStep> builder)
        {
            builder.ToTable("CookingSteps");

            builder.Property(p => p.CookingStepTypeId).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(1000);
        }
    }
}
