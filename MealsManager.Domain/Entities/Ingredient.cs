namespace MealsManager.Domain.Entities
{
    public class Ingredient
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Cuisine { get; set; }
        public IngredientUnit Unit { get; set; }

        public ICollection<Receipe> Receipes { get; set; }
        public ICollection<IngredientCategory> Categories { get; set; }
    }
}
