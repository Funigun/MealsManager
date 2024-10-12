namespace MealsManager.Domain.Entities
{
    public class IngredientUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = [];
        public ICollection<PantryCategoryIngredient> PantryIngredients { get; set; } = [];
    }
}
