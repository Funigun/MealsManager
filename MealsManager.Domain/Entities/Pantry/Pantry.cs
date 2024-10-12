namespace MealsManager.Domain.Entities
{
    public class Pantry
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public ICollection<PantryCategory> Categories { get; set; } = [];
        public ICollection<PantryCategoryIngredient> CategoryIngredients { get; set; } = [];
    }
}
