using Microsoft.AspNetCore.Mvc;

namespace MealsManager.API.Controllers
{
    /// <summary>
    /// Controller handles cookbooks CRUD operations
    /// </summary>
    [Route("api/cookbooks")]
    public class CookbookController : Controller
    {
        /// <summary>
        /// Endpoint for creating a cookbook
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult CreateCookbook()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for getting cookbooks
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetCookbooks()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating / overriting existing cookbook
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RefreshCookbook()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating existing cookbook
        /// </summary>
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateCookbook()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for deleting existing cookbook
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteCookbook()
        {
            return View();
        }
    }
}
