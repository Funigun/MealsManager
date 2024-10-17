namespace MealsManager.Domain.Entities
{
    public class IngredientCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<IngredientCategory> ParentCategories { get; set; } = [];
        public ICollection<IngredientCategory> Subcategories { get; set; } = [];
        public ICollection<Ingredient> Ingredients { get; set; } = [];
        public ICollection<PantryCategoryChild> PantryCategories { get; set; } = [];
        public ICollection<PantryCategoryChild> PantryCategoryChildren { get; set; } = [];
        public ICollection<PantryCategoryIngredient> PantryCategoryIngredients { get; set; } = [];
    }
}
