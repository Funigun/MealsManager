using MealsManager.Application.Interfaces;
using MealsManager.Domain.Common;
using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MealsManager.Persistance
{
    public class MealsManagerDbContext(DbContextOptions<MealsManagerDbContext> options) : DbContext(options)
    {
        private IDateTime _dateTimeService;

        public DbSet<Cookbook> Cookbooks { get; set; }
        public DbSet<CookbookCategory> CookbookCategories { get; set; }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeCategory> RecipeCategories { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientCategory> IngredientCategories { get; set; }
        public DbSet<IngredientUnit> IngredientUnits { get; set; }

        public DbSet<Pantry> Pantries { get; set; }
        public DbSet<PantryCategory> PantryCategories { get; set; }

        public DbSet<MealPlan> MealPlans { get; set; }

        public MealsManagerDbContext(DbContextOptions<MealsManagerDbContext> options, IDateTime dateTimeService) : this(options)
        {
            _dateTimeService = dateTimeService;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            UpdateEntities();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void UpdateEntities()
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "";
                        entry.Entity.CreatedOn = _dateTimeService.Now;
                        entry.Entity.StatusId = 1;
                        break;

                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = "";
                        entry.Entity.ModifiedOn = _dateTimeService.Now;
                        break;

                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = "";
                        entry.Entity.ModifiedOn = _dateTimeService.Now;
                        entry.Entity.InavtivatedBy = "";
                        entry.Entity.InactivatedOn = _dateTimeService.Now;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
        }
    }
}
