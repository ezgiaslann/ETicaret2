﻿using System;
using System.Linq;

namespace ETicaret2.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public string q { get; set; }
        public int AltCategoryId { get; set; }

    }
}