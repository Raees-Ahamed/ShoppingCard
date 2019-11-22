using ShoppingCard.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.Interfaces
{
    public interface IOrderLineService
    {
        public void AddOrderItems(OrderItem items);
        public OrderItem GetOrderItemById(int id);
        public List<OrderItem> GetOrderItems();
        public void Edit(OrderItem EditedItems);
        public void DeleteOrderLine(int id);      
    }
}
