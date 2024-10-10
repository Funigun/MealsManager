using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;



namespace MealsManager.Persistance
{
    public class MealsManagerDbContext : DbContext
    {
        public MealsManagerDbContext(DbContextOptions<MealsManagerDbContext> options) : base(options)
        {
 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());                       
        }
    }
}
