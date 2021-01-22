using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYKHACHSAN.Model;

namespace QUANLYKHACHSAN
{
    public partial class frmKhachhang : UserControl
    {
        QLKS_DB context = new QLKS_DB();
        string maKhGlobal = "";
        public frmKhachhang()
        {
            InitializeComponent();
        }
        // Load grid control
        public void loadData()
        {
            gridControlKhachhang.DataSource = context.KHACH_HANG.ToList();
            cboGioitinh.DataSource = context.KHACH_HANG.Select(p => p.GioiTinh).Distinct().ToList();
            clearTXT();
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string maKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            KHACH_HANG nv = context.KHACH_HANG.FirstOrDefault(p => p.MaKhachHang.ToLower().Trim() == maKH.ToLower().Trim());
            if (nv != null)
            {
                maKhGlobal = maKH;
                txtHoten.Text = nv.TenKhachHang;
                txtDiachi.Text = nv.DiaChi;
                txtCMND.Text = nv.CMND;
                cboGioitinh.Text = nv.GioiTinh;
                dateTimePicker1.Text = nv.NgaySinh.ToString();
                txtSDT.Text = nv.DienThoai;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (txtCMND.Text.Length > 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (txtSDT.Text.Length > 9)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        //Lay nhan vien cuoi
        public KHACH_HANG getLastStaff()
        {
            KHACH_HANG nv = null;
            List<KHACH_HANG> list = context.KHACH_HANG.ToList();
            foreach (var temp in list)
            {
                nv = temp;
            }
            return nv;
        }

        //Chuyen so thanh ma  "KH030" -> "KH031"
        public string convertNumbtoID(string n)
        {
            int numb = int.Parse(n);
            numb++;
            if (numb.ToString().Length == 3)
            {
                return "KH" + numb.ToString();
            }
            else if (numb.ToString().Length == 2)
            {
                return "KH0" + numb.ToString();
            }
            return "KH00" + numb.ToString();
        }

        //Clear text box

        public void clearTXT()
        {
            txtHoten.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
            txtCMND.Clear();

            txtHoten.Focus();
        }
        private void icoBtnThem_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "" || txtDiachi.Text == "" || txtSDT.Text == "" || txtCMND.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtSDT.Text.Substring(0, 1) != "0")
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng! (0xxx)");
                }
                else
                {
                    // Lay nhan vien cuoi
                    KHACH_HANG nv = getLastStaff();

                    KHACH_HANG isExits = context.KHACH_HANG.FirstOrDefault(p=>p.CMND == txtCMND.Text );

                    if (isExits == null)
                    {
                        if (txtCMND.Text.Length == 9)
                        {
                            if (nv == null)
                            {
                                KHACH_HANG newNV = new KHACH_HANG() { MaKhachHang = "NV001", TenKhachHang = txtHoten.Text.Trim(), CMND = txtCMND.Text, GioiTinh = cboGioitinh.Text, DiaChi = txtDiachi.Text, NgaySinh = DateTime.Parse(dateTimePicker1.Text), DienThoai = txtSDT.Text };

                                context.KHACH_HANG.Add(newNV);
                                context.SaveChanges();
                                MessageBox.Show(" Thêm thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadData();
                            }
                            else
                            {
                                string sttCuoi = nv.MaKhachHang.Replace("KH", "").ToString();
                                string maMoi = convertNumbtoID(sttCuoi);

                                KHACH_HANG newNV = new KHACH_HANG() { MaKhachHang = maMoi, TenKhachHang = txtHoten.Text.Trim(), CMND = txtCMND.Text, GioiTinh = cboGioitinh.Text, DiaChi = txtDiachi.Text, NgaySinh = DateTime.Parse(dateTimePicker1.Text), DienThoai = txtSDT.Text };

                                context.KHACH_HANG.Add(newNV);
                                context.SaveChanges();
                                MessageBox.Show(" Thêm thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadData();
                            }
                        }else
                        {
                            MessageBox.Show(" CMND phải đủ 9 số!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" CMND đã tồn tại!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void icoBtnSua_Click(object sender, EventArgs e)
        {
            if (maKhGlobal == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtHoten.Text == "" || txtDiachi.Text == "" || txtSDT.Text == "" || txtCMND.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtSDT.Text.Substring(0, 1) != "0")
                    {
                        MessageBox.Show("Số điện thoại không đúng định dạng! (0xxx)");
                    }
                    else
                    {
                        KHACH_HANG nv = context.KHACH_HANG.FirstOrDefault(p => p.MaKhachHang.Equals(maKhGlobal));
                        nv.TenKhachHang = txtHoten.Text.Trim();
                        nv.NgaySinh = DateTime.Parse(dateTimePicker1.Text);
                        nv.DienThoai = txtSDT.Text;
                        nv.GioiTinh = cboGioitinh.Text;
                        nv.CMND = txtCMND.Text;
                        nv.DiaChi = txtDiachi.Text;

                        context.SaveChanges();
                        MessageBox.Show(" Sửa thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
            }
        }

        public void xoaTTLienQUan(string maKH)
        {
            foreach(var item in context.PHIEU_THUE_PHONG.ToList())
            {
                if (item.MaKhachHang == maKH)
                {
                    foreach (var hoadon in context.HOA_DON.ToList())
                    {
                        if(hoadon.MaThuePhong == item.MaThuePhong)
                        {
                            context.HOA_DON.Remove(hoadon);
                            context.SaveChanges();
                        }
                    }
                    context.PHIEU_THUE_PHONG.Remove(item);
                    context.SaveChanges();
                }
            }
        }


        private void icoBtnXoa_Click(object sender, EventArgs e)
        {
            if (maKhGlobal == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    KHACH_HANG nv = context.KHACH_HANG.FirstOrDefault(p => p.MaKhachHang == maKhGlobal);
                    xoaTTLienQUan(nv.MaKhachHang);
                   context.KHACH_HANG.Remove(nv);
                    context.SaveChanges();
                    MessageBox.Show(" Xóa thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
        }

        private void txtHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void icoBtnXuatkhachhang_Click(object sender, EventArgs e)
        {
            FormReport.ReportKhachHang Frm = new FormReport.ReportKhachHang();
            Frm.DataSource = context.KHACH_HANG.ToList();
            frmReportViewer Rpv = new frmReportViewer(Frm);
            Rpv.ShowDialog();
        }
    }
}
