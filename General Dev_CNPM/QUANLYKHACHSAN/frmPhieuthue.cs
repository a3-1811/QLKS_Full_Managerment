using QUANLYKHACHSAN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class frmPhieuthue : UserControl
    {

        string maThuePhong = "";
        double tongtienthue = 0;
        QLKS_DB context = new QLKS_DB();
        public frmPhieuthue()
        {
            InitializeComponent();
        }
        // Load grid control
        public void loadData()
        {
            var dataGrid = context.CHI_TIET_PHIEU_THUE_PHONG.ToList();
            gridControlPhieuthue.DataSource = dataGrid;
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string maPT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            maThuePhong = maPT;
            PHIEU_THUE_PHONG pt = context.PHIEU_THUE_PHONG.FirstOrDefault(p => p.MaThuePhong.ToLower() == maPT.ToLower());
            if (pt != null)
            {
                NHAN_VIEN nv = context.NHAN_VIEN.FirstOrDefault(p => p.MaNhanVien == pt.MaNhanVien);
                txtNhanVienLap.Text = nv.HoTen;
                //tinh so ngay
                CHI_TIET_PHIEU_THUE_PHONG ctTP = context.CHI_TIET_PHIEU_THUE_PHONG.FirstOrDefault(p => p.MaThuePhong == pt.MaThuePhong);
                Double milTime = DateTime.Parse(ctTP.NgayTraDuKien.ToString()).Day - DateTime.Parse(ctTP.NgayNhan.ToString()).Day + 1;
                txtSoNgay.Text = milTime.ToString() + " ngày";
            }
        }

        private void frmPhieuthue_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void iconBtnDatPhong_Click(object sender, EventArgs e)
        {
            frmDatPhongMain frm = new frmDatPhongMain();
            frm.ShowDialog();
            loadData();
        }

        private void icoBtnThemdichvu_Click(object sender, EventArgs e)
        {
            if (maThuePhong == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu thuê trước!", "Thông tin");
            }
            else
            {
                HOA_DON hd = context.HOA_DON.FirstOrDefault(p => p.MaThuePhong == maThuePhong);
                if (hd == null)
                {
                    frmThemDV frm = new frmThemDV(maThuePhong);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Phiếu thuê phòng này đã thanh toán", "Thông tin");
                }
            }
        }
        //Chuyen so thanh ma  "030" -> "HD031"
        public string convertNumbtoID(string n)
        {
            int numb = int.Parse(n);
            numb++;
            if (numb.ToString().Length == 3)
            {
                return "HD" + numb.ToString();
            }
            else if (numb.ToString().Length == 2)
            {
                return "HD0" + numb.ToString();
            }
            return "HD00" + numb.ToString();
        }

        private void icoBtnTraphong_Click(object sender, EventArgs e)
        {
            //Check tra chua
            if (maThuePhong == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu thuê trước!", "Thông tin");
            }
            else
            {
                // thanh toan chua
                HOA_DON hd = context.HOA_DON.FirstOrDefault(p => p.MaThuePhong == maThuePhong);
                if (hd == null)
                {
                    HOA_DON hdCuoi = context.HOA_DON.ToList().LastOrDefault();

                    if (hdCuoi == null)
                    {
                        // HD001
                        String maMoi = "HD001";
                        PHIEU_THUE_PHONG phieuThue = context.PHIEU_THUE_PHONG.FirstOrDefault(p => p.MaThuePhong == maThuePhong);
                        //Tinh tien
                        double tongTien = 0;

                        CHI_TIET_PHIEU_THUE_PHONG ctThuePhong = context.CHI_TIET_PHIEU_THUE_PHONG.FirstOrDefault(p => p.MaThuePhong == maThuePhong);
                        ctThuePhong.NgayTra = DateTime.Now;
                        context.SaveChanges();
                        //So ngay
                        double dayTime = DateTime.Parse(ctThuePhong.NgayTra.ToString()).Day - DateTime.Parse(ctThuePhong.NgayNhan.ToString()).Day + 1;
                        //Tien phong
                        PHONG phong = context.PHONG.FirstOrDefault(p => p.MaPhong == ctThuePhong.MaPhong);
                        LOAI_PHONG loaiPhong = context.LOAI_PHONG.FirstOrDefault(p => p.MaLoaiPhong == phong.MaLoaiPhong);
                        double tienPhong = dayTime * Double.Parse(loaiPhong.DonGia.ToString());

                        //Tien dich vu
                        List<DANH_SACH_SU_DUNG_DICH_VU> ds = context.DANH_SACH_SU_DUNG_DICH_VU.ToList();
                        double tienDV = 0;
                        foreach (var item in ds)
                        {
                            if (item.MaThuePhong == maThuePhong)
                            {
                                tienDV += Double.Parse(loaiPhong.DonGia.ToString()) * Double.Parse(item.SoLuong.ToString());
                            }
                        }
                        tongTien = tienPhong + tienDV;
                        tongtienthue = tongTien;

                        HOA_DON newHD = new HOA_DON() { MaHoaDon = maMoi, MaNhanVien = phieuThue.MaNhanVien, MaThuePhong = maThuePhong, NgayLap = DateTime.Now, TongTien = long.Parse(tongTien.ToString()) };
                        context.HOA_DON.Add(newHD);
                        context.SaveChanges();
                        CHI_TIET_HOA_DON ctHD = new CHI_TIET_HOA_DON() { MaHoaDon = maMoi, MaThuePhong = maThuePhong, SoNgay = int.Parse(dayTime.ToString()), ThanhTien = long.Parse(tongTien.ToString()), TienDichVu = long.Parse(tienDV.ToString()), TienPhong = long.Parse(tienPhong.ToString()) };
                        context.CHI_TIET_HOA_DON.Add(ctHD);
                        //Cap nhat lai tinh trang phong
                        phong.MaLoaiTinhTrangPhong = "TP001";
                        context.SaveChanges();
                        loadData();
                        //Tra phong xuat hoa don


                    }
                    else
                    {
                        PHIEU_THUE_PHONG phieuThue = context.PHIEU_THUE_PHONG.FirstOrDefault(p => p.MaThuePhong == maThuePhong);
                        String maMoi = convertNumbtoID(hdCuoi.MaHoaDon.Replace("HD", ""));
                        //Tinh tien
                        Double tongTien = 0;

                        CHI_TIET_PHIEU_THUE_PHONG ctThuePhong = context.CHI_TIET_PHIEU_THUE_PHONG.FirstOrDefault(p => p.MaThuePhong == maThuePhong);
                        ctThuePhong.NgayTra = DateTime.Now;
                        context.SaveChanges();
                        //So ngay
                        Double dayTime = DateTime.Parse(ctThuePhong.NgayTra.ToString()).Day - DateTime.Parse(ctThuePhong.NgayNhan.ToString()).Day + 1;
                        //Tien phong
                        PHONG phong = context.PHONG.FirstOrDefault(p => p.MaPhong == ctThuePhong.MaPhong);
                        LOAI_PHONG loaiPhong = context.LOAI_PHONG.FirstOrDefault(p => p.MaLoaiPhong == phong.MaLoaiPhong);
                        Double tienPhong = dayTime * Double.Parse(loaiPhong.DonGia.ToString());

                        //Tien dich vu
                        List<DANH_SACH_SU_DUNG_DICH_VU> ds = context.DANH_SACH_SU_DUNG_DICH_VU.ToList();
                        Double tienDV = 0;
                        foreach (var item in ds)
                        {
                            if (item.MaThuePhong == maThuePhong)
                            {
                                DICH_VU dv = context.DICH_VU.FirstOrDefault(p=>p.MaDichVu == item.MaDichVu);
                                tienDV += Double.Parse(dv.DonGia.ToString()) * Double.Parse(item.SoLuong.ToString());
                            }
                        }
                        tongTien = tienPhong + tienDV;

                        HOA_DON newHD = new HOA_DON() { MaHoaDon = maMoi, MaNhanVien = phieuThue.MaNhanVien, MaThuePhong = maThuePhong, NgayLap = DateTime.Now, TongTien = long.Parse(tongTien.ToString()) };
                        context.HOA_DON.Add(newHD);
                        context.SaveChanges();
                        CHI_TIET_HOA_DON ctHD = new CHI_TIET_HOA_DON() { MaHoaDon = maMoi, MaThuePhong = maThuePhong, SoNgay = int.Parse(dayTime.ToString()), ThanhTien = long.Parse(tongTien.ToString()), TienDichVu = long.Parse(tienDV.ToString()), TienPhong = long.Parse(tienPhong.ToString()) };
                        context.CHI_TIET_HOA_DON.Add(ctHD);
                        //Cap nhat lai tinh trang phong
                        phong.MaLoaiTinhTrangPhong = "TP001";
                        context.SaveChanges();
                        loadData();
                        //Tra phong xuat hoa don

                    }
                }
                else
                {
                    MessageBox.Show("Phiếu thuê phòng này đã thanh toán", "Thông tin");
                }
            }
        }

        private void icoBtnInphieuthue_Click(object sender, EventArgs e)
        {
            try
            {
                HOA_DON hd = context.HOA_DON.FirstOrDefault(p => p.MaThuePhong == maThuePhong);
                if (hd == null)
                {
                    throw new Exception("Phiếu thuê này chưa thanh toán");
                }

                if (maThuePhong.Equals(string.Empty))
                    throw new Exception("Vui lòng chọn phiếu thuê cần xuất");
                ClassReport.ReportInfo info = new ClassReport.ReportInfo();
                info.ID = maThuePhong;
                info.pIDRoom = context.CHI_TIET_PHIEU_THUE_PHONG.Where(p => p.MaThuePhong.Equals(maThuePhong)).Select(p => p.MaPhong).FirstOrDefault();
                info.pName = context.CHI_TIET_PHIEU_THUE_PHONG.Where(p => p.MaThuePhong.Equals(maThuePhong)).Select(p => p.HoTenKhachHang).FirstOrDefault();
                info.pDateFrom = context.CHI_TIET_PHIEU_THUE_PHONG.Where(p => p.MaThuePhong.Equals(maThuePhong)).Select(p => p.NgayNhan).FirstOrDefault();
                info.pDateTo = context.CHI_TIET_PHIEU_THUE_PHONG.Where(p => p.MaThuePhong.Equals(maThuePhong)).Select(p => p.NgayTra).FirstOrDefault();
                info.pTienPhong = double.Parse(context.HOA_DON.Where(p=>p.MaThuePhong.Equals(maThuePhong)).Select(p=>p.TongTien).FirstOrDefault().ToString());

                FormReport.ReportPhieuThue Frm = new FormReport.ReportPhieuThue(info);
                Frm.DataSource = context.DANH_SACH_SU_DUNG_DICH_VU.Join
                    (
                        context.DICH_VU,
                        DS => DS.MaDichVu,
                        DV => DV.MaDichVu,
                        (DS, DV) => new { DS, DV }
                    )
                    .Where(p => p.DS.MaThuePhong.Equals(maThuePhong))
                    .Select
                    (
                        p => new
                        {
                            TenDichVu = p.DV.TenDichVu,
                            SoLuong = p.DS.SoLuong,
                            DonGia = p.DV.DonGia,
                            ThanhTien = p.DV.DonGia*p.DS.SoLuong,
                        }
                    ).ToList();
                frmReportViewer Rpv = new frmReportViewer(Frm);
                Rpv.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
