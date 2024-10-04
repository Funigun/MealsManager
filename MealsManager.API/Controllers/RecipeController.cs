using MealsManager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MealsManager.API.Controllers
{
    /// <summary>
    /// Controller handler CRUD operations for Recipes
    /// </summary>
    [Route("api/recipes")]
    public class RecipeController : Controller
    {
        /// <summary>
        /// Endpoint for creating a recipe
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Recipe>> CreateRecipe()
        {
            return new Recipe();
        }

        /// <summary>
        /// Endpoint for getting recipes
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipes()
        {
            return new List<Recipe>();
        }

        /// <summary>
        /// Endpoint for updating / overriting existing recipe
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RefreshRecipe()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating existing recipe
        /// </summary>
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateRecipe()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for deleting existing recipe
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteRecipe()
        {
            return View();
        }
    }
}
