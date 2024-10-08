namespace MealsManager.Domain.Entities
{
    public class PantryCategory
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public IngredientCategory IngredientCategory { get; set; }

        public int? ChildCategoryId { get; set; }
        public IngredientCategory? ChildCategory { get; set; }
    }
}
