namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_HOA_DON
    {
        [Key]
        [StringLength(5)]
        public string MaHoaDon { get; set; }

        [Required]
        [StringLength(5)]
        public string MaThuePhong { get; set; }

        public long? TienPhong { get; set; }

        public long? TienDichVu { get; set; }

        public int? SoNgay { get; set; }

        public long? ThanhTien { get; set; }

        public virtual HOA_DON HOA_DON { get; set; }
    }
}
