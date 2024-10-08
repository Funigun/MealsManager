namespace MealsManager.Domain.Entities
{
    public class CookbookCategory
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public RecipeCategory Category { get; set; }

        public int? ChildCategoryId { get; set; }
        public RecipeCategory? ChildCategory { get; set; }
    }
}
