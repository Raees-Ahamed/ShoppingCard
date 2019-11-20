using ShoppingCard.BL.Interfaces;
using ShoppingCard.Data.Entity;
using ShoppingCard.Data.ShoppingCardContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCard.BL.Services
{
    public class OrderService : IOrderServices
    {
        private readonly ShoppingCardDbContext db;

        public OrderService(ShoppingCardDbContext db)
        {
            this.db = db;
        }
        public int AddOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order.Id;
        }

        public IEnumerable<Order> GetOrders()
        {
            var query = db.Orders.Include(c => c.Customer).ToList();
            return query;
        }

        public IEnumerable<Order> GetOrdersById(int id)
        {
            return from r in db.Orders where r.Id == id select r;
        }
    }
}
