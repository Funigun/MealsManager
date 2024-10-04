using MealsManager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MealsManager.API.Controllers
{
    /// <summary>
    /// Controller handles creaing shopping list based on different criteria
    /// </summary>
    [Route("api/shopping-list")]
    public class ShoppingListController : Controller
    {
        /// <summary>
        /// Endpoint for creating a shopping list
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Ingredient>>> CreateShoppingList()
        {
            return new List<Ingredient>();  
        }
    }
}
