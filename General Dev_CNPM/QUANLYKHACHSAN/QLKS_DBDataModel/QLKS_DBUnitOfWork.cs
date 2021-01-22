using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using QUANLYKHACHSAN.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QUANLYKHACHSAN.QLKS_DBDataModel {

    /// <summary>
    /// A QLKS_DBUnitOfWork instance that represents the run-time implementation of the IQLKS_DBUnitOfWork interface.
    /// </summary>
    public class QLKS_DBUnitOfWork : DbUnitOfWork<QLKS_DB>, IQLKS_DBUnitOfWork {

        public QLKS_DBUnitOfWork(Func<QLKS_DB> contextFactory)
            : base(contextFactory) {
        }

        IRepository<CHI_TIET_HOA_DON, Tuple<string, string, string>> IQLKS_DBUnitOfWork.CHI_TIET_HOA_DON {
            get { return GetRepository(x => x.Set<CHI_TIET_HOA_DON>(), (CHI_TIET_HOA_DON x) => Tuple.Create(x.MaHoaDon, x.MaThuePhong, x.MaThanhToan)); }
        }

        IRepository<HOA_DON, string> IQLKS_DBUnitOfWork.HOA_DON {
            get { return GetRepository(x => x.Set<HOA_DON>(), (HOA_DON x) => x.MaHoaDon); }
        }

        IRepository<NHAN_VIEN, string> IQLKS_DBUnitOfWork.NHAN_VIEN {
            get { return GetRepository(x => x.Set<NHAN_VIEN>(), (NHAN_VIEN x) => x.MaNhanVien); }
        }

        IRepository<CHUC_VU, string> IQLKS_DBUnitOfWork.CHUC_VU {
            get { return GetRepository(x => x.Set<CHUC_VU>(), (CHUC_VU x) => x.MaChucVu); }
        }

        IRepository<NGUOI_DUNG, string> IQLKS_DBUnitOfWork.NGUOI_DUNG {
            get { return GetRepository(x => x.Set<NGUOI_DUNG>(), (NGUOI_DUNG x) => x.TenDangNhap); }
        }

        IRepository<PHIEU_SUA_CHUA, string> IQLKS_DBUnitOfWork.PHIEU_SUA_CHUA {
            get { return GetRepository(x => x.Set<PHIEU_SUA_CHUA>(), (PHIEU_SUA_CHUA x) => x.MaPhieuSua); }
        }

        IRepository<CHI_TIET_PHIEU_SUA_CHUA, Tuple<string, string>> IQLKS_DBUnitOfWork.CHI_TIET_PHIEU_SUA_CHUA {
            get { return GetRepository(x => x.Set<CHI_TIET_PHIEU_SUA_CHUA>(), (CHI_TIET_PHIEU_SUA_CHUA x) => Tuple.Create(x.MaPhieuSua, x.MaPhong)); }
        }

        IRepository<PHONG, string> IQLKS_DBUnitOfWork.PHONG {
            get { return GetRepository(x => x.Set<PHONG>(), (PHONG x) => x.MaPhong); }
        }

        IRepository<CHI_TIET_PHIEU_THUE_PHONG, Tuple<string, string, string>> IQLKS_DBUnitOfWork.CHI_TIET_PHIEU_THUE_PHONG {
            get { return GetRepository(x => x.Set<CHI_TIET_PHIEU_THUE_PHONG>(), (CHI_TIET_PHIEU_THUE_PHONG x) => Tuple.Create(x.MaThuePhong, x.MaPhong, x.MaKhachHang)); }
        }

        IRepository<PHIEU_THUE_PHONG, string> IQLKS_DBUnitOfWork.PHIEU_THUE_PHONG {
            get { return GetRepository(x => x.Set<PHIEU_THUE_PHONG>(), (PHIEU_THUE_PHONG x) => x.MaThuePhong); }
        }

        IRepository<DANH_SACH_SU_DUNG_DICH_VU, Tuple<string, string>> IQLKS_DBUnitOfWork.DANH_SACH_SU_DUNG_DICH_VU {
            get { return GetRepository(x => x.Set<DANH_SACH_SU_DUNG_DICH_VU>(), (DANH_SACH_SU_DUNG_DICH_VU x) => Tuple.Create(x.MaThuePhong, x.MaDichVu)); }
        }

        IRepository<DICH_VU, string> IQLKS_DBUnitOfWork.DICH_VU {
            get { return GetRepository(x => x.Set<DICH_VU>(), (DICH_VU x) => x.MaDichVu); }
        }

        IRepository<KHACH_HANG, string> IQLKS_DBUnitOfWork.KHACH_HANG {
            get { return GetRepository(x => x.Set<KHACH_HANG>(), (KHACH_HANG x) => x.MaKhachHang); }
        }

        IRepository<LOAI_PHONG, string> IQLKS_DBUnitOfWork.LOAI_PHONG {
            get { return GetRepository(x => x.Set<LOAI_PHONG>(), (LOAI_PHONG x) => x.MaLoaiPhong); }
        }

        IRepository<LOAI_TINH_TRANG, string> IQLKS_DBUnitOfWork.LOAI_TINH_TRANG {
            get { return GetRepository(x => x.Set<LOAI_TINH_TRANG>(), (LOAI_TINH_TRANG x) => x.MaLoaiTinhTrangPhong); }
        }

        IRepository<SO_HUU_THIET_BI, Tuple<string, string>> IQLKS_DBUnitOfWork.SO_HUU_THIET_BI {
            get { return GetRepository(x => x.Set<SO_HUU_THIET_BI>(), (SO_HUU_THIET_BI x) => Tuple.Create(x.MaPhong, x.MaThietBi)); }
        }

        IRepository<THIET_BI, string> IQLKS_DBUnitOfWork.THIET_BI {
            get { return GetRepository(x => x.Set<THIET_BI>(), (THIET_BI x) => x.MaThietBi); }
        }

        IRepository<LOAI_THANH_TOAN, string> IQLKS_DBUnitOfWork.LOAI_THANH_TOAN {
            get { return GetRepository(x => x.Set<LOAI_THANH_TOAN>(), (LOAI_THANH_TOAN x) => x.MaThanhToan); }
        }
    }
}
