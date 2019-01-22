using System;
using System.Collections.Generic;
using System.Text;
using Crawler.Server.Hepsiburada.Data.Repositories;
namespace Crawler.Server.Hepsiburada.Data.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SellerCount { get; set; }
        public int CommentCount { get; set; }
      
        
    }
    
}
