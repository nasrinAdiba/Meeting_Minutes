using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Meeting_Minutes.Data
{
    public partial class DBMeeting_MinutesContext : DbContext
    {
        public DBMeeting_MinutesContext()
        {
        }

        public DBMeeting_MinutesContext(DbContextOptions<DBMeeting_MinutesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CorporateCustomerTbl> CorporateCustomerTbls { get; set; } = null!;
        public virtual DbSet<IndividualCustomerTbl> IndividualCustomerTbls { get; set; } = null!;
        public virtual DbSet<ProductsServiceTbl> ProductsServiceTbls { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FNMBC9E;Database=DBMeeting_Minutes;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CorporateCustomerTbl>(entity =>
            {
                entity.ToTable("Corporate_Customer_Tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IndividualCustomerTbl>(entity =>
            {
                entity.ToTable("Individual_Customer_Tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductsServiceTbl>(entity =>
            {
                entity.ToTable("Products_Service_Tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductService)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("productService");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
