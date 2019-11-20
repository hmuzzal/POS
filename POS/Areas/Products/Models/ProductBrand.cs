using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace POS.Areas.Products.Models
{
    public class ProductBrand
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public List<Product> Products { get; set; }
    }
}