using DevExpress.Mvvm.DataModel;
using QUANLYKHACHSAN.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QUANLYKHACHSAN.QLKS_DBDataModel {

    /// <summary>
    /// IQLKS_DBUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IQLKS_DBUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The CHI_TIET_HOA_DON entities repository.
        /// </summary>
		IRepository<CHI_TIET_HOA_DON, Tuple<string, string, string>> CHI_TIET_HOA_DON { get; }
        
        /// <summary>
        /// The HOA_DON entities repository.
        /// </summary>
		IRepository<HOA_DON, string> HOA_DON { get; }
        
        /// <summary>
        /// The NHAN_VIEN entities repository.
        /// </summary>
		IRepository<NHAN_VIEN, string> NHAN_VIEN { get; }
        
        /// <summary>
        /// The CHUC_VU entities repository.
        /// </summary>
		IRepository<CHUC_VU, string> CHUC_VU { get; }
        
        /// <summary>
        /// The NGUOI_DUNG entities repository.
        /// </summary>
		IRepository<NGUOI_DUNG, string> NGUOI_DUNG { get; }
        
        /// <summary>
        /// The PHIEU_SUA_CHUA entities repository.
        /// </summary>
		IRepository<PHIEU_SUA_CHUA, string> PHIEU_SUA_CHUA { get; }
        
        /// <summary>
        /// The CHI_TIET_PHIEU_SUA_CHUA entities repository.
        /// </summary>
		IRepository<CHI_TIET_PHIEU_SUA_CHUA, Tuple<string, string>> CHI_TIET_PHIEU_SUA_CHUA { get; }
        
        /// <summary>
        /// The PHONG entities repository.
        /// </summary>
		IRepository<PHONG, string> PHONG { get; }
        
        /// <summary>
        /// The CHI_TIET_PHIEU_THUE_PHONG entities repository.
        /// </summary>
		IRepository<CHI_TIET_PHIEU_THUE_PHONG, Tuple<string, string, string>> CHI_TIET_PHIEU_THUE_PHONG { get; }
        
        /// <summary>
        /// The PHIEU_THUE_PHONG entities repository.
        /// </summary>
		IRepository<PHIEU_THUE_PHONG, string> PHIEU_THUE_PHONG { get; }
        
        /// <summary>
        /// The DANH_SACH_SU_DUNG_DICH_VU entities repository.
        /// </summary>
		IRepository<DANH_SACH_SU_DUNG_DICH_VU, Tuple<string, string>> DANH_SACH_SU_DUNG_DICH_VU { get; }
        
        /// <summary>
        /// The DICH_VU entities repository.
        /// </summary>
		IRepository<DICH_VU, string> DICH_VU { get; }
        
        /// <summary>
        /// The KHACH_HANG entities repository.
        /// </summary>
		IRepository<KHACH_HANG, string> KHACH_HANG { get; }
        
        /// <summary>
        /// The LOAI_PHONG entities repository.
        /// </summary>
		IRepository<LOAI_PHONG, string> LOAI_PHONG { get; }
        
        /// <summary>
        /// The LOAI_TINH_TRANG entities repository.
        /// </summary>
		IRepository<LOAI_TINH_TRANG, string> LOAI_TINH_TRANG { get; }
        
        /// <summary>
        /// The SO_HUU_THIET_BI entities repository.
        /// </summary>
		IRepository<SO_HUU_THIET_BI, Tuple<string, string>> SO_HUU_THIET_BI { get; }
        
        /// <summary>
        /// The THIET_BI entities repository.
        /// </summary>
		IRepository<THIET_BI, string> THIET_BI { get; }
        
        /// <summary>
        /// The LOAI_THANH_TOAN entities repository.
        /// </summary>
		IRepository<LOAI_THANH_TOAN, string> LOAI_THANH_TOAN { get; }
    }
}
