namespace MealsManager.Domain.Entities
{
    public class RecipeCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RecipeCategory> ParentCategories { get; set; } = [];
        public ICollection<RecipeCategory> Subcategories { get; set; } = [];
        public ICollection<CookbookCategoryChild> CookbookCategories { get; set; } = [];
        public ICollection<CookbookCategoryChild> CookbookCategoryChildren { get; set; } = [];
        public ICollection<CookbookCategoryRecipe> CookbookCategoryRecipes {  get; set; } = [];
        public ICollection<Recipe> Recipes { get; set; } = [];
    }
}
