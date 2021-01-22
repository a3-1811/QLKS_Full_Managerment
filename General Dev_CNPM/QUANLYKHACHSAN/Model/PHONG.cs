namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            CHI_TIET_PHIEU_THUE_PHONG = new HashSet<CHI_TIET_PHIEU_THUE_PHONG>();
            PHIEU_SUA_CHUA = new HashSet<PHIEU_SUA_CHUA>();
            SO_HUU_THIET_BI = new HashSet<SO_HUU_THIET_BI>();
        }

        [Key]
        [StringLength(5)]
        public string MaPhong { get; set; }

        [StringLength(5)]
        public string MaLoaiPhong { get; set; }

        [StringLength(5)]
        public string MaLoaiTinhTrangPhong { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHIEU_THUE_PHONG> CHI_TIET_PHIEU_THUE_PHONG { get; set; }

        public virtual LOAI_PHONG LOAI_PHONG { get; set; }

        public virtual LOAI_TINH_TRANG LOAI_TINH_TRANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_SUA_CHUA> PHIEU_SUA_CHUA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SO_HUU_THIET_BI> SO_HUU_THIET_BI { get; set; }
    }
}
