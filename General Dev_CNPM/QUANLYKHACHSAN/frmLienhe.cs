using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QUANLYKHACHSAN.Model;


namespace QUANLYKHACHSAN
{
    public partial class frmLienhe : DevExpress.XtraEditors.XtraUserControl
    {
        public frmLienhe()
        {
            InitializeComponent();
            loadData();
        }
        QLKS_DB context = new QLKS_DB();
        
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
            loadData();
        }
        private void loadData()
        {
            var list = context.NHAN_VIEN.Select(p => new { HoTen = p.HoTen, ChucVu = p.ChucVu, SoDienThoai = p.SoDienThoai }).ToList();
            gridControl1.DataSource = list;
        }
    }
}
