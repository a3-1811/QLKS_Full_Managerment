namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON
    {
        [Key]
        [StringLength(5)]
        public string MaHoaDon { get; set; }

        [Required]
        [StringLength(5)]
        public string MaThuePhong { get; set; }

        [StringLength(5)]
        public string MaNhanVien { get; set; }

        public long? TongTien { get; set; }

        public DateTime? NgayLap { get; set; }

        public virtual CHI_TIET_HOA_DON CHI_TIET_HOA_DON { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }

        public virtual PHIEU_THUE_PHONG PHIEU_THUE_PHONG { get; set; }
    }
}
