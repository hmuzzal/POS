using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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
            Database.SetInitializer<ApplicationDbContext>(null);
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }



        public static ApplicationDbContext Create()
        {

            return new ApplicationDbContext();
        }

        public DbSet<IdentityUserLogin> UserLogins { get; set; }
        public DbSet<IdentityUserClaim> UserClaims { get; set; }
        public DbSet<IdentityUserRole> UserRoles { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<PoliceStation> PoliceStations { get; set; }      
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Village> Villages { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Configure Asp Net Identity Tables
            modelBuilder.Entity<IdentityUser>().ToTable("User");
            modelBuilder.Entity<IdentityUser>().Property(u => u.PasswordHash).HasMaxLength(500);
            modelBuilder.Entity<IdentityUser>().Property(u => u.SecurityStamp).HasMaxLength(500);
            modelBuilder.Entity<IdentityUser>().Property(u => u.PhoneNumber).HasMaxLength(50);

            modelBuilder.Entity<IdentityRole>().ToTable("Role");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRole");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim");
            modelBuilder.Entity<IdentityUserClaim>().Property(u => u.ClaimType).HasMaxLength(150);
            modelBuilder.Entity<IdentityUserClaim>().Property(u => u.ClaimValue).HasMaxLength(500);


            //modelBuilder.Entity<Country>()
            //    .HasRequired(c => c.Districts)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Side>()
            //    .HasRequired(s => s.Stage)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

        }
    }


}