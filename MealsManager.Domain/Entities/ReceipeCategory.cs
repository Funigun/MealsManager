using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealsManager.Domain.Entities
{
    public class ReceipeCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Receipe> Receipes { get; set; }
    }
}
