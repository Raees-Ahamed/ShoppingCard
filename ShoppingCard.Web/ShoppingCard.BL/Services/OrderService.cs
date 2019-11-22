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
            try
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return order.Id;
            }
            catch (Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
           
        }

        public IEnumerable<Order> GetOrders()
        {
            try
            {
                var query = db.Orders.Include(c => c.Customer).ToList();
                return query;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
           
        }

        public IEnumerable<Order> GetOrdersById(int id)
        {
            try
            {
                return from r in db.Orders where r.Id == id select r;
            }
            catch (Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }

        public IEnumerable<Order> GetOrdersByIdEdit(int id)
        {
            try
            {
                var query = db.Orders.Include(c => c.Customer).Where(o => o.CustomerId == id);
                return query;
            }
            catch (Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
            
        }
    }
}
