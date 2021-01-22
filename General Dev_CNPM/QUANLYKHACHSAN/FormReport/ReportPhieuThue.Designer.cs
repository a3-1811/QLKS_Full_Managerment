namespace QUANLYKHACHSAN.FormReport
{
    partial class ReportPhieuThue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label10 = new DevExpress.XtraReports.UI.XRLabel();
            this.label11 = new DevExpress.XtraReports.UI.XRLabel();
            this.label14 = new DevExpress.XtraReports.UI.XRLabel();
            this.label15 = new DevExpress.XtraReports.UI.XRLabel();
            this.label16 = new DevExpress.XtraReports.UI.XRLabel();
            this.label17 = new DevExpress.XtraReports.UI.XRLabel();
            this.label18 = new DevExpress.XtraReports.UI.XRLabel();
            this.label19 = new DevExpress.XtraReports.UI.XRLabel();
            this.label20 = new DevExpress.XtraReports.UI.XRLabel();
            this.label21 = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellSL = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellDG = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.pID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pIDRoom = new DevExpress.XtraReports.Parameters.Parameter();
            this.pName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pDateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.pDateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.pTienPhong = new DevExpress.XtraReports.Parameters.Parameter();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4,
            this.table1,
            this.label10,
            this.label11,
            this.label14,
            this.label15,
            this.label16,
            this.label17,
            this.label18,
            this.label19,
            this.label20,
            this.label21,
            this.label1});
            this.TopMargin.HeightF = 328.125F;
            this.TopMargin.Name = "TopMargin";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(383.7916F, 229.1667F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(138.5417F, 35.41666F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Tiền phòng";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pTienPhong")});
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(536.9166F, 229.1667F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(202.0833F, 35.41666F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "Mã phòng";
            this.xrLabel4.TextFormatString = "{0:c0}";
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(1.624997F, 289.5833F);
            this.table1.Name = "table1";
            this.table1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(747.3751F, 38.54166F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2,
            this.xrTableCell1,
            this.xrTableCell4,
            this.tableCell3});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // tableCell1
            // 
            this.tableCell1.Font = new System.Drawing.Font("Arial", 13.75F);
            this.tableCell1.Multiline = true;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StylePriority.UseFont = false;
            this.tableCell1.StylePriority.UseTextAlignment = false;
            this.tableCell1.Text = "STT";
            this.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tableCell1.Weight = 0.322704675090027D;
            // 
            // tableCell2
            // 
            this.tableCell2.Font = new System.Drawing.Font("Arial", 13.75F);
            this.tableCell2.Multiline = true;
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StylePriority.UseFont = false;
            this.tableCell2.StylePriority.UseTextAlignment = false;
            this.tableCell2.Text = "Tên dịch vụ";
            this.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tableCell2.Weight = 2.5768613168752519D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new System.Drawing.Font("Arial", 13.75F);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Số lượng";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.77772933294469448D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Arial", 13.75F);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Đơn giá";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 0.77772933294469448D;
            // 
            // tableCell3
            // 
            this.tableCell3.Font = new System.Drawing.Font("Arial", 13.75F);
            this.tableCell3.Multiline = true;
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StylePriority.UseFont = false;
            this.tableCell3.StylePriority.UseTextAlignment = false;
            this.tableCell3.Text = "Thành tiền";
            this.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tableCell3.Weight = 0.99966598396098971D;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.LocationFloat = new DevExpress.Utils.PointFloat(1.041635F, 119.7917F);
            this.label10.Multiline = true;
            this.label10.Name = "label10";
            this.label10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label10.SizeF = new System.Drawing.SizeF(138.5417F, 35.41666F);
            this.label10.StylePriority.UseFont = false;
            this.label10.Text = "Mã phiếu thuê phòng";
            // 
            // label11
            // 
            this.label11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pID")});
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.LocationFloat = new DevExpress.Utils.PointFloat(154.1666F, 119.7917F);
            this.label11.Multiline = true;
            this.label11.Name = "label11";
            this.label11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label11.SizeF = new System.Drawing.SizeF(202.0833F, 35.41666F);
            this.label11.StylePriority.UseFont = false;
            this.label11.Text = "Mã phiếu thuê phòng";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.LocationFloat = new DevExpress.Utils.PointFloat(383.7916F, 119.7917F);
            this.label14.Multiline = true;
            this.label14.Name = "label14";
            this.label14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label14.SizeF = new System.Drawing.SizeF(138.5417F, 35.41666F);
            this.label14.StylePriority.UseFont = false;
            this.label14.Text = "Ngày đến";
            // 
            // label15
            // 
            this.label15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pDateFrom")});
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.LocationFloat = new DevExpress.Utils.PointFloat(536.9167F, 119.7917F);
            this.label15.Multiline = true;
            this.label15.Name = "label15";
            this.label15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label15.SizeF = new System.Drawing.SizeF(202.0833F, 35.41666F);
            this.label15.StylePriority.UseFont = false;
            this.label15.Text = "Mã phiếu thuê phòng";
            // 
            // label16
            // 
            this.label16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pDateTo")});
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.LocationFloat = new DevExpress.Utils.PointFloat(535.875F, 170.8333F);
            this.label16.Multiline = true;
            this.label16.Name = "label16";
            this.label16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label16.SizeF = new System.Drawing.SizeF(202.0833F, 35.41666F);
            this.label16.StylePriority.UseFont = false;
            this.label16.Text = "Mã phòng";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.LocationFloat = new DevExpress.Utils.PointFloat(382.75F, 170.8333F);
            this.label17.Multiline = true;
            this.label17.Name = "label17";
            this.label17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label17.SizeF = new System.Drawing.SizeF(138.5417F, 35.41666F);
            this.label17.StylePriority.UseFont = false;
            this.label17.Text = "Ngày trả";
            // 
            // label18
            // 
            this.label18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pIDRoom")});
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.LocationFloat = new DevExpress.Utils.PointFloat(153.125F, 170.8333F);
            this.label18.Multiline = true;
            this.label18.Name = "label18";
            this.label18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label18.SizeF = new System.Drawing.SizeF(202.0833F, 35.41666F);
            this.label18.StylePriority.UseFont = false;
            this.label18.Text = "Mã phòng";
            // 
            // label19
            // 
            this.label19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pName")});
            this.label19.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.LocationFloat = new DevExpress.Utils.PointFloat(153.125F, 229.1667F);
            this.label19.Multiline = true;
            this.label19.Name = "label19";
            this.label19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label19.SizeF = new System.Drawing.SizeF(202.0833F, 35.41666F);
            this.label19.StylePriority.UseFont = false;
            this.label19.Text = "Tên khách hàng";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.LocationFloat = new DevExpress.Utils.PointFloat(0F, 229.1667F);
            this.label20.Multiline = true;
            this.label20.Name = "label20";
            this.label20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label20.SizeF = new System.Drawing.SizeF(138.5417F, 35.41666F);
            this.label20.StylePriority.UseFont = false;
            this.label20.Text = "Tên khách hàng";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.LocationFloat = new DevExpress.Utils.PointFloat(0F, 170.8333F);
            this.label21.Multiline = true;
            this.label21.Name = "label21";
            this.label21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label21.SizeF = new System.Drawing.SizeF(138.5417F, 35.41666F);
            this.label21.StylePriority.UseFont = false;
            this.label21.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(242.7084F, 10.00001F);
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(257.2916F, 74.04168F);
            this.label1.StylePriority.UseFont = false;
            this.label1.Text = "PHIẾU THUÊ";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.Detail.HeightF = 38.5417F;
            this.Detail.Name = "Detail";
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(1.625021F, 0F);
            this.table2.Name = "table2";
            this.table2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(747.3751F, 38.54166F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell4,
            this.tableCell5,
            this.cellSL,
            this.cellDG,
            this.tableCell6});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 1D;
            // 
            // tableCell4
            // 
            this.tableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex] + 1")});
            this.tableCell4.Font = new System.Drawing.Font("Arial", 13.75F);
            this.tableCell4.Multiline = true;
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StylePriority.UseFont = false;
            this.tableCell4.StylePriority.UseTextAlignment = false;
            this.tableCell4.Text = "STT";
            this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tableCell4.Weight = 0.322704675090027D;
            // 
            // tableCell5
            // 
            this.tableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TenDichVu]")});
            this.tableCell5.Font = new System.Drawing.Font("Arial", 13.75F);
            this.tableCell5.Multiline = true;
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StylePriority.UseFont = false;
            this.tableCell5.StylePriority.UseTextAlignment = false;
            this.tableCell5.Text = "Tên dịch vụ";
            this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell5.Weight = 2.5768609349263762D;
            // 
            // cellSL
            // 
            this.cellSL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SoLuong]")});
            this.cellSL.Font = new System.Drawing.Font("Arial", 13.75F);
            this.cellSL.Multiline = true;
            this.cellSL.Name = "cellSL";
            this.cellSL.StylePriority.UseFont = false;
            this.cellSL.StylePriority.UseTextAlignment = false;
            this.cellSL.Text = "cellSL";
            this.cellSL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellSL.Weight = 0.77772971489357023D;
            // 
            // cellDG
            // 
            this.cellDG.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DonGia]")});
            this.cellDG.Font = new System.Drawing.Font("Arial", 13.75F);
            this.cellDG.Multiline = true;
            this.cellDG.Name = "cellDG";
            this.cellDG.StylePriority.UseFont = false;
            this.cellDG.StylePriority.UseTextAlignment = false;
            this.cellDG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.cellDG.TextFormatString = "{0:c0}";
            this.cellDG.Weight = 0.77772971489357023D;
            // 
            // tableCell6
            // 
            this.tableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ThanhTien]")});
            this.tableCell6.Font = new System.Drawing.Font("Arial", 13.75F);
            this.tableCell6.Multiline = true;
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StylePriority.UseFont = false;
            this.tableCell6.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.tableCell6.Summary = xrSummary1;
            this.tableCell6.Text = "Chi phí";
            this.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell6.TextFormatString = "{0:c0}";
            this.tableCell6.Weight = 0.99966598396098971D;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel1,
            this.xrLabel2});
            this.BottomMargin.HeightF = 270.2499F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(382.7499F, 115.2083F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(138.5417F, 35.41666F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "Tổng chi phí";
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([ThanhTien]) + ?pTienPhong")});
            this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(535.875F, 115.2083F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(202.0833F, 35.41666F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Chi phí";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel8.TextFormatString = "{0:c0}";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(382.7499F, 67.29167F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(138.5417F, 35.41666F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "Tiền phòng";
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pTienPhong")});
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(535.875F, 67.29167F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(202.0833F, 35.41666F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel6.Summary = xrSummary2;
            this.xrLabel6.Text = "Mã phiếu thuê phòng";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel6.TextFormatString = "{0:c0}";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(382.7499F, 20.41667F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(138.5417F, 35.41666F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Tiền dịch vụ";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([ThanhTien])")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(535.875F, 20.41667F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(202.0833F, 35.41666F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel2.Summary = xrSummary3;
            this.xrLabel2.Text = "Mã phiếu thuê phòng";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel2.TextFormatString = "{0:c0}";
            // 
            // pID
            // 
            this.pID.Description = "ID phieu thue";
            this.pID.Name = "pID";
            // 
            // pIDRoom
            // 
            this.pIDRoom.Description = "ID phòng";
            this.pIDRoom.Name = "pIDRoom";
            // 
            // pName
            // 
            this.pName.Description = "Tên KH";
            this.pName.Name = "pName";
            // 
            // pDateFrom
            // 
            this.pDateFrom.Description = "Ngày đến";
            this.pDateFrom.Name = "pDateFrom";
            this.pDateFrom.Type = typeof(System.DateTime);
            this.pDateFrom.ValueInfo = "2021-01-20";
            // 
            // pDateTo
            // 
            this.pDateTo.Description = "Ngày đi";
            this.pDateTo.Name = "pDateTo";
            this.pDateTo.Type = typeof(System.DateTime);
            this.pDateTo.ValueInfo = "2021-01-20";
            // 
            // pTienPhong
            // 
            this.pTienPhong.Description = "TienPhong";
            this.pTienPhong.Name = "pTienPhong";
            this.pTienPhong.Type = typeof(double);
            this.pTienPhong.ValueInfo = "0";
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(QUANLYKHACHSAN.ClassReport.ReportDataPhieuThue);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // ReportPhieuThue
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(39, 39, 328, 270);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pID,
            this.pIDRoom,
            this.pName,
            this.pDateFrom,
            this.pDateTo,
            this.pTienPhong});
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRLabel label10;
        private DevExpress.XtraReports.UI.XRLabel label11;
        private DevExpress.XtraReports.UI.XRLabel label14;
        private DevExpress.XtraReports.UI.XRLabel label15;
        private DevExpress.XtraReports.UI.XRLabel label16;
        private DevExpress.XtraReports.UI.XRLabel label17;
        private DevExpress.XtraReports.UI.XRLabel label18;
        private DevExpress.XtraReports.UI.XRLabel label19;
        private DevExpress.XtraReports.UI.XRLabel label20;
        private DevExpress.XtraReports.UI.XRLabel label21;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableCell cellSL;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.Parameters.Parameter pID;
        private DevExpress.XtraReports.Parameters.Parameter pIDRoom;
        private DevExpress.XtraReports.Parameters.Parameter pName;
        private DevExpress.XtraReports.Parameters.Parameter pDateFrom;
        private DevExpress.XtraReports.Parameters.Parameter pDateTo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.Parameters.Parameter pTienPhong;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell cellDG;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
    }
}
