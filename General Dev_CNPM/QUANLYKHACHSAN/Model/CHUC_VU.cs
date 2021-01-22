namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHUC_VU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUC_VU()
        {
            NGUOI_DUNG = new HashSet<NGUOI_DUNG>();
            NHAN_VIEN = new HashSet<NHAN_VIEN>();
        }

        [Key]
        [StringLength(5)]
        public string MaChucVu { get; set; }

        [StringLength(30)]
        public string TenChucVu { get; set; }

        public double? HeSoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOI_DUNG> NGUOI_DUNG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAN_VIEN> NHAN_VIEN { get; set; }
    }
}
