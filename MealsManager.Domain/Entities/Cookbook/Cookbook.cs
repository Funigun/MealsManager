using MealsManager.Domain.Common;

namespace MealsManager.Domain.Entities;

public class Cookbook : AuditableEntity
{
    public string Title { get; set; }

    public ICollection<CookbookCategory> Categories { get; set; } = [];
}
