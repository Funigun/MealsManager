namespace MealsManager.Domain.Entities
{
    public class Cuisine
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Recipe> Recipes { get; set; } = [];
        public ICollection<Ingredient> Ingredients { get; set; } = [];
    }
}
