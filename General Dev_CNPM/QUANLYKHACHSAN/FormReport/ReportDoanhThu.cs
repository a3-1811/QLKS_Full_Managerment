using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QUANLYKHACHSAN.FormReport
{
    public partial class ReportDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDoanhThu()
        {
            InitializeComponent();
        }
        public ReportDoanhThu(string unit)
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in this.Parameters)
                p.Visible = false;
            pUnit.Value = unit;
        }

    }
}
