using ProductReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.Domain.Interfaces
{
    public interface IReviewsRepository
    {
        void AddReview(Review review);
    }
}
