namespace MealsManager.Domain.Entities;

public class Cookbook
{
    public int Id { get; set; }
    public string Title { get; set; }

    public ICollection<RecipeCategory> Categories { get; set; } = [];
}
