using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Journey.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]    
    public class JournalController : ControllerBase
    {
        private readonly ILogger<JournalController> _logger;

        public JournalController(ILogger<JournalController> logger)
        {
            _logger = logger;
        }

        [HttpGet] 
        public IActionResult HelloWorld() => Ok("Hello, World!");
    }
}
