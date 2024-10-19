using MealsManager.Domain.Common;

namespace MealsManager.Domain.Entities;

public class Ingredient : AuditableEntity
{
    public string Name { get; set; }

    public PantryCategory? PantryCategory { get; set; }
    public ICollection<Recipe> Recipes { get; set; } = [];
    public ICollection<IngredientCategory> Categories { get; set; } = [];
    public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = [];
}
