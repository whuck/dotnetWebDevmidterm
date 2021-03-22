using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Module5.Models
{
    public class NorthwindContext : DbContext {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }
        public DbSet<Category> Categories {get;set;}
        public DbSet<Product> Products {get;set;}
        public DbSet<Discount> Discounts {get;set;}

        public DbSet<Customer> Customers {get;set;}
    }
}