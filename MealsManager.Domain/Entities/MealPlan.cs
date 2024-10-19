using MealsManager.Domain.Common;

namespace MealsManager.Domain.Entities
{
    public class MealPlan : AuditableEntity
    {
        public string Name { get; set; }

        // TODO
        /* Consider object composition with decorator / visitor patterns as Meal Plan period could be:
         * a) from-to dd.mm.yyyy       e.g. 01.01.2024 - 14.01.2024
         * b) from-to dd.mm-dd.mm yyyy e.g. 01.01 - 14.01 2024
         * c) mm.yyyy                  e.g. 02.2024
         * d) string yyyy              e.g. Christmas 2024
         */
        public DateOnly From {  get; set; }
        public DateOnly To { get; set; }

        public ICollection<Recipe> Recipes { get; set; } = [];
    }
}
