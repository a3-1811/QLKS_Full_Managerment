using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYKHACHSAN.Properties;

namespace QUANLYKHACHSAN
{
    public partial class frmNoiquykhachsan : UserControl
    {
        public frmNoiquykhachsan()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            try
            {
                pdfViewer1.NavigationPaneVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
                pdfViewer1.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
                pdfViewer1.Enabled = true;
                pdfViewer1.ReadOnly = true;
                pdfViewer1.LoadDocument(@"..\..\noiquy.pdf");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
