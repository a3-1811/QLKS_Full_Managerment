namespace QUANLYKHACHSAN
{
    partial class frmDichvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichvu));
            this.gridControlDichvu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDonvitinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTendichvu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMadichvu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.icoBtnXuatDichVu = new FontAwesome.Sharp.IconButton();
            this.icoBtnThem = new FontAwesome.Sharp.IconButton();
            this.icoBtnXoa = new FontAwesome.Sharp.IconButton();
            this.icoBtnSua = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlDichvu
            // 
            this.gridControlDichvu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDichvu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlDichvu.Location = new System.Drawing.Point(16, 14);
            this.gridControlDichvu.MainView = this.gridView1;
            this.gridControlDichvu.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlDichvu.Name = "gridControlDichvu";
            this.gridControlDichvu.Size = new System.Drawing.Size(655, 368);
            this.gridControlDichvu.TabIndex = 8;
            this.gridControlDichvu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDichVu,
            this.colTenDichVu,
            this.colDonViTinh,
            this.colDonGia});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlDichvu;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaDichVu
            // 
            this.colMaDichVu.Caption = "Mã Dịch Vụ";
            this.colMaDichVu.FieldName = "MaDichVu";
            this.colMaDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMaDichVu.ImageOptions.Image")));
            this.colMaDichVu.MinWidth = 19;
            this.colMaDichVu.Name = "colMaDichVu";
            this.colMaDichVu.OptionsColumn.AllowEdit = false;
            this.colMaDichVu.OptionsColumn.ReadOnly = true;
            this.colMaDichVu.Visible = true;
            this.colMaDichVu.VisibleIndex = 0;
            this.colMaDichVu.Width = 95;
            // 
            // colTenDichVu
            // 
            this.colTenDichVu.Caption = "Tên Dịch Vụ";
            this.colTenDichVu.FieldName = "TenDichVu";
            this.colTenDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTenDichVu.ImageOptions.Image")));
            this.colTenDichVu.MinWidth = 19;
            this.colTenDichVu.Name = "colTenDichVu";
            this.colTenDichVu.OptionsColumn.AllowEdit = false;
            this.colTenDichVu.OptionsColumn.ReadOnly = true;
            this.colTenDichVu.Visible = true;
            this.colTenDichVu.VisibleIndex = 1;
            this.colTenDichVu.Width = 182;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "Đơn Vị Tính";
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDonViTinh.ImageOptions.Image")));
            this.colDonViTinh.MinWidth = 19;
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.OptionsColumn.AllowEdit = false;
            this.colDonViTinh.OptionsColumn.ReadOnly = true;
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 2;
            this.colDonViTinh.Width = 108;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn Giá";
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
            this.colDonGia.Width = 167;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboDonvitinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTendichvu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDongia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMadichvu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(699, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 368);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // cboDonvitinh
            // 
            this.cboDonvitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonvitinh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDonvitinh.FormattingEnabled = true;
            this.cboDonvitinh.Location = new System.Drawing.Point(13, 230);
            this.cboDonvitinh.Margin = new System.Windows.Forms.Padding(2);
            this.cboDonvitinh.Name = "cboDonvitinh";
            this.cboDonvitinh.Size = new System.Drawing.Size(265, 27);
            this.cboDonvitinh.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Đơn vị tính";
            // 
            // txtTendichvu
            // 
            this.txtTendichvu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendichvu.Location = new System.Drawing.Point(13, 146);
            this.txtTendichvu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTendichvu.Name = "txtTendichvu";
            this.txtTendichvu.Size = new System.Drawing.Size(265, 27);
            this.txtTendichvu.TabIndex = 33;
            this.txtTendichvu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTendichvu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tên dịch vụ";
            // 
            // txtDongia
            // 
            this.txtDongia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.Location = new System.Drawing.Point(13, 315);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(265, 27);
            this.txtDongia.TabIndex = 20;
            this.txtDongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongia_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Đơn giá";
            // 
            // txtMadichvu
            // 
            this.txtMadichvu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadichvu.Location = new System.Drawing.Point(13, 63);
            this.txtMadichvu.Margin = new System.Windows.Forms.Padding(2);
            this.txtMadichvu.Name = "txtMadichvu";
            this.txtMadichvu.Size = new System.Drawing.Size(265, 27);
            this.txtMadichvu.TabIndex = 14;
            this.txtMadichvu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMadichvu_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã dịch vụ";
            // 
            // icoBtnXuatDichVu
            // 
            this.icoBtnXuatDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnXuatDichVu.FlatAppearance.BorderSize = 0;
            this.icoBtnXuatDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnXuatDichVu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnXuatDichVu.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnXuatDichVu.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icoBtnXuatDichVu.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnXuatDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnXuatDichVu.IconSize = 35;
            this.icoBtnXuatDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnXuatDichVu.Location = new System.Drawing.Point(845, 13);
            this.icoBtnXuatDichVu.Name = "icoBtnXuatDichVu";
            this.icoBtnXuatDichVu.Size = new System.Drawing.Size(148, 46);
            this.icoBtnXuatDichVu.TabIndex = 31;
            this.icoBtnXuatDichVu.Text = "Xuất Dịch Vụ";
            this.icoBtnXuatDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnXuatDichVu.UseVisualStyleBackColor = true;
            this.icoBtnXuatDichVu.Click += new System.EventHandler(this.icoBtnXuatDichVu_Click);
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
            this.icoBtnThem.Location = new System.Drawing.Point(574, 13);
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
            this.icoBtnXoa.Location = new System.Drawing.Point(759, 13);
            this.icoBtnXoa.Name = "icoBtnXoa";
            this.icoBtnXoa.Size = new System.Drawing.Size(80, 46);
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
            this.icoBtnSua.Location = new System.Drawing.Point(672, 13);
            this.icoBtnSua.Name = "icoBtnSua";
            this.icoBtnSua.Size = new System.Drawing.Size(81, 46);
            this.icoBtnSua.TabIndex = 4;
            this.icoBtnSua.Text = "Sửa";
            this.icoBtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnSua.UseVisualStyleBackColor = true;
            this.icoBtnSua.Click += new System.EventHandler(this.icoBtnSua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.icoBtnXuatDichVu);
            this.panel1.Controls.Add(this.icoBtnXoa);
            this.panel1.Controls.Add(this.icoBtnSua);
            this.panel1.Controls.Add(this.icoBtnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 73);
            this.panel1.TabIndex = 9;
            // 
            // frmDichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControlDichvu);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDichvu";
            this.Size = new System.Drawing.Size(1008, 478);
            this.Load += new System.EventHandler(this.frmDichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDichvu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboDonvitinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTendichvu;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton icoBtnXuatDichVu;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMadichvu;
        private FontAwesome.Sharp.IconButton icoBtnThem;
        private FontAwesome.Sharp.IconButton icoBtnXoa;
        private FontAwesome.Sharp.IconButton icoBtnSua;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private System.Windows.Forms.Panel panel1;
    }
}
