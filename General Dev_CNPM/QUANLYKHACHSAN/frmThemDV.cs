using QUANLYKHACHSAN.Model;
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
    public partial class frmThemDV : Form
    {
        QLKS_DB context = new QLKS_DB();
        string maPhieuThue;
        public frmThemDV(string ma)
        {
            InitializeComponent();
            maPhieuThue = ma;
        }

        // Load grid control
        public void loadData()
        {

            var ds = context.DANH_SACH_SU_DUNG_DICH_VU.Where(p=>p.MaThuePhong == maPhieuThue).Select(
                p => new
                {
                    TenDichVu = p.DICH_VU.TenDichVu,
                    DonViTinh = p.DICH_VU.DonViTinh,
                    SoLuong = p.SoLuong,
                    DonGia = context.DICH_VU.FirstOrDefault(v => v.MaDichVu == p.MaDichVu).DonGia
                }
            ).ToList();
            gridControlDichvu.DataSource = ds;
            //Load tong tien
            Double tong = 0;
            foreach(var item in ds)
            {
                tong += Double.Parse(item.DonGia.ToString()) * Double.Parse(item.SoLuong.ToString());
            }
            txtTongcong.Text = tong.ToString("c0");
            loadCbo();
        }

        //Load Combo Box
        public void loadCbo()
        {
            cboTenDV.DataSource = context.DICH_VU.ToList();
            cboTenDV.DisplayMember = "TenDichVu";
            cboTenDV.ValueMember = "MaDichVu";
        }

        private void icoBtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string tenDV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            string soLuong = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            cboTenDV.Text = tenDV;
            txtSoLuong.Text = soLuong;
        }

        private void frmThemDV_Load(object sender, EventArgs e)
        {
            loadData();
            label2.Text += maPhieuThue;
        }

        private void icoBtnThem_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text == "" || txtSoLuong.Text == "0")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và số lượng > 0","Cảnh báo");
            }else
            {
                string maDV = cboTenDV.SelectedValue.ToString();
                DANH_SACH_SU_DUNG_DICH_VU ds = context.DANH_SACH_SU_DUNG_DICH_VU.FirstOrDefault(p => p.MaThuePhong == maPhieuThue && p.MaDichVu == maDV);
                if (ds == null)
                {
                    //Them moi
                    DANH_SACH_SU_DUNG_DICH_VU newDS = new DANH_SACH_SU_DUNG_DICH_VU()
                    {
                        MaThuePhong = maPhieuThue,
                        MaDichVu = cboTenDV.SelectedValue.ToString(),
                        SoLuong = int.Parse(txtSoLuong.Text)
                    };
                    context.DANH_SACH_SU_DUNG_DICH_VU.Add(newDS);
                    context.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông tin");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông tin");
                    ds.SoLuong += int.Parse(txtSoLuong.Text);
                    context.SaveChanges();
                    loadData();
                }
            }
        }

        private void icoBtnSua_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "" || txtSoLuong.Text == "0")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và số lượng > 0", "Cảnh báo");
            }
            else
            {
                string maDV = cboTenDV.SelectedValue.ToString();
                DANH_SACH_SU_DUNG_DICH_VU ds = context.DANH_SACH_SU_DUNG_DICH_VU.FirstOrDefault(p => p.MaThuePhong == maPhieuThue && p.MaDichVu == maDV);
                if (ds == null)
                {
                    if(MessageBox.Show("Dịch vụ này chưa có bạn muốn thêm mới không ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Them moi
                        DANH_SACH_SU_DUNG_DICH_VU newDS = new DANH_SACH_SU_DUNG_DICH_VU()
                        {
                            MaThuePhong = maPhieuThue,
                            MaDichVu = cboTenDV.SelectedValue.ToString(),
                            SoLuong = int.Parse(txtSoLuong.Text)
                        };
                        context.DANH_SACH_SU_DUNG_DICH_VU.Add(newDS);
                        context.SaveChanges();
                        MessageBox.Show("Thêm thành công", "Thông tin");
                        loadData();
                    }
                }
                else
                {
                    ds.SoLuong = int.Parse(txtSoLuong.Text);
                    context.SaveChanges();
                    loadData();
                    MessageBox.Show("Sửa thành công", "Thông tin");
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
