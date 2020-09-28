﻿using ProductReview.Application.Interfaces;
using ProductReview.Application.ViewModels;
using ProductReview.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReview.Application.Services
{
    public class ProductsServices : IProductsService
    {
        public ProductsServices(IProductsRepository repo)
        {
            productsRepository = repo;
        }

        IProductsRepository productsRepository;
        public IEnumerable<ProductViewModel> GetProducts()
        {
            return from p in productsRepository.GetProducts().AsEnumerable()
                   select new ProductViewModel()
                   { 
                     Name = p.Name, Price = p.Price
                   };
        }
    }
}