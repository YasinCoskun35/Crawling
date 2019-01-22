using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
namespace Crawler.Server.Hepsiburada.Data.Entities

{
    class HepsiburadaCrawlingContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-U7VAFP4\SQLEXPRESS;Database=HepsiburadaCrawlingDB;Trusted_Connection=True;ConnectRetryCount=0");
        }
    }
}
