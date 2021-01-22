namespace QUANLYKHACHSAN
{
    partial class frmDangnhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangnhap));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDangnhap = new System.Windows.Forms.TextBox();
            this.icoUsername = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.iconUserpassword = new FontAwesome.Sharp.IconPictureBox();
            this.icoBtnDangnhap = new FontAwesome.Sharp.IconButton();
            this.icoBtnThoat = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblCountdown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icoUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserpassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(94, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // txtDangnhap
            // 
            this.txtDangnhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDangnhap.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDangnhap.Location = new System.Drawing.Point(130, 150);
            this.txtDangnhap.Name = "txtDangnhap";
            this.txtDangnhap.Size = new System.Drawing.Size(358, 29);
            this.txtDangnhap.TabIndex = 2;
            // 
            // icoUsername
            // 
            this.icoUsername.BackColor = System.Drawing.Color.Transparent;
            this.icoUsername.ForeColor = System.Drawing.Color.Black;
            this.icoUsername.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.icoUsername.IconColor = System.Drawing.Color.Black;
            this.icoUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoUsername.IconSize = 49;
            this.icoUsername.Location = new System.Drawing.Point(64, 142);
            this.icoUsername.Name = "icoUsername";
            this.icoUsername.Size = new System.Drawing.Size(60, 49);
            this.icoUsername.TabIndex = 3;
            this.icoUsername.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 80;
            this.iconPictureBox1.Location = new System.Drawing.Point(16, 29);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(82, 80);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatkhau.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatkhau.Location = new System.Drawing.Point(130, 213);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(358, 29);
            this.txtMatkhau.TabIndex = 5;
            // 
            // iconUserpassword
            // 
            this.iconUserpassword.BackColor = System.Drawing.Color.Transparent;
            this.iconUserpassword.ForeColor = System.Drawing.Color.Black;
            this.iconUserpassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconUserpassword.IconColor = System.Drawing.Color.Black;
            this.iconUserpassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUserpassword.IconSize = 47;
            this.iconUserpassword.Location = new System.Drawing.Point(64, 206);
            this.iconUserpassword.Name = "iconUserpassword";
            this.iconUserpassword.Size = new System.Drawing.Size(66, 47);
            this.iconUserpassword.TabIndex = 6;
            this.iconUserpassword.TabStop = false;
            // 
            // icoBtnDangnhap
            // 
            this.icoBtnDangnhap.BackColor = System.Drawing.Color.Transparent;
            this.icoBtnDangnhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icoBtnDangnhap.ForeColor = System.Drawing.Color.Black;
            this.icoBtnDangnhap.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.icoBtnDangnhap.IconColor = System.Drawing.Color.Black;
            this.icoBtnDangnhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnDangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnDangnhap.Location = new System.Drawing.Point(146, 281);
            this.icoBtnDangnhap.Name = "icoBtnDangnhap";
            this.icoBtnDangnhap.Size = new System.Drawing.Size(161, 50);
            this.icoBtnDangnhap.TabIndex = 7;
            this.icoBtnDangnhap.Text = "ĐĂNG NHẬP";
            this.icoBtnDangnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnDangnhap.UseVisualStyleBackColor = false;
            this.icoBtnDangnhap.Click += new System.EventHandler(this.icoBtnDangnhap_Click);
            // 
            // icoBtnThoat
            // 
            this.icoBtnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icoBtnThoat.ForeColor = System.Drawing.Color.Black;
            this.icoBtnThoat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.icoBtnThoat.IconColor = System.Drawing.Color.Black;
            this.icoBtnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnThoat.Location = new System.Drawing.Point(338, 281);
            this.icoBtnThoat.Name = "icoBtnThoat";
            this.icoBtnThoat.Size = new System.Drawing.Size(136, 50);
            this.icoBtnThoat.TabIndex = 8;
            this.icoBtnThoat.Text = "THOÁT";
            this.icoBtnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnThoat.UseVisualStyleBackColor = false;
            this.icoBtnThoat.Click += new System.EventHandler(this.icoBtnThoat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Red;
            this.lblCountdown.Location = new System.Drawing.Point(125, 106);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(150, 29);
            this.lblCountdown.TabIndex = 9;
            this.lblCountdown.Text = "Countdown";
            // 
            // frmDangnhap
            // 
            this.AcceptButton = this.icoBtnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(588, 373);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.icoBtnThoat);
            this.Controls.Add(this.icoBtnDangnhap);
            this.Controls.Add(this.iconUserpassword);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.icoUsername);
            this.Controls.Add(this.txtDangnhap);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDangnhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.icoUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserpassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDangnhap;
        private FontAwesome.Sharp.IconPictureBox icoUsername;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtMatkhau;
        private FontAwesome.Sharp.IconPictureBox iconUserpassword;
        private FontAwesome.Sharp.IconButton icoBtnDangnhap;
        private FontAwesome.Sharp.IconButton icoBtnThoat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblCountdown;
    }
}