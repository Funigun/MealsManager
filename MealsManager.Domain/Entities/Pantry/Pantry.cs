namespace MealsManager.Domain.Entities
{
    public class Pantry
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public ICollection<IngredientCategory> Categories { get; set; } = [];
        public ICollection<PantryCategoryChild> CategoryChildren { get; set; } = [];
        public ICollection<PantryCategoryIngredient> CategoryIngredients { get; set; } = [];
    }
}
