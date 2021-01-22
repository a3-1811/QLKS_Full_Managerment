namespace QUANLYKHACHSAN
{
    partial class frmThemDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemDV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.icoBtnHuy = new FontAwesome.Sharp.IconButton();
            this.icoBtnSua = new FontAwesome.Sharp.IconButton();
            this.icoBtnThem = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTongcong = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTenDV = new System.Windows.Forms.ComboBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlDichvu = new DevExpress.XtraGrid.GridControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.icoBtnHuy);
            this.panel1.Controls.Add(this.icoBtnSua);
            this.panel1.Controls.Add(this.icoBtnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 64);
            this.panel1.TabIndex = 18;
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
            this.icoBtnHuy.Location = new System.Drawing.Point(719, 8);
            this.icoBtnHuy.Name = "icoBtnHuy";
            this.icoBtnHuy.Size = new System.Drawing.Size(90, 46);
            this.icoBtnHuy.TabIndex = 11;
            this.icoBtnHuy.Text = "Hủy";
            this.icoBtnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnHuy.UseVisualStyleBackColor = true;
            this.icoBtnHuy.Click += new System.EventHandler(this.icoBtnHuy_Click);
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
            this.icoBtnSua.Location = new System.Drawing.Point(630, 6);
            this.icoBtnSua.Name = "icoBtnSua";
            this.icoBtnSua.Size = new System.Drawing.Size(83, 46);
            this.icoBtnSua.TabIndex = 4;
            this.icoBtnSua.Text = "Sửa";
            this.icoBtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnSua.UseVisualStyleBackColor = true;
            this.icoBtnSua.Click += new System.EventHandler(this.icoBtnSua_Click);
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
            this.icoBtnThem.Location = new System.Drawing.Point(533, 8);
            this.icoBtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnThem.Name = "icoBtnThem";
            this.icoBtnThem.Size = new System.Drawing.Size(91, 45);
            this.icoBtnThem.TabIndex = 10;
            this.icoBtnThem.Text = "Thêm";
            this.icoBtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnThem.UseVisualStyleBackColor = true;
            this.icoBtnThem.Click += new System.EventHandler(this.icoBtnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(182, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "MÃ THUÊ PHÒNG: ";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 50;
            this.iconPictureBox1.Location = new System.Drawing.Point(9, 320);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(53, 50);
            this.iconPictureBox1.TabIndex = 48;
            this.iconPictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.iconPictureBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTongcong);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboTenDV);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(529, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 401);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tên dịch vụ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(63, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 19);
            this.label13.TabIndex = 47;
            this.label13.Text = "Tổng Cộng";
            // 
            // txtTongcong
            // 
            this.txtTongcong.AcceptsTab = true;
            this.txtTongcong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTongcong.Enabled = false;
            this.txtTongcong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTongcong.Location = new System.Drawing.Point(67, 343);
            this.txtTongcong.Multiline = true;
            this.txtTongcong.Name = "txtTongcong";
            this.txtTongcong.ReadOnly = true;
            this.txtTongcong.Size = new System.Drawing.Size(153, 27);
            this.txtTongcong.TabIndex = 46;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(10, 166);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(214, 27);
            this.txtSoLuong.TabIndex = 38;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Số lượng";
            // 
            // cboTenDV
            // 
            this.cboTenDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenDV.FormattingEnabled = true;
            this.cboTenDV.Location = new System.Drawing.Point(9, 78);
            this.cboTenDV.Margin = new System.Windows.Forms.Padding(2);
            this.cboTenDV.Name = "cboTenDV";
            this.cboTenDV.Size = new System.Drawing.Size(211, 26);
            this.cboTenDV.TabIndex = 36;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDichVu,
            this.colDonGia,
            this.colDonViTinh,
            this.colSoLuong});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlDichvu;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
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
            this.colTenDichVu.VisibleIndex = 0;
            this.colTenDichVu.Width = 116;
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
            this.colDonGia.Width = 153;
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
            this.colDonViTinh.VisibleIndex = 1;
            this.colDonViTinh.Width = 100;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSoLuong.ImageOptions.Image")));
            this.colSoLuong.MinWidth = 19;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.OptionsColumn.AllowEdit = false;
            this.colSoLuong.OptionsColumn.ReadOnly = true;
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            this.colSoLuong.Width = 94;
            // 
            // gridControlDichvu
            // 
            this.gridControlDichvu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDichvu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlDichvu.Location = new System.Drawing.Point(9, 69);
            this.gridControlDichvu.MainView = this.gridView1;
            this.gridControlDichvu.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlDichvu.Name = "gridControlDichvu";
            this.gridControlDichvu.Size = new System.Drawing.Size(488, 401);
            this.gridControlDichvu.TabIndex = 16;
            this.gridControlDichvu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frmThemDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 541);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControlDichvu);
            this.Name = "frmThemDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmThemDV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icoBtnSua;
        private FontAwesome.Sharp.IconButton icoBtnThem;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTongcong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTenDV;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.GridControl gridControlDichvu;
        private FontAwesome.Sharp.IconButton icoBtnHuy;
        private System.Windows.Forms.Label label1;
    }
}