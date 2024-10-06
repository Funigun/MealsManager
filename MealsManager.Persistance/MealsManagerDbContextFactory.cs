using Microsoft.EntityFrameworkCore;

namespace MealsManager.Persistance
{
    internal class MealsManagerDbContextFactory : DesignTimerDbContextFactoryBase<MealsManagerDbContext>
    {
        public override MealsManagerDbContext CreateContextInstance(DbContextOptions<MealsManagerDbContext> options)
        {
            return new MealsManagerDbContext(options);
        }
    }
}
