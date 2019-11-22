using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCard.BL.Interfaces;
using ShoppingCard.Data.Entity;
using ShoppingCard.Data.ShoppingCardContext;
using ShoppingCard.Web.Models;

namespace ShoppingCard.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductService product;
        private readonly ICustomerService customer;
        private readonly IOrderServices orders;
        private readonly IOrderLineService orderitems;

        public OrderController(IProductService product,ICustomerService customer,IOrderServices orders,IOrderLineService orderitems)
        {
            this.product = product;
            this.customer = customer;
            this.orders = orders;
            this.orderitems = orderitems;
        }
        [HttpGet]
        public IActionResult AddOrder()
        {
            var customers = customer.GetAll().ToList();
            var products = product.GetAll().ToList();

            ViewBag.listOfProducts = products;
            ViewBag.listOfCustomers = customers;

            return View();
        }

        [HttpPost]
        public ActionResult Addorder([FromBody]OrderViewModel orderViewModel)
        {

            var order = new Order() {
                CustomerId = orderViewModel.CustomerId,
                Date = orderViewModel.Date
            };

            var OrderId = orders.AddOrder(order);

            for (int i = 0; i < orderViewModel.OrderItems.Count; i++) {
                var orderItem = new OrderItem()
                {
                    ProductId = orderViewModel.OrderItems[i].ProductId,
                    Price = Convert.ToInt32(orderViewModel.OrderItems[i].UnitPrice),
                    Qty = orderViewModel.OrderItems[i].Quantity,
                    OrderId = OrderId
                };

                orderitems.AddOrderItems(orderItem);
            }
            return RedirectToAction("GetAllOrders", "Order");
        }

        [HttpGet]
        public IActionResult GetAllOrders() {
            var modal = orders.GetOrders();
            return View(modal);
        }
        [HttpGet]
        public IActionResult GetOrdersById(int id) {
            var orderbyId = orders.GetOrdersById(id);
            return View(orderbyId);
        }
    }
}