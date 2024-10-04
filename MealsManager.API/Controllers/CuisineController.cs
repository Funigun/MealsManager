using MealsManager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MealsManager.API.Controllers
{
    /// <summary>
    /// Controller handler CRUD operations for Cuisine categories
    /// </summary>
    [Route("api/cusine-categories")]
    public class CuisineController : Controller
    {
        /// <summary>
        /// Endpoint for creating a cuisine category
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Cuisine>> CreateCuisine()
        {
            return new Cuisine();
        }

        /// <summary>
        /// Endpoint for getting cuisine categories
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Cuisine>>> GetCuisineCategories()
        {
            return new List<Cuisine>();
        }

        /// <summary>
        /// Endpoint for updating / overriting existing cuisine category
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RefreshCusineCategory()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating existing cuisine category
        /// </summary>
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateCuisineCategory()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for deleting existing cuisine category
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteCuisineCategory()
        {
            return View();
        }
    }
}
