using Microsoft.EntityFrameworkCore;
using ShoppingCard.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.Data.ShoppingCardContext
{
    public class ShoppingCardDbContext : DbContext
    {
        public ShoppingCardDbContext(DbContextOptions<ShoppingCardDbContext>options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Orderitems { get; set; }
    }
}
