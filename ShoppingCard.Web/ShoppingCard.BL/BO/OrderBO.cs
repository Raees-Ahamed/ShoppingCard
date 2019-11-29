using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.BO
{
    public class OrderBO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public virtual CustomerBO CustomerBO { get; set; }
        public virtual List<OrderItemBO> OrderItems { get; set; }
     
    }
}
