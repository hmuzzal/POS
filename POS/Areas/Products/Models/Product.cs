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
        public List<ProductCategory> Categories { get; set; }
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public List<ProductBrand> Brands { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        [NotMapped]
        public HttpPostedFileBase Image { get; set; }

    }
}