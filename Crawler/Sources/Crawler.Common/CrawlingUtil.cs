using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PuppeteerSharp;
namespace Crawler.Common
{
    public class CrawlingUtil
    {
        
        public async Task<List<string>> DeterminePages(string categoryUrl)
        {
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);
            var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true
            });
            var page = await browser.NewPageAsync();
            await page.GoToAsync(categoryUrl);
            var allPagesXpath=await page.XPathAsync("//ul//li/a");
            
            string[] x = { "", "" };
           var y=x.ToList();
           return y;
        }
        public async Task<List<string>> DetermineProducts(List<string> productPages)
        {
            var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true
            });
            var page = await browser.NewPageAsync();
            await page.GoToAsync("http://www.google.com");
            string[] x = { "", "" };
            var y = x.ToList();
            return y;
        }
        

    }
}
