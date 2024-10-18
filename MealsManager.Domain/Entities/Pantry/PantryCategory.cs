namespace MealsManager.Domain.Entities;
public class PantryCategory
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<PantryCategory> Subcategories { get; set; } = [];
    public ICollection<Pantry> Pantries { get; set; } = [];
    public int? IngredientId { get; set; }
    public Ingredient? Ingredient { get; set; }
    public int? IngredientUnitId { get; set; }
    public IngredientUnit? IngredientUnit { get; set; }
    public double IngredientAmount {  get; set; }
}
