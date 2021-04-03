using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_kho
{
    public partial class QLPhieuNhapForm : Form
    {
        public QLPhieuNhapForm()
        {
            InitializeComponent();
        }

        private void QLPhieuNhapForm_Load(object sender, EventArgs e)
        {
            LoadPhieuNhap();
        }

        private void LoadPhieuNhap()
        {
            dgvPhieuNhap.DataSource = new CSDL().SelectData("exec selectAllPhieuNhap");

            dgvPhieuNhap.Columns["MaPhieu"].HeaderText = "Mã phiếu";
            dgvPhieuNhap.Columns["MaHang"].HeaderText = "Mã hàng";
            dgvPhieuNhap.Columns["TGNhap"].HeaderText = "Thời gian nhập";
            dgvPhieuNhap.Columns["NhaSanXuat"].HeaderText = "Nhà sản xuất";
        }

        private void btnPNThem_Click(object sender, EventArgs e)
        {
            new ThemPhieuNhap(null).ShowDialog();
            LoadPhieuNhap();
        }
    }
}
