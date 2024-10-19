namespace MealsManager.Domain.Entities;

public class IngredientCategory
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<IngredientCategory> Subcategories { get; set; } = [];
    public ICollection<Ingredient> Ingredients { get; set; } = [];
}
