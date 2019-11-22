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
            try
            {
                db.Orderitems.Add(items);
                db.SaveChanges();
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
           
        }

        public void Edit(OrderItem EditedItems)
        {
            try
            {
                db.Orderitems.Update(EditedItems);
                db.SaveChanges();
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }

        public OrderItem GetOrderItemById(int id)
        {
            try
            {
                //var result = from r in db.Orderitems where r.Id == id select r;
                var result = db.Orderitems.FirstOrDefault(r => r.Id == id);
                return result;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
          
        }

        public List<OrderItem> GetOrderItems()
        {
            try
            {
                return db.Orderitems.ToList();
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }
    }
}
