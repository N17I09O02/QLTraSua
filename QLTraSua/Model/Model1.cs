using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTraSua.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Ban> Ban { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<Mon> Mon { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tang> Tang { get; set; }
        public virtual DbSet<TKDangNhap> TKDangNhap { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .HasMany(e => e.HoaDon)
                .WithRequired(e => e.Ban)
                .HasForeignKey(e => e.MaBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DanhMuc>()
                .HasMany(e => e.Mon)
                .WithRequired(e => e.DanhMuc)
                .HasForeignKey(e => e.MaDanhMuc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDon)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.MaHoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mon>()
                .Property(e => e.Gia)
                .HasPrecision(8, 0);

            modelBuilder.Entity<Mon>()
                .HasMany(e => e.ChiTietHoaDon)
                .WithRequired(e => e.Mon)
                .HasForeignKey(e => e.MaMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tang>()
                .HasMany(e => e.Ban)
                .WithRequired(e => e.Tang)
                .HasForeignKey(e => e.MaTang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TKDangNhap>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TKDangNhap>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TKDangNhap>()
                .Property(e => e.ChucVu)
                .IsUnicode(false);
        }
    }
}
