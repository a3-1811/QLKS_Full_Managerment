namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_THUE_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_THUE_PHONG()
        {
            CHI_TIET_PHIEU_THUE_PHONG = new HashSet<CHI_TIET_PHIEU_THUE_PHONG>();
            DANH_SACH_SU_DUNG_DICH_VU = new HashSet<DANH_SACH_SU_DUNG_DICH_VU>();
            HOA_DON = new HashSet<HOA_DON>();
        }

        [Key]
        [StringLength(5)]
        public string MaThuePhong { get; set; }

        [StringLength(5)]
        public string MaNhanVien { get; set; }

        [StringLength(5)]
        public string MaKhachHang { get; set; }

        public DateTime? NgayLap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHIEU_THUE_PHONG> CHI_TIET_PHIEU_THUE_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_SACH_SU_DUNG_DICH_VU> DANH_SACH_SU_DUNG_DICH_VU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }

        public virtual KHACH_HANG KHACH_HANG { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
