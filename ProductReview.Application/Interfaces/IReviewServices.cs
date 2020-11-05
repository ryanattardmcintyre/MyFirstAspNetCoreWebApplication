using ProductReview.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.Application.Interfaces
{
    public interface IReviewServices
    {
        void AddReview(ReviewViewModel review);
    }
}
