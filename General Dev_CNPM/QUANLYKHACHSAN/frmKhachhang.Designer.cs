namespace QUANLYKHACHSAN
{
    partial class frmKhachhang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachhang));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.icoBtnXuatkhachhang = new FontAwesome.Sharp.IconButton();
            this.icoBtnThem = new FontAwesome.Sharp.IconButton();
            this.icoBtnXoa = new FontAwesome.Sharp.IconButton();
            this.icoBtnSua = new FontAwesome.Sharp.IconButton();
            this.gridControlKhachhang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboGioitinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(847, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 420);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(14, 222);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(270, 26);
            this.txtCMND.TabIndex = 24;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "CMND";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(13, 365);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(270, 26);
            this.txtSDT.TabIndex = 22;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số điện thoại";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(13, 276);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(270, 53);
            this.txtDiachi.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Địa chỉ";
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.Location = new System.Drawing.Point(16, 163);
            this.cboGioitinh.Margin = new System.Windows.Forms.Padding(2);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(270, 26);
            this.cboGioitinh.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Giới tính";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 110);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 26);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ngày Sinh";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(16, 55);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(270, 26);
            this.txtHoten.TabIndex = 14;
            this.txtHoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoten_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ và tên Khách Hàng";
            // 
            // icoBtnXuatkhachhang
            // 
            this.icoBtnXuatkhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnXuatkhachhang.FlatAppearance.BorderSize = 0;
            this.icoBtnXuatkhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnXuatkhachhang.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnXuatkhachhang.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnXuatkhachhang.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icoBtnXuatkhachhang.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnXuatkhachhang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnXuatkhachhang.IconSize = 35;
            this.icoBtnXuatkhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnXuatkhachhang.Location = new System.Drawing.Point(1055, 6);
            this.icoBtnXuatkhachhang.Name = "icoBtnXuatkhachhang";
            this.icoBtnXuatkhachhang.Size = new System.Drawing.Size(111, 46);
            this.icoBtnXuatkhachhang.TabIndex = 29;
            this.icoBtnXuatkhachhang.Text = "Xuất KH";
            this.icoBtnXuatkhachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnXuatkhachhang.UseVisualStyleBackColor = true;
            this.icoBtnXuatkhachhang.Click += new System.EventHandler(this.icoBtnXuatkhachhang_Click);
            // 
            // icoBtnThem
            // 
            this.icoBtnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnThem.FlatAppearance.BorderSize = 0;
            this.icoBtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnThem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnThem.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.icoBtnThem.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnThem.IconSize = 35;
            this.icoBtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnThem.Location = new System.Drawing.Point(779, 6);
            this.icoBtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnThem.Name = "icoBtnThem";
            this.icoBtnThem.Size = new System.Drawing.Size(91, 40);
            this.icoBtnThem.TabIndex = 10;
            this.icoBtnThem.Text = "Thêm";
            this.icoBtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnThem.UseVisualStyleBackColor = true;
            this.icoBtnThem.Click += new System.EventHandler(this.icoBtnThem_Click);
            // 
            // icoBtnXoa
            // 
            this.icoBtnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnXoa.FlatAppearance.BorderSize = 0;
            this.icoBtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnXoa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.icoBtnXoa.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.icoBtnXoa.IconColor = System.Drawing.Color.DarkRed;
            this.icoBtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnXoa.IconSize = 35;
            this.icoBtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnXoa.Location = new System.Drawing.Point(970, 3);
            this.icoBtnXoa.Name = "icoBtnXoa";
            this.icoBtnXoa.Size = new System.Drawing.Size(79, 46);
            this.icoBtnXoa.TabIndex = 5;
            this.icoBtnXoa.Text = "Xoá";
            this.icoBtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnXoa.UseVisualStyleBackColor = true;
            this.icoBtnXoa.Click += new System.EventHandler(this.icoBtnXoa_Click);
            // 
            // icoBtnSua
            // 
            this.icoBtnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnSua.FlatAppearance.BorderSize = 0;
            this.icoBtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnSua.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnSua.ForeColor = System.Drawing.Color.DarkBlue;
            this.icoBtnSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.icoBtnSua.IconColor = System.Drawing.Color.DarkBlue;
            this.icoBtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnSua.IconSize = 35;
            this.icoBtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnSua.Location = new System.Drawing.Point(877, 6);
            this.icoBtnSua.Name = "icoBtnSua";
            this.icoBtnSua.Size = new System.Drawing.Size(87, 39);
            this.icoBtnSua.TabIndex = 4;
            this.icoBtnSua.Text = "Sửa";
            this.icoBtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnSua.UseVisualStyleBackColor = true;
            this.icoBtnSua.Click += new System.EventHandler(this.icoBtnSua_Click);
            // 
            // gridControlKhachhang
            // 
            this.gridControlKhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlKhachhang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlKhachhang.Location = new System.Drawing.Point(17, 18);
            this.gridControlKhachhang.MainView = this.gridView1;
            this.gridControlKhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlKhachhang.Name = "gridControlKhachhang";
            this.gridControlKhachhang.Size = new System.Drawing.Size(812, 597);
            this.gridControlKhachhang.TabIndex = 8;
            this.gridControlKhachhang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhachHang,
            this.colTenKhachHang,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colCMND,
            this.colDienThoai,
            this.colDiaChi});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlKhachhang;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.Caption = "Mã Khách Hàng";
            this.colMaKhachHang.FieldName = "MaKhachHang";
            this.colMaKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMaKhachHang.ImageOptions.Image")));
            this.colMaKhachHang.MinWidth = 19;
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.OptionsColumn.AllowEdit = false;
            this.colMaKhachHang.OptionsColumn.ReadOnly = true;
            this.colMaKhachHang.Visible = true;
            this.colMaKhachHang.VisibleIndex = 0;
            this.colMaKhachHang.Width = 115;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.Caption = "Họ và Tên";
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTenKhachHang.ImageOptions.Image")));
            this.colTenKhachHang.MinWidth = 19;
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.OptionsColumn.AllowEdit = false;
            this.colTenKhachHang.OptionsColumn.ReadOnly = true;
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 1;
            this.colTenKhachHang.Width = 103;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày Sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNgaySinh.ImageOptions.Image")));
            this.colNgaySinh.MinWidth = 19;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.OptionsColumn.AllowEdit = false;
            this.colNgaySinh.OptionsColumn.ReadOnly = true;
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            this.colNgaySinh.Width = 99;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colGioiTinh.ImageOptions.Image")));
            this.colGioiTinh.MinWidth = 19;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.OptionsColumn.AllowEdit = false;
            this.colGioiTinh.OptionsColumn.ReadOnly = true;
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 3;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "CMND";
            this.colCMND.FieldName = "CMND";
            this.colCMND.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colCMND.ImageOptions.Image")));
            this.colCMND.MinWidth = 19;
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.AllowEdit = false;
            this.colCMND.OptionsColumn.ReadOnly = true;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 4;
            this.colCMND.Width = 83;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Caption = "SĐT";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDienThoai.ImageOptions.Image")));
            this.colDienThoai.MinWidth = 19;
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.OptionsColumn.AllowEdit = false;
            this.colDienThoai.OptionsColumn.ReadOnly = true;
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 5;
            this.colDienThoai.Width = 79;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDiaChi.ImageOptions.Image")));
            this.colDiaChi.MinWidth = 19;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.AllowEdit = false;
            this.colDiaChi.OptionsColumn.ReadOnly = true;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 6;
            this.colDiaChi.Width = 141;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.icoBtnXuatkhachhang);
            this.panel1.Controls.Add(this.icoBtnXoa);
            this.panel1.Controls.Add(this.icoBtnSua);
            this.panel1.Controls.Add(this.icoBtnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 62);
            this.panel1.TabIndex = 9;
            // 
            // frmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControlKhachhang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKhachhang";
            this.Size = new System.Drawing.Size(1170, 690);
            this.Load += new System.EventHandler(this.frmKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoten;
        private FontAwesome.Sharp.IconButton icoBtnThem;
        private FontAwesome.Sharp.IconButton icoBtnXoa;
        private FontAwesome.Sharp.IconButton icoBtnSua;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gridControlKhachhang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private FontAwesome.Sharp.IconButton icoBtnXuatkhachhang;
        private System.Windows.Forms.Panel panel1;
    }
}
