using ShoppingCard.BL.Interfaces;
using ShoppingCard.Data.Entity;
using ShoppingCard.Data.ShoppingCardContext;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly ShoppingCardDbContext db;

        public ProductService(ShoppingCardDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Product> GetAll()
        {
            return from r in db.Products orderby r.Id select r;
        }

        public Product GetProductById(int id)
        {
            return db.Products.Find(id);
        }
    }
}
