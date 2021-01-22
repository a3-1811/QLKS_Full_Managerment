namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAN_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAN_VIEN()
        {
            HOA_DON = new HashSet<HOA_DON>();
            PHIEU_THUE_PHONG = new HashSet<PHIEU_THUE_PHONG>();
            PHIEU_SUA_CHUA = new HashSet<PHIEU_SUA_CHUA>();
        }

        [Key]
        [StringLength(5)]
        public string MaNhanVien { get; set; }

        [StringLength(5)]
        public string MaChucVu { get; set; }

        [StringLength(30)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(3)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(10)]
        public string SoDienThoai { get; set; }

        [StringLength(30)]
        public string ChucVu { get; set; }

        public virtual CHUC_VU CHUC_VU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_THUE_PHONG> PHIEU_THUE_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_SUA_CHUA> PHIEU_SUA_CHUA { get; set; }
    }
}
