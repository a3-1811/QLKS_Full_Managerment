namespace QUANLYKHACHSAN
{
    partial class frmPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTinhtrang = new System.Windows.Forms.ComboBox();
            this.cboLoaiphong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.icoBtnThem = new FontAwesome.Sharp.IconButton();
            this.icoBtnXoa = new FontAwesome.Sharp.IconButton();
            this.icoBtnSua = new FontAwesome.Sharp.IconButton();
            this.gridControlPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboTinhtrang);
            this.groupBox1.Controls.Add(this.cboLoaiphong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(668, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 528);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN PHÒNG";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtGhichu
            // 
            this.txtGhichu.AcceptsTab = true;
            this.txtGhichu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhichu.Location = new System.Drawing.Point(29, 223);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(231, 101);
            this.txtGhichu.TabIndex = 12;
            this.txtGhichu.Text = "ok chua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ghi chú";
            // 
            // cboTinhtrang
            // 
            this.cboTinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhtrang.FormattingEnabled = true;
            this.cboTinhtrang.Location = new System.Drawing.Point(28, 147);
            this.cboTinhtrang.Name = "cboTinhtrang";
            this.cboTinhtrang.Size = new System.Drawing.Size(231, 30);
            this.cboTinhtrang.TabIndex = 3;
            // 
            // cboLoaiphong
            // 
            this.cboLoaiphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiphong.FormattingEnabled = true;
            this.cboLoaiphong.Location = new System.Drawing.Point(27, 62);
            this.cboLoaiphong.Name = "cboLoaiphong";
            this.cboLoaiphong.Size = new System.Drawing.Size(231, 30);
            this.cboLoaiphong.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tình Trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Phòng";
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
            this.icoBtnThem.Location = new System.Drawing.Point(679, 3);
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
            this.icoBtnXoa.Location = new System.Drawing.Point(878, 3);
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
            this.icoBtnSua.Location = new System.Drawing.Point(777, 3);
            this.icoBtnSua.Name = "icoBtnSua";
            this.icoBtnSua.Size = new System.Drawing.Size(93, 46);
            this.icoBtnSua.TabIndex = 4;
            this.icoBtnSua.Text = "Sửa";
            this.icoBtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnSua.UseVisualStyleBackColor = true;
            this.icoBtnSua.Click += new System.EventHandler(this.icoBtnSua_Click);
            // 
            // gridControlPhong
            // 
            this.gridControlPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPhong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlPhong.Location = new System.Drawing.Point(24, 18);
            this.gridControlPhong.MainView = this.gridView1;
            this.gridControlPhong.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlPhong.Name = "gridControlPhong";
            this.gridControlPhong.Size = new System.Drawing.Size(639, 528);
            this.gridControlPhong.TabIndex = 2;
            this.gridControlPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhong,
            this.colTenLoaiPhong,
            this.colDonGia,
            this.colTinhTrang,
            this.colGhiChu});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlPhong;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaPhong
            // 
            this.colMaPhong.Caption = "Mã phòng";
            this.colMaPhong.FieldName = "MaPhong";
            this.colMaPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMaPhong.ImageOptions.Image")));
            this.colMaPhong.MinWidth = 19;
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.OptionsColumn.AllowEdit = false;
            this.colMaPhong.OptionsColumn.ReadOnly = true;
            this.colMaPhong.Visible = true;
            this.colMaPhong.VisibleIndex = 0;
            this.colMaPhong.Width = 70;
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
            this.colTenLoaiPhong.Width = 70;
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
            this.colDonGia.VisibleIndex = 2;
            this.colDonGia.Width = 70;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Caption = "Tình trạng";
            this.colTinhTrang.FieldName = "TinhTrang";
            this.colTinhTrang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTinhTrang.ImageOptions.Image")));
            this.colTinhTrang.MinWidth = 19;
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.OptionsColumn.AllowEdit = false;
            this.colTinhTrang.OptionsColumn.ReadOnly = true;
            this.colTinhTrang.Visible = true;
            this.colTinhTrang.VisibleIndex = 3;
            this.colTinhTrang.Width = 70;
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
            this.colGhiChu.VisibleIndex = 4;
            this.colGhiChu.Width = 70;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.icoBtnXoa);
            this.panel1.Controls.Add(this.icoBtnSua);
            this.panel1.Controls.Add(this.icoBtnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 55);
            this.panel1.TabIndex = 3;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControlPhong);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPhong";
            this.Size = new System.Drawing.Size(960, 621);
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton icoBtnXoa;
        private FontAwesome.Sharp.IconButton icoBtnSua;
        private System.Windows.Forms.ComboBox cboTinhtrang;
        private System.Windows.Forms.ComboBox cboLoaiphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton icoBtnThem;
        private DevExpress.XtraGrid.GridControl gridControlPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Panel panel1;
    }
}
