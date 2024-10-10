namespace MealsManager.Domain.Entities
{
    public class CookingStepType
    {
        public int Id { get; set; }

        public ICollection<CookingStep> Steps { get; set; } = new List<CookingStep>();
    }
}
