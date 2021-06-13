using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlterPott
{
    [ApiController]
    [Route("[controller]")]
    public class FacebookCrawlerController : ControllerBase
    {
        private readonly ILogger<FacebookCrawlerController> _logger;

        public FacebookCrawlerController(ILogger<FacebookCrawlerController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post(string url)
        {
        }
    }
}