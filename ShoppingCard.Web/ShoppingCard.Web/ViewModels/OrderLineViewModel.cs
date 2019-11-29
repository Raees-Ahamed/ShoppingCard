using ShoppingCard.Web.ViewModels;
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
        public ProductViewModel Products { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public int OrderId { get; set; }
    }
}
