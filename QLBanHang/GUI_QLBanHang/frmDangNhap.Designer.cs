
namespace GUI_QLBanHang
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkGhiNho = new Guna.UI2.WinForms.Guna2CheckBox();
            this.llblQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_QLBanHang.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(99, -7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 174);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(80, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEMBER LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(165, 224);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(347, 44);
            this.txtEmail.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.Parent = this.txtMatKhau;
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.FocusedState.Parent = this.txtMatKhau;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.HoverState.Parent = this.txtMatKhau;
            this.txtMatKhau.Location = new System.Drawing.Point(165, 282);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.ShadowDecoration.Parent = this.txtMatKhau;
            this.txtMatKhau.Size = new System.Drawing.Size(347, 44);
            this.txtMatKhau.TabIndex = 2;
            // 
            // chkGhiNho
            // 
            this.chkGhiNho.AutoSize = true;
            this.chkGhiNho.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkGhiNho.CheckedState.BorderRadius = 2;
            this.chkGhiNho.CheckedState.BorderThickness = 0;
            this.chkGhiNho.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkGhiNho.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGhiNho.Location = new System.Drawing.Point(23, 346);
            this.chkGhiNho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkGhiNho.Name = "chkGhiNho";
            this.chkGhiNho.Size = new System.Drawing.Size(187, 29);
            this.chkGhiNho.TabIndex = 3;
            this.chkGhiNho.Text = "Ghi nhớ tài khoản";
            this.chkGhiNho.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkGhiNho.UncheckedState.BorderRadius = 2;
            this.chkGhiNho.UncheckedState.BorderThickness = 0;
            this.chkGhiNho.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkGhiNho.UseVisualStyleBackColor = true;
            // 
            // llblQuenMatKhau
            // 
            this.llblQuenMatKhau.AutoSize = true;
            this.llblQuenMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.llblQuenMatKhau.Location = new System.Drawing.Point(311, 350);
            this.llblQuenMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblQuenMatKhau.Name = "llblQuenMatKhau";
            this.llblQuenMatKhau.Size = new System.Drawing.Size(191, 25);
            this.llblQuenMatKhau.TabIndex = 4;
            this.llblQuenMatKhau.TabStop = true;
            this.llblQuenMatKhau.Text = "Bạn quên mật khẩu ?";
            this.llblQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblQuenMatKhau_LinkClicked);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.CheckedState.Parent = this.btnDangNhap;
            this.btnDangNhap.CustomImages.Parent = this.btnDangNhap;
            this.btnDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnDangNhap.FillColor2 = System.Drawing.SystemColors.HotTrack;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.HoverState.Parent = this.btnDangNhap;
            this.btnDangNhap.Location = new System.Drawing.Point(20, 385);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ShadowDecoration.Parent = this.btnDangNhap;
            this.btnDangNhap.Size = new System.Drawing.Size(488, 44);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(528, 447);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.llblQuenMatKhau);
            this.Controls.Add(this.chkGhiNho);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.QL_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2CheckBox chkGhiNho;
        private System.Windows.Forms.LinkLabel llblQuenMatKhau;
        private Guna.UI2.WinForms.Guna2GradientButton btnDangNhap;
    }
}