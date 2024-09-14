using Microsoft.AspNetCore.Mvc;

namespace MealsManager.API.Controllers
{
    /// <summary>
    /// Controller handles CRUD operations for Pantry
    /// </summary>
    [Route("api/pantries")]
    public class PantryController : Controller
    {
        /// <summary>
        /// Endpoint for creating a pantry
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult CreatePantry()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for getting pantries
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPantries()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating / overriting ingredients within existing pantry
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RefreshPantry()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating ingredient within existing pantry
        /// </summary>
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdatePantry()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for creating a pantry
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeletePantry()
        {
            return View();
        }
    }
}
