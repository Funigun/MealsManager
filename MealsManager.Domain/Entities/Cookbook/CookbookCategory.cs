namespace MealsManager.Domain.Entities;

public class CookbookCategory
{
    public int Id { get; set; }
    public string Name { get; set; }


    public ICollection<CookbookCategory> Subcategories { get; set; }
    public int CookbookId { get; set; }
    public Cookbook Cookbook { get; set; }
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}
