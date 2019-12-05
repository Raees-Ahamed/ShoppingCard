using ShoppingCard.BL.BO;
using ShoppingCard.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.Interfaces
{
    public interface IOrderServices
    {
        public int CreateOrder(OrderBO order);
        IEnumerable<OrderBO> GetOrders();
        OrderBO GetOrdersById(int id);        
        public void DeleteOrder(int Id);
        public void ChangeOrder(OrderBO orderBO);
    }
}