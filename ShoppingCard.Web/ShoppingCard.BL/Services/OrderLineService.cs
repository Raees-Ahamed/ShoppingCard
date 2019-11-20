using ShoppingCard.BL.Interfaces;
using ShoppingCard.Data.Entity;
using ShoppingCard.Data.ShoppingCardContext;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.Services
{
    public class OrderLineService : IOrderLineService
    {
        private readonly ShoppingCardDbContext db;

        public OrderLineService(ShoppingCardDbContext db)
        {
            this.db = db;
        }
        public void AddOrderItems(OrderItem items)
        {
            db.Orderitems.Add(items);
            db.SaveChanges();
        }
        public IEnumerable<OrderItem> GetOrderItem(int id)
        {
             var query = from r in db.Orderitems where r.OrderId == id select r;
            return query;
        }
    }
}
