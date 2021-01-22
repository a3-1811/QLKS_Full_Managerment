namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLKS_DB : DbContext
    {
        public QLKS_DB()
            : base("name=QLKS_DB")
        {
        }

        public virtual DbSet<CHI_TIET_HOA_DON> CHI_TIET_HOA_DON { get; set; }
        public virtual DbSet<CHI_TIET_PHIEU_SUA_CHUA> CHI_TIET_PHIEU_SUA_CHUA { get; set; }
        public virtual DbSet<CHI_TIET_PHIEU_THUE_PHONG> CHI_TIET_PHIEU_THUE_PHONG { get; set; }
        public virtual DbSet<CHUC_VU> CHUC_VU { get; set; }
        public virtual DbSet<DANH_SACH_SU_DUNG_DICH_VU> DANH_SACH_SU_DUNG_DICH_VU { get; set; }
        public virtual DbSet<DICH_VU> DICH_VU { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<LOAI_PHONG> LOAI_PHONG { get; set; }
        public virtual DbSet<LOAI_TINH_TRANG> LOAI_TINH_TRANG { get; set; }
        public virtual DbSet<NGUOI_DUNG> NGUOI_DUNG { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<PHIEU_SUA_CHUA> PHIEU_SUA_CHUA { get; set; }
        public virtual DbSet<PHIEU_THUE_PHONG> PHIEU_THUE_PHONG { get; set; }
        public virtual DbSet<PHONG> PHONG { get; set; }
        public virtual DbSet<SO_HUU_THIET_BI> SO_HUU_THIET_BI { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<THIET_BI> THIET_BI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHI_TIET_HOA_DON>()
                .Property(e => e.MaHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_HOA_DON>()
                .Property(e => e.MaThuePhong)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_SUA_CHUA>()
                .Property(e => e.MaPhieuSua)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_SUA_CHUA>()
                .Property(e => e.MaThietBi)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_THUE_PHONG>()
                .Property(e => e.MaThuePhong)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_THUE_PHONG>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_THUE_PHONG>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<CHI_TIET_PHIEU_THUE_PHONG>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<CHUC_VU>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<CHUC_VU>()
                .HasMany(e => e.NGUOI_DUNG)
                .WithOptional(e => e.CHUC_VU)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CHUC_VU>()
                .HasMany(e => e.NHAN_VIEN)
                .WithOptional(e => e.CHUC_VU)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DANH_SACH_SU_DUNG_DICH_VU>()
                .Property(e => e.MaThuePhong)
                .IsUnicode(false);

            modelBuilder.Entity<DANH_SACH_SU_DUNG_DICH_VU>()
                .Property(e => e.MaDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<DICH_VU>()
                .Property(e => e.MaDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MaHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MaThuePhong)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .HasOptional(e => e.CHI_TIET_HOA_DON)
                .WithRequired(e => e.HOA_DON)
                .WillCascadeOnDelete();

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .HasMany(e => e.PHIEU_THUE_PHONG)
                .WithOptional(e => e.KHACH_HANG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LOAI_PHONG>()
                .Property(e => e.MaLoaiPhong)
                .IsUnicode(false);

            modelBuilder.Entity<LOAI_PHONG>()
                .HasMany(e => e.PHONG)
                .WithOptional(e => e.LOAI_PHONG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LOAI_TINH_TRANG>()
                .Property(e => e.MaLoaiTinhTrangPhong)
                .IsUnicode(false);

            modelBuilder.Entity<LOAI_TINH_TRANG>()
                .HasMany(e => e.PHONG)
                .WithOptional(e => e.LOAI_TINH_TRANG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NGUOI_DUNG>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.HOA_DON)
                .WithOptional(e => e.NHAN_VIEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.PHIEU_THUE_PHONG)
                .WithOptional(e => e.NHAN_VIEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NHAN_VIEN>()
                .HasMany(e => e.PHIEU_SUA_CHUA)
                .WithOptional(e => e.NHAN_VIEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PHIEU_SUA_CHUA>()
                .Property(e => e.MaPhieuSua)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_SUA_CHUA>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_SUA_CHUA>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_THUE_PHONG>()
                .Property(e => e.MaThuePhong)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_THUE_PHONG>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_THUE_PHONG>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEU_THUE_PHONG>()
                .HasMany(e => e.HOA_DON)
                .WithRequired(e => e.PHIEU_THUE_PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MaLoaiPhong)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MaLoaiTinhTrangPhong)
                .IsUnicode(false);

            modelBuilder.Entity<SO_HUU_THIET_BI>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<SO_HUU_THIET_BI>()
                .Property(e => e.MaThietBi)
                .IsUnicode(false);

            modelBuilder.Entity<THIET_BI>()
                .Property(e => e.MaThietBi)
                .IsUnicode(false);

            modelBuilder.Entity<THIET_BI>()
                .HasMany(e => e.CHI_TIET_PHIEU_SUA_CHUA)
                .WithRequired(e => e.THIET_BI)
                .WillCascadeOnDelete(false);
        }
    }
}
