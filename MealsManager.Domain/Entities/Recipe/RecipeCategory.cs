namespace MealsManager.Domain.Entities
{
    public class RecipeCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RecipeCategory> ParentCategories { get; set; } = new List<RecipeCategory>();
        public ICollection<RecipeCategory> Subcategories { get; set; } = new List<RecipeCategory>();
        public ICollection<CookbookCategory> CategoryCookbooks { get; set; } = new List<CookbookCategory>(); 
        public ICollection<CookbookCategoryRecipe> CookbookRecipeCategory {  get; set; } = new List<CookbookCategoryRecipe>();   
        public ICollection<Recipe> CategoryRecipes { get; set; } = new List<Recipe>();
    }
}
