namespace MealsManager.Domain.Entities
{
    public class Receipe
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string ImageURL { get; set; }
        public string VideoURL { get; set; }

        public string Cuisine { get; set; }
        public int Amount { get; set; }
        public byte NumberOfServings { get; set; }

        public Cookbook Cookbook { get; set; }
        public ICollection<ReceipeCategory> Categories { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<CookingStep> CookingSteps { get; set; }
    }
}
