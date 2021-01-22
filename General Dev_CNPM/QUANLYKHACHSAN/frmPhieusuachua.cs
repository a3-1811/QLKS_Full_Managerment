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
    public partial class frmPhieusuachua : UserControl
    {
        QLKS_DB context = new QLKS_DB();
        string maPSGlobal="";
        public frmPhieusuachua()
        {
            InitializeComponent();
        }
        //Load data
        public void loadData()
        {


            var ds = context.PHIEU_SUA_CHUA.Join(
                context.NHAN_VIEN,
                PSC => PSC.MaNhanVien,
                NV => NV.MaNhanVien,
                (PSC, NV) => new { PSC, NV }
                ).Join(
                context.CHI_TIET_PHIEU_SUA_CHUA,
                PN => PN.PSC.MaPhieuSua,
                CT => CT.MaPhieuSua,
                (PN, CT) => new { PN, CT }
                ).Select(p => new
                {
                    MaPhong = p.PN.PSC.MaPhong,
                    NgayBatDau = p.PN.PSC.NgayBatDau,
                    NgayKetThuc = p.PN.PSC.NgayKetThuc,
                    HoTen = p.PN.NV.HoTen,
                    PhiSuaChua = p.CT.PhiSuaChua,
                    NguyenNhan = p.PN.PSC.NguyenNhan,
                    GhiChu = p.PN.PSC.GhiChu,
                    TenThietBi = p.CT.THIET_BI.TenThietBi,
                    MaPhieuSua = p.PN.PSC.MaPhieuSua
                }).ToList();

            gridControlNhanVien.DataSource = ds;

            //Load combobox

            cboManhanvien.DataSource = context.NHAN_VIEN.ToList();
            cboManhanvien.DisplayMember = "HoTen";
            cboManhanvien.ValueMember = "MaNhanVien";

            cboMaphong.DataSource = context.PHONG.ToList();
            cboMaphong.DisplayMember = "MaPhong";
            cboMaphong.ValueMember = "MaPhong";

            cboMathietbi.DataSource = context.THIET_BI.ToList();
            cboMathietbi.DisplayMember = "TenThietBi";
            cboMathietbi.ValueMember = "MaThietBi";



        }
        private void frmPhieusuachua_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtPhisuachua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && (char)Keys.Back != e.KeyChar)
            {
                e.Handled = true;
            }
        }

        //Chuyen so thanh ma  "030" -> "NV031"
        public string convertNumbtoID(string n)
        {
            int numb = int.Parse(n);
            numb++;
            if (numb.ToString().Length == 3)
            {
                return "PS" + numb.ToString();
            }
            else if (numb.ToString().Length == 2)
            {
                return "PS0" + numb.ToString();
            }
            return "PS00" + numb.ToString();
        }

        private void icoBtnThem_Click(object sender, EventArgs e)
        {

            PHONG phongTrong = context.PHONG.FirstOrDefault(p => p.MaLoaiTinhTrangPhong == "TP003" && p.MaPhong == cboMaphong.SelectedValue.ToString());
            if (phongTrong != null)
            {
                MessageBox.Show("Phòng này đang thuê!");
            }else
            {
                DateTime ngayden = DateTime.Parse(dtpBatDau.Text.ToString());
                DateTime ngaydi = DateTime.Parse(dtpKetthuc.Text.ToString());
                int compareDate = DateTime.Compare(ngayden, ngaydi);
                if (compareDate <= 0)
                {
                    if(txtGhichu.Text == "" || txtNguyennhan.Text == "" || txtPhisuachua.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo");
                    }else
                    {
                        PHIEU_SUA_CHUA ps = context.PHIEU_SUA_CHUA.ToList().LastOrDefault();
                        PHONG phong = context.PHONG.FirstOrDefault(p=>p.MaPhong == cboMaphong.SelectedValue.ToString());
                        if (ps == null)
                        {
                            //PS001
                            string maMoi = "PS001";
                            PHIEU_SUA_CHUA phieuSC = new PHIEU_SUA_CHUA()
                            {
                                MaPhieuSua = maMoi,
                                MaNhanVien = cboManhanvien.SelectedValue.ToString(),
                                GhiChu = txtGhichu.Text,
                                MaPhong = cboMaphong.SelectedValue.ToString(),
                                NgayBatDau = DateTime.Parse(dtpBatDau.Text),
                                NgayKetThuc = DateTime.Parse(dtpKetthuc.Text),
                                NguyenNhan = txtNguyennhan.Text
                            };
                            context.PHIEU_SUA_CHUA.Add(phieuSC);
                            phong.MaLoaiTinhTrangPhong = "TP002";
                            context.SaveChanges();

                            CHI_TIET_PHIEU_SUA_CHUA ctPS = new CHI_TIET_PHIEU_SUA_CHUA()
                            {
                                MaPhieuSua = maMoi,
                                MaThietBi = cboMathietbi.SelectedValue.ToString(),
                                PhiSuaChua = int.Parse(txtPhisuachua.Text)
                            };
                            context.CHI_TIET_PHIEU_SUA_CHUA.Add(ctPS);
                            context.SaveChanges();
                            loadData();
                            MessageBox.Show("Thêm thành công!", "Cảnh báo");
                        }
                        else
                        {
                            //Them
                            string maMoi = convertNumbtoID(ps.MaPhieuSua.Replace("PS", ""));
                            PHIEU_SUA_CHUA phieuSC = new PHIEU_SUA_CHUA()
                            {
                                MaPhieuSua = maMoi,
                                MaNhanVien = cboManhanvien.SelectedValue.ToString(),
                                GhiChu = txtGhichu.Text,
                                MaPhong = cboMaphong.SelectedValue.ToString(),
                                NgayBatDau = DateTime.Parse(dtpBatDau.Text),
                                NgayKetThuc = DateTime.Parse(dtpKetthuc.Text),
                                NguyenNhan = txtNguyennhan.Text
                            };
                            context.PHIEU_SUA_CHUA.Add(phieuSC);
                            phong.MaLoaiTinhTrangPhong = "TP002";
                            context.SaveChanges();

                            CHI_TIET_PHIEU_SUA_CHUA ctPS = new CHI_TIET_PHIEU_SUA_CHUA()
                            {
                                MaPhieuSua = maMoi,
                                MaThietBi = cboMathietbi.SelectedValue.ToString(),
                                PhiSuaChua = int.Parse(txtPhisuachua.Text)
                            };
                            context.CHI_TIET_PHIEU_SUA_CHUA.Add(ctPS);
                            context.SaveChanges();
                            loadData();
                            MessageBox.Show("Thêm thành công!", "Cảnh báo");
                        }
                       
                    }
                }else
                {
                    MessageBox.Show("Ngày kết thúc không hợp lệ!","Cảnh báo");
                }
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cboMaphong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            cboManhanvien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            cboMathietbi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[7]).ToString();
            txtGhichu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString();
            txtNguyennhan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
            txtPhisuachua.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
            dtpBatDau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            dtpKetthuc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            maPSGlobal = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[8]).ToString();
        }

        private void icoBtnSua_Click(object sender, EventArgs e)
        {
            if(maPSGlobal == "")
            {
                MessageBox.Show("Chọn phiếu cần sửa!");
            }
            else
            {
                PHIEU_SUA_CHUA psc = context.PHIEU_SUA_CHUA.FirstOrDefault(p=>p.MaPhieuSua == maPSGlobal);

                psc.MaNhanVien = cboManhanvien.SelectedValue.ToString();
                psc.GhiChu = txtGhichu.Text;
                psc.MaPhong = cboMaphong.SelectedValue.ToString();
                psc.NgayBatDau = DateTime.Parse(dtpBatDau.Text);
                psc.NgayKetThuc = DateTime.Parse(dtpKetthuc.Text);
                psc.NguyenNhan = txtNguyennhan.Text;

                CHI_TIET_PHIEU_SUA_CHUA ct = context.CHI_TIET_PHIEU_SUA_CHUA.FirstOrDefault(p=>p.MaPhieuSua == maPSGlobal);

                ct.PhiSuaChua = int.Parse(txtPhisuachua.Text);


                PHONG phong = context.PHONG.FirstOrDefault(p => p.MaPhong == cboMaphong.SelectedValue.ToString());
                phong.MaLoaiTinhTrangPhong = "TP002";
                context.SaveChanges();
                loadData();
                MessageBox.Show("Sửa thành công!");

            }
        }

        private void icoBtnXoa_Click(object sender, EventArgs e)
        {
            if (maPSGlobal == "")
            {
                MessageBox.Show("Chọn phiếu cần xóa!");
            }
            else
            {
                if (MessageBox.Show("Chắc chắn muốn xóa!","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PHIEU_SUA_CHUA psc = context.PHIEU_SUA_CHUA.FirstOrDefault(p => p.MaPhieuSua == maPSGlobal);

                    context.PHIEU_SUA_CHUA.Remove(psc);
                    PHONG phong = context.PHONG.FirstOrDefault(p => p.MaPhong == cboMaphong.SelectedValue.ToString());
                    phong.MaLoaiTinhTrangPhong = "TP001";
                    context.SaveChanges();
                    loadData();
                    MessageBox.Show("Xóa thành công!");
                }
            }
        }

        private void icoBtnXuatphieusuachua_Click(object sender, EventArgs e)
        {
            FormReport.ReportPhieuSuaChua Frm = new FormReport.ReportPhieuSuaChua();
            var psc = context.PHIEU_SUA_CHUA.Join
                (
                    context.CHI_TIET_PHIEU_SUA_CHUA,
                    PSC => PSC.MaPhieuSua,
                    CT => CT.MaPhieuSua,
                    (PSC,CT) => new {PSC,CT}
                )
                .Join
                (
                    context.THIET_BI,
                    PSCCT=>PSCCT.CT.MaThietBi,
                    TB=>TB.MaThietBi,
                    (PSCCT,TB)=> new {PSCCT,TB}
                ).Join
                (
                    context.NHAN_VIEN,
                    PSCCTTB=>PSCCTTB.PSCCT.PSC.MaNhanVien,
                    NV => NV.MaNhanVien,
                    (PSCCTTB,NV) => new {PSCCTTB,NV}
                ).Select
                (
                    p=> new
                    {
                        MaPhong = p.PSCCTTB.PSCCT.PSC.MaPhong,
                        NgayBatDau = p.PSCCTTB.PSCCT.PSC.NgayBatDau,
                        NgayKetThuc = p.PSCCTTB.PSCCT.PSC.NgayKetThuc,
                        HoTen = p.NV.HoTen,
                        MaThietBi = p.PSCCTTB.TB.MaThietBi,
                        TenThietBi = p.PSCCTTB.TB.TenThietBi,
                        PhiSuaChua = p.PSCCTTB.PSCCT.CT.PhiSuaChua,
                        NguyenNhan = p.PSCCTTB.PSCCT.PSC.NguyenNhan,
                        GhiChu = p.PSCCTTB.PSCCT.PSC.GhiChu
                    }
                ).ToList();
            Frm.DataSource = psc;
            frmReportViewer Rpv = new frmReportViewer(Frm);
            Rpv.ShowDialog();
        }
    }
}
