namespace QUANLYKHACHSAN
{
    partial class frmPhieusuachua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieusuachua));
            this.txtNguyennhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhisuachua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMathietbi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboManhanvien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpKetthuc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaphong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.icoBtnXuatphieusuachua = new FontAwesome.Sharp.IconButton();
            this.icoBtnThem = new FontAwesome.Sharp.IconButton();
            this.icoBtnXoa = new FontAwesome.Sharp.IconButton();
            this.icoBtnSua = new FontAwesome.Sharp.IconButton();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhiSuaChua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguyenNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coTenThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaPhieuSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlNhanVien = new DevExpress.XtraGrid.GridControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.colTenThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNguyennhan
            // 
            this.txtNguyennhan.Location = new System.Drawing.Point(23, 388);
            this.txtNguyennhan.Margin = new System.Windows.Forms.Padding(2);
            this.txtNguyennhan.Multiline = true;
            this.txtNguyennhan.Name = "txtNguyennhan";
            this.txtNguyennhan.Size = new System.Drawing.Size(278, 56);
            this.txtNguyennhan.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nguyên nhân";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPhisuachua);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboMathietbi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboManhanvien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpKetthuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpBatDau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboMaphong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNguyennhan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(929, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 552);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN PHIẾU SỬA CHỮA";
            // 
            // txtPhisuachua
            // 
            this.txtPhisuachua.Location = new System.Drawing.Point(23, 325);
            this.txtPhisuachua.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhisuachua.Name = "txtPhisuachua";
            this.txtPhisuachua.Size = new System.Drawing.Size(278, 26);
            this.txtPhisuachua.TabIndex = 44;
            this.txtPhisuachua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhisuachua_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Phí sửa chữa";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(22, 476);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(278, 56);
            this.txtGhichu.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Ghi Chú";
            // 
            // cboMathietbi
            // 
            this.cboMathietbi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMathietbi.FormattingEnabled = true;
            this.cboMathietbi.Location = new System.Drawing.Point(21, 270);
            this.cboMathietbi.Margin = new System.Windows.Forms.Padding(2);
            this.cboMathietbi.Name = "cboMathietbi";
            this.cboMathietbi.Size = new System.Drawing.Size(276, 26);
            this.cboMathietbi.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Mã thiết bị";
            // 
            // cboManhanvien
            // 
            this.cboManhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManhanvien.FormattingEnabled = true;
            this.cboManhanvien.Location = new System.Drawing.Point(22, 216);
            this.cboManhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.cboManhanvien.Name = "cboManhanvien";
            this.cboManhanvien.Size = new System.Drawing.Size(276, 26);
            this.cboManhanvien.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tên nhân viên";
            // 
            // 
            // dtpKetthuc
            // 
            this.dtpKetthuc.Location = new System.Drawing.Point(21, 162);
            this.dtpKetthuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpKetthuc.Name = "dtpKetthuc";
            this.dtpKetthuc.Size = new System.Drawing.Size(276, 26);
            this.dtpKetthuc.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ngày kết thúc";
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Location = new System.Drawing.Point(23, 106);
            this.dtpBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(276, 26);
            this.dtpBatDau.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // cboMaphong
            // 
            this.cboMaphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaphong.FormattingEnabled = true;
            this.cboMaphong.Location = new System.Drawing.Point(21, 53);
            this.cboMaphong.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaphong.Name = "cboMaphong";
            this.cboMaphong.Size = new System.Drawing.Size(276, 26);
            this.cboMaphong.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã Phòng";
            // 
            // icoBtnXuatphieusuachua
            // 
            this.icoBtnXuatphieusuachua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnXuatphieusuachua.FlatAppearance.BorderSize = 0;
            this.icoBtnXuatphieusuachua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnXuatphieusuachua.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnXuatphieusuachua.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnXuatphieusuachua.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icoBtnXuatphieusuachua.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnXuatphieusuachua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnXuatphieusuachua.IconSize = 35;
            this.icoBtnXuatphieusuachua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnXuatphieusuachua.Location = new System.Drawing.Point(1121, 3);
            this.icoBtnXuatphieusuachua.Name = "icoBtnXuatphieusuachua";
            this.icoBtnXuatphieusuachua.Size = new System.Drawing.Size(139, 45);
            this.icoBtnXuatphieusuachua.TabIndex = 30;
            this.icoBtnXuatphieusuachua.Text = "Xuất Phiếu Sửa Chửa";
            this.icoBtnXuatphieusuachua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnXuatphieusuachua.UseVisualStyleBackColor = true;
            this.icoBtnXuatphieusuachua.Click += new System.EventHandler(this.icoBtnXuatphieusuachua_Click);
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
            this.icoBtnThem.Location = new System.Drawing.Point(857, 4);
            this.icoBtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnThem.Name = "icoBtnThem";
            this.icoBtnThem.Size = new System.Drawing.Size(91, 45);
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
            this.icoBtnXoa.Location = new System.Drawing.Point(1036, 2);
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
            this.icoBtnSua.Location = new System.Drawing.Point(955, 2);
            this.icoBtnSua.Name = "icoBtnSua";
            this.icoBtnSua.Size = new System.Drawing.Size(82, 46);
            this.icoBtnSua.TabIndex = 4;
            this.icoBtnSua.Text = "Sửa";
            this.icoBtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnSua.UseVisualStyleBackColor = true;
            this.icoBtnSua.Click += new System.EventHandler(this.icoBtnSua_Click);
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Tên Nhân Viên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colHoTen.ImageOptions.Image")));
            this.colHoTen.MinWidth = 19;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsColumn.AllowEdit = false;
            this.colHoTen.OptionsColumn.ReadOnly = true;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 3;
            this.colHoTen.Width = 107;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.Caption = "Ngày Kết Thúc";
            this.colNgayKetThuc.FieldName = "NgayKetThuc";
            this.colNgayKetThuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNgayKetThuc.ImageOptions.Image")));
            this.colNgayKetThuc.MinWidth = 19;
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.OptionsColumn.AllowEdit = false;
            this.colNgayKetThuc.OptionsColumn.ReadOnly = true;
            this.colNgayKetThuc.Visible = true;
            this.colNgayKetThuc.VisibleIndex = 2;
            this.colNgayKetThuc.Width = 91;
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
            this.colMaPhong.VisibleIndex = 0;
            this.colMaPhong.Width = 85;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhong,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            this.colHoTen,
            this.colPhiSuaChua,
            this.colNguyenNhan,
            this.colGhiChu,
            this.coTenThietBi,
            this.MaPhieuSua});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlNhanVien;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.Caption = "Ngày Bắt Đầu";
            this.colNgayBatDau.FieldName = "NgayBatDau";
            this.colNgayBatDau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNgayBatDau.ImageOptions.Image")));
            this.colNgayBatDau.MinWidth = 19;
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.OptionsColumn.AllowEdit = false;
            this.colNgayBatDau.OptionsColumn.ReadOnly = true;
            this.colNgayBatDau.Visible = true;
            this.colNgayBatDau.VisibleIndex = 1;
            this.colNgayBatDau.Width = 94;
            // 
            // colPhiSuaChua
            // 
            this.colPhiSuaChua.Caption = "Phí Sửa Chữa";
            this.colPhiSuaChua.DisplayFormat.FormatString = "c0";
            this.colPhiSuaChua.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPhiSuaChua.FieldName = "PhiSuaChua";
            this.colPhiSuaChua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPhiSuaChua.ImageOptions.Image")));
            this.colPhiSuaChua.MinWidth = 19;
            this.colPhiSuaChua.Name = "colPhiSuaChua";
            this.colPhiSuaChua.OptionsColumn.AllowEdit = false;
            this.colPhiSuaChua.OptionsColumn.ReadOnly = true;
            this.colPhiSuaChua.Visible = true;
            this.colPhiSuaChua.VisibleIndex = 4;
            this.colPhiSuaChua.Width = 100;
            // 
            // colNguyenNhan
            // 
            this.colNguyenNhan.Caption = "Nguyên Nhân";
            this.colNguyenNhan.FieldName = "NguyenNhan";
            this.colNguyenNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNguyenNhan.ImageOptions.Image")));
            this.colNguyenNhan.MinWidth = 19;
            this.colNguyenNhan.Name = "colNguyenNhan";
            this.colNguyenNhan.OptionsColumn.AllowEdit = false;
            this.colNguyenNhan.OptionsColumn.ReadOnly = true;
            this.colNguyenNhan.Visible = true;
            this.colNguyenNhan.VisibleIndex = 5;
            this.colNguyenNhan.Width = 98;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colGhiChu.ImageOptions.Image")));
            this.colGhiChu.MinWidth = 19;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.OptionsColumn.ReadOnly = true;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 6;
            this.colGhiChu.Width = 87;
            // 
            // coTenThietBi
            // 
            this.coTenThietBi.Caption = "Tên Thiết Bị";
            this.coTenThietBi.FieldName = "TenThietBi";
            this.coTenThietBi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("coTenThietBi.ImageOptions.SvgImage")));
            this.coTenThietBi.Name = "coTenThietBi";
            this.coTenThietBi.Visible = true;
            this.coTenThietBi.VisibleIndex = 7;
            this.coTenThietBi.Width = 108;
            // 
            // MaPhieuSua
            // 
            this.MaPhieuSua.Caption = "Mã Sửa Chữa";
            this.MaPhieuSua.FieldName = "MaPhieuSua";
            this.MaPhieuSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MaPhieuSua.ImageOptions.SvgImage")));
            this.MaPhieuSua.Name = "MaPhieuSua";
            this.MaPhieuSua.Visible = true;
            this.MaPhieuSua.VisibleIndex = 8;
            this.MaPhieuSua.Width = 102;
            // 
            // gridControlNhanVien
            // 
            this.gridControlNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlNhanVien.Location = new System.Drawing.Point(15, 23);
            this.gridControlNhanVien.MainView = this.gridView1;
            this.gridControlNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.Size = new System.Drawing.Size(897, 552);
            this.gridControlNhanVien.TabIndex = 6;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.icoBtnXoa);
            this.panel1.Controls.Add(this.icoBtnSua);
            this.panel1.Controls.Add(this.icoBtnThem);
            this.panel1.Controls.Add(this.icoBtnXuatphieusuachua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 62);
            this.panel1.TabIndex = 7;
            // 
            // colTenThietBi
            // 
            this.colTenThietBi.Caption = "Tên Thiết Bị";
            this.colTenThietBi.FieldName = "TenThietBi";
            this.colTenThietBi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTenThietBi.ImageOptions.Image")));
            this.colTenThietBi.MinWidth = 19;
            this.colTenThietBi.Name = "colTenThietBi";
            this.colTenThietBi.OptionsColumn.AllowEdit = false;
            this.colTenThietBi.OptionsColumn.ReadOnly = true;
            this.colTenThietBi.Visible = true;
            this.colTenThietBi.VisibleIndex = 4;
            this.colTenThietBi.Width = 118;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn1";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Thiết Bị";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã Sửa Chữa";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã Sửa Chữa";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            // 
            // frmPhieusuachua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControlNhanVien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPhieusuachua";
            this.Size = new System.Drawing.Size(1274, 656);
            this.Load += new System.EventHandler(this.frmPhieusuachua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNguyennhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaphong;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton icoBtnXuatphieusuachua;
        private FontAwesome.Sharp.IconButton icoBtnThem;
        private FontAwesome.Sharp.IconButton icoBtnXoa;
        private FontAwesome.Sharp.IconButton icoBtnSua;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBatDau;
        private DevExpress.XtraGrid.GridControl gridControlNhanVien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.DateTimePicker dtpKetthuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboManhanvien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMathietbi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhisuachua;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.Columns.GridColumn colPhiSuaChua;
        private DevExpress.XtraGrid.Columns.GridColumn colNguyenNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn coTenThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhieuSua;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
