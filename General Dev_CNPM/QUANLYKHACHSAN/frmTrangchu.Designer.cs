namespace QUANLYKHACHSAN
{
    partial class frmTrangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangchu));
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSlider1
            // 
            this.imageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.imageSlider1.AutoSlideInterval = 5000;
            this.imageSlider1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images1"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images2"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images3"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images4"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images5"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images6"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images7"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images8"))));
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomOutside;
            this.imageSlider1.Location = new System.Drawing.Point(0, 0);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(1313, 861);
            this.imageSlider1.TabIndex = 0;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // frmTrangchu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.imageSlider1);
            this.Name = "frmTrangchu";
            this.Size = new System.Drawing.Size(1313, 861);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
    }
}
