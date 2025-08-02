using ASPNet8ExampleAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPNet8ExampleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AdvancedController(ILogger<AdvancedController> logger, IAdvancedService advancedService) : ControllerBase
    {
        private readonly ILogger<AdvancedController> _logger = logger;
        private readonly IAdvancedService _advancedService = advancedService;
    }
}
