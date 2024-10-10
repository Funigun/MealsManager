namespace MealsManager.Domain.Entities
{
    public class Pantry
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public ICollection<PantryCategory> Categories { get; set; } = new List<PantryCategory>();
        public ICollection<PantryCategoryIngredient> CategoryIngredients { get; set; } = new List<PantryCategoryIngredient>();
    }
}
