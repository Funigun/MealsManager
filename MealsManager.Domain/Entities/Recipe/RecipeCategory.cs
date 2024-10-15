namespace MealsManager.Domain.Entities
{
    public class RecipeCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RecipeCategory> ParentCategories { get; set; } = new List<RecipeCategory>();
        public ICollection<RecipeCategory> Subcategories { get; set; } = new List<RecipeCategory>();
        public ICollection<CookbookCategory> CookbookCategories { get; set; } = new List<CookbookCategory>(); 
        public ICollection<CookbookCategoryRecipe> CookbookCategoryRecipes {  get; set; } = new List<CookbookCategoryRecipe>();   
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}
