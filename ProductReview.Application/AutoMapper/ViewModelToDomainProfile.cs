using AutoMapper;
using ProductReview.Application.ViewModels;
using ProductReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.Application.AutoMapper
{
    public class ViewModelToDomainProfile: Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<ProductViewModel, Product>();
            CreateMap<ReviewViewModel, Review>();
        }
        
    }
}
