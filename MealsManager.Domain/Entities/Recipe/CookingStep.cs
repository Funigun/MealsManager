namespace MealsManager.Domain.Entities
{
    public class CookingStep
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string? ImageURL { get; set; }

        public int CookingStepTypeId { get; set; }
        public CookingStepType StepType { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
