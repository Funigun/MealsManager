namespace MealsManager.Domain.Entities
{
    public class PantryCategory
    {
        public int PantryId { get; set; }
        public Pantry Pantry { get; set; }

        public int CategoryId { get; set; }
        public IngredientCategory IngredientCategory { get; set; }

        public int? ChildCategoryId { get; set; }
        public IngredientCategory? ChildCategory { get; set; }
    }
}
