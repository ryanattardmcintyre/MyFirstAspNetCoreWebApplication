using ProductReview.DataAccess.Context;
using ProductReview.Domain.Interfaces;
using ProductReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReview.DataAccess.Repositories
{
    public class ProductsRepository : IProductsRepository
    {

        public ProductsRepository(ProductReviewDbContext context)
        {
            _context = context;
        }

        ProductReviewDbContext _context;

        public int AddProduct(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
            return p.Id;
        }

        public void DeleteProduct(Product p)
        {
            _context.Products.Remove(p);
            _context.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.Single(x => x.Id == id);
        }

        public IQueryable<Product> GetProducts()
        {
            return _context.Products.AsQueryable();
        }
    }
}
