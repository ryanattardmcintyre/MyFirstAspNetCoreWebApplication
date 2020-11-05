using AutoMapper;
using ProductReview.Application.Interfaces;
using ProductReview.Application.ViewModels;
using ProductReview.Domain.Interfaces;
using ProductReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.Application.Services
{
    public class ReviewServices : IReviewServices
    {
        IReviewsRepository _reviewRepo;
        IMapper _autoMapper;
        public ReviewServices (IReviewsRepository reviewRepo,  IMapper autoMapper)
        {
            _reviewRepo = reviewRepo;
            _autoMapper = autoMapper;
        }
        public void AddReview(ReviewViewModel review)
        {
            _reviewRepo.AddReview(_autoMapper.Map<Review>(review));
        }
    }
}
