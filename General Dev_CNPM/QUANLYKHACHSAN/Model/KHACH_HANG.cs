namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHACH_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH_HANG()
        {
            PHIEU_THUE_PHONG = new HashSet<PHIEU_THUE_PHONG>();
        }

        [Key]
        [StringLength(5)]
        public string MaKhachHang { get; set; }

        [StringLength(50)]
        public string TenKhachHang { get; set; }

        [StringLength(3)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(10)]
        public string CMND { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(10)]
        public string DienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_THUE_PHONG> PHIEU_THUE_PHONG { get; set; }
    }
}
