using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace MealsManager.Persistance
{
    public class MealsManagerDbContext : DbContext
    {
        public MealsManagerDbContext(DbContextOptions<MealsManagerDbContext> options) : base(options)
        {
            
        }
    }
}
