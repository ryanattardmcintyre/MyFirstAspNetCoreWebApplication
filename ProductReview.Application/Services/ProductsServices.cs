using ProductReview.Application.Interfaces;
using ProductReview.Application.ViewModels;
using ProductReview.Domain.Interfaces;
using ProductReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ProductReview.Application.Services
{
    public class ProductsServices : IProductsService
    {

        public ProductsServices(IProductsRepository repo, IMapper autoMapper)
        {
            _autoMapper = autoMapper;
            productsRepository = repo;
        }

        IMapper _autoMapper;
        IProductsRepository productsRepository;
        public IEnumerable<ProductViewModel> GetProducts()
        {
            return  productsRepository.GetProducts().ProjectTo<ProductViewModel>(_autoMapper.ConfigurationProvider);

                   /*.AsEnumerable()
                   select new ProductViewModel()
                   { 
                     Name = p.Name, Price = p.Price
                   };*/
        }

        public void AddProduct(ProductViewModel p)
        {
           /* Product pr = new Product()
            {
                Name = p.Name,
                Price = p.Price
            };*/
            productsRepository.AddProduct(_autoMapper.Map<Product>(p));
        }
    }
}
