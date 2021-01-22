namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DICH_VU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICH_VU()
        {
            DANH_SACH_SU_DUNG_DICH_VU = new HashSet<DANH_SACH_SU_DUNG_DICH_VU>();
        }

        [Key]
        [StringLength(5)]
        public string MaDichVu { get; set; }

        [StringLength(50)]
        public string TenDichVu { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        public double? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_SACH_SU_DUNG_DICH_VU> DANH_SACH_SU_DUNG_DICH_VU { get; set; }
    }
}
