﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReview
    {
        //getter and setter fieldes
            public int productId { get; set; }
            public int userId { get; set; }
            public int rating { get; set; }
            public string review { get; set; }
            public bool isLike { get; set; }
    }
}
