using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QUANLYKHACHSAN
{
    public partial class frmKhachhangthanthiet : UserControl
    {
        public frmKhachhangthanthiet()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            var constr  = ConfigurationManager.ConnectionStrings["QLKS_DB"].ConnectionString;

            var cmdText = "select KH.MaKhachHang, KH.TenKhachHang, KH.DienThoai, COUNT(KH.MaKhachHang) as SoLuotDen, case when COUNT(KH.MaKhachHang) >= 8 then N'Kim cương' when COUNT(KH.MaKhachHang) >= 3 then N'Vàng' else N'Bạc' end as LoaiHoiVien, SUM(HD.TongTien) as TongHoaDon from KHACH_HANG KH, PHIEU_THUE_PHONG PTP, HOA_DON HD where KH.MaKhachHang = PTP.MaKhachHang And HD.MaThuePhong = PTP.MaThuePhong group by KH.MaKhachHang, KH.TenKhachHang, KH.DienThoai having COUNT(KH.MaKhachHang) >= 3";

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds, "Data");
            gridControlKhachhangthanthiet.DataSource = ds.Tables["Data"];
        }
    }
}
