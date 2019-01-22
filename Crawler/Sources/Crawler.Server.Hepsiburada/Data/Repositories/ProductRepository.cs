using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Crawler.Server.Hepsiburada.Data.Entities;
namespace Crawler.Server.Hepsiburada.Data.Repositories
{
    class ProductRepository
    {
        private DbContext DbContext;
        private DbSet<Product> ObjectSet;
       
       public  ProductRepository()
        {
            DbContext = new HepsiburadaCrawlingContext();
            ObjectSet = DbContext.Set<Product>();
        }
        public void Add(Product entity)
        {
            this.ObjectSet.Add(entity);
            DbContext.SaveChanges();
        }
    }

}
