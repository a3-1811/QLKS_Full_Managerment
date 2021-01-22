namespace QUANLYKHACHSAN
{
    partial class frmPhieuthue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuthue));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gridControlPhieuthue = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaThuePhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTraDuKien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.icoBtnTraphong = new FontAwesome.Sharp.IconButton();
            this.icoBtnInphieuthue = new FontAwesome.Sharp.IconButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.icoBtnThemdichvu = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNhanVienLap = new System.Windows.Forms.TextBox();
            this.iconBtnDatPhong = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuthue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlPhieuthue
            // 
            this.gridControlPhieuthue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPhieuthue.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlPhieuthue.Location = new System.Drawing.Point(17, 30);
            this.gridControlPhieuthue.MainView = this.gridView1;
            this.gridControlPhieuthue.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlPhieuthue.Name = "gridControlPhieuthue";
            this.gridControlPhieuthue.Size = new System.Drawing.Size(604, 359);
            this.gridControlPhieuthue.TabIndex = 22;
            this.gridControlPhieuthue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaThuePhong,
            this.colMaPhong,
            this.colTenKhachHang,
            this.colNgayTra,
            this.colNgayNhan,
            this.colNgayTraDuKien});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlPhieuthue;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaThuePhong
            // 
            this.colMaThuePhong.Caption = "Mã Thuê";
            this.colMaThuePhong.FieldName = "MaThuePhong";
            this.colMaThuePhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMaThuePhong.ImageOptions.Image")));
            this.colMaThuePhong.MinWidth = 19;
            this.colMaThuePhong.Name = "colMaThuePhong";
            this.colMaThuePhong.OptionsColumn.AllowEdit = false;
            this.colMaThuePhong.OptionsColumn.ReadOnly = true;
            this.colMaThuePhong.Visible = true;
            this.colMaThuePhong.VisibleIndex = 0;
            this.colMaThuePhong.Width = 100;
            // 
            // colMaPhong
            // 
            this.colMaPhong.Caption = "Mã Phòng";
            this.colMaPhong.FieldName = "MaPhong";
            this.colMaPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMaPhong.ImageOptions.Image")));
            this.colMaPhong.MinWidth = 19;
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.OptionsColumn.AllowEdit = false;
            this.colMaPhong.OptionsColumn.ReadOnly = true;
            this.colMaPhong.Visible = true;
            this.colMaPhong.VisibleIndex = 1;
            this.colMaPhong.Width = 145;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.Caption = "Tên Khách Hàng";
            this.colTenKhachHang.FieldName = "HoTenKhachHang";
            this.colTenKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTenKhachHang.ImageOptions.Image")));
            this.colTenKhachHang.MinWidth = 19;
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.OptionsColumn.AllowEdit = false;
            this.colTenKhachHang.OptionsColumn.ReadOnly = true;
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 2;
            this.colTenKhachHang.Width = 150;
            // 
            // colNgayTra
            // 
            this.colNgayTra.Caption = "Trả Lúc";
            this.colNgayTra.FieldName = "NgayTra";
            this.colNgayTra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNgayTra.ImageOptions.Image")));
            this.colNgayTra.MinWidth = 19;
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.OptionsColumn.AllowEdit = false;
            this.colNgayTra.OptionsColumn.ReadOnly = true;
            this.colNgayTra.Visible = true;
            this.colNgayTra.VisibleIndex = 5;
            this.colNgayTra.Width = 142;
            // 
            // colNgayNhan
            // 
            this.colNgayNhan.Caption = "Vào Lúc";
            this.colNgayNhan.FieldName = "NgayNhan";
            this.colNgayNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNgayNhan.ImageOptions.Image")));
            this.colNgayNhan.MinWidth = 19;
            this.colNgayNhan.Name = "colNgayNhan";
            this.colNgayNhan.OptionsColumn.AllowEdit = false;
            this.colNgayNhan.OptionsColumn.ReadOnly = true;
            this.colNgayNhan.Visible = true;
            this.colNgayNhan.VisibleIndex = 3;
            this.colNgayNhan.Width = 141;
            // 
            // colNgayTraDuKien
            // 
            this.colNgayTraDuKien.Caption = "Ngày Trả Dự Kiến";
            this.colNgayTraDuKien.FieldName = "NgayTraDuKien";
            this.colNgayTraDuKien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNgayTraDuKien.ImageOptions.Image")));
            this.colNgayTraDuKien.MinWidth = 19;
            this.colNgayTraDuKien.Name = "colNgayTraDuKien";
            this.colNgayTraDuKien.OptionsColumn.AllowEdit = false;
            this.colNgayTraDuKien.OptionsColumn.ReadOnly = true;
            this.colNgayTraDuKien.Visible = true;
            this.colNgayTraDuKien.VisibleIndex = 4;
            this.colNgayTraDuKien.Width = 133;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.icoBtnTraphong);
            this.groupBox3.Controls.Add(this.icoBtnInphieuthue);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 482);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(999, 69);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // icoBtnTraphong
            // 
            this.icoBtnTraphong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnTraphong.FlatAppearance.BorderSize = 0;
            this.icoBtnTraphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnTraphong.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnTraphong.ForeColor = System.Drawing.Color.Black;
            this.icoBtnTraphong.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.icoBtnTraphong.IconColor = System.Drawing.Color.Black;
            this.icoBtnTraphong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnTraphong.IconSize = 35;
            this.icoBtnTraphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnTraphong.Location = new System.Drawing.Point(838, 24);
            this.icoBtnTraphong.Name = "icoBtnTraphong";
            this.icoBtnTraphong.Size = new System.Drawing.Size(130, 32);
            this.icoBtnTraphong.TabIndex = 42;
            this.icoBtnTraphong.Text = "Trả Phòng";
            this.icoBtnTraphong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnTraphong.UseVisualStyleBackColor = true;
            this.icoBtnTraphong.Click += new System.EventHandler(this.icoBtnTraphong_Click);
            // 
            // icoBtnInphieuthue
            // 
            this.icoBtnInphieuthue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnInphieuthue.FlatAppearance.BorderSize = 0;
            this.icoBtnInphieuthue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnInphieuthue.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnInphieuthue.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnInphieuthue.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icoBtnInphieuthue.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnInphieuthue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnInphieuthue.IconSize = 35;
            this.icoBtnInphieuthue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnInphieuthue.Location = new System.Drawing.Point(674, 24);
            this.icoBtnInphieuthue.Name = "icoBtnInphieuthue";
            this.icoBtnInphieuthue.Size = new System.Drawing.Size(158, 32);
            this.icoBtnInphieuthue.TabIndex = 41;
            this.icoBtnInphieuthue.Text = "Xuất Phiếu Thuê";
            this.icoBtnInphieuthue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnInphieuthue.UseVisualStyleBackColor = true;
            this.icoBtnInphieuthue.Click += new System.EventHandler(this.icoBtnInphieuthue_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(708, 320);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(686, 115);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số Ngày";
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.AcceptsTab = true;
            this.txtSoNgay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSoNgay.Enabled = false;
            this.txtSoNgay.Location = new System.Drawing.Point(131, 18);
            this.txtSoNgay.Multiline = true;
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.ReadOnly = true;
            this.txtSoNgay.Size = new System.Drawing.Size(210, 27);
            this.txtSoNgay.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-2, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Dùng dịch vụ";
            // 
            // icoBtnThemdichvu
            // 
            this.icoBtnThemdichvu.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.icoBtnThemdichvu.IconColor = System.Drawing.Color.Black;
            this.icoBtnThemdichvu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnThemdichvu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnThemdichvu.Location = new System.Drawing.Point(131, 72);
            this.icoBtnThemdichvu.Margin = new System.Windows.Forms.Padding(2);
            this.icoBtnThemdichvu.Name = "icoBtnThemdichvu";
            this.icoBtnThemdichvu.Size = new System.Drawing.Size(192, 52);
            this.icoBtnThemdichvu.TabIndex = 31;
            this.icoBtnThemdichvu.Text = "Thêm dịch vụ";
            this.icoBtnThemdichvu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnThemdichvu.UseVisualStyleBackColor = true;
            this.icoBtnThemdichvu.Click += new System.EventHandler(this.icoBtnThemdichvu_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 19);
            this.label14.TabIndex = 36;
            this.label14.Text = "Nhân viên lập";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtNhanVienLap);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.icoBtnThemdichvu);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSoNgay);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(628, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(356, 274);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // txtNhanVienLap
            // 
            this.txtNhanVienLap.AcceptsTab = true;
            this.txtNhanVienLap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNhanVienLap.Enabled = false;
            this.txtNhanVienLap.Location = new System.Drawing.Point(131, 140);
            this.txtNhanVienLap.Multiline = true;
            this.txtNhanVienLap.Name = "txtNhanVienLap";
            this.txtNhanVienLap.ReadOnly = true;
            this.txtNhanVienLap.Size = new System.Drawing.Size(210, 27);
            this.txtNhanVienLap.TabIndex = 37;
            // 
            // iconBtnDatPhong
            // 
            this.iconBtnDatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnDatPhong.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconBtnDatPhong.FlatAppearance.BorderSize = 0;
            this.iconBtnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDatPhong.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnDatPhong.ForeColor = System.Drawing.Color.Black;
            this.iconBtnDatPhong.IconChar = FontAwesome.Sharp.IconChar.SadCry;
            this.iconBtnDatPhong.IconColor = System.Drawing.Color.Black;
            this.iconBtnDatPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnDatPhong.IconSize = 35;
            this.iconBtnDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDatPhong.Location = new System.Drawing.Point(847, 30);
            this.iconBtnDatPhong.Name = "iconBtnDatPhong";
            this.iconBtnDatPhong.Size = new System.Drawing.Size(137, 55);
            this.iconBtnDatPhong.TabIndex = 43;
            this.iconBtnDatPhong.Text = "Đặt Phòng";
            this.iconBtnDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDatPhong.UseVisualStyleBackColor = false;
            this.iconBtnDatPhong.Click += new System.EventHandler(this.iconBtnDatPhong_Click);
            // 
            // frmPhieuthue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconBtnDatPhong);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gridControlPhieuthue);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPhieuthue";
            this.Size = new System.Drawing.Size(999, 551);
            this.Load += new System.EventHandler(this.frmPhieuthue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuthue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.GridControl gridControlPhieuthue;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaThuePhong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTra;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhan;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton icoBtnInphieuthue;
        private FontAwesome.Sharp.IconButton icoBtnTraphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton icoBtnThemdichvu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTraDuKien;
        private System.Windows.Forms.TextBox txtNhanVienLap;
        private FontAwesome.Sharp.IconButton iconBtnDatPhong;
    }
}
