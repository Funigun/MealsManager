namespace MealsManager.Domain.Entities
{
    public class PantryCategoryIngredient
    {
        public int PantryId { get; set; }
        public Pantry Pantry { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public int? IngredientCategoryId {  get; set; }
        public IngredientCategory? IngredientCategory { get; set; }

        public int IngredientUnitId { get; set; }
        public IngredientUnit IngredientUnit { get; set; }

        public double Amount { get; set; }
    }
}
