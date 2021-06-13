using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlterPott
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacebookCrawlerController : ControllerBase
    {
        private readonly ILogger<FacebookCrawlerController> _logger;

        public FacebookCrawlerController(ILogger<FacebookCrawlerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Hello World");
        }

        [HttpPost]
        public void Post(string url)
        {
        }
    }
}