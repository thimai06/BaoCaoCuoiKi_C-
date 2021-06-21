using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ModelEF.Model
{
    public partial class NguyenThiMaiContext : DbContext
    {
        public NguyenThiMaiContext()
            : base("name=NguyenThiMaiContext")
        {
        }

        public virtual DbSet<LoaiSP> LoaiSPs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoanNguoiDung> TaiKhoanNguoiDungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSP>()
                .Property(e => e.IDLSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSP>()
                .HasMany(e => e.SanPhams)
                .WithOptional(e => e.LoaiSP)
                .HasForeignKey(e => e.LoaiSP_ID);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.IDSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.LoaiSP_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Trangthai)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNguoiDung>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNguoiDung>()
                .Property(e => e.Ten)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNguoiDung>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNguoiDung>()
                .Property(e => e.Trangthai)
                .IsUnicode(false);
        }
    }
}
