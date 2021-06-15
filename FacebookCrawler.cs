using RestSharp;

namespace AlterPott
{
    public class FacebookCrawler : ICrawler
    {
        public FacebookCrawler()
        {

        }

        public string Crawl(string url)
        {
            var rs = new RestClient("baseUri");
            

            return "";   
        }
    }
}