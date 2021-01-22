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
    public partial class frmNhanvien : UserControl
    {
        QLKS_DB context = new QLKS_DB();
        string maNvGlobal = "";
        public frmNhanvien()
        {
            InitializeComponent();
        }

        // Load grid control
        public void loadData()
        {
            gridControlNhanVien.DataSource = context.NHAN_VIEN.ToList();
            loadCbo();
            clearTXT();
        }

        //Load Combo Box
        public void loadCbo()
        {
            cboChucvu.DataSource = context.CHUC_VU.ToList();
            cboChucvu.ValueMember = "MaChucVu";
            cboChucvu.DisplayMember = "TenChucVu";
            cboGioitinh.DataSource = context.NHAN_VIEN.Select(p => p.GioiTinh).Distinct().ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string maNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();

            NHAN_VIEN nv = context.NHAN_VIEN.FirstOrDefault(p => p.MaNhanVien.ToLower() == maNV.ToLower());
            if (nv != null)
            {
                maNvGlobal = maNV;
                txtHoten.Text = nv.HoTen;
                txtDiachi.Text = nv.DiaChi;
                cboChucvu.Text = nv.ChucVu;
                cboGioitinh.Text = nv.GioiTinh;
                dateTimePicker1.Text = nv.NgaySinh.ToString();
                txtSDT.Text = nv.SoDienThoai;
            }
        }


        //Lay nhan vien cuoi
        public NHAN_VIEN getLastStaff()
        {
            NHAN_VIEN nv = null;
            List<NHAN_VIEN> list = context.NHAN_VIEN.ToList();
            foreach (var temp in list)
            {
                nv = temp;
            }
            return nv;
        }

        //Chuyen so thanh ma  "030" -> "NV031"
        public string convertNumbtoID(string n)
        {
            int numb = int.Parse(n);
            numb++;
            if (numb.ToString().Length == 3)
            {
                return "NV" + numb.ToString();
            }
            else if (numb.ToString().Length == 2)
            {
                return "NV0" + numb.ToString();
            }
            return "NV00" + numb.ToString();
        }


        //Clear text box

        public void clearTXT()
        {
            txtHoten.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
        }

        //Check >= 18 tuoi
        public Boolean check18(DateTime ngaySinh)
        {
            int years = DateTime.Now.Year - ngaySinh.Year;
            if(years < 18)
            {
                return false;
            }
            return true;
        }

        private void icoBtnThem_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "" || txtDiachi.Text == "" || txtSDT.Text == "")
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
                    if (check18(DateTime.Parse(dateTimePicker1.Text.ToString())))
                    {
                        // Lay nhan vien cuoi
                        NHAN_VIEN nv = getLastStaff();

                        if (nv == null)
                        {
                            NHAN_VIEN newNV = new NHAN_VIEN() { MaNhanVien = "NV001", HoTen = txtHoten.Text, ChucVu = cboChucvu.Text, GioiTinh = cboGioitinh.Text, DiaChi = txtDiachi.Text, NgaySinh = DateTime.Parse(dateTimePicker1.Text), SoDienThoai = txtSDT.Text, MaChucVu = cboChucvu.SelectedValue.ToString() };

                            context.NHAN_VIEN.Add(newNV);
                            context.SaveChanges();
                            MessageBox.Show(" Thêm thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                        }
                        else
                        {
                            string sttCuoi = nv.MaNhanVien.Replace("NV", "").ToString();
                            string maMoi = convertNumbtoID(sttCuoi);

                            NHAN_VIEN newNV = new NHAN_VIEN() { MaNhanVien = maMoi, HoTen = txtHoten.Text, ChucVu = cboChucvu.Text, GioiTinh = cboGioitinh.Text, DiaChi = txtDiachi.Text, NgaySinh = DateTime.Parse(dateTimePicker1.Text), SoDienThoai = txtSDT.Text, MaChucVu = cboChucvu.SelectedValue.ToString() };

                            context.NHAN_VIEN.Add(newNV);
                            context.SaveChanges();
                            MessageBox.Show(" Thêm thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();

                        }
                    }else
                    {
                        MessageBox.Show(" Nhân viên quá nhỏ tuổi!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
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

        private void icoBtnSua_Click(object sender, EventArgs e)
        {
            if (maNvGlobal == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtHoten.Text == "" || txtDiachi.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (check18(DateTime.Parse(dateTimePicker1.Text.ToString())))
                    {
                        if (txtSDT.Text.Substring(0, 1) != "0")
                        {
                            MessageBox.Show("Số điện thoại không đúng định dạng! (0xxx)");
                        }
                        else
                        {
                            NHAN_VIEN nv = context.NHAN_VIEN.FirstOrDefault(p => p.MaNhanVien.Equals(maNvGlobal));
                            nv.HoTen = txtHoten.Text;
                            nv.NgaySinh = DateTime.Parse(dateTimePicker1.Text);
                            nv.SoDienThoai = txtSDT.Text;
                            nv.GioiTinh = cboGioitinh.Text;
                            nv.ChucVu = cboChucvu.Text;
                            nv.MaChucVu = cboChucvu.SelectedValue.ToString();
                            nv.DiaChi = txtDiachi.Text;

                            context.SaveChanges();
                            MessageBox.Show(" Sửa thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                        }
                    }else
                    {
                        MessageBox.Show(" Nhân viên quá nhỏ tuổi!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void icoBtnXoa_Click(object sender, EventArgs e)
        {
            if (maNvGlobal == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                NHAN_VIEN nv = context.NHAN_VIEN.FirstOrDefault(p => p.MaNhanVien.Equals(maNvGlobal));

                if(nv != null)
                {
                    if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.NHAN_VIEN.Remove(nv);
                        context.SaveChanges();
                        MessageBox.Show(" Xóa thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }else
                {
                    MessageBox.Show(" Vui lòng chọn nhân viên cần xóa", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            loadData();
            txtHoten.Focus();
        }

        private void txtHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void icoBtnXuatnhanvien_Click(object sender, EventArgs e)
        {
            FormReport.ReportNhanVien Frm = new FormReport.ReportNhanVien();
            Frm.DataSource = context.NHAN_VIEN.ToList();
            frmReportViewer Rpv = new frmReportViewer(Frm);
            Rpv.ShowDialog();
        }
    }
}
