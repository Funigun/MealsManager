using Microsoft.AspNetCore.Mvc;

namespace MealsManager.API.Controllers
{
    /// <summary>
    /// Health Check controller
    /// </summary>
    [Route("api/health-checks")]
    public class HealthCheckController : ControllerBase
    {
        /// <summary>
        /// Basic Health Check to ensure proper API configuration
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> GetHealthCheckAsync()
        {
            return "Healthy";
        }
    }
}
