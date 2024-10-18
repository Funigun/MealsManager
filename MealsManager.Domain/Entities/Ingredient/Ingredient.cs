namespace MealsManager.Domain.Entities;

public class Ingredient
{
    public int Id { get; private set; }
    public string Name { get; set; }

    public PantryCategoryIngredient? PantryCategoryIngredient { get; set; }
    public ICollection<Cuisine> Cuisines { get; set; } = [];
    public ICollection<Recipe> Recipes { get; set; } = [];
    public ICollection<IngredientCategory> Categories { get; set; } = [];
    public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = [];
}
