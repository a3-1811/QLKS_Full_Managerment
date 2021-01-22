using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class frmReportViewer : Form
    {
        FormReport.ReportDichVu FormDV;
        FormReport.ReportKhachHang FormKH;
        FormReport.ReportNhanVien FormNV;
        FormReport.ReportPhieuSuaChua FormPSC;
        FormReport.ReportPhieuThue FormPT;
        FormReport.ReportThietBi FormTB;
        FormReport.ReportDoanhThu FormDT;
        public frmReportViewer()
        {
            InitializeComponent();
        }
        public frmReportViewer(FormReport.ReportDichVu frm)
        {
            InitializeComponent();
            FormDV = frm;
            load();
        }
        public frmReportViewer(FormReport.ReportKhachHang frm)
        {
            InitializeComponent();
            FormKH = frm;
            load();
        }
        public frmReportViewer(FormReport.ReportNhanVien frm)
        {
            InitializeComponent();
            FormNV = frm;
            load();
        }
        public frmReportViewer(FormReport.ReportPhieuSuaChua frm)
        {
            InitializeComponent();
            FormPSC = frm;
            load();
        }
        public frmReportViewer(FormReport.ReportPhieuThue frm)
        {
            InitializeComponent();
            FormPT = frm;
            load();
        }
        public frmReportViewer(FormReport.ReportThietBi frm)
        {
            InitializeComponent();
            FormTB = frm;
            load();
        }
        public frmReportViewer(FormReport.ReportDoanhThu frm)
        {
            InitializeComponent();
            FormDT = frm;
            load();
        }
        public void load()
        {
            if(FormDV!=null)
            {
                FormDV.CreateDocument();
                documentViewer1.DocumentSource = FormDV;
                documentViewer1.Refresh();
            }else if (FormKH != null)
            {
                FormKH.CreateDocument();
                documentViewer1.DocumentSource = FormKH;
                documentViewer1.Refresh();
            }else if (FormNV != null)
            {
                FormNV.CreateDocument();
                documentViewer1.DocumentSource = FormNV;
                documentViewer1.Refresh();
            }else if (FormPSC != null)
            {
                FormPSC.CreateDocument();
                documentViewer1.DocumentSource = FormPSC;
                documentViewer1.Refresh();
            }else if (FormPT != null)
            {
                FormPT.CreateDocument();
                documentViewer1.DocumentSource = FormPT;
                documentViewer1.Refresh();
            }else if (FormTB != null)
            {
                FormTB.CreateDocument();
                documentViewer1.DocumentSource = FormTB;
                documentViewer1.Refresh();
            }else if (FormDT != null)
            {
                FormDT.CreateDocument();
                documentViewer1.DocumentSource = FormDT;
                documentViewer1.Refresh();
            }
        }
    }
}
