using MealsManager.Domain.Enums;

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


        public int? IngredientId { get; set; }
        public Ingredient? Ingredient { get; set; }

        public RecipeDifficulty Difficulty { get; set; }

        public ICollection<RecipeCategory> Categories { get; set; } = [];
        public ICollection<RecipeIngredient> Ingredients { get; set; } = [];
        public ICollection<CookingStep> CookingSteps { get; set; } = [];
        public ICollection<MealPlan> MealPlans { get; set; } = [];
    }
}
