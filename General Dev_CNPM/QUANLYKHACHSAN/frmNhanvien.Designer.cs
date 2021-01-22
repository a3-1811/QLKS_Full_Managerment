namespace QUANLYKHACHSAN
{
    partial class frmNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.icoBtnXoa = new FontAwesome.Sharp.IconButton();
            this.icoBtnSua = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.icoBtnThem = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gridControlNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboChucvu = new System.Windows.Forms.ComboBox();
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
            this.icoBtnXuatnhanvien = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.icoBtnXoa.Location = new System.Drawing.Point(932, 3);
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
            this.icoBtnSua.Location = new System.Drawing.Point(834, 2);
            this.icoBtnSua.Name = "icoBtnSua";
            this.icoBtnSua.Size = new System.Drawing.Size(83, 46);
            this.icoBtnSua.TabIndex = 4;
            this.icoBtnSua.Text = "Sửa";
            this.icoBtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnSua.UseVisualStyleBackColor = true;
            this.icoBtnSua.Click += new System.EventHandler(this.icoBtnSua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ và tên Nhân viên";
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
            this.icoBtnThem.Location = new System.Drawing.Point(728, 3);
            this.icoBtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnThem.Name = "icoBtnThem";
            this.icoBtnThem.Size = new System.Drawing.Size(91, 45);
            this.icoBtnThem.TabIndex = 10;
            this.icoBtnThem.Text = "Thêm";
            this.icoBtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnThem.UseVisualStyleBackColor = true;
            this.icoBtnThem.Click += new System.EventHandler(this.icoBtnThem_Click);
            // 
            // gridControlNhanVien
            // 
            this.gridControlNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlNhanVien.Location = new System.Drawing.Point(13, 12);
            this.gridControlNhanVien.MainView = this.gridView1;
            this.gridControlNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.Size = new System.Drawing.Size(757, 451);
            this.gridControlNhanVien.TabIndex = 4;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhanVien,
            this.colHoTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDiaChi,
            this.colGhiChu});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlNhanVien;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Caption = "Mã nhân viên";
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMaNhanVien.ImageOptions.Image")));
            this.colMaNhanVien.MinWidth = 19;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.OptionsColumn.AllowEdit = false;
            this.colMaNhanVien.OptionsColumn.ReadOnly = true;
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 0;
            this.colMaNhanVien.Width = 94;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ và Tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colHoTen.ImageOptions.Image")));
            this.colHoTen.MinWidth = 19;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsColumn.AllowEdit = false;
            this.colHoTen.OptionsColumn.ReadOnly = true;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 125;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày Sinh ";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNgaySinh.ImageOptions.Image")));
            this.colNgaySinh.MinWidth = 19;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.OptionsColumn.AllowEdit = false;
            this.colNgaySinh.OptionsColumn.ReadOnly = true;
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            this.colNgaySinh.Width = 91;
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
            this.colGioiTinh.Width = 73;
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
            this.colDiaChi.VisibleIndex = 4;
            this.colDiaChi.Width = 143;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colGhiChu.ImageOptions.Image")));
            this.colGhiChu.MinWidth = 19;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.OptionsColumn.ReadOnly = true;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 5;
            this.colGhiChu.Width = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboChucvu);
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
            this.groupBox1.Location = new System.Drawing.Point(799, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 451);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // cboChucvu
            // 
            this.cboChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucvu.FormattingEnabled = true;
            this.cboChucvu.Location = new System.Drawing.Point(15, 404);
            this.cboChucvu.Margin = new System.Windows.Forms.Padding(2);
            this.cboChucvu.Name = "cboChucvu";
            this.cboChucvu.Size = new System.Drawing.Size(282, 26);
            this.cboChucvu.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Chức vụ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(14, 336);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(282, 26);
            this.txtSDT.TabIndex = 22;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số điện thoại";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(14, 248);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(282, 53);
            this.txtDiachi.TabIndex = 20;
            this.txtDiachi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Địa chỉ";
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.Location = new System.Drawing.Point(14, 178);
            this.cboGioitinh.Margin = new System.Windows.Forms.Padding(2);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(282, 26);
            this.cboGioitinh.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Giới tính";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 122);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 26);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ngày Sinh";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(14, 57);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(282, 26);
            this.txtHoten.TabIndex = 14;
            this.txtHoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoten_KeyPress);
            // 
            // icoBtnXuatnhanvien
            // 
            this.icoBtnXuatnhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnXuatnhanvien.FlatAppearance.BorderSize = 0;
            this.icoBtnXuatnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnXuatnhanvien.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnXuatnhanvien.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnXuatnhanvien.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icoBtnXuatnhanvien.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnXuatnhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnXuatnhanvien.IconSize = 35;
            this.icoBtnXuatnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnXuatnhanvien.Location = new System.Drawing.Point(1017, 3);
            this.icoBtnXuatnhanvien.Name = "icoBtnXuatnhanvien";
            this.icoBtnXuatnhanvien.Size = new System.Drawing.Size(113, 46);
            this.icoBtnXuatnhanvien.TabIndex = 30;
            this.icoBtnXuatnhanvien.Text = "Xuất NV";
            this.icoBtnXuatnhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnXuatnhanvien.UseVisualStyleBackColor = true;
            this.icoBtnXuatnhanvien.Click += new System.EventHandler(this.icoBtnXuatnhanvien_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.icoBtnXuatnhanvien);
            this.panel1.Controls.Add(this.icoBtnXoa);
            this.panel1.Controls.Add(this.icoBtnSua);
            this.panel1.Controls.Add(this.icoBtnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 60);
            this.panel1.TabIndex = 5;
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControlNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhanvien";
            this.Size = new System.Drawing.Size(1142, 545);
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private FontAwesome.Sharp.IconButton icoBtnXoa;
        private FontAwesome.Sharp.IconButton icoBtnSua;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private FontAwesome.Sharp.IconButton icoBtnThem;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.GridControl gridControlNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboChucvu;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton icoBtnXuatnhanvien;
        private System.Windows.Forms.Panel panel1;
    }
}
