using ProductReview.Application.ViewModels;
using ProductReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.Application.Interfaces
{
    public interface IProductsService
    {
        IEnumerable<ProductViewModel> GetProducts();
    }
}
