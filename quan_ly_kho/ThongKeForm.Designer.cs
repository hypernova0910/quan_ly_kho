
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
            this.tabControlNX = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvHHTK = new System.Windows.Forms.DataGridView();
            this.dgvNXTK = new System.Windows.Forms.DataGridView();
            this.tabControlNX.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXTK)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlNX
            // 
            this.tabControlNX.Controls.Add(this.tabPage1);
            this.tabControlNX.Controls.Add(this.tabPage2);
            this.tabControlNX.Location = new System.Drawing.Point(114, 28);
            this.tabControlNX.Name = "tabControlNX";
            this.tabControlNX.SelectedIndex = 0;
            this.tabControlNX.Size = new System.Drawing.Size(1014, 753);
            this.tabControlNX.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvHHTK);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 724);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hàng Hóa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvNXTK);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 724);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhập Xuất";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvHHTK
            // 
            this.dgvHHTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHHTK.Location = new System.Drawing.Point(57, 88);
            this.dgvHHTK.Name = "dgvHHTK";
            this.dgvHHTK.RowHeadersWidth = 51;
            this.dgvHHTK.RowTemplate.Height = 24;
            this.dgvHHTK.Size = new System.Drawing.Size(899, 594);
            this.dgvHHTK.TabIndex = 0;
            // 
            // dgvNXTK
            // 
            this.dgvNXTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXTK.Location = new System.Drawing.Point(59, 72);
            this.dgvNXTK.Name = "dgvNXTK";
            this.dgvNXTK.RowHeadersWidth = 51;
            this.dgvNXTK.RowTemplate.Height = 24;
            this.dgvNXTK.Size = new System.Drawing.Size(887, 597);
            this.dgvNXTK.TabIndex = 0;
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 815);
            this.Controls.Add(this.tabControlNX);
            this.Name = "ThongKeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeForm";
            this.tabControlNX.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHHTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlNX;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvHHTK;
        private System.Windows.Forms.DataGridView dgvNXTK;
    }
}