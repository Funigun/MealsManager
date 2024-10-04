namespace MealsManager.Domain.Entities
{
    public class MealPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateOnly From {  get; set; }
        public DateOnly To { get; set; }

        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}
