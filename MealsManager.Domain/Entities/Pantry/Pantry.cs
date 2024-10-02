namespace MealsManager.Domain.Entities
{
    public class Pantry
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public ICollection<IngredientGroupCategory> Ingredients { get; set; } = new List<IngredientGroupCategory>();
    }
}
