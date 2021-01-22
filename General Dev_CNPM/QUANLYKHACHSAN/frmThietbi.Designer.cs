namespace QUANLYKHACHSAN
{
    partial class frmThietbi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThietbi));
            this.gridControlThietbi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenthietbi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.icoBtnXuatthietbi = new FontAwesome.Sharp.IconButton();
            this.icoBtnThem = new FontAwesome.Sharp.IconButton();
            this.icoBtnXoa = new FontAwesome.Sharp.IconButton();
            this.icoBtnSua = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThietbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlThietbi
            // 
            this.gridControlThietbi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlThietbi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlThietbi.Location = new System.Drawing.Point(13, 14);
            this.gridControlThietbi.MainView = this.gridView1;
            this.gridControlThietbi.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlThietbi.Name = "gridControlThietbi";
            this.gridControlThietbi.Size = new System.Drawing.Size(575, 291);
            this.gridControlThietbi.TabIndex = 6;
            this.gridControlThietbi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaThietBi,
            this.colTenThietBi,
            this.colSoLuong});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlThietbi;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaThietBi
            // 
            this.colMaThietBi.Caption = "Mã Thiết Bị";
            this.colMaThietBi.FieldName = "MaThietBi";
            this.colMaThietBi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMaThietBi.ImageOptions.Image")));
            this.colMaThietBi.MinWidth = 19;
            this.colMaThietBi.Name = "colMaThietBi";
            this.colMaThietBi.OptionsColumn.AllowEdit = false;
            this.colMaThietBi.OptionsColumn.ReadOnly = true;
            this.colMaThietBi.Visible = true;
            this.colMaThietBi.VisibleIndex = 0;
            this.colMaThietBi.Width = 137;
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
            this.colTenThietBi.VisibleIndex = 1;
            this.colTenThietBi.Width = 244;
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
            this.colSoLuong.Width = 143;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenthietbi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(606, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 232);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN THIẾT BỊ";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(18, 176);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(239, 30);
            this.txtSoluong.TabIndex = 20;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số lượng";
            // 
            // txtTenthietbi
            // 
            this.txtTenthietbi.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenthietbi.Location = new System.Drawing.Point(17, 84);
            this.txtTenthietbi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenthietbi.Name = "txtTenthietbi";
            this.txtTenthietbi.Size = new System.Drawing.Size(239, 30);
            this.txtTenthietbi.TabIndex = 14;
            this.txtTenthietbi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenthietbi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên thiết bị";
            // 
            // icoBtnXuatthietbi
            // 
            this.icoBtnXuatthietbi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnXuatthietbi.FlatAppearance.BorderSize = 0;
            this.icoBtnXuatthietbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnXuatthietbi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnXuatthietbi.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnXuatthietbi.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icoBtnXuatthietbi.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnXuatthietbi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnXuatthietbi.IconSize = 35;
            this.icoBtnXuatthietbi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnXuatthietbi.Location = new System.Drawing.Point(747, 3);
            this.icoBtnXuatthietbi.Name = "icoBtnXuatthietbi";
            this.icoBtnXuatthietbi.Size = new System.Drawing.Size(148, 43);
            this.icoBtnXuatthietbi.TabIndex = 31;
            this.icoBtnXuatthietbi.Text = "Xuất Thiết Bị";
            this.icoBtnXuatthietbi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnXuatthietbi.UseVisualStyleBackColor = true;
            this.icoBtnXuatthietbi.Click += new System.EventHandler(this.icoBtnXuatthietbi_Click);
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
            this.icoBtnThem.Location = new System.Drawing.Point(465, 4);
            this.icoBtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnThem.Name = "icoBtnThem";
            this.icoBtnThem.Size = new System.Drawing.Size(91, 42);
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
            this.icoBtnXoa.Location = new System.Drawing.Point(653, 3);
            this.icoBtnXoa.Name = "icoBtnXoa";
            this.icoBtnXoa.Size = new System.Drawing.Size(88, 43);
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
            this.icoBtnSua.Location = new System.Drawing.Point(563, 3);
            this.icoBtnSua.Name = "icoBtnSua";
            this.icoBtnSua.Size = new System.Drawing.Size(89, 43);
            this.icoBtnSua.TabIndex = 4;
            this.icoBtnSua.Text = "Sửa";
            this.icoBtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnSua.UseVisualStyleBackColor = true;
            this.icoBtnSua.Click += new System.EventHandler(this.icoBtnSua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.icoBtnXuatthietbi);
            this.panel1.Controls.Add(this.icoBtnSua);
            this.panel1.Controls.Add(this.icoBtnXoa);
            this.panel1.Controls.Add(this.icoBtnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 56);
            this.panel1.TabIndex = 7;
            // 
            // frmThietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControlThietbi);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThietbi";
            this.Size = new System.Drawing.Size(908, 315);
            this.Load += new System.EventHandler(this.frmThietbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThietbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlThietbi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenthietbi;
        private FontAwesome.Sharp.IconButton icoBtnThem;
        private FontAwesome.Sharp.IconButton icoBtnXoa;
        private FontAwesome.Sharp.IconButton icoBtnSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoluong;
        private FontAwesome.Sharp.IconButton icoBtnXuatthietbi;
        private System.Windows.Forms.Panel panel1;
    }
}
