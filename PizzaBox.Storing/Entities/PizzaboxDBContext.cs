using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    public partial class PizzaboxDBContext : DbContext
    {
        public PizzaboxDBContext()
        {
        }

        public PizzaboxDBContext(DbContextOptions<PizzaboxDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<PizzaBuild> PizzaBuilds { get; set; }
        public virtual DbSet<PizzaCrust> PizzaCrusts { get; set; }
        public virtual DbSet<PizzaOrder> PizzaOrders { get; set; }
        public virtual DbSet<PizzaSize> PizzaSizes { get; set; }
        public virtual DbSet<PizzaStore> PizzaStores { get; set; }
        public virtual DbSet<PizzaTopping> PizzaToppings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:pizzabox.database.windows.net,1433;Initial Catalog=PizzaboxDB;Persist Security Info=False;User ID=Keyosu;Password=Randye12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PizzaBuild>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PizzaCrust>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PizzaOrder>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PizzaSize>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PizzaStore>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PizzaTopping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
