namespace MealsManager.Domain.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string? ImageURL { get; set; }
        public string? VideoURL { get; set; }

        public string Cuisine { get; set; }
        public int Amount { get; set; }
        public byte NumberOfServings { get; set; }


        public ICollection<RecipeCategory> Categories { get; set; } = new List<RecipeCategory>();
        public ICollection<RecipeGroupCategory> GroupCategories { get; set; } = new List<RecipeGroupCategory>();
        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public ICollection<CookingStep> CookingSteps { get; set; } = new List<CookingStep>();
    }
}
