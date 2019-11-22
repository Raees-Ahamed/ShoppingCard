using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCard.BL.Interfaces;

namespace ShoppingCard.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService product;

        public ProductController(IProductService product)
        {
            this.product = product;
        }
        [HttpGet]
        public JsonResult GetProduct(int id)
        {
            var products = product.GetProductById(id);
            return Json(products);
        }
    }
}