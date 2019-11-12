using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS.Areas.Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public ProductCategory Category { get; set; }
        public ProductBrand Brand { get; set; }
        public string Name { get; set; }
        public HttpPostedFileBase Image { get; set; }

    }
}