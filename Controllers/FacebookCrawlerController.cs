using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlterPott
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacebookCrawlerController : ControllerBase
    {
        private readonly ILogger<FacebookCrawlerController> _logger;
        private readonly ICrawler _crawler;

        public FacebookCrawlerController(ILogger<FacebookCrawlerController> logger, ICrawler crawler)
        {
            _logger = logger;
            _crawler = crawler;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_crawler.Crawl("..."));
        }

        [HttpPost]
        public void Post(string url)
        {
        }
    }
}