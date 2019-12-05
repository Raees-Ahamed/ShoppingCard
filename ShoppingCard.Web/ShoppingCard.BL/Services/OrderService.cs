using ShoppingCard.BL.Interfaces;
using ShoppingCard.Data.Entity;
using ShoppingCard.Data.ShoppingCardContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ShoppingCard.BL.BO;
using ShoppingCart.Data.Repository.RespositoryInterface;
using AutoMapper;

namespace ShoppingCard.BL.Services
{
    public class OrderService : IOrderServices
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
       
        public OrderService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public int CreateOrder(OrderBO orderBO)
        {
            var order = mapper.Map<Order>(orderBO);
            unitOfWork.OrderRepository.Create(order);
            unitOfWork.Save();
            return orderBO.Id;            
        }

        public void DeleteOrder(int Id)
        {
            var orderBo = unitOfWork.OrderRepository.GetByID(Id);
            var DeleteOrder = mapper.Map<Order>(orderBo);
            unitOfWork.OrderRepository.Delete(DeleteOrder);
            unitOfWork.Save();
        }

        private void DeleteOrderLine(int id)
        {
            var orderItemBO = unitOfWork.OrderItemRepository.GetByID(id);
            var DeleteLine = mapper.Map<OrderItem>(orderItemBO);
            unitOfWork.OrderItemRepository.Delete(DeleteLine);
            unitOfWork.Save();
        }

        public void ChangeOrder(OrderBO orderBO)
        {
            foreach(var items in orderBO.OrderItems)
            {
                if (items.IsDelete)
                {
                    DeleteOrderLine(items.Id);         
                } 
                else
                {
                    var orderItem = mapper.Map<OrderItem>(items);
                    unitOfWork.OrderItemRepository.Update(orderItem);
                    unitOfWork.Save();
                }
            }
        }

        public IEnumerable<OrderBO> GetOrders()
        {
            var query = unitOfWork.OrderRepository.Get().ToList();
            return mapper.Map<IEnumerable<OrderBO>>(query);
        }

        public OrderBO GetOrdersById(int id)
        {
            var Orders = unitOfWork.OrderRepository.Get(includeProperties:"OrderItems").FirstOrDefault(o => o.Id == id);
            return mapper.Map<OrderBO>(Orders);
        }     
    }
}