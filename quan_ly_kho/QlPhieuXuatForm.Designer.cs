
namespace quan_ly_kho
{
    partial class QlPhieuXuatForm
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
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.btnPXXoa = new System.Windows.Forms.Button();
            this.btnPXThem = new System.Windows.Forms.Button();
            this.btnPXTimKiem = new System.Windows.Forms.Button();
            this.txbPhieuXuatTT = new System.Windows.Forms.TextBox();
            this.cbbTimKiemPX = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Location = new System.Drawing.Point(129, 121);
            this.dgvPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.RowHeadersWidth = 51;
            this.dgvPhieuXuat.Size = new System.Drawing.Size(896, 546);
            this.dgvPhieuXuat.TabIndex = 14;
            // 
            // btnPXXoa
            // 
            this.btnPXXoa.Location = new System.Drawing.Point(886, 702);
            this.btnPXXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPXXoa.Name = "btnPXXoa";
            this.btnPXXoa.Size = new System.Drawing.Size(139, 37);
            this.btnPXXoa.TabIndex = 13;
            this.btnPXXoa.Text = "Xóa";
            this.btnPXXoa.UseVisualStyleBackColor = true;
            // 
            // btnPXThem
            // 
            this.btnPXThem.Location = new System.Drawing.Point(129, 702);
            this.btnPXThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPXThem.Name = "btnPXThem";
            this.btnPXThem.Size = new System.Drawing.Size(139, 37);
            this.btnPXThem.TabIndex = 12;
            this.btnPXThem.Text = "Thêm";
            this.btnPXThem.UseVisualStyleBackColor = true;
            // 
            // btnPXTimKiem
            // 
            this.btnPXTimKiem.Location = new System.Drawing.Point(886, 60);
            this.btnPXTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPXTimKiem.Name = "btnPXTimKiem";
            this.btnPXTimKiem.Size = new System.Drawing.Size(139, 37);
            this.btnPXTimKiem.TabIndex = 11;
            this.btnPXTimKiem.Text = "Tìm kiếm";
            this.btnPXTimKiem.UseVisualStyleBackColor = true;
            // 
            // txbPhieuXuatTT
            // 
            this.txbPhieuXuatTT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhieuXuatTT.Location = new System.Drawing.Point(406, 60);
            this.txbPhieuXuatTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPhieuXuatTT.Name = "txbPhieuXuatTT";
            this.txbPhieuXuatTT.Size = new System.Drawing.Size(417, 27);
            this.txbPhieuXuatTT.TabIndex = 10;
            // 
            // cbbTimKiemPX
            // 
            this.cbbTimKiemPX.FormattingEnabled = true;
            this.cbbTimKiemPX.Items.AddRange(new object[] {
            "Mã học sinh",
            "Tên học sinh",
            "Mã lớp theo học"});
            this.cbbTimKiemPX.Location = new System.Drawing.Point(129, 63);
            this.cbbTimKiemPX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbTimKiemPX.Name = "cbbTimKiemPX";
            this.cbbTimKiemPX.Size = new System.Drawing.Size(160, 24);
            this.cbbTimKiemPX.TabIndex = 9;
            // 
            // QlPhieuXuatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 798);
            this.Controls.Add(this.dgvPhieuXuat);
            this.Controls.Add(this.btnPXXoa);
            this.Controls.Add(this.btnPXThem);
            this.Controls.Add(this.btnPXTimKiem);
            this.Controls.Add(this.txbPhieuXuatTT);
            this.Controls.Add(this.cbbTimKiemPX);
            this.Name = "QlPhieuXuatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QlPhieuXuatForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private System.Windows.Forms.Button btnPXXoa;
        private System.Windows.Forms.Button btnPXThem;
        private System.Windows.Forms.Button btnPXTimKiem;
        private System.Windows.Forms.TextBox txbPhieuXuatTT;
        private System.Windows.Forms.ComboBox cbbTimKiemPX;
    }
}