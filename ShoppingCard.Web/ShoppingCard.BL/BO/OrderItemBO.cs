using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.BO
{
    public class OrderItemBO
    {
        public int Id { get; set; }

        public int Qty { get; set; }

        public int Price { get; set; }

        public int ProductId { get; set; }
        public ProductBO Products { get; set; }

        public int OrderId { get; set; }
    }
}
