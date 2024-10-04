using MealsManager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MealsManager.API.Controllers
{
    /// <summary>
    /// Controller handler CRUD operations for Ingredients
    /// </summary>
    [Route("api/ingredients")]
    public class IngredientsController : Controller
    {
        /// <summary>
        /// Endpoint for creating ingredient
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Ingredient>> CreateIngredient()
        {
            return new Ingredient();
        }

        /// <summary>
        /// Endpoint for getting ingredients
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Ingredient>>> GetIngredients()
        {
            return new List<Ingredient>();
        }

        /// <summary>
        /// Endpoint for updating / overriting existing ingredient
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RefreshIngredient()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating existing ingredient
        /// </summary>
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateIngredient()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for deleting existing ingredient
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteIngredient()
        {
            return View();
        }
    }
}
