namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_PHIEU_THUE_PHONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaThuePhong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaPhong { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string MaKhachHang { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTenKhachHang { get; set; }

        [StringLength(10)]
        public string CMND { get; set; }

        public DateTime? NgayNhan { get; set; }

        public DateTime? NgayTraDuKien { get; set; }

        public DateTime? NgayTra { get; set; }

        public virtual PHIEU_THUE_PHONG PHIEU_THUE_PHONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
