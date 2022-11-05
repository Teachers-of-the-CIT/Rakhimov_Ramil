using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DemoRakhimov4432
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderShopAddress> OrderShopAddress { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductOrder> ProductOrder { get; set; }
        public virtual DbSet<ShopAddress> ShopAddress { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserOrder> UserOrder { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderShopAddress)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.ProductOrder)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.UserOrder)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShopAddress>()
                .HasMany(e => e.OrderShopAddress)
                .WithRequired(e => e.ShopAddress)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserOrder)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
