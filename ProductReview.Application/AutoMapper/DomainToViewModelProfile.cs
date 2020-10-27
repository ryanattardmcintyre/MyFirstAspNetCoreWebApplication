using AutoMapper;
using ProductReview.Application.ViewModels;
using ProductReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.Application.AutoMapper
{
    public class DomainToViewModelProfile: Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
