using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCard.BL.Interfaces;
using ShoppingCard.Data.Entity;
using ShoppingCard.Web.Models;

namespace ShoppingCard.Web.Controllers
{
    public class OrderLineController : Controller
    {
        private readonly IOrderLineService orderLines;
        private readonly IProductService products;

        public OrderLineController(IOrderLineService orderLines,IProductService products)
        {
            this.orderLines = orderLines;
            this.products = products;
        }


        public IActionResult ShowOrderLines()
        {
            var lines = orderLines.GetOrderItems();
            return View(lines); 
        }

        [HttpGet]
        public IActionResult EditOrderLine(int id) {

            var orderItem = orderLines.GetOrderItemById(id);
            ViewBag.AllProduct = products.GetAll().ToList();
            return View(orderItem);
        }

        [HttpPost]
        public IActionResult EditOrderLine([FromBody] OrderLineViewModel OrderLines ) 
        {
            var lines = new OrderItem()
            {
                Id = OrderLines.Id,
                ProductId = OrderLines.ProductId,
                Qty = OrderLines.Quantity,
                Price = Convert.ToInt32(OrderLines.UnitPrice),
                OrderId = OrderLines.OrderId
            };

            orderLines.Edit(lines);
            return RedirectToPage("ShowOrderLines");
        }

        public IActionResult DeleteOrderLine(int id) {
            orderLines.DeleteOrderLine(id);
            return RedirectToAction("ShowOrderLines","OrderLine");
        }
    }
}