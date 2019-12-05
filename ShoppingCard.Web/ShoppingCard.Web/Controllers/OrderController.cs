using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
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
        public IActionResult CreateOrder()        
        {
            var customers = customerService.GetAllCustomers().ToList();
            var products = productService.GetAll().ToList();

            ViewBag.listOfProducts = products;
            ViewBag.listOfCustomers = customers;
            return View();
        }
   
        //Add New Order
        [HttpPost]
        public ActionResult CreateOrder([FromBody]OrderViewModel orderViewModel)          
        {
            var order = mapper.Map<OrderBO>(orderViewModel);
            orderService.CreateOrder(order);           
            return RedirectToAction("GetAllOrders","Order");
        }

        [HttpPost]
        public IActionResult ChangeOrder([FromBody]OrderViewModel orderViewModel)
        {
            var order = mapper.Map<OrderBO>(orderViewModel);
            orderService.ChangeOrder(order);
            return RedirectToAction("GetAllOrders", "Order");
        }

        //Delete order 
        public IActionResult RemoveOrders(int id)
        {
            orderService.DeleteOrder(id);
            return RedirectToAction("GetAllOrders", "Order");
        }


        //Display All Order 
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var modal = mapper.Map<IEnumerable<OrderViewModel>>(orderService.GetOrders());
            return View(modal);
        }
             
        //Display All Order Items in Order
        public IActionResult ShowOrderLines(int id)
        {
            ViewBag.Products = productService.GetAll().ToList();
            var linesBO = orderService.GetOrdersById(id);   
            var lines = mapper.Map<OrderViewModel>(linesBO);
            return View(lines);
        }
    }
}