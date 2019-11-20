using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCard.Web.Models
{
    public class OrderLineViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
    }
}
