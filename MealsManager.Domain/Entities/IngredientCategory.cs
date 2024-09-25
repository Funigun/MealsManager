using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealsManager.Domain.Entities
{
    public class IngredientCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
