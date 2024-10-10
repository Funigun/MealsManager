namespace MealsManager.Domain.Entities
{
    public class IngredientCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<IngredientCategory> ParentCategories { get; set; } = new List<IngredientCategory>();
        public ICollection<IngredientCategory> Subcategories { get; set; } = new List<IngredientCategory>();
        public ICollection<Ingredient> Ingredients { get; set;} = new List<Ingredient>();
        public ICollection<PantryCategory> PantryCategories { get; set; } = new List<PantryCategory>();
        public ICollection<PantryCategoryIngredient> PantryIngredientCategories { get; set; } = new List<PantryCategoryIngredient>();
    }
}
