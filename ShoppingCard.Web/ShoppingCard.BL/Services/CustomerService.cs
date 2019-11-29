using ShoppingCard.BL.Interfaces;
using ShoppingCard.Data.Entity;
using ShoppingCard.Data.ShoppingCardContext;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.BL.BO;
using ShoppingCart.Data.Repository.RespositoryInterface;
using AutoMapper;

namespace ShoppingCard.BL.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CustomerService(IUnitOfWork unitOfWork,IMapper mapper )
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public IEnumerable<CustomerBO> GetAllCustomers()
        {
            var query= unitOfWork.CustomerRepository.Get().ToList();
            return mapper.Map<IEnumerable<CustomerBO>>(query);
        }
    }
}
