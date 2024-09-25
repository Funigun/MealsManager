namespace MealsManager.Domain.Entities
{
    public class CookingStep
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string? ImageURL { get; set; }

        public CookingStepType Type { get; set; }

        public Receipe Receipe { get; set; }
    }
}
