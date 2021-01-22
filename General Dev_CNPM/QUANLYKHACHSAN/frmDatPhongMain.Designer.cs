namespace QUANLYKHACHSAN
{
    partial class frmDatPhongMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatPhongMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.icoBtnHuy = new FontAwesome.Sharp.IconButton();
            this.icoBtnDatphong = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTimphong = new System.Windows.Forms.TextBox();
            this.cboHoTen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.icoBtnTimphong = new FontAwesome.Sharp.IconButton();
            this.dtpNgaydi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayden = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSonguoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiphong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoNguoiToiDa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlPhong = new DevExpress.XtraGrid.GridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.icoBtnHuy);
            this.panel1.Controls.Add(this.icoBtnDatphong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 71);
            this.panel1.TabIndex = 8;
            // 
            // icoBtnHuy
            // 
            this.icoBtnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnHuy.FlatAppearance.BorderSize = 0;
            this.icoBtnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnHuy.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnHuy.ForeColor = System.Drawing.Color.DarkRed;
            this.icoBtnHuy.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.icoBtnHuy.IconColor = System.Drawing.Color.DarkRed;
            this.icoBtnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnHuy.IconSize = 35;
            this.icoBtnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnHuy.Location = new System.Drawing.Point(726, 12);
            this.icoBtnHuy.Name = "icoBtnHuy";
            this.icoBtnHuy.Size = new System.Drawing.Size(90, 46);
            this.icoBtnHuy.TabIndex = 5;
            this.icoBtnHuy.Text = "Hủy";
            this.icoBtnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnHuy.UseVisualStyleBackColor = true;
            this.icoBtnHuy.Click += new System.EventHandler(this.icoBtnHuy_Click);
            // 
            // icoBtnDatphong
            // 
            this.icoBtnDatphong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnDatphong.FlatAppearance.BorderSize = 0;
            this.icoBtnDatphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnDatphong.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnDatphong.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnDatphong.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.icoBtnDatphong.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnDatphong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnDatphong.IconSize = 35;
            this.icoBtnDatphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnDatphong.Location = new System.Drawing.Point(579, 12);
            this.icoBtnDatphong.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnDatphong.Name = "icoBtnDatphong";
            this.icoBtnDatphong.Size = new System.Drawing.Size(140, 45);
            this.icoBtnDatphong.TabIndex = 10;
            this.icoBtnDatphong.Text = "Đặt Phòng";
            this.icoBtnDatphong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnDatphong.UseVisualStyleBackColor = true;
            this.icoBtnDatphong.Click += new System.EventHandler(this.icoBtnDatphong_Click);
            // 
            // txtTimphong
            // 
            this.txtTimphong.AcceptsTab = true;
            this.txtTimphong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimphong.Enabled = false;
            this.txtTimphong.Location = new System.Drawing.Point(19, 422);
            this.txtTimphong.Multiline = true;
            this.txtTimphong.Name = "txtTimphong";
            this.txtTimphong.ReadOnly = true;
            this.txtTimphong.Size = new System.Drawing.Size(269, 37);
            this.txtTimphong.TabIndex = 31;
            this.txtTimphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboHoTen
            // 
            this.cboHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoTen.FormattingEnabled = true;
            this.cboHoTen.Location = new System.Drawing.Point(20, 112);
            this.cboHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.cboHoTen.Name = "cboHoTen";
            this.cboHoTen.Size = new System.Drawing.Size(269, 26);
            this.cboHoTen.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tìm Phòng Trống";
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(100, 411);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(6, 6);
            this.iconButton2.TabIndex = 26;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // icoBtnTimphong
            // 
            this.icoBtnTimphong.Enabled = false;
            this.icoBtnTimphong.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnTimphong.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icoBtnTimphong.IconColor = System.Drawing.Color.Black;
            this.icoBtnTimphong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnTimphong.Location = new System.Drawing.Point(100, 382);
            this.icoBtnTimphong.Margin = new System.Windows.Forms.Padding(2);
            this.icoBtnTimphong.Name = "icoBtnTimphong";
            this.icoBtnTimphong.Size = new System.Drawing.Size(104, 35);
            this.icoBtnTimphong.TabIndex = 25;
            this.icoBtnTimphong.Text = "Tìm Phòng ";
            this.icoBtnTimphong.UseVisualStyleBackColor = true;
            this.icoBtnTimphong.Click += new System.EventHandler(this.icoBtnTimphong_Click);
            // 
            // dtpNgaydi
            // 
            this.dtpNgaydi.Location = new System.Drawing.Point(20, 314);
            this.dtpNgaydi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaydi.Name = "dtpNgaydi";
            this.dtpNgaydi.Size = new System.Drawing.Size(269, 26);
            this.dtpNgaydi.TabIndex = 24;
            // 
            // dtpNgayden
            // 
            this.dtpNgayden.Location = new System.Drawing.Point(20, 246);
            this.dtpNgayden.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayden.Name = "dtpNgayden";
            this.dtpNgayden.Size = new System.Drawing.Size(269, 26);
            this.dtpNgayden.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ngày đi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ngày đến";
            // 
            // txtSonguoi
            // 
            this.txtSonguoi.AcceptsTab = true;
            this.txtSonguoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSonguoi.Location = new System.Drawing.Point(20, 173);
            this.txtSonguoi.Multiline = true;
            this.txtSonguoi.Name = "txtSonguoi";
            this.txtSonguoi.Size = new System.Drawing.Size(269, 27);
            this.txtSonguoi.TabIndex = 18;
            this.txtSonguoi.TextChanged += new System.EventHandler(this.txtSonguoi_TextChanged);
            this.txtSonguoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSonguoi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số người";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Họ Tên Khách Hàng";
            // 
            // cboLoaiphong
            // 
            this.cboLoaiphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiphong.FormattingEnabled = true;
            this.cboLoaiphong.Location = new System.Drawing.Point(20, 52);
            this.cboLoaiphong.Name = "cboLoaiphong";
            this.cboLoaiphong.Size = new System.Drawing.Size(269, 26);
            this.cboLoaiphong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Phòng";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiPhong,
            this.colTenLoaiPhong,
            this.colSoNguoiToiDa,
            this.colDonGia});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlPhong;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaLoaiPhong
            // 
            this.colMaLoaiPhong.Caption = "Mã Loại Phòng";
            this.colMaLoaiPhong.FieldName = "MaLoaiPhong";
            this.colMaLoaiPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMaLoaiPhong.ImageOptions.Image")));
            this.colMaLoaiPhong.MinWidth = 19;
            this.colMaLoaiPhong.Name = "colMaLoaiPhong";
            this.colMaLoaiPhong.OptionsColumn.AllowEdit = false;
            this.colMaLoaiPhong.OptionsColumn.ReadOnly = true;
            this.colMaLoaiPhong.Visible = true;
            this.colMaLoaiPhong.VisibleIndex = 0;
            this.colMaLoaiPhong.Width = 115;
            // 
            // colTenLoaiPhong
            // 
            this.colTenLoaiPhong.Caption = "Tên loại phòng";
            this.colTenLoaiPhong.FieldName = "TenLoaiPhong";
            this.colTenLoaiPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTenLoaiPhong.ImageOptions.Image")));
            this.colTenLoaiPhong.MinWidth = 19;
            this.colTenLoaiPhong.Name = "colTenLoaiPhong";
            this.colTenLoaiPhong.OptionsColumn.AllowEdit = false;
            this.colTenLoaiPhong.OptionsColumn.ReadOnly = true;
            this.colTenLoaiPhong.Visible = true;
            this.colTenLoaiPhong.VisibleIndex = 1;
            this.colTenLoaiPhong.Width = 107;
            // 
            // colSoNguoiToiDa
            // 
            this.colSoNguoiToiDa.Caption = "Số Người Tối Đa";
            this.colSoNguoiToiDa.FieldName = "SoNguoiToiDa";
            this.colSoNguoiToiDa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSoNguoiToiDa.ImageOptions.Image")));
            this.colSoNguoiToiDa.MinWidth = 19;
            this.colSoNguoiToiDa.Name = "colSoNguoiToiDa";
            this.colSoNguoiToiDa.OptionsColumn.AllowEdit = false;
            this.colSoNguoiToiDa.OptionsColumn.ReadOnly = true;
            this.colSoNguoiToiDa.Visible = true;
            this.colSoNguoiToiDa.VisibleIndex = 2;
            this.colSoNguoiToiDa.Width = 108;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.DisplayFormat.FormatString = "c0";
            this.colDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDonGia.ImageOptions.Image")));
            this.colDonGia.MinWidth = 19;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.OptionsColumn.AllowEdit = false;
            this.colDonGia.OptionsColumn.ReadOnly = true;
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 3;
            this.colDonGia.Width = 106;
            // 
            // gridControlPhong
            // 
            this.gridControlPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPhong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlPhong.Location = new System.Drawing.Point(15, 3);
            this.gridControlPhong.MainView = this.gridView1;
            this.gridControlPhong.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlPhong.Name = "gridControlPhong";
            this.gridControlPhong.Size = new System.Drawing.Size(447, 477);
            this.gridControlPhong.TabIndex = 7;
            this.gridControlPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTimphong);
            this.groupBox1.Controls.Add(this.cboHoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.icoBtnTimphong);
            this.groupBox1.Controls.Add(this.dtpNgaydi);
            this.groupBox1.Controls.Add(this.dtpNgayden);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSonguoi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboLoaiphong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(467, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 477);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PHIẾU ĐẶT PHÒNG";
            // 
            // frmDatPhongMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 567);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControlPhong);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDatPhongMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDatPhongMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icoBtnHuy;
        private FontAwesome.Sharp.IconButton icoBtnDatphong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTimphong;
        private System.Windows.Forms.ComboBox cboHoTen;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton icoBtnTimphong;
        private System.Windows.Forms.DateTimePicker dtpNgaydi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoNguoiToiDa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSonguoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiphong;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.GridControl gridControlPhong;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}