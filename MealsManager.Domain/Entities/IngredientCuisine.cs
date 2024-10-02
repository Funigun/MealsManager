using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealsManager.Domain.Entities
{
    public class IngredientCuisine
    {
        public int CuisineId { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
