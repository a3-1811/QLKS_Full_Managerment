namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_PHIEU_SUA_CHUA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaPhieuSua { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaThietBi { get; set; }

        public long? PhiSuaChua { get; set; }

        public virtual THIET_BI THIET_BI { get; set; }

        public virtual PHIEU_SUA_CHUA PHIEU_SUA_CHUA { get; set; }
    }
}
