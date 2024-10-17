namespace MealsManager.Domain.Entities
{
    public class CookbookCategoryChild
    {
        public int CookbookId { get; set; }
        public Cookbook Cookbook { get; set; }

        public int CategoryId { get; set; }
        public RecipeCategory Category { get; set; }

        public int ChildCategoryId { get; set; }
        public RecipeCategory ChildCategory { get; set; }
    }
}
