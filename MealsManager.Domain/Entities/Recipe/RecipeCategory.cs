namespace MealsManager.Domain.Entities
{
    public class RecipeCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RecipeCategory> ParentCategories { get; set; } = [];
        public ICollection<RecipeCategory> Subcategories { get; set; } = [];
        public ICollection<Recipe> Recipes { get; set; } = [];
    }
}
