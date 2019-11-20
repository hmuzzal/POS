using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POS.Areas.Products.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public List<Product> Products { get; set; }
    }
}