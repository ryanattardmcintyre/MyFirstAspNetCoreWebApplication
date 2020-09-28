using Microsoft.EntityFrameworkCore;
using ProductReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview.DataAccess.Context
{
    public class ProductReviewDbContext:DbContext 
    {
        public ProductReviewDbContext(DbContextOptions options):base(options)
        { }


        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
