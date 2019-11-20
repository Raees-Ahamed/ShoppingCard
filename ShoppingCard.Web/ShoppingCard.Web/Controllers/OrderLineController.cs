using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCard.BL.Interfaces;

namespace ShoppingCard.Web.Controllers
{
    public class OrderLineController : Controller
    {
        private readonly IOrderLineService orderLines;

        public OrderLineController(IOrderLineService orderLines)
        {
            this.orderLines = orderLines;
        }


        public IActionResult ShowOrderLines(int id)
        {
            var lines = orderLines.GetOrderItem(id);
            return View(lines);
        }

        public IActionResult EditOrderLine() {
            return View();
        }
    }
}