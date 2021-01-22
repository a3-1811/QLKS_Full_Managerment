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
    public partial class frmDatPhongMain : Form
    {
        QLKS_DB context = new QLKS_DB();
        public frmDatPhongMain()
        {
            InitializeComponent();
        }

        //loadData
        public void loadData()
        {
            gridControlPhong.DataSource = context.LOAI_PHONG.ToList();

            //Combo box
            cboLoaiphong.DataSource = context.LOAI_PHONG.ToList();
            cboLoaiphong.DisplayMember = "TenLoaiPhong";
            cboLoaiphong.ValueMember = "MaLoaiPhong";

            cboHoTen.DataSource = context.KHACH_HANG.ToList();
            cboHoTen.DisplayMember = "TenKhachHang";
            cboHoTen.ValueMember = "MaKhachHang";

        }




        private void icoBtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDatPhongMain_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtSonguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && (char)Keys.Back != e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void icoBtnTimphong_Click(object sender, EventArgs e)
        {
            LOAI_PHONG loaiPhong = context.LOAI_PHONG.FirstOrDefault(p => p.MaLoaiPhong == cboLoaiphong.SelectedValue.ToString());
            if (int.Parse(txtSonguoi.Text) <= loaiPhong.SoNguoiToiDa && int.Parse(txtSonguoi.Text) > 0 )
            {
                PHONG phongTrong = context.PHONG.FirstOrDefault(p => p.MaLoaiTinhTrangPhong == "TP001" && p.MaLoaiPhong == cboLoaiphong.SelectedValue.ToString());
                if (phongTrong == null)
                {
                    MessageBox.Show("Loại phòng này đã được đặt hết hoặc đang trong quá trình sửa chữa!");
                }
                else
                {
                    txtTimphong.Text = phongTrong.MaPhong;
                }
            }else
            {
                MessageBox.Show("Số lượng phải lớn hơn 0 và nhỏ hơn bằng " + loaiPhong.SoNguoiToiDa);
            }
        }

        private void txtSonguoi_TextChanged(object sender, EventArgs e)
        {
            if(txtSonguoi.Text.Length != 0)
            {
                icoBtnTimphong.Enabled = true;
            }else
            {
                icoBtnTimphong.Enabled = false;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string maLoai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            LOAI_PHONG loaiPhong = context.LOAI_PHONG.FirstOrDefault(p => p.MaLoaiPhong == maLoai);
            cboLoaiphong.Text = loaiPhong.TenLoaiPhong;
        }

        //Chuyen so thanh ma  "030" -> "PT031"
        public string convertNumbtoID(string n)
        {
            int numb = int.Parse(n);
            numb++;
            if (numb.ToString().Length == 3)
            {
                return "TP" + numb.ToString();
            }
            else if (numb.ToString().Length == 2)
            {
                return "TP0" + numb.ToString();
            }
            return "TP00" + numb.ToString();
        }


        //Lay phieuthue phong cuoi
        public PHIEU_THUE_PHONG getLastPT()
        {
            PHIEU_THUE_PHONG nv = null;
            List<PHIEU_THUE_PHONG> list = context.PHIEU_THUE_PHONG.ToList();
            foreach (var temp in list)
            {
                nv = temp;
            }
            return nv;
        }
        private void icoBtnDatphong_Click(object sender, EventArgs e)
        {
            DateTime ngayden = DateTime.Parse(dtpNgayden.Text.ToString());
            DateTime ngaydi = DateTime.Parse(dtpNgaydi.Text.ToString());
            int compareDate = DateTime.Compare(ngayden,ngaydi );
            if ( txtSonguoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (txtTimphong.Text != "" && compareDate <= 0)
                {
                    PHIEU_THUE_PHONG itemCuoi = getLastPT();

                    if (itemCuoi != null)
                    {
                        string maMoi = convertNumbtoID(itemCuoi.MaThuePhong.Replace("TP", ""));
                        PHIEU_THUE_PHONG phieuThue = new PHIEU_THUE_PHONG() { MaThuePhong = maMoi, MaKhachHang = cboHoTen.SelectedValue.ToString(), MaNhanVien = "NV002", NgayLap = DateTime.Now };
                        context.PHIEU_THUE_PHONG.Add(phieuThue);
                        context.SaveChanges();

                        KHACH_HANG kh = context.KHACH_HANG.FirstOrDefault(p => p.MaKhachHang == cboHoTen.SelectedValue.ToString());

                        CHI_TIET_PHIEU_THUE_PHONG ctThuePhong = new CHI_TIET_PHIEU_THUE_PHONG()
                        {
                            MaThuePhong = maMoi,
                            MaKhachHang = kh.MaKhachHang,
                            MaPhong = txtTimphong.Text,
                            HoTenKhachHang = cboHoTen.Text,
                            CMND = kh.CMND,
                            NgayNhan = DateTime.Parse(dtpNgayden.Text.ToString()),
                            NgayTraDuKien = DateTime.Parse(dtpNgaydi.Text.ToString()),
                            NgayTra = null
                        };
                        context.CHI_TIET_PHIEU_THUE_PHONG.Add(ctThuePhong);
                        context.SaveChanges();

                        PHONG phong = context.PHONG.FirstOrDefault(p => p.MaPhong == txtTimphong.Text);
                        phong.MaLoaiTinhTrangPhong = "TP003";
                        context.SaveChanges();

                        MessageBox.Show("Đặt phòng thành công!");
                    }
                    else
                    {
                        PHIEU_THUE_PHONG phieuThue = new PHIEU_THUE_PHONG() { MaThuePhong = "PT001", MaKhachHang = cboHoTen.SelectedValue.ToString(), MaNhanVien = "NV002", NgayLap = DateTime.Now };
                        context.PHIEU_THUE_PHONG.Add(phieuThue);
                        context.SaveChanges();

                        KHACH_HANG kh = context.KHACH_HANG.FirstOrDefault(p => p.MaKhachHang == cboHoTen.SelectedValue.ToString());

                        CHI_TIET_PHIEU_THUE_PHONG ctThuePhong = new CHI_TIET_PHIEU_THUE_PHONG()
                        {
                            MaThuePhong = "PT001",
                            MaKhachHang = kh.MaKhachHang,
                            MaPhong = txtTimphong.Text,
                            HoTenKhachHang = cboHoTen.Text,
                            CMND = kh.CMND,
                            NgayNhan = DateTime.Parse(dtpNgayden.Text.ToString()),
                            NgayTraDuKien = DateTime.Parse(dtpNgaydi.Text.ToString()),
                            NgayTra = null
                        };
                        context.CHI_TIET_PHIEU_THUE_PHONG.Add(ctThuePhong);
                        context.SaveChanges();

                        PHONG phong = context.PHONG.FirstOrDefault(p => p.MaPhong == txtTimphong.Text);
                        phong.MaLoaiTinhTrangPhong = "TP003";
                        context.SaveChanges();

                        MessageBox.Show("Đặt phòng thành công!");
                    }
                }
                else if (compareDate >= 0)
                {
                    MessageBox.Show("Ngày đến không thể lớn hơn ngày đi");
                }
            }
        }
    }
}
