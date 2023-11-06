using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Infrastructure.DataLayer
{
    public class OnlineShopDbContext : DbContext
    {
    
        public OnlineShopDbContext() { }

        public OnlineShopDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-C37NTHQ\\SQLEXPRESS;Database=DBShop;Trusted_Connection=True;");
            }
        }

        public DbSet<CartItem> CartItems => Set<CartItem>();
        public DbSet<Discount> Discounts => Set<Discount>();
        public DbSet<OrderDetail> OrderDetails => Set<OrderDetail>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
        public DbSet<PaymentDetail> PaymentDetails => Set<PaymentDetail>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
        public DbSet<ProductInventory> ProductInventories => Set<ProductInventory>();
        public DbSet<ShoppingSession> ShoppingSessions => Set<ShoppingSession>();
        public DbSet<User> Users => Set<User>();
        public DbSet<UserAddres> UserAddresses => Set<UserAddres>();
        public DbSet<UserPayment> UserPayments => Set<UserPayment>();


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("shop");
            builder.ApplyConfigurationsFromAssembly(typeof(OnlineShopDbContext).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
