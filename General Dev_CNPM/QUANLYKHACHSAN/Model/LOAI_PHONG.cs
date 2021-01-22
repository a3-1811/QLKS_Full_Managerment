namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAI_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_PHONG()
        {
            PHONG = new HashSet<PHONG>();
        }

        [Key]
        [StringLength(5)]
        public string MaLoaiPhong { get; set; }

        [StringLength(50)]
        public string TenLoaiPhong { get; set; }

        public int? SoNguoiLonToiDa { get; set; }

        public int? SoTreEmToiDa { get; set; }

        public int? SoNguoiToiDa { get; set; }

        public int? TongSoPhong { get; set; }

        public string MoTa { get; set; }

        public double? DonGia { get; set; }

        public int? Tang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONG { get; set; }
    }
}
