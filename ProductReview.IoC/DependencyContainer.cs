using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProductReview.Application.AutoMapper;
using ProductReview.Application.Interfaces;
using ProductReview.Application.Services;
using ProductReview.DataAccess.Repositories;
using ProductReview.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.IoC
{
   public  class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //there are three ways how to initialize services
            //Singleton: IoC container will create and share a single instance of a service throughout the application's lifetime.
            //Transient: The IoC container will create a new instance of the specified service type every time you ask for it.
            //Scoped: IoC container will create an instance of the specified service type once per request and will be shared in a single request.

            services.AddScoped<IProductsRepository, ProductsRepository>();

            services.AddScoped<IProductsService, ProductsServices>();

            services.AddScoped<IReviewsRepository, ReviewRepository > ();
            services.AddScoped<IReviewServices, ReviewServices>();


        }
    }
}
