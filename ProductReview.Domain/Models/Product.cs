using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.Domain.Models
{
    public class Product
    {
     
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public IEnumerable<Review> Reviews {get; set;}

    }
}
