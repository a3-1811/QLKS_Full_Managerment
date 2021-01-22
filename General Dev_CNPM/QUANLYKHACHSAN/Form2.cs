using QUANLYKHACHSAN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class Form2 : Form
    {
        QLKS_DB context = new QLKS_DB();
        public Form2()
        {
            InitializeComponent();
            FormReport.ReportThietBi nv = new FormReport.ReportThietBi();


            nv.DataSource = context.THIET_BI.ToList();
            nv.CreateDocument();
            documentViewer1.DocumentSource = nv;
            documentViewer1.Refresh();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
