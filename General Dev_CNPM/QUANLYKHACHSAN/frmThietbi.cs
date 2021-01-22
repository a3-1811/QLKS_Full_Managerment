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
    public partial class frmThietbi : UserControl
    {
        QLKS_DB context = new QLKS_DB();
        string maTbGlobal = "";
        public frmThietbi()
        {
            InitializeComponent();
        }
        // Load grid control
        public void loadData()
        {
            gridControlThietbi.DataSource = context.THIET_BI.ToList();
        }

        //Lay thiet bi cuoi
        public THIET_BI getLastTB()
        {
            THIET_BI tb = null;
            List<THIET_BI> list = context.THIET_BI.ToList();
            foreach (var temp in list)
            {
                tb = temp;
            }
            return tb;
        }

        //Chuyen so thanh ma  "01" -> "TB02"
        public string convertNumbtoID(string n)
        {
            int numb = int.Parse(n);
            numb++;
            if (numb.ToString().Length == 2)
            {
                return "TB" + numb.ToString();
            }
            return "TB0" + numb.ToString();
        }

        //Clear textbox
        public void clearTxt()
        {
            txtTenthietbi.Clear();
            txtSoluong.Clear();
        }

        private void frmThietbi_Load(object sender, EventArgs e)
        {
            loadData();
            txtTenthietbi.Focus();
            capNhat();
        }

        //bo dau tieng viet

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

            foreach (var  p in context.THIET_BI.ToList())
            {
                if(Regex.Replace(RemoveVietnameseTone(p.TenThietBi.Trim()), @"\s+", "") == newString)
                {
                    return true;
                }
            }
            return false;
        }

        private void icoBtnThem_Click(object sender, EventArgs e)
        {
            if (txtTenthietbi.Text == "" || txtSoluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
            }
            else
            {
                THIET_BI tb = getLastTB();
                bool isExits = checkName(txtTenthietbi.Text);
                if (isExits == false)
                {
                    if (tb == null)
                    {
                        THIET_BI temp = new THIET_BI() { MaThietBi = "TB01", TenThietBi = txtTenthietbi.Text.Trim(), SoLuong = txtSoluong.Text == "" ? 0 : int.Parse(txtSoluong.Text) };
                        context.THIET_BI.Add(temp);
                        context.SaveChanges();
                        loadData();
                        clearTxt();
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                    }
                    else
                    {
                        string sttCuoi = tb.MaThietBi.Replace("TB", "");
                        string maTbMoi = convertNumbtoID(sttCuoi);
                        THIET_BI temp = new THIET_BI() { MaThietBi = maTbMoi, TenThietBi = txtTenthietbi.Text.Trim(), SoLuong = txtSoluong.Text == "" ? 0 : int.Parse(txtSoluong.Text) };
                        context.THIET_BI.Add(temp);
                        context.SaveChanges();
                        loadData();
                        clearTxt();
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                    }
                }else
                {
                    MessageBox.Show("Đã tồn tại tên thiết bị!", "Thông báo");
                }
            }
        }

        public void capNhat()
        {
            foreach (var thietBi in context.THIET_BI.ToList())
            {
                int count = 0;
                foreach (var sohuu in context.SO_HUU_THIET_BI.ToList())
                {
                    if(sohuu.MaThietBi == thietBi.MaThietBi)
                    {
                        count++;
                    }
                }
                thietBi.SoLuong = count;
                context.SaveChanges();
            }
        }


        private void icoBtnSua_Click(object sender, EventArgs e)
        {
            if (maTbGlobal != "")
            {
                THIET_BI tb = context.THIET_BI.FirstOrDefault(p => p.MaThietBi.Equals(maTbGlobal));

                bool isExits = checkName(txtTenthietbi.Text);
                if (isExits == false)
                {
                    tb.TenThietBi = txtTenthietbi.Text.Trim();
                    tb.SoLuong = txtSoluong.Text == "" ? 0 : int.Parse(txtSoluong.Text);
                    context.SaveChanges();
                    loadData();
                    clearTxt();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }else
                {
                    MessageBox.Show("Đã tồn tại tên thiết bị!", "Thông báo");
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thiết bị muốn sửa!", "Thông báo");
            }
        }

        private void icoBtnXoa_Click(object sender, EventArgs e)
        {

            if (maTbGlobal != "")
            {
                THIET_BI tb = context.THIET_BI.FirstOrDefault(p => p.MaThietBi.Equals(maTbGlobal));
                if (tb != null)
                {
                    if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.THIET_BI.Remove(tb);
                        context.SaveChanges();
                        loadData();
                        clearTxt();
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thiết bị muốn xóa!", "Thông báo");
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string maTB = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();

            THIET_BI tb = context.THIET_BI.FirstOrDefault(p => p.MaThietBi.ToLower() == maTB.ToLower());
            if (tb != null)
            {
                maTbGlobal = maTB;
                txtTenthietbi.Text = tb.TenThietBi;
                txtSoluong.Text = tb.SoLuong == null ? "0" : tb.SoLuong.ToString();
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void icoBtnXuatthietbi_Click(object sender, EventArgs e)
        {
            FormReport.ReportThietBi Frm = new FormReport.ReportThietBi();
            Frm.DataSource = context.THIET_BI.ToList();
            frmReportViewer Rpv = new frmReportViewer(Frm);
            Rpv.ShowDialog();
        }

        private void txtTenthietbi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            if(txtTenthietbi.Text.ToString().Trim().Length > 45)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
    }
}
