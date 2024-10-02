using MealsManager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MealsManager.API.Controllers
{
    public class IngredientCategoriesController : Controller
    {
        /// <summary>
        /// Endpoint for creating ingredient categories
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IngredientCategory>> CreateIngredientCategory()
        {
            return new IngredientCategory();
        }

        /// <summary>
        /// Endpoint for getting ingredients
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<IngredientCategory>>> GetIngredientCategories()
        {
            return new List<IngredientCategory>();
        }

        /// <summary>
        /// Endpoint for updating / overriting existing ingredient
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RefreshIngredientCategory()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating existing ingredient category
        /// </summary>
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateIngredientCategory()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for deleting existing ingredient category
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteIngredientCategory()
        {
            return View();
        }
    }
}
