namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SO_HUU_THIET_BI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaPhong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaThietBi { get; set; }

        public int? SoLuong { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual THIET_BI THIET_BI { get; set; }
    }
}
