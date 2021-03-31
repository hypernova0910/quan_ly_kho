
namespace quan_ly_kho
{
    partial class QuanLy
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
            this.pnPhieuNhap = new System.Windows.Forms.Panel();
            this.lbPhieuNhap = new System.Windows.Forms.Label();
            this.pnPhieuXuat = new System.Windows.Forms.Panel();
            this.lbPhieuXuat = new System.Windows.Forms.Label();
            this.pnPhieuNhap.SuspendLayout();
            this.pnPhieuXuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPhieuNhap
            // 
            this.pnPhieuNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnPhieuNhap.Controls.Add(this.lbPhieuNhap);
            this.pnPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.pnPhieuNhap.Name = "pnPhieuNhap";
            this.pnPhieuNhap.Size = new System.Drawing.Size(557, 800);
            this.pnPhieuNhap.TabIndex = 0;
            this.pnPhieuNhap.Click += new System.EventHandler(this.pnPhieuNhap_Click);
            // 
            // lbPhieuNhap
            // 
            this.lbPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPhieuNhap.AutoSize = true;
            this.lbPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuNhap.Location = new System.Drawing.Point(132, 362);
            this.lbPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhieuNhap.Name = "lbPhieuNhap";
            this.lbPhieuNhap.Size = new System.Drawing.Size(380, 76);
            this.lbPhieuNhap.TabIndex = 1;
            this.lbPhieuNhap.Text = "Phiếu Nhập";
            // 
            // pnPhieuXuat
            // 
            this.pnPhieuXuat.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnPhieuXuat.Controls.Add(this.lbPhieuXuat);
            this.pnPhieuXuat.Location = new System.Drawing.Point(553, 0);
            this.pnPhieuXuat.Name = "pnPhieuXuat";
            this.pnPhieuXuat.Size = new System.Drawing.Size(570, 800);
            this.pnPhieuXuat.TabIndex = 1;
            this.pnPhieuXuat.Click += new System.EventHandler(this.pnPhieuXuat_Click);
            // 
            // lbPhieuXuat
            // 
            this.lbPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPhieuXuat.AutoSize = true;
            this.lbPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuXuat.Location = new System.Drawing.Point(129, 362);
            this.lbPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhieuXuat.Name = "lbPhieuXuat";
            this.lbPhieuXuat.Size = new System.Drawing.Size(359, 76);
            this.lbPhieuXuat.TabIndex = 1;
            this.lbPhieuXuat.Text = "Phiếu Xuất";
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 797);
            this.Controls.Add(this.pnPhieuXuat);
            this.Controls.Add(this.pnPhieuNhap);
            this.Name = "QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hàng hóa";
            this.pnPhieuNhap.ResumeLayout(false);
            this.pnPhieuNhap.PerformLayout();
            this.pnPhieuXuat.ResumeLayout(false);
            this.pnPhieuXuat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPhieuNhap;
        private System.Windows.Forms.Panel pnPhieuXuat;
        private System.Windows.Forms.Label lbPhieuNhap;
        private System.Windows.Forms.Label lbPhieuXuat;
    }
}