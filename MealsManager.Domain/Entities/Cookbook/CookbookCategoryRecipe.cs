namespace MealsManager.Domain.Entities
{
    public class CookbookCategoryRecipe
    {
        public int CookbookId { get; set; } 
        public Cookbook Cookbook { get; set; }

        public int CategoryId { get; set; }
        public RecipeCategory RecipeCategory { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
