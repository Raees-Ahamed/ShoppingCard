using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingCard.Data.Entity
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int Qty { get; set; }
        public int Price { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Orders { get; set; }

    }
}
