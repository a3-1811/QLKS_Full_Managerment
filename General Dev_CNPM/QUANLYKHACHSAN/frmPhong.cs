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
    public partial class frmPhong : System.Windows.Forms.UserControl
    {
        QLKS_DB context = new QLKS_DB();
        string maPhongGlobal = "";
        public frmPhong()
        {
            InitializeComponent();
        }
        // Load grid control
        public void loadData()
        {
            var dataGrid = context.PHONG.Join(
               context.LOAI_PHONG,
               P => P.MaLoaiPhong,
               L => L.MaLoaiPhong,
               (P, L) => new { P, L }
               ).Join(
                context.LOAI_TINH_TRANG,
                PL => PL.P.MaLoaiTinhTrangPhong,
                L => L.MaLoaiTinhTrangPhong,
                (PL, L) => new { PL, L }
                ).Select(p => new
                {
                    MaPhong = p.PL.P.MaPhong,
                    TenLoaiPhong = p.PL.L.TenLoaiPhong,
                    DonGia = p.PL.L.DonGia,
                    TinhTrang = p.L.TenLoaiTinhTrangPhong,
                    GhiChu = p.PL.P.GhiChu
                }).ToList();

            gridControlPhong.DataSource = dataGrid;
            loadCbo();
        }

        //Load combobox
        public void loadCbo()
        {
            cboLoaiphong.DataSource = context.LOAI_PHONG.ToList();
            cboLoaiphong.DisplayMember = "TenLoaiPhong";
            cboLoaiphong.ValueMember = "MaLoaiPhong";

            cboTinhtrang.DataSource = context.LOAI_TINH_TRANG.ToList();
            cboTinhtrang.ValueMember = "MaLoaiTinhTrangPhong";
            cboTinhtrang.DisplayMember = "TenLoaiTinhTrangPhong";

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle <= gridView1.RowCount)
            {
                maPhongGlobal = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                String tenLoai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
                String tinhTrang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
                cboLoaiphong.Text = tenLoai;
                cboTinhtrang.Text = tinhTrang;

                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]) == null)
                {
                    txtGhichu.Text = "";
                }
                else
                {
                    txtGhichu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
                }
            }
        }

        //Lay phong cuoi
        public PHONG getLastRoom()
        {
            PHONG tb = null;
            List<PHONG> list = context.PHONG.ToList();
            foreach (var temp in list)
            {
                tb = temp;
            }
            return tb;
        }

        //Chuyen so thanh ma  "1535" -> "1536"
        public string convertNumbtoID(string n)
        {
            int numb = int.Parse(n);
            numb++;
            return numb.ToString();
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            loadData();
            txtGhichu.Clear();
        }

        private void icoBtnThem_Click(object sender, EventArgs e)
        {
            PHONG phong = getLastRoom();
            if (phong == null)
            {
                PHONG temp = new PHONG() { MaPhong = "1501", MaLoaiPhong = cboLoaiphong.SelectedValue.ToString(), MaLoaiTinhTrangPhong = cboTinhtrang.SelectedValue.ToString(), GhiChu = txtGhichu.Text };
                context.PHONG.Add(temp);
                context.SaveChanges();
                loadData();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            else
            {
                string maMoi = convertNumbtoID(phong.MaPhong);
                PHONG temp = new PHONG() { MaPhong = maMoi, MaLoaiPhong = cboLoaiphong.SelectedValue.ToString(), MaLoaiTinhTrangPhong = cboTinhtrang.SelectedValue.ToString(), GhiChu = txtGhichu.Text };
                context.PHONG.Add(temp);
                context.SaveChanges();
                loadData();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
        }

        private void icoBtnSua_Click(object sender, EventArgs e)
        {
            if (maPhongGlobal == "")
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!", "Thông báo");
            }
            else
            {
                PHONG phong = context.PHONG.FirstOrDefault(p => p.MaPhong == maPhongGlobal);
                if (phong == null)
                {
                    MessageBox.Show("Không tồn tại phòng này!", "Thông báo");
                }
                else
                {
                    phong.MaLoaiPhong = cboLoaiphong.SelectedValue.ToString();
                    phong.MaLoaiTinhTrangPhong = cboTinhtrang.SelectedValue.ToString();
                    phong.GhiChu = txtGhichu.Text;
                    context.SaveChanges();
                    loadData();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
            }
        }

        private void icoBtnXoa_Click(object sender, EventArgs e)
        {
            if (maPhongGlobal == "")
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!", "Thông báo");
            }
            else
            {
                PHONG phong = context.PHONG.FirstOrDefault(p => p.MaPhong == maPhongGlobal);
                if (phong == null)
                {
                    MessageBox.Show("Không tồn tại phòng này!", "Thông báo");
                }
                else
                {
                    if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.PHONG.Remove(phong);
                        context.SaveChanges();
                        loadData();
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                    }
                }
            }
        }
    }
}
