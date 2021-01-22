using QUANLYKHACHSAN.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
            timer1.Interval = 10000;
            timer2.Interval = 1000;
            lblCountdown.Text = string.Empty;
        }
        int countdown = 10;
        int count = 0;
        private QLKS_DB context = new QLKS_DB();
        private bool checkLogin(string username, string password)
        {
            string acc = (username + password).Replace("\'", "").Trim();
            string accData = username + context.NGUOI_DUNG.Where(p => p.TenDangNhap.Equals(username)).Select(p => p.MatKhau).FirstOrDefault();
            if (acc.Equals(accData))
                return true;
            return false;
        }
        private void disablebutton()
        {
            txtDangnhap.Enabled = false;
            txtMatkhau.Enabled = false;
            icoBtnDangnhap.Enabled = false;
            timer2.Start();
            timer1.Start();
        }
        private void icoBtnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                count++;
                if (count >= 3)
                {
                    disablebutton();
                    throw new Exception("Sai tài khoản mật khẩu quá nhiều lần, vui lòng đăng nhập lại sau");
                }
                if (txtDangnhap.Text == string.Empty || txtMatkhau.Text == string.Empty)
                    throw new Exception("Vui lòng nhập đủ thông tin đăng nhập");
                if (!checkLogin(txtDangnhap.Text, txtMatkhau.Text))
                    throw new Exception("Sai thông tin đăng nhập");
                frmMain frm = new frmMain(txtDangnhap.Text);
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void icoBtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDangnhap.Enabled = true;
            txtMatkhau.Enabled = true;
            icoBtnDangnhap.Enabled = true;
            count = 0;
            timer1.Stop();
            timer2.Stop();
            lblCountdown.Text = string.Empty;
            countdown = 10;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            countdown--;
            lblCountdown.Text = "Đăng nhập sau " + countdown.ToString() + " giây nữa !";
        }
    }
}
