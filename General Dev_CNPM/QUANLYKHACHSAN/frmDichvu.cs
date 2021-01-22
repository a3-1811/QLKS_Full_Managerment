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
using System.Text.RegularExpressions;

namespace QUANLYKHACHSAN
{
    public partial class frmDichvu : UserControl
    {
        QLKS_DB context = new QLKS_DB();
        public frmDichvu()
        {
            InitializeComponent();
        }

        // Load grid control
        public void loadData()
        {
            gridControlDichvu.DataSource = context.DICH_VU.ToList();
            loadCbo();
        }

        //Load Combo Box
        public void loadCbo()
        {
            cboDonvitinh.DataSource = context.DICH_VU.Select(p => p.DonViTinh).Distinct().ToList();
        }

        //Clear text box

        public void clearTXT()
        {
            txtMadichvu.Clear();
            txtTendichvu.Clear();
            txtDongia.Clear();
        }
        private void frmDichvu_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public static string RemoveVietnameseTone(string text)
        {
            string result = text.ToLower();
            result = Regex.Replace(result, "à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ|/g", "a");
            result = Regex.Replace(result, "è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ|/g", "e");
            result = Regex.Replace(result, "ì|í|ị|ỉ|ĩ|/g", "i");
            result = Regex.Replace(result, "ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ|/g", "o");
            result = Regex.Replace(result, "ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ|/g", "u");
            result = Regex.Replace(result, "ỳ|ý|ỵ|ỷ|ỹ|/g", "y");
            result = Regex.Replace(result, "đ", "d");
            return result;
        }

        //Check ten trung "Dieu hoa" == "dieu     hoa"
        public bool checkName(String name)
        {
            string temp = RemoveVietnameseTone(name.Trim());

            string newString = Regex.Replace(temp, @"\s+", "");

            foreach (var p in context.DICH_VU.ToList())
            {
                if (Regex.Replace(RemoveVietnameseTone(p.TenDichVu.Trim()), @"\s+", "") == newString)
                {
                    return true;
                }
            }
            return false;
        }

        private void icoBtnThem_Click(object sender, EventArgs e)
        {
            if (txtMadichvu.Text == "" || txtTendichvu.Text == "" || txtDongia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DICH_VU dv = context.DICH_VU.FirstOrDefault(p => p.MaDichVu.ToLower() == txtMadichvu.Text.ToLower());
                if (dv != null)
                {
                    MessageBox.Show("Đã tồn tại mã dịch vụ này!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool isExist = checkName(txtTendichvu.Text);
                    if (isExist == false)
                    {
                        DICH_VU newDV = new DICH_VU() { MaDichVu = RemoveVietnameseTone(txtMadichvu.Text.ToUpper()).ToUpper(), TenDichVu = txtTendichvu.Text, DonViTinh = cboDonvitinh.Text, DonGia = Double.Parse(txtDongia.Text) };
                        context.DICH_VU.Add(newDV);
                        context.SaveChanges();
                        MessageBox.Show(" Thêm thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        clearTXT();
                    }else
                    {
                        MessageBox.Show(" Đã tồn tại tên dịch vụ!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    
                }
            }
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string maDV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();

            DICH_VU dv = context.DICH_VU.FirstOrDefault(p => p.MaDichVu.ToLower() == maDV.ToLower());
            if (dv != null)
            {
                txtMadichvu.Text = dv.MaDichVu;
                txtTendichvu.Text = dv.TenDichVu;
                cboDonvitinh.Text = dv.DonViTinh;
                txtDongia.Text = dv.DonGia.ToString();
            }
        }

        private void icoBtnSua_Click(object sender, EventArgs e)
        {
            if (txtMadichvu.Text == "" || txtTendichvu.Text == "" || txtDongia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DICH_VU dv = context.DICH_VU.FirstOrDefault(p => p.MaDichVu.ToLower() == txtMadichvu.Text.ToLower());
                if (dv != null)
                {
                    bool isExist = checkName(txtTendichvu.Text);
                    if (isExist == false)
                    {
                        dv.TenDichVu = txtTendichvu.Text;
                        dv.DonGia = Double.Parse(txtDongia.Text);
                        dv.DonViTinh = cboDonvitinh.Text;
                        MessageBox.Show("Sửa thành công!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        context.SaveChanges();
                        loadData();
                        clearTXT();
                    }else
                    {
                        MessageBox.Show(" Đã tồn tại tên dịch vụ!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show(" Không tìm thấy mã dịch vụ cần sửa!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void icoBtnXoa_Click(object sender, EventArgs e)
        {
            if (txtMadichvu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DICH_VU dv = context.DICH_VU.FirstOrDefault(p => p.MaDichVu.ToLower() == txtMadichvu.Text.ToLower());
                if (dv != null)
                {
                    if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.DICH_VU.Remove(dv);
                        MessageBox.Show("Xoá thành công!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        context.SaveChanges();
                        loadData();
                        clearTXT();
                    }
                }
                else
                {
                    MessageBox.Show(" Không tìm thấy mã dịch vụ cần xóa!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtMadichvu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            if (txtMadichvu.Text.Length > 4)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtTendichvu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            if (txtTendichvu.Text.ToString().Trim().Length > 45)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void icoBtnXuatDichVu_Click(object sender, EventArgs e)
        {
            FormReport.ReportDichVu Frm = new FormReport.ReportDichVu();
            Frm.DataSource = context.DICH_VU.ToList();
            frmReportViewer Rpv = new frmReportViewer(Frm);
            Rpv.ShowDialog();
        }
    }
}
