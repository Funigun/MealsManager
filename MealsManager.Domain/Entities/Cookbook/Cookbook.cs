namespace MealsManager.Domain.Entities
{
    public class Cookbook
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<CookbookCategory> Categories { get; set; } = [];
        public ICollection<CookbookCategoryRecipe> CategoryRecipes { get; set; } = [];
        public ICollection<Recipe> Recipes { get; set; } = [];
    }
}
