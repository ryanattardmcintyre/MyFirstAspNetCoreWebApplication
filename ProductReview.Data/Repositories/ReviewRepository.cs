using ProductReview.DataAccess.Context;
using ProductReview.Domain.Interfaces;
using ProductReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.DataAccess.Repositories
{
    public class ReviewRepository : IReviewsRepository
    {
        ProductReviewDbContext _context;
        public ReviewRepository(ProductReviewDbContext context)
        {
            _context = context;
        }
        public void AddReview(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }
    }
}
