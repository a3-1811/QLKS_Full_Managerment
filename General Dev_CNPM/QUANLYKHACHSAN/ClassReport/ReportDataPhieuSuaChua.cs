using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHACHSAN.ClassReport
{
    public class ReportDataPhieuSuaChua
    {
        public string MaPhong { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string HoTen { get; set; }
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public long PhiSuaChua { get; set; }

        public string NguyenNhan { get; set; }
        public string GhiChu { get; set; }
    }
}
