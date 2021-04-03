
namespace quan_ly_kho
{
    partial class QLPhieuNhapForm
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
            this.cbbTimKiemPN = new System.Windows.Forms.ComboBox();
            this.txbPhieuNhapTT = new System.Windows.Forms.TextBox();
            this.btnPNTimKiem = new System.Windows.Forms.Button();
            this.btnPNXoa = new System.Windows.Forms.Button();
            this.btnPNThem = new System.Windows.Forms.Button();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTimKiemPN
            // 
            this.cbbTimKiemPN.FormattingEnabled = true;
            this.cbbTimKiemPN.Items.AddRange(new object[] {
            "Mã học sinh",
            "Tên học sinh",
            "Mã lớp theo học"});
            this.cbbTimKiemPN.Location = new System.Drawing.Point(77, 72);
            this.cbbTimKiemPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbTimKiemPN.Name = "cbbTimKiemPN";
            this.cbbTimKiemPN.Size = new System.Drawing.Size(121, 22);
            this.cbbTimKiemPN.TabIndex = 1;
            // 
            // txbPhieuNhapTT
            // 
            this.txbPhieuNhapTT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhieuNhapTT.Location = new System.Drawing.Point(285, 69);
            this.txbPhieuNhapTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPhieuNhapTT.Name = "txbPhieuNhapTT";
            this.txbPhieuNhapTT.Size = new System.Drawing.Size(314, 23);
            this.txbPhieuNhapTT.TabIndex = 2;
            // 
            // btnPNTimKiem
            // 
            this.btnPNTimKiem.Location = new System.Drawing.Point(645, 69);
            this.btnPNTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPNTimKiem.Name = "btnPNTimKiem";
            this.btnPNTimKiem.Size = new System.Drawing.Size(104, 32);
            this.btnPNTimKiem.TabIndex = 3;
            this.btnPNTimKiem.Text = "Tìm kiếm";
            this.btnPNTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnPNXoa
            // 
            this.btnPNXoa.Location = new System.Drawing.Point(645, 631);
            this.btnPNXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPNXoa.Name = "btnPNXoa";
            this.btnPNXoa.Size = new System.Drawing.Size(104, 32);
            this.btnPNXoa.TabIndex = 7;
            this.btnPNXoa.Text = "Xóa";
            this.btnPNXoa.UseVisualStyleBackColor = true;
            // 
            // btnPNThem
            // 
            this.btnPNThem.Location = new System.Drawing.Point(77, 631);
            this.btnPNThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPNThem.Name = "btnPNThem";
            this.btnPNThem.Size = new System.Drawing.Size(104, 32);
            this.btnPNThem.TabIndex = 6;
            this.btnPNThem.Text = "Thêm";
            this.btnPNThem.UseVisualStyleBackColor = true;
            this.btnPNThem.Click += new System.EventHandler(this.btnPNThem_Click);
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(77, 122);
            this.dgvPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(672, 478);
            this.dgvPhieuNhap.TabIndex = 8;
            // 
            // QLPhieuNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 690);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.btnPNXoa);
            this.Controls.Add(this.btnPNThem);
            this.Controls.Add(this.btnPNTimKiem);
            this.Controls.Add(this.txbPhieuNhapTT);
            this.Controls.Add(this.cbbTimKiemPN);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "QLPhieuNhapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLPhieuNhapForm";
            this.Load += new System.EventHandler(this.QLPhieuNhapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTimKiemPN;
        private System.Windows.Forms.TextBox txbPhieuNhapTT;
        private System.Windows.Forms.Button btnPNTimKiem;
        private System.Windows.Forms.Button btnPNXoa;
        private System.Windows.Forms.Button btnPNThem;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
    }
}