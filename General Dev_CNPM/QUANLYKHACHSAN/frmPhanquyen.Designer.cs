namespace QUANLYKHACHSAN
{
    partial class frmPhanquyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanquyen));
            this.lblDanhsachnguoidung = new System.Windows.Forms.Label();
            this.lblTendangnhaphethong = new System.Windows.Forms.Label();
            this.lblMatkhauhethong = new System.Windows.Forms.Label();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.txtTendangnhaphethong = new System.Windows.Forms.TextBox();
            this.txtMatkhauhethong = new System.Windows.Forms.TextBox();
            this.cboChucvu = new System.Windows.Forms.ComboBox();
            this.icoBtnThem = new FontAwesome.Sharp.IconButton();
            this.icoBtnSua = new FontAwesome.Sharp.IconButton();
            this.icoBtnXoa = new FontAwesome.Sharp.IconButton();
            this.gridControlPhanquyen = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhanquyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDanhsachnguoidung
            // 
            this.lblDanhsachnguoidung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDanhsachnguoidung.AutoSize = true;
            this.lblDanhsachnguoidung.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhsachnguoidung.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhsachnguoidung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDanhsachnguoidung.Location = new System.Drawing.Point(230, 19);
            this.lblDanhsachnguoidung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhsachnguoidung.Name = "lblDanhsachnguoidung";
            this.lblDanhsachnguoidung.Size = new System.Drawing.Size(439, 39);
            this.lblDanhsachnguoidung.TabIndex = 1;
            this.lblDanhsachnguoidung.Text = "DANH SÁCH NGƯỜI DÙNG";
            // 
            // lblTendangnhaphethong
            // 
            this.lblTendangnhaphethong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTendangnhaphethong.AutoSize = true;
            this.lblTendangnhaphethong.BackColor = System.Drawing.Color.Transparent;
            this.lblTendangnhaphethong.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTendangnhaphethong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTendangnhaphethong.Location = new System.Drawing.Point(58, 19);
            this.lblTendangnhaphethong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTendangnhaphethong.Name = "lblTendangnhaphethong";
            this.lblTendangnhaphethong.Size = new System.Drawing.Size(173, 23);
            this.lblTendangnhaphethong.TabIndex = 2;
            this.lblTendangnhaphethong.Text = "TÊN ĐĂNG NHẬP";
            // 
            // lblMatkhauhethong
            // 
            this.lblMatkhauhethong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatkhauhethong.AutoSize = true;
            this.lblMatkhauhethong.BackColor = System.Drawing.Color.Transparent;
            this.lblMatkhauhethong.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhauhethong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMatkhauhethong.Location = new System.Drawing.Point(58, 63);
            this.lblMatkhauhethong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatkhauhethong.Name = "lblMatkhauhethong";
            this.lblMatkhauhethong.Size = new System.Drawing.Size(113, 23);
            this.lblMatkhauhethong.TabIndex = 3;
            this.lblMatkhauhethong.Text = "MẬT KHẨU";
            // 
            // lblChucvu
            // 
            this.lblChucvu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChucvu.AutoSize = true;
            this.lblChucvu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucvu.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChucvu.Location = new System.Drawing.Point(58, 111);
            this.lblChucvu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(99, 23);
            this.lblChucvu.TabIndex = 4;
            this.lblChucvu.Text = "CHỨC VỤ";
            // 
            // txtTendangnhaphethong
            // 
            this.txtTendangnhaphethong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTendangnhaphethong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTendangnhaphethong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTendangnhaphethong.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTendangnhaphethong.Location = new System.Drawing.Point(239, 19);
            this.txtTendangnhaphethong.Name = "txtTendangnhaphethong";
            this.txtTendangnhaphethong.Size = new System.Drawing.Size(277, 23);
            this.txtTendangnhaphethong.TabIndex = 5;
            // 
            // txtMatkhauhethong
            // 
            this.txtMatkhauhethong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatkhauhethong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatkhauhethong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMatkhauhethong.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatkhauhethong.Location = new System.Drawing.Point(239, 63);
            this.txtMatkhauhethong.Name = "txtMatkhauhethong";
            this.txtMatkhauhethong.Size = new System.Drawing.Size(277, 23);
            this.txtMatkhauhethong.TabIndex = 6;
            // 
            // cboChucvu
            // 
            this.cboChucvu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucvu.FormattingEnabled = true;
            this.cboChucvu.Location = new System.Drawing.Point(239, 107);
            this.cboChucvu.Margin = new System.Windows.Forms.Padding(2);
            this.cboChucvu.Name = "cboChucvu";
            this.cboChucvu.Size = new System.Drawing.Size(278, 25);
            this.cboChucvu.TabIndex = 7;
            // 
            // icoBtnThem
            // 
            this.icoBtnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.icoBtnThem.AutoSize = true;
            this.icoBtnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.icoBtnThem.FlatAppearance.BorderSize = 0;
            this.icoBtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnThem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnThem.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.icoBtnThem.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnThem.IconSize = 35;
            this.icoBtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnThem.Location = new System.Drawing.Point(161, 168);
            this.icoBtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnThem.Name = "icoBtnThem";
            this.icoBtnThem.Size = new System.Drawing.Size(93, 41);
            this.icoBtnThem.TabIndex = 9;
            this.icoBtnThem.Text = "Thêm";
            this.icoBtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnThem.UseVisualStyleBackColor = true;
            this.icoBtnThem.Click += new System.EventHandler(this.icoBtnThem_Click);
            // 
            // icoBtnSua
            // 
            this.icoBtnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.icoBtnSua.AutoSize = true;
            this.icoBtnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.icoBtnSua.FlatAppearance.BorderSize = 0;
            this.icoBtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnSua.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnSua.ForeColor = System.Drawing.Color.DarkBlue;
            this.icoBtnSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.icoBtnSua.IconColor = System.Drawing.Color.DarkBlue;
            this.icoBtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnSua.IconSize = 35;
            this.icoBtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnSua.Location = new System.Drawing.Point(310, 168);
            this.icoBtnSua.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnSua.Name = "icoBtnSua";
            this.icoBtnSua.Size = new System.Drawing.Size(82, 41);
            this.icoBtnSua.TabIndex = 10;
            this.icoBtnSua.Text = "Sửa";
            this.icoBtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnSua.UseVisualStyleBackColor = true;
            this.icoBtnSua.Click += new System.EventHandler(this.icoBtnSua_Click);
            // 
            // icoBtnXoa
            // 
            this.icoBtnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.icoBtnXoa.AutoSize = true;
            this.icoBtnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.icoBtnXoa.FlatAppearance.BorderSize = 0;
            this.icoBtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnXoa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.icoBtnXoa.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.icoBtnXoa.IconColor = System.Drawing.Color.DarkRed;
            this.icoBtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnXoa.IconSize = 35;
            this.icoBtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnXoa.Location = new System.Drawing.Point(452, 168);
            this.icoBtnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnXoa.Name = "icoBtnXoa";
            this.icoBtnXoa.Size = new System.Drawing.Size(81, 41);
            this.icoBtnXoa.TabIndex = 11;
            this.icoBtnXoa.Text = "Xoá";
            this.icoBtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnXoa.UseVisualStyleBackColor = true;
            this.icoBtnXoa.Click += new System.EventHandler(this.icoBtnXoa_Click);
            // 
            // gridControlPhanquyen
            // 
            this.gridControlPhanquyen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPhanquyen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlPhanquyen.Location = new System.Drawing.Point(105, 304);
            this.gridControlPhanquyen.MainView = this.gridView1;
            this.gridControlPhanquyen.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlPhanquyen.Name = "gridControlPhanquyen";
            this.gridControlPhanquyen.Size = new System.Drawing.Size(666, 315);
            this.gridControlPhanquyen.TabIndex = 17;
            this.gridControlPhanquyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDangNhap,
            this.colMatKhau,
            this.colMaChucVu,
            this.colTenChucVu});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlPhanquyen;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.Caption = "Tên Đăng Nhập";
            this.colTenDangNhap.FieldName = "TenDangNhap";
            this.colTenDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTenDangNhap.ImageOptions.Image")));
            this.colTenDangNhap.MinWidth = 19;
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.OptionsColumn.ReadOnly = true;
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 0;
            this.colTenDangNhap.Width = 70;
            // 
            // colMatKhau
            // 
            this.colMatKhau.Caption = "Mật Khẩu";
            this.colMatKhau.DisplayFormat.FormatString = "*";
            this.colMatKhau.FieldName = "MatKhau";
            this.colMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMatKhau.ImageOptions.Image")));
            this.colMatKhau.MinWidth = 19;
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.OptionsColumn.ReadOnly = true;
            this.colMatKhau.Visible = true;
            this.colMatKhau.VisibleIndex = 1;
            this.colMatKhau.Width = 70;
            // 
            // colMaChucVu
            // 
            this.colMaChucVu.Caption = "Mã Chức Vụ";
            this.colMaChucVu.FieldName = "MaChucVu";
            this.colMaChucVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMaChucVu.ImageOptions.Image")));
            this.colMaChucVu.MinWidth = 19;
            this.colMaChucVu.Name = "colMaChucVu";
            this.colMaChucVu.OptionsColumn.ReadOnly = true;
            this.colMaChucVu.Visible = true;
            this.colMaChucVu.VisibleIndex = 2;
            this.colMaChucVu.Width = 70;
            // 
            // colTenChucVu
            // 
            this.colTenChucVu.Caption = "Tên Chức Vụ";
            this.colTenChucVu.FieldName = "TenChucVu";
            this.colTenChucVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTenChucVu.ImageOptions.Image")));
            this.colTenChucVu.MinWidth = 19;
            this.colTenChucVu.Name = "colTenChucVu";
            this.colTenChucVu.OptionsColumn.ReadOnly = true;
            this.colTenChucVu.Visible = true;
            this.colTenChucVu.VisibleIndex = 3;
            this.colTenChucVu.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.icoBtnXoa);
            this.groupBox1.Controls.Add(this.icoBtnSua);
            this.groupBox1.Controls.Add(this.icoBtnThem);
            this.groupBox1.Controls.Add(this.cboChucvu);
            this.groupBox1.Controls.Add(this.txtMatkhauhethong);
            this.groupBox1.Controls.Add(this.txtTendangnhaphethong);
            this.groupBox1.Controls.Add(this.lblChucvu);
            this.groupBox1.Controls.Add(this.lblMatkhauhethong);
            this.groupBox1.Controls.Add(this.lblTendangnhaphethong);
            this.groupBox1.Location = new System.Drawing.Point(107, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 226);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // frmPhanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControlPhanquyen);
            this.Controls.Add(this.lblDanhsachnguoidung);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPhanquyen";
            this.Size = new System.Drawing.Size(856, 644);
            this.Load += new System.EventHandler(this.frmPhanquyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhanquyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhsachnguoidung;
        private System.Windows.Forms.Label lblTendangnhaphethong;
        private System.Windows.Forms.Label lblMatkhauhethong;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.TextBox txtTendangnhaphethong;
        private System.Windows.Forms.TextBox txtMatkhauhethong;
        private System.Windows.Forms.ComboBox cboChucvu;
        private FontAwesome.Sharp.IconButton icoBtnThem;
        private FontAwesome.Sharp.IconButton icoBtnSua;
        private FontAwesome.Sharp.IconButton icoBtnXoa;
        private DevExpress.XtraGrid.GridControl gridControlPhanquyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
