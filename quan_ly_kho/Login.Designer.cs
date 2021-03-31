
namespace quan_ly_kho
{
    partial class Login
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
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lilbTaiKhoan = new System.Windows.Forms.LinkLabel();
            this.lilbAbout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.Location = new System.Drawing.Point(302, 233);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(99, 25);
            this.lbTaiKhoan.TabIndex = 1;
            this.lbTaiKhoan.Text = "Tài khoản";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(302, 307);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(93, 25);
            this.lbMatKhau.TabIndex = 2;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaiKhoan.Location = new System.Drawing.Point(451, 232);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(317, 26);
            this.txbTaiKhoan.TabIndex = 3;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Location = new System.Drawing.Point(451, 308);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.PasswordChar = '•';
            this.txbMatKhau.Size = new System.Drawing.Size(317, 26);
            this.txbMatKhau.TabIndex = 4;
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(451, 380);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(127, 38);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Crimson;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(671, 380);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 38);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lilbTaiKhoan
            // 
            this.lilbTaiKhoan.AutoSize = true;
            this.lilbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilbTaiKhoan.Location = new System.Drawing.Point(869, 77);
            this.lilbTaiKhoan.Name = "lilbTaiKhoan";
            this.lilbTaiKhoan.Size = new System.Drawing.Size(99, 25);
            this.lilbTaiKhoan.TabIndex = 7;
            this.lilbTaiKhoan.TabStop = true;
            this.lilbTaiKhoan.Text = "Tài khoản";
            this.lilbTaiKhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilbTaiKhoan_LinkClicked);
            // 
            // lilbAbout
            // 
            this.lilbAbout.AutoSize = true;
            this.lilbAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilbAbout.Location = new System.Drawing.Point(1016, 77);
            this.lilbAbout.Name = "lilbAbout";
            this.lilbAbout.Size = new System.Drawing.Size(64, 25);
            this.lilbAbout.TabIndex = 8;
            this.lilbAbout.TabStop = true;
            this.lilbAbout.Text = "About";
            this.lilbAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilbAbout_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 637);
            this.Controls.Add(this.lilbAbout);
            this.Controls.Add(this.lilbTaiKhoan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTaiKhoan);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.LinkLabel lilbTaiKhoan;
        private System.Windows.Forms.LinkLabel lilbAbout;
    }
}

