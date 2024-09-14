using Microsoft.AspNetCore.Mvc;

namespace MealsManager.API.Controllers
{
    /// <summary>
    /// Controller handles meal preparation logic
    /// </summary>
    [Route("api/meal-plans")]
    public class MealPlannerController :Controller
    {
        /// <summary>
        /// Endpoint for creating a meal plan
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult CreateMealPlan()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for getting meal plans
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetMealPlans()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating / overriting existing plan
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RefreshMealPlan()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for updating existing plan
        /// </summary>
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateMealPlan()
        {
            return View();
        }

        /// <summary>
        /// Endpoint for deleting a plan
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteMealPlan()
        {
            return View();
        }
    }
}
