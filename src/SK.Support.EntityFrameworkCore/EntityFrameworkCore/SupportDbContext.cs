using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SK.Support.Authorization.Roles;
using SK.Support.Authorization.Users;
using SK.Support.MultiTenancy;
using SK.Support.Products;
using SK.Support.ProductModels;
using SK.Support.Faults;
using SK.Support.Regions;
using SK.Support.Branches;
using SK.Support.TechnicalServices;

namespace SK.Support.EntityFrameworkCore
{
    public class SupportDbContext : AbpZeroDbContext<Tenant, Role, User, SupportDbContext>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<Fault> Faults { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<TechnicalService> TechnicalServices { get; set; }

        public SupportDbContext(DbContextOptions<SupportDbContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{


        //    modelBuilder.Entity<TechnicalService>()
        //        .HasOne(x => x.Fault).WithOne(x => x.TechnicalService).HasForeignKey<Fault>(x => x.Id);

        //    modelBuilder.Entity<Fault>()
        //        .HasOne(x => x.TechnicalService).WithOne(x => x.Fault).HasForeignKey<TechnicalService>(x => x.Id);
          
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
