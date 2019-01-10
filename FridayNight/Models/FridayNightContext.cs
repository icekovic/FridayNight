using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FridayNight.Models
{
    public partial class FridayNightContext : DbContext
    {
        public FridayNightContext()
        {
        }

        public FridayNightContext(DbContextOptions<FridayNightContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<PlaceToGo> PlaceToGo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=FridayNight;User ID=sa;Password=!v@n");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Idcategory)
                    .HasName("PK__Category__1AA1EC663AD0A78A");

                entity.Property(e => e.Idcategory).HasColumnName("IDCategory");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PlaceToGo>(entity =>
            {
                entity.HasKey(e => e.IdplaceToGo)
                    .HasName("IDPlaceToGo");

                entity.Property(e => e.IdplaceToGo)
                    .HasColumnName("IDPlaceToGo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PriceRange)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PlaceToGo)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("CategoryID");
            });
        }
    }
}
