using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductReview.Application.Interfaces;

namespace ProductReview.Mvc.Controllers
{
    public class ProductsController : Controller
    {

        IProductsService productService;
        public ProductsController(IProductsService s1)
        {
            productService = s1;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            var list = productService.GetProducts();

            return View(list);
        }
    }
}