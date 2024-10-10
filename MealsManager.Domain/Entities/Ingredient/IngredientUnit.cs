namespace MealsManager.Domain.Entities
{
    public class IngredientUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
        public ICollection<PantryCategoryIngredient> PantryIngredients { get; set; } = new List<PantryCategoryIngredient>();
    }
}
