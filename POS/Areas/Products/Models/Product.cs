using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace POS.Areas.Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public ProductCategory PrdouctCategory { get; set; }
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public int Stock { get; set; }
        [NotMapped]
        public HttpPostedFileBase Image { get; set; }

    }
}