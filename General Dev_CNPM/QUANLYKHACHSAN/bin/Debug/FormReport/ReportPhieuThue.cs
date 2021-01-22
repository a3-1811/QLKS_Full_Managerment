using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QUANLYKHACHSAN.FormReport
{
    public partial class ReportPhieuThue : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportPhieuThue()
        {
            InitializeComponent();
        }
        public ReportPhieuThue(ClassReport.ReportInfo info)
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in this.Parameters)
                p.Visible = false;
            pID.Value = info.ID;
            pIDRoom.Value = info.pIDRoom;
            pName.Value = info.pName;
            pDateFrom.Value = info.pDateFrom;
            pDateTo.Value = info.pDateTo;
            pTienPhong.Value = info.pTienPhong;
        }
    }
}
