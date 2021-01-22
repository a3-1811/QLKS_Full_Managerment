namespace QUANLYKHACHSAN
{
    partial class frmLienhe
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLienhe));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.RoomTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.DevTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DevLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.customersNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.AppearanceText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar.AppearanceText.Options.UseFont = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 20;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 6, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaxId = 3;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.RoomTileBarItem;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(800, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 230;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.RoomTileBarItem);
            this.tileBarGroupTables.Items.Add(this.DevTileBarItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // RoomTileBarItem
            // 
            this.RoomTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkCyan;
            this.RoomTileBarItem.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.RoomTileBarItem.AppearanceItem.Normal.Options.UseFont = true;
            this.RoomTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement1.ImageOptions.ImageIndex = 1;
            tileItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement1.Text = "PHÒNG BAN";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.RoomTileBarItem.Elements.Add(tileItemElement1);
            this.RoomTileBarItem.Name = "RoomTileBarItem";
            this.RoomTileBarItem.Padding = new System.Windows.Forms.Padding(5);
            // 
            // DevTileBarItem
            // 
            this.DevTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.Green;
            this.DevTileBarItem.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.DevTileBarItem.AppearanceItem.Normal.Options.UseFont = true;
            this.DevTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            tileItemElement2.Text = "NHÀ PHÁT TRIỂN";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.DevTileBarItem.Elements.Add(tileItemElement2);
            this.DevTileBarItem.Id = 2;
            this.DevTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.DevTileBarItem.Name = "DevTileBarItem";
            this.DevTileBarItem.Padding = new System.Windows.Forms.Padding(5);
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 110);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage});
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(800, 490);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Caption = "employeesNavigationPage";
            this.employeesNavigationPage.Controls.Add(this.gridControl1);
            this.employeesNavigationPage.Controls.Add(this.RoomLabelControl);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(800, 490);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 490);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHoTen,
            this.colChucVu,
            this.colSoDienThoai});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            // 
            // colHoTen
            // 
            this.colHoTen.AppearanceHeader.Options.UseTextOptions = true;
            this.colHoTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHoTen.Caption = "Họ và Tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("colHoTen.ImageOptions.SvgImage")));
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsColumn.ReadOnly = true;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 0;
            // 
            // colChucVu
            // 
            this.colChucVu.AppearanceCell.Options.UseTextOptions = true;
            this.colChucVu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChucVu.AppearanceHeader.Options.UseTextOptions = true;
            this.colChucVu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChucVu.Caption = "Chức vụ";
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("colChucVu.ImageOptions.SvgImage")));
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.OptionsColumn.ReadOnly = true;
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 1;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.AppearanceCell.Options.UseTextOptions = true;
            this.colSoDienThoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSoDienThoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoDienThoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoDienThoai.Caption = "Số điện thoại";
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSoDienThoai.ImageOptions.Image")));
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.OptionsColumn.ReadOnly = true;
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 2;
            // 
            // RoomLabelControl
            // 
            this.RoomLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.RoomLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.RoomLabelControl.Appearance.Options.UseFont = true;
            this.RoomLabelControl.Appearance.Options.UseForeColor = true;
            this.RoomLabelControl.Appearance.Options.UseTextOptions = true;
            this.RoomLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoomLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoomLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.RoomLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomLabelControl.Location = new System.Drawing.Point(0, 0);
            this.RoomLabelControl.Name = "RoomLabelControl";
            this.RoomLabelControl.Size = new System.Drawing.Size(800, 490);
            this.RoomLabelControl.TabIndex = 2;
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Caption = "customersNavigationPage";
            this.customersNavigationPage.Controls.Add(this.pictureBox2);
            this.customersNavigationPage.Controls.Add(this.pictureBox1);
            this.customersNavigationPage.Controls.Add(this.DevLabelControl);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(800, 490);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::QUANLYKHACHSAN.Properties.Resources.infomation;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 490);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DevLabelControl
            // 
            this.DevLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.DevLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.DevLabelControl.Appearance.Options.UseFont = true;
            this.DevLabelControl.Appearance.Options.UseForeColor = true;
            this.DevLabelControl.Appearance.Options.UseTextOptions = true;
            this.DevLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DevLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DevLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.DevLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevLabelControl.Location = new System.Drawing.Point(0, 0);
            this.DevLabelControl.Name = "DevLabelControl";
            this.DevLabelControl.Size = new System.Drawing.Size(800, 490);
            this.DevLabelControl.TabIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Họ và Tên";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // frmLienhe
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Name = "frmLienhe";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.customersNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem RoomTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem DevTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraEditors.LabelControl RoomLabelControl;
        private DevExpress.XtraEditors.LabelControl DevLabelControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
