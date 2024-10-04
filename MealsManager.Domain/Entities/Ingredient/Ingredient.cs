namespace MealsManager.Domain.Entities
{
    public class Ingredient
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public ICollection<Cuisine> Cuisines { get; set; } = new List<Cuisine>();
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
        public ICollection<IngredientCategory> Categories { get; set; } = new List<IngredientCategory>();
        public ICollection<IngredientGroupCategory> GroupCategories { get; set; } = new List<IngredientGroupCategory>();  
    }
}
