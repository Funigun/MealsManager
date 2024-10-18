using MealsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MealsManager.Persistance
{
    public class MealsManagerDbContext(DbContextOptions<MealsManagerDbContext> options) : DbContext(options)
    {
        public DbSet<Cookbook> Cookbooks { get; set; }
        public DbSet<CookbookCategory> CookbookCategories { get; set; }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeCategory> RecipeCategories { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientCategory> IngredientCategories { get; set; }
        public DbSet<IngredientUnit> IngredientUnits { get; set; }

        public DbSet<Pantry> Pantries { get; set; }
        public DbSet<PantryCategoryChild> PantryCategoryChildren { get; set; }
        public DbSet<PantryCategoryIngredient> PantryCategoryIngredients { get; set; }

        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
