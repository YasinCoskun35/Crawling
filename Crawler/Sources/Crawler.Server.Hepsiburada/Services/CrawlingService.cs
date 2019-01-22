using System;
using System.Collections.Generic;
using System.Text;
using Crawler.Server.Hepsiburada.Data.Repositories;
using Crawler.Common;
using System.Threading.Tasks;
using Crawler.Server.Hepsiburada.Data.Entities;
using PuppeteerSharp;
namespace Crawler.Server.Hepsiburada.Services
{
    class CrawlingService
    {
        CrawlingUtil util;
        ProductRepository productRepository;
        public CrawlingService(CrawlingUtil crawlingUtil,ProductRepository productRepository)
        {
            this.util = crawlingUtil;
            this.productRepository = productRepository;
        }
       public async Task Crawl(string categoryUrl)
        {
            Product product = new Product();

            var productPageUrls = await util.DeterminePages(categoryUrl);
            var productUrls = await util.DetermineProducts(productPageUrls);
            foreach (var item in productUrls)
            {
                
                this.productRepository.Add(product);
            }
            Console.WriteLine("Crawling Completed...");
        }
    }
}
