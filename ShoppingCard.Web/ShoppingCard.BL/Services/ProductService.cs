using ShoppingCard.BL.Interfaces;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.BL.BO;
using ShoppingCart.Data.Repository.Respositories;
using AutoMapper;
using ShoppingCart.Data.Repository.RespositoryInterface;

namespace ShoppingCard.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProductService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<ProductBO> GetAll()
        {
            var query = unitOfWork.ProductRepository.Get();
            return mapper.Map<IEnumerable<ProductBO>>(query);
        }

        public ProductBO GetProductById(int id)
        {
            var query = unitOfWork.ProductRepository.GetByID(id);
            return mapper.Map<ProductBO>(query);
        }
    }
}
