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
            try
            {
                return from r in db.Products orderby r.Id select r;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
           
        }

        public Product GetProductById(int id)
        {
            try
            {
                return db.Products.Find(id);
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }
    }
}
