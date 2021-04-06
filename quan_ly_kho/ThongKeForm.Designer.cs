
namespace quan_ly_kho
{
    partial class ThongKeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHHTK = new System.Windows.Forms.DataGridView();
            this.dgvNXTK = new System.Windows.Forms.DataGridView();
            this.btnHangTimKiem = new System.Windows.Forms.Button();
            this.txbHangTT = new System.Windows.Forms.TextBox();
            this.cbbTimKiemHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXTK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(964, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thống Kê Nhập Xuất";
            // 
            // dgvHHTK
            // 
            this.dgvHHTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHHTK.Location = new System.Drawing.Point(16, 110);
            this.dgvHHTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHHTK.Name = "dgvHHTK";
            this.dgvHHTK.RowHeadersWidth = 51;
            this.dgvHHTK.Size = new System.Drawing.Size(620, 447);
            this.dgvHHTK.TabIndex = 2;
            // 
            // dgvNXTK
            // 
            this.dgvNXTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXTK.Location = new System.Drawing.Point(708, 110);
            this.dgvNXTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNXTK.Name = "dgvNXTK";
            this.dgvNXTK.RowHeadersWidth = 51;
            this.dgvNXTK.Size = new System.Drawing.Size(636, 447);
            this.dgvNXTK.TabIndex = 3;
            // 
            // btnHangTimKiem
            // 
            this.btnHangTimKiem.Location = new System.Drawing.Point(1002, 14);
            this.btnHangTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHangTimKiem.Name = "btnHangTimKiem";
            this.btnHangTimKiem.Size = new System.Drawing.Size(139, 37);
            this.btnHangTimKiem.TabIndex = 6;
            this.btnHangTimKiem.Text = "Tìm kiếm";
            this.btnHangTimKiem.UseVisualStyleBackColor = true;
            this.btnHangTimKiem.Click += new System.EventHandler(this.btnHangTimKiem_Click);
            // 
            // txbHangTT
            // 
            this.txbHangTT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHangTT.Location = new System.Drawing.Point(522, 14);
            this.txbHangTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbHangTT.Name = "txbHangTT";
            this.txbHangTT.Size = new System.Drawing.Size(417, 27);
            this.txbHangTT.TabIndex = 5;
            // 
            // cbbTimKiemHang
            // 
            this.cbbTimKiemHang.FormattingEnabled = true;
            this.cbbTimKiemHang.Items.AddRange(new object[] {
            "Mã Hàng"});
            this.cbbTimKiemHang.Location = new System.Drawing.Point(245, 17);
            this.cbbTimKiemHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbTimKiemHang.Name = "cbbTimKiemHang";
            this.cbbTimKiemHang.Size = new System.Drawing.Size(160, 24);
            this.cbbTimKiemHang.TabIndex = 4;
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 656);
            this.Controls.Add(this.btnHangTimKiem);
            this.Controls.Add(this.txbHangTT);
            this.Controls.Add(this.cbbTimKiemHang);
            this.Controls.Add(this.dgvNXTK);
            this.Controls.Add(this.dgvHHTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThongKeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeForm";
            this.Load += new System.EventHandler(this.ThongKeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHHTK;
        private System.Windows.Forms.DataGridView dgvNXTK;
        private System.Windows.Forms.Button btnHangTimKiem;
        private System.Windows.Forms.TextBox txbHangTT;
        private System.Windows.Forms.ComboBox cbbTimKiemHang;
    }
}