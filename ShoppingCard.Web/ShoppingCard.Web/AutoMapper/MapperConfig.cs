using AutoMapper;
using ShoppingCard.BL.BO;
using ShoppingCard.Data.Entity;
using ShoppingCard.Web.Models;
using ShoppingCard.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCard.Web.AutoMapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {

            CreateMap<Order, OrderItem>().ReverseMap();

            CreateMap<OrderBO, Order>().ReverseMap();
            CreateMap<Order, OrderBO>().ReverseMap();
            CreateMap<OrderItemBO, OrderItem>().ReverseMap();
            CreateMap<OrderBO, OrderItemBO>().ReverseMap();

            CreateMap<OrderViewModel, OrderBO>().ReverseMap();
           
            CreateMap<ProductViewModel, ProductBO>().ReverseMap();

            CreateMap<OrderItemBO, OrderLineViewModel>().ReverseMap();
            CreateMap<CustomerBO, CustomerViewModel>().ReverseMap();

            CreateMap<ProductBO, Product>().ReverseMap();
            CreateMap<CustomerBO, Customer>().ReverseMap();           
        }
    }
}
