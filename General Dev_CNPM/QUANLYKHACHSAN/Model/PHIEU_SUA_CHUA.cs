namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_SUA_CHUA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_SUA_CHUA()
        {
            CHI_TIET_PHIEU_SUA_CHUA = new HashSet<CHI_TIET_PHIEU_SUA_CHUA>();
        }

        [Key]
        [StringLength(5)]
        public string MaPhieuSua { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        [StringLength(5)]
        public string MaNhanVien { get; set; }

        [StringLength(5)]
        public string MaPhong { get; set; }

        public string NguyenNhan { get; set; }

        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHIEU_SUA_CHUA> CHI_TIET_PHIEU_SUA_CHUA { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
