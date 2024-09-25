namespace MealsManager.Domain.Entities
{
    public class Cookbook
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public ICollection<Receipe> Receipes { get; set; }
    }
}
