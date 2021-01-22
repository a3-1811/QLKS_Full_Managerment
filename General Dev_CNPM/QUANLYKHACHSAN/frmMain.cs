using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QUANLYKHACHSAN.Model;


namespace QUANLYKHACHSAN
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string username)
        {
            InitializeComponent();

            //Set default value
            customizeDesing();
            leftPan = new Panel();
            leftPan.Size = new Size(12, 40);
            panel1.Controls.Add(leftPan);
            this.DoubleBuffered = true;
            pnlUserSetting.Visible = false;
            lblUsername.Text = username;
            setPermission(username);
            UserControl us = new frmTrangchu();
            lblTittle.Text = icoBtnTrangchu.Text;
            iconCurrentChildForm.IconChar = icoBtnTrangchu.IconChar;
            loadForm(us);
            timer1.Start();
        }

        //Define global
        public IconButton currentBtn;
        public Panel leftPan;
        public UserControl currentUs;
        string tittle = string.Empty;
        string username = string.Empty;
        //define color struct

        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(0, 255, 255);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(152, 251, 152);
            public static Color color4 = Color.FromArgb(173, 255, 47);
            public static Color color5 = Color.FromArgb(64, 224, 208);
            public static Color color6 = Color.FromArgb(75, 0, 130);
            public static Color color7 = Color.FromArgb(61, 163, 141);
        }

        //SetPermission for user
        private void setPermission(string username)
        {
            QLKS_DB context = new QLKS_DB();
            string CV = context.NGUOI_DUNG.Where(p => p.TenDangNhap.Equals(username)).Select(p => p.MaChucVu).FirstOrDefault();
            switch(CV)
            {
                case "CV001":
                    hideAll();
                    iconBtnQuanly.Visible = true;
                    pnlQuanly.Visible = true;
                    iconBtnPhieuthue.Visible = true;
                    iconBtnKhachhang.Visible = true;
                    pnlQuanly.Height = 45 * 2;
                    break;
                case "CV002":
                    hideAll();
                    iconBtnQuanly.Visible = true;
                    pnlQuanly.Visible = true;
                    pnlQuanly.Height = 45 * 4;
                    iconBtnPhieuthue.Visible = true;
                    iconBtnKhachhang.Visible = true;
                    iconBtnPhong.Visible = true;
                    iconBtnDichvu.Visible = true;
                    break;
                case "CV006":
                    hideAll();
                    iconBtnQuanly.Visible = true;
                    pnlQuanly.Visible = true;
                    pnlQuanly.Height = 45 * 2;
                    iconBtnThietbi.Visible = true;
                    iconBtnPhieusuachua.Visible = true;
                    break;
                case "CV007":
                    hideAll();
                    iconBtnQuanly.Visible = true;
                    pnlQuanly.Visible = true;
                    pnlQuanly.Height = 45;
                    iconBtnNhanvien.Visible = true;
                    break;
                case "CV008":
                    hideAll();
                    iconBtnBaocao.Visible = true;
                    pnlBaocao.Visible = true;
                    pnlBaocao.Height = 45;
                    iconBtnDoanhthu.Visible = true;
                    break;
                default:
                    break;
            }
        }


        //Add usercontrol into Desktop panel
        public void loadForm(UserControl us)
        {
            us.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Clear();
            pnlDesktop.Controls.Add(us);
        }
        //Active a button
        private void ActiveBtn(object sender, Color color)
        {
            if (sender != null)
            {
                SetButton(sender, color);
                leftPan.BackColor = color;
                leftPan.Location = new System.Drawing.Point(currentBtn.Location.X, currentBtn.Location.Y);
                leftPan.Visible = true;
                leftPan.BringToFront();
                SetTittle(color);
            }
        }
        //Active a sub button
        private void ActiveSubBtn(object sender, Color color)
        {
            //leftPan.Visible = false;
            SetButton(sender, color);
            SetTittle(color);
        }
        private void SetButton(object sender, Color color)
        {
            DisableBtn();
            currentBtn = (IconButton)sender;
            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = color;
            //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            //currentBtn.ImageAlign = ContentAlignment.MiddleRight;

        }
        //Set tittle bar
        private void SetTittle(Color color)
        {
            iconCurrentChildForm.IconChar = currentBtn.IconChar;
            iconCurrentChildForm.IconColor = color;
            lblTittle.Text = currentBtn.Text;
        }
        //Disable a button
        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(52, 130, 198);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }
        //hide all submenu when init
        private void customizeDesing()
        {
            pnlBaocao.Visible = false;
            pnlHeThong.Visible = false;
            pnlQuanly.Visible = false;
            pnlTrogiup.Visible = false;
        }
        //hide all button
        private void hideAll()
        {
            pnlBaocao.Visible = false;
            foreach (Control ctl in pnlBaocao.Controls)
                ctl.Visible = false;
            pnlHeThong.Visible = false;
            foreach (Control ctl in pnlHeThong.Controls)
                ctl.Visible = false;
            pnlQuanly.Visible = false;
            foreach (Control ctl in pnlQuanly.Controls)
                ctl.Visible = false;
            iconBtnQuanly.Visible = false;
            iconBtnHethong.Visible = false;
            iconBtnBaocao.Visible = false;
        }
        //hide a submenu
        private void hideSubMenu()
        {
            if (pnlBaocao.Visible == true)
                pnlBaocao.Visible = false;
            if (pnlHeThong.Visible == true)
                pnlHeThong.Visible = false;
            if (pnlQuanly.Visible == true)
                pnlQuanly.Visible = false;
            if (pnlTrogiup.Visible == true)
                pnlTrogiup.Visible = false;
        }
        //Show a submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void icoBtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void icoBtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void icoBtnTrangchu_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColor.color1);
            UserControl us = new frmTrangchu();
            loadForm(us);
            customizeDesing();
        }

        private void iconBtnHethong_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlHeThong);
            ActiveBtn(sender, RGBColor.color2);
        }
        private void iconBtnQuanly_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlQuanly);
            ActiveBtn(sender, RGBColor.color3);
        }
        private void iconBtnBaocao_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBaocao);
            ActiveBtn(sender, RGBColor.color4);
        }

        private void iconBtnTrogiup_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlTrogiup);
            ActiveBtn(sender, RGBColor.color5);
        }

        private void icoBtnSetting_Click(object sender, EventArgs e)
        {
                pnlUserSetting.Visible = !pnlUserSetting.Visible;
                if (pnlUserSetting.Visible)
                {
                    icoBtnSetting.Flip = FlipOrientation.Horizontal;
                }
                else
                {
                    icoBtnSetting.Flip = FlipOrientation.Normal;
                }
        }

        private void iconBtnPhanquyen_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color2);
            UserControl us = new frmPhanquyen();
            loadForm(us);
        }

        private void iconBtnPhong_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color3);
            UserControl us = new frmPhong();
            loadForm(us);
        }

        private void iconBtnPhieuthue_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color3);
            UserControl us = new frmPhieuthue();
            loadForm(us);
        }

        private void iconBtnKhachhang_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color3);
            UserControl us = new frmKhachhang();
            loadForm(us);
        }

        private void iconBtnNhanvien_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color3);
            UserControl us = new frmNhanvien();
            loadForm(us);
        }

        private void iconBtnThietbi_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color3);
            UserControl us = new frmThietbi();
            loadForm(us);
        }

        private void iconBtnDichvu_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color3);
            UserControl us = new frmDichvu();
            loadForm(us);
        }

        private void iconBtnPhieusuachua_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color3);
            UserControl us = new frmPhieusuachua();
            loadForm(us);
        }

        private void iconBtnDoanhthu_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color4);
            UserControl us = new frmDoanhthu();
            loadForm(us);
        }

        private void icoBtnLogout_Click(object sender, EventArgs e)
        {
            frmDangnhap login = new frmDangnhap();
            login.Show();
            this.Hide();
        }

        private void iconBtnKhachhangthanthiet_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color4);
            UserControl us = new frmKhachhangthanthiet();
            loadForm(us);
        }

        private void iconBtnHuongdan_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color5);
            UserControl us = new frmHuongdan();
            loadForm(us);
        }

        private void iconBtnNoiquy_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color5);
            UserControl us = new frmNoiquykhachsan();
            loadForm(us);
        }

        private void iconBtnLienhe_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color5);
            UserControl us = new frmLienhe();
            loadForm(us);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString();
        }
    }
}
