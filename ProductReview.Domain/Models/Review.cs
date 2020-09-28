using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.Domain.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public double Rate { get; set; }

        public string Username { get; set; }
    }
}
