using Microsoft.AspNetCore.Mvc;

namespace MealsManager.API.Controllers
{
    /// <summary>
    /// Controller handler CRUD operations for Receipes
    /// </summary>
    [Route("api/receipes")]
    public class ReceipeController : Controller
    {
        /// <summary>
        /// Endpoint for creating a receipe
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult CreateReceipe()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for getting receipes
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetReceipes()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating / overriting existing receipe
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RefreshReceipe()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating existing receipe
        /// </summary>
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateReceipe()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for deleting existing receipe
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteReceipe()
        {
            return View();
        }
    }
}
