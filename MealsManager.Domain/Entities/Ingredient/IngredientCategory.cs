namespace MealsManager.Domain.Entities
{
    public class IngredientCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }

        public int? ParentId { get; set; }
        public IngredientCategory ParentCategory { get; set; }

        public ICollection<IngredientCategory> Subcategories { get; set; } = new List<IngredientCategory>();
        public ICollection<IngredientGroupCategory> CategoryIngredients { get; set; } = new List<IngredientGroupCategory>();
    }
}
