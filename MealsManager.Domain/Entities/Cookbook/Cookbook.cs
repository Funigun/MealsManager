using MealsManager.Domain.Common;

namespace MealsManager.Domain.Entities;

public class Cookbook : AuditableEntity
{
    public string Title { get; set; }

    public ICollection<RecipeCategory> Categories { get; set; } = [];
}
