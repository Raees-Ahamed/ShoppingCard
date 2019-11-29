using ShoppingCard.BL.BO;
using ShoppingCard.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.Interfaces
{
    public interface IOrderServices
    {
        public int AddOrder(OrderBO order);
        IEnumerable<OrderBO> GetOrders();
        OrderBO GetOrdersById(int id);        
        public void DeleteOrder(int Id);
        public void AddOrderItems(OrderItemBO items);
        public IEnumerable<OrderItemBO> GetOrderItemById(int id);
        public OrderItemBO GetEditItems(int id);
        public IEnumerable<OrderItemBO> GetOrderItems();
        public void Edit(OrderItemBO EditedItems);
        public void DeleteOrderLine(int id);
    }
}
