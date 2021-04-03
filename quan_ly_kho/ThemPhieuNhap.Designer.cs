
namespace quan_ly_kho
{
    partial class ThemPhieuNhap
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.cbMaHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(350, 42);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(107, 14);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Thông tin phiếu nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhà sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phiếu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(313, 148);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(222, 20);
            this.dtpDate.TabIndex = 39;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(313, 97);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(222, 20);
            this.txtMaPhieu.TabIndex = 40;
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(313, 196);
            this.txtNSX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(222, 20);
            this.txtNSX.TabIndex = 41;
            // 
            // cbMaHang
            // 
            this.cbMaHang.FormattingEnabled = true;
            this.cbMaHang.Location = new System.Drawing.Point(313, 245);
            this.cbMaHang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbMaHang.Name = "cbMaHang";
            this.cbMaHang.Size = new System.Drawing.Size(222, 22);
            this.cbMaHang.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 14);
            this.label6.TabIndex = 53;
            this.label6.Text = "Mã hàng";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(445, 335);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(204, 335);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ThemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 477);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbMaHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNSX);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitle);
            this.Name = "ThemPhieuNhap";
            this.Text = "ThemPhieuNhap";
            this.Load += new System.EventHandler(this.ThemPhieuNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.ComboBox cbMaHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}