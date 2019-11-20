using ShoppingCard.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.Interfaces
{
    public interface IOrderLineService
    {
        public void AddOrderItems(OrderItem items);
        public IEnumerable<OrderItem> GetOrderItem(int id);
    }
}
