using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using POS.Areas.Address.Models;
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
        public System.Data.Entity.DbSet<Address> Addresses { get; set; }
        //public DbSet<Country> CountriesOne { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<PoliceStation> PoliceStations { get; set; }      
        public DbSet<Division> Divisions { get; set; }
    }


}