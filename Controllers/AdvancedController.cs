using ASPNet8ExampleAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPNet8ExampleAPI.Controllers
{
    /// <summary>
    /// Advanced controller for the example API
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="advancedService"></param>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AdvancedController(ILogger<AdvancedController> logger, IAdvancedService advancedService) : ControllerBase
    {
        private readonly ILogger<AdvancedController> _logger = logger;
        private readonly IAdvancedService _advancedService = advancedService;

        /// <summary>
        /// Returns a list of all video games that the API currently contains
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetVideoGames()
        {
            var videoGames = _advancedService.GetVideoGames();

            if (videoGames == null)
            {
                return NotFound();
            }

            return Ok(videoGames);
        }

        /// <summary>
        /// Returns one of the video games that the API currently contains by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetVideoGame(string id)
        {
            var videoGame = _advancedService.GetVideoGame(id);


            if (videoGame == null)
            {
                return NotFound();
            }

            return Ok(videoGame);
        }
    }
}
