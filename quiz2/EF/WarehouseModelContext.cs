using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz2.EF.models;

namespace quiz2.EF {
    public class WarehouseModelContext : DbContext {
        public WarehouseModelContext() : base("name=warehouse") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>()
                .Property(p => p.UnitPrice).HasPrecision(12, 2);
            modelBuilder.Entity<Product>()
                .HasMany(p => p.OrderItems)
                .WithRequired(oi => oi.Product)
                .HasForeignKey(oi => oi.ProductId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Supplier>()
                .HasMany(s => s.Products)
                .WithRequired(p => p.Supplier)
                .HasForeignKey(p => p.SupplierId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount).HasPrecision(12, 2);
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithRequired(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<OrderItem>()
                .Property(o => o.UnitPrice).HasPrecision(12, 2);

            modelBuilder.Entity<Customer>()
                .HasMany(s => s.Orders)
                .WithRequired(o => o.Customer)
                .HasForeignKey(o => o.CustomerId)
                .WillCascadeOnDelete(true);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
