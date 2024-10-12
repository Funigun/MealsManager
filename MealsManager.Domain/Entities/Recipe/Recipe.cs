namespace MealsManager.Domain.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string? ImageURL { get; set; }
        public string? VideoURL { get; set; }
        public int Amount { get; set; }
        public byte NumberOfServings { get; set; }

        public int CuisineId {  get; set; }
        public Cuisine Cuisine { get; set; }

        public ICollection<Cookbook> Cookbooks { get; set; } = [];
        public ICollection<CookbookCategory> CookbookCategories { get; set; } = [];
        public ICollection<RecipeCategory> Categories { get; set; } = [];
        public ICollection<Ingredient> Ingredients { get; set; } = [];
        public ICollection<CookingStep> CookingSteps { get; set; } = [];
        public ICollection<MealPlan> MealPlans { get; set; } = [];
    }
}
