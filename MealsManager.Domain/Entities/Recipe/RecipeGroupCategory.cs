namespace MealsManager.Domain.Entities
{
    public class RecipeGroupCategory
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public int CategoryId { get; set; }
        public RecipeCategory Category { get; set; }
    }
}
