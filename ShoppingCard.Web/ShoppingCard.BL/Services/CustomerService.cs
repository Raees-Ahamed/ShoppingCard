using ShoppingCard.BL.Interfaces;
using ShoppingCard.Data.Entity;
using ShoppingCard.Data.ShoppingCardContext;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ShoppingCardDbContext db;

        public CustomerService(ShoppingCardDbContext db)
        {
            this.db = db;
        }


        public IEnumerable<Customer> GetAll()
        {
            return from r in db.Customers orderby r.Id select r;
        }
    }
}
