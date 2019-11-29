using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCard.BL.BO;
using ShoppingCard.BL.Interfaces;
using ShoppingCard.Data.Entity;
using ShoppingCard.Data.ShoppingCardContext;
using ShoppingCard.Web.Models;

namespace ShoppingCard.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductService productService;
        private readonly ICustomerService customerService;
        private readonly IOrderServices orderService;
        private readonly IMapper mapper;

        public OrderController(IProductService productService,ICustomerService customerService,IOrderServices orderService,IMapper mapper)
        {
            this.productService = productService;
            this.customerService = customerService;
            this.orderService = orderService;
            this.mapper = mapper;
        }

        //Show All Orders
        [HttpGet]
        public IActionResult AddOrder()
        {
            var customers = customerService.GetAllCustomers().ToList();
            var products = productService.GetAll().ToList();

            ViewBag.listOfProducts = products;
            ViewBag.listOfCustomers = customers;
            return View();
        }

        //Add New Order
        [HttpPost]
        public ActionResult Addorder([FromBody]OrderViewModel orderViewModel)
        {
            var order = mapper.Map<OrderBO>(orderViewModel);
            var OrderId = orderService.AddOrder(order);           
            return RedirectToAction("GetAllOrders","Order");
        }

        //Display All Order 
        [HttpGet]
        public IActionResult GetAllOrders() {
            var modal = mapper.Map<IEnumerable<OrderViewModel>>(orderService.GetOrders());

            return View(modal);
        }

        //When user clicks Go to order in orderline user interface it shows orders for that appropriate order items
        [HttpGet]
        public IActionResult GetOrdersById(int id) {
            var orderbyId = orderService.GetOrdersById(id);
            var lines = mapper.Map<OrderViewModel>(orderbyId);
            return View(lines);
        }

        //Delete order 
        public IActionResult DeleteOrders(int id) {
            orderService.DeleteOrder(id);
            return RedirectToAction("GetAllOrders","Order");
        }

        //Display All Order Items in Order
        public IActionResult ShowOrderLines(int id)
        {
            var linesBO= orderService.GetOrderItemById(id);
            var lines = mapper.Map<IEnumerable<OrderLineViewModel>>(linesBO);
            return View(lines);
        }

        //Getting neccessary details to edit orders
        [HttpGet]
        public IActionResult EditOrderLine(int id)
        {
            var orderItem = orderService.GetEditItems(id);
            ViewBag.AllProduct = productService.GetAll().ToList();
            var lines = mapper.Map<OrderLineViewModel>(orderItem);
            return View(lines);
        }

        //Edit Order items in order
        [HttpPost]
        public IActionResult EditOrderLine([FromBody] OrderLineViewModel OrderLines)
        {
            var lines = new OrderItemBO()
            {
                Id = OrderLines.Id,
                ProductId = OrderLines.ProductId,
                Qty = OrderLines.Qty,
                Price = Convert.ToInt32(OrderLines.Price),
                OrderId = OrderLines.OrderId
            };
            orderService.Edit(lines);
            return RedirectToAction("ShowOrderLines", "Order");
        }

        //Delete Order Items in order        
        public IActionResult DeleteOrderLine(int id)
        {
            orderService.DeleteOrderLine(id);
            return RedirectToAction("ShowOrderLines", "Order");
        }
    }
}