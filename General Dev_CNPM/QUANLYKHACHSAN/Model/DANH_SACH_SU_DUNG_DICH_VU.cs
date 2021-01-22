namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_SACH_SU_DUNG_DICH_VU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaThuePhong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaDichVu { get; set; }

        public int? SoLuong { get; set; }

        public virtual DICH_VU DICH_VU { get; set; }

        public virtual PHIEU_THUE_PHONG PHIEU_THUE_PHONG { get; set; }
    }
}
