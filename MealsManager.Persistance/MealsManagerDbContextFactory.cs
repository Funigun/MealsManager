using Microsoft.EntityFrameworkCore;

namespace MealsManager.Persistance
{
    internal class MealsManagerDbContextFactory : DesignTimeDbContextFactoryBase<MealsManagerDbContext>
    {
        protected override MealsManagerDbContext CreateContextInstance(DbContextOptions<MealsManagerDbContext> options)
        {
            return new MealsManagerDbContext(options);
        }
    }
}
