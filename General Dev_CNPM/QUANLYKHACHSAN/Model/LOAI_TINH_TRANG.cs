namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAI_TINH_TRANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_TINH_TRANG()
        {
            PHONG = new HashSet<PHONG>();
        }

        [Key]
        [StringLength(5)]
        public string MaLoaiTinhTrangPhong { get; set; }

        [StringLength(50)]
        public string TenLoaiTinhTrangPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONG { get; set; }
    }
}
