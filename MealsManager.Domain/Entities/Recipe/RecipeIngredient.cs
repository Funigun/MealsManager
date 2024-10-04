namespace MealsManager.Domain.Entities
{
    public class RecipeIngredient
    {
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
        public ICollection<Ingredient> Ingredients { get; set;} = new List<Ingredient>();
        public IngredientUnit IngredientUnit { get; set; }
        public double Amount { get; set; }
    }
}
