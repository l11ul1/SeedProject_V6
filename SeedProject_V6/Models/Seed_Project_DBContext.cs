using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SeedProject_V6.Models
{
    public partial class Seed_Project_DBContext : DbContext
    {
        public Seed_Project_DBContext()
        {
        }

        public Seed_Project_DBContext(DbContextOptions<Seed_Project_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SeedProduct> SeedProducts { get; set; }
        public virtual DbSet<SeedProductInfo> SeedProductInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Database=Seed_Project_DB; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<SeedProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_Product");

                entity.ToTable("seed_Product");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("productId");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.VendorId).HasColumnName("vendorId");
            });

            modelBuilder.Entity<SeedProductInfo>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_Seed_Products");

                entity.ToTable("seed_ProductInfo");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("dateAdded");

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productDescription");

                entity.Property(e => e.ProductImg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productImg");

                entity.Property(e => e.ProductPrice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productPrice");

                entity.Property(e => e.ProductRating).HasColumnName("productRating");

                entity.Property(e => e.RatingCount).HasColumnName("ratingCount");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
