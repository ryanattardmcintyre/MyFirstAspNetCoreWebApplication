using ProductReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReview.Domain.Interfaces
{
    public interface IProductsRepository
    {
        Product GetProduct(int id);
        IQueryable<Product> GetProducts();
        int AddProduct(Product p);

        void DeleteProduct(Product p);

    }
}
