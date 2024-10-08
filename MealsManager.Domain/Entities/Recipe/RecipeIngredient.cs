namespace MealsManager.Domain.Entities
{
    public class RecipeIngredient
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public int IngredientUnitId {  get; set; }
        public IngredientUnit IngredientUnit { get; set; }

        public double Amount { get; set; }
    }
}
