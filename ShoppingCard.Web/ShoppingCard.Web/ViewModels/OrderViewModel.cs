using ShoppingCard.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCard.Web.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public List<OrderLineViewModel> OrderItems { get; set; }
        public CustomerViewModel Customer { get; set; }
    }
}
