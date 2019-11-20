using ShoppingCard.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetProductById(int id);
    }
}
