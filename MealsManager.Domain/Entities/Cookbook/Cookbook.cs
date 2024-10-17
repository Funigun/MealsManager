namespace MealsManager.Domain.Entities
{
    public class Cookbook
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<RecipeCategory> Categories { get; set; } = [];
        public ICollection<CookbookCategoryChild> CategoryChildren { get; set; } = [];
        public ICollection<CookbookCategoryRecipe> CategoryRecipes { get; set; } = [];
    }
}
