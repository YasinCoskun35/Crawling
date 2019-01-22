using System;
using Crawler.Server.Hepsiburada.Data.Repositories;
using Crawler.Server.Hepsiburada.Services;
using Crawler.Common;

namespace Crawler.Server.Hepsiburada
{
    class Program
    {
        static  void Main(string[] args)
        {
            //todo:Create an app config file,put in category url
            //todo:Do validations
            var crawlingUtil = new CrawlingUtil();
            var productRepository = new ProductRepository();
            var service = new CrawlingService(crawlingUtil, productRepository);
            //var request = new CrawlingRequest(categoryUrl);
             service.Crawl("https://www.hepsiburada.com/oyuncu-laptoplari-c-95583").GetAwaiter().OnCompleted(()=>{ Console.WriteLine("Completed");Console.Read(); });

        



            }
    }
}
