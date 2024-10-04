using MealsManager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MealsManager.API.Controllers
{
    /// <summary>
    /// Controller handler CRUD operations for Recipe Categories
    /// </summary>
    [Route("api/recipe-categories")]
    public class RecipeCategoryController :Controller
    {
        /// <summary>
        /// Endpoint for creating a recipe
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RecipeCategory>> CreateRecipeCategory()
        {
            return new RecipeCategory();
        }

        /// <summary>
        /// Endpoint for getting recipes
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<RecipeCategory>>> GetRecipeCategories()
        {
            return new List<RecipeCategory>();
        }

        /// <summary>
        /// Endpoint for updating / overriting existing recipe category
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RefreshRecipeCategory()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating existing recipe category
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
        /// Endpoint for deleting existing recipe category
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
