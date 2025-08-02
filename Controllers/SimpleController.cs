using ASPNet8ExampleAPI.Models.DTO;
using ASPNet8ExampleAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPNet8ExampleAPI.Controllers
{
    /// <summary>
    /// Simple controller for the example API
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="simpleService"></param>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SimpleController(ILogger<SimpleController> logger, ISimpleService simpleService) : ControllerBase
    {
        private readonly ILogger<SimpleController> _logger = logger;
        private readonly ISimpleService _simpleService = simpleService;

        /// <summary>
        /// This route only displays an info string when user goes directly to the API address
        /// </summary>
        /// <returns>Returns a very simple string back to the user</returns>
        [HttpGet]
        public string Get()
        {
            return "You are on the API address right now!";
        }

        /// <summary>
        /// This route sends back a very simple string back to the Client
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetExample()
        {
            return _simpleService.GetExampleText();
        }

        [HttpGet]
        public IEnumerable<ExampleObjectDTO> GetExampleArrayObject()
        {
            return _simpleService.GetExampleArrayObject();
        }

        /// <summary>
        /// When this route receives a string, it will return it with a prefix
        /// </summary>
        /// <param name="contentString"></param>
        /// <returns></returns>
        [HttpPost]
        public string PostExample(string contentString)
        {
            return _simpleService.PostExampleText(contentString);
        }

        /// <summary>
        /// Adds a movie to the internal memory of the API, that will display when the above GET is called
        /// </summary>
        /// <param name="movie"></param>
        [HttpPost]
        public void PostMovieObject(ExampleObjectDTO movie)
        {
            _simpleService.PostMovieExample(movie);
        }
    }
}
