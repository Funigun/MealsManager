namespace MealsManager.Domain.Entities
{
    public class IngredientGroupCategory
    {
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public int CategoryId { get; set; }
        public IngredientCategory Category { get; set; }
    }
}
