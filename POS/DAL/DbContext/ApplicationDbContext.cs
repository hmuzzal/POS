using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using POS.Areas.Products.Models;

namespace POS.Identity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }



        public static ApplicationDbContext Create()
        {

            return new ApplicationDbContext();
        }


        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<Product> Products { get; set; }

    }


}