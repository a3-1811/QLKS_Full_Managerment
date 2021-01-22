using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHACHSAN.ClassReport
{
    public class ReportInfo
    {
        public string ID { get; set; }
        public string pIDRoom { get; set; }
        public string pName { get; set; }
        public DateTime? pDateFrom { get; set; }
        public DateTime? pDateTo { get; set; }
        public double pTienPhong { get; set; }

    }
}
