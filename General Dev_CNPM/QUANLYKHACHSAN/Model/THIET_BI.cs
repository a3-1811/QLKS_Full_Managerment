namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class THIET_BI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THIET_BI()
        {
            CHI_TIET_PHIEU_SUA_CHUA = new HashSet<CHI_TIET_PHIEU_SUA_CHUA>();
            SO_HUU_THIET_BI = new HashSet<SO_HUU_THIET_BI>();
        }

        [Key]
        [StringLength(5)]
        public string MaThietBi { get; set; }

        [StringLength(50)]
        public string TenThietBi { get; set; }

        public int? SoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHIEU_SUA_CHUA> CHI_TIET_PHIEU_SUA_CHUA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SO_HUU_THIET_BI> SO_HUU_THIET_BI { get; set; }
    }
}
