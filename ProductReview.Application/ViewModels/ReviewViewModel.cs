using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.Application.ViewModels
{
    //https://stackoverflow.com/questions/62866379/ef-core-unable-to-insert-new-entry-that-has-a-foreign-key
    public class ReviewViewModel
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public double Rate { get; set; }

        public string Username { get; set; }
        public int ProductId { get; set; }

        public ProductViewModel Product { get; set; }
      
    }
}
