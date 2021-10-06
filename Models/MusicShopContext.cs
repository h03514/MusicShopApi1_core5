using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MusicShop.Models
{
    public partial class MusicShopContext : DbContext
    {
        public MusicShopContext()
        {
        }

        public MusicShopContext(DbContextOptions<MusicShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Instrument> Instruments { get; set; }
        public virtual DbSet<Price> Prices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=MusicShop;Trusted_Connection=True;User ID=todo;Password=todo");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<Instrument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("instrument");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Instrument1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instrument");

                entity.Property(e => e.Xid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("xid");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("price");

                entity.Property(e => e.InstrumentId).HasColumnName("instrumentId");

                entity.Property(e => e.PreferntialPrice).HasColumnName("preferntialPrice");

                entity.Property(e => e.Price1).HasColumnName("price");

                entity.Property(e => e.Xid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("xid");

                entity.Property(e => e.Year)
                    .HasColumnType("date")
                    .HasColumnName("year");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
