using MealsManager.Domain.Enums;

namespace MealsManager.Domain.Entities
{
    public class CookingStep
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string? ImageURL { get; set; }

        public CookingStepType StepType { get; set; }
    }
}
