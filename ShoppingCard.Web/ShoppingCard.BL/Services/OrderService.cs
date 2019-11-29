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
        private readonly ProductService productService;

        public OrderService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            productService = new ProductService(unitOfWork, mapper);
        }

        public int AddOrder(OrderBO orderBO)
        {
            var order = mapper.Map<Order>(orderBO);
            unitOfWork.OrderRepository.Create(order);
            unitOfWork.Save();
            return orderBO.Id;
            
        }

        public void AddOrderItems(OrderItemBO orderItemBO)
        {
            var orderItems = mapper.Map<OrderItem>(orderItemBO);
            unitOfWork.OrderItemRepository.Create(orderItems);
            unitOfWork.Save();
        }

        public void DeleteOrder(int Id)
        {
            var orderBo = unitOfWork.OrderRepository.GetByID(Id);
            var DeleteOrder = mapper.Map<Order>(orderBo);
            unitOfWork.OrderRepository.Delete(DeleteOrder);
            unitOfWork.Save();
        }

        public void DeleteOrderLine(int id)
        {
            var orderItemBO= unitOfWork.OrderItemRepository.GetByID(id);
            var DeleteLine = mapper.Map<OrderItem>(orderItemBO);
            unitOfWork.OrderItemRepository.Delete(DeleteLine);
            unitOfWork.Save();
        }

        public void Edit(OrderItemBO EditedItems)
        {
            var OrderItemEdit = mapper.Map<OrderItem>(EditedItems);
            unitOfWork.OrderItemRepository.Update(OrderItemEdit);
            unitOfWork.Save();
        }

        public OrderItemBO GetEditItems(int id)
        {
            var OrderItems = unitOfWork.OrderItemRepository.GetByID(id);
            return mapper.Map<OrderItemBO>(OrderItems);
        }

        public IEnumerable<OrderItemBO> GetOrderItemById(int id)
        {
            var OrderItems = unitOfWork.OrderItemRepository.Get(o => o.OrderId == id, includeProperties:"Products");
            return mapper.Map<IEnumerable<OrderItemBO>>(OrderItems);
        }

        public IEnumerable<OrderItemBO> GetOrderItems()
        {
            var query = unitOfWork.OrderItemRepository.Get();
            return mapper.Map<IEnumerable<OrderItemBO>>(query);
        }

        public IEnumerable<OrderBO> GetOrders()
        {
            var query = unitOfWork.OrderRepository.Get().ToList();
            return mapper.Map<IEnumerable<OrderBO>>(query);
        }

        public OrderBO GetOrdersById(int id)
        {
            var Orders = unitOfWork.OrderRepository.GetByID(id);
            return mapper.Map<OrderBO>(Orders);
        }

      
    }
}
