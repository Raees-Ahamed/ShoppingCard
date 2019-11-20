using ShoppingCard.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.Interfaces
{
    public interface IOrderServices
    {
        public int AddOrder(Order order);
        IEnumerable<Order> GetOrders();
    }
}
