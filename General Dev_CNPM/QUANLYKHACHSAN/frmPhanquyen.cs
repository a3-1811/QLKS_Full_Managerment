using QUANLYKHACHSAN.Model;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class frmPhanquyen : UserControl
    {
        public frmPhanquyen()
        {
            InitializeComponent();
        }
        private QLKS_DB context = new QLKS_DB();

        private void clear()
        {
            txtMatkhauhethong.Clear();
            txtTendangnhaphethong.Clear();
            cboChucvu.SelectedIndex = 0;
        }
        private void load()
        {
            var temp = context.NGUOI_DUNG.Join
                (
                    context.CHUC_VU,
                    ND => ND.MaChucVu,
                    CV => CV.MaChucVu,
                    (ND, CV) => new { ND, CV }
                )
                .Select(p => new
                {
                    TenDangNhap = p.ND.TenDangNhap,
                    MatKhau = p.ND.MatKhau,
                    MaChucVu = p.CV.MaChucVu,
                    TenChucVu = p.CV.TenChucVu,
                })
                .ToList();
            gridControlPhanquyen.DataSource = temp;


            cboChucvu.DataSource = context.CHUC_VU.Select(p => new { MaChucVu = p.MaChucVu, TenChucVu = p.TenChucVu }).ToList();
            cboChucvu.DisplayMember = "TenChucVu";
            cboChucvu.ValueMember = "MaChucVu";
            clear();
        }
        private void frmPhanquyen_Load(object sender, EventArgs e)
        {
            load();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle <= gridView1.RowCount)
            {
                string ID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                NGUOI_DUNG ND = context.NGUOI_DUNG.Where(p => p.TenDangNhap.Equals(ID)).FirstOrDefault();
                txtTendangnhaphethong.Text = ND.TenDangNhap.ToString();
                txtMatkhauhethong.Text = ND.MatKhau.ToString();
                cboChucvu.SelectedValue = ND.MaChucVu;
            }
        }

        private void icoBtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatkhauhethong.Text.Equals(string.Empty) || txtTendangnhaphethong.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng nhập đủ thông tin !");
                NGUOI_DUNG ND = context.NGUOI_DUNG.Where(p => p.TenDangNhap.Equals(txtTendangnhaphethong.Text)).FirstOrDefault();
                if (ND != null)
                    throw new Exception("Tên người dùng đã tồn tại, vui lòng chọn một tên khác");
                if (cboChucvu.SelectedValue.Equals("CV004"))
                    if (MessageBox.Show("Nếu bạn cấp quyền quản trị, người dùng này có thể thao tác trên toàn hệ thống, Xác nhận ?", "Cảnh báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        clear();
                        throw new Exception("Thêm thất bại");
                    }
                ND.TenDangNhap = txtTendangnhaphethong.Text.Replace("\'", "").Trim();
                ND.MatKhau = txtMatkhauhethong.Text;
                ND.MaChucVu = cboChucvu.SelectedValue.ToString();
                context.NGUOI_DUNG.Add(ND);
                context.SaveChanges();
                MessageBox.Show("Thêm thành công !");
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void icoBtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatkhauhethong.Text.Equals(string.Empty) || txtTendangnhaphethong.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng chọn người dùng cần sửa !");
                NGUOI_DUNG ND = context.NGUOI_DUNG.Where(p => p.TenDangNhap.Equals(txtTendangnhaphethong.Text)).FirstOrDefault();
                if (ND == null)
                    throw new Exception("Tên người dùng không tồn tại");
                if (cboChucvu.SelectedValue.Equals("CV004"))
                    if (MessageBox.Show("Nếu bạn cấp quyền quản trị, người dùng này có thể thao tác trên toàn hệ thống, Xác nhận ?", "Cảnh báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        clear();
                        throw new Exception("Sửa thất bại");
                    }
                ND.MatKhau = txtMatkhauhethong.Text;
                ND.MaChucVu = cboChucvu.SelectedValue.ToString();
                context.Entry(ND).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Sửa thành công !");
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void icoBtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatkhauhethong.Text.Equals(string.Empty) || txtTendangnhaphethong.Text.Equals(string.Empty))
                    throw new Exception("Vui lòng chọn người dùng cần xoá !");
                NGUOI_DUNG ND = context.NGUOI_DUNG.Where(p => p.TenDangNhap.Equals(txtTendangnhaphethong.Text)).FirstOrDefault();
                if (ND == null)
                    throw new Exception("Tên người dùng không tồn tại");
                if (MessageBox.Show("Nếu bạn xoá người dùng này, người dùng này sẽ không thể thao tác với hệ thống, Xác nhận ?", "Cảnh báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    clear();
                    throw new Exception("Xoá thất bại");
                }
                context.NGUOI_DUNG.Remove(ND);
                context.SaveChanges();
                MessageBox.Show("Xoá thành công !");
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
