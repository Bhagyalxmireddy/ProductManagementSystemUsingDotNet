using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagementSystem
{
    public  class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }

    }
}
