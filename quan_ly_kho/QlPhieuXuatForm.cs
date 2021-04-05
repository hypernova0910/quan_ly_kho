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
    public partial class QlPhieuXuatForm : Form
    {
        public QlPhieuXuatForm()
        {
            InitializeComponent();
        }

        private void QlPhieuXuatForm_Load(object sender, EventArgs e)
        {
            LoadPhieuXuat();
        }
        private void LoadPhieuXuat()
        {
            dgvPhieuXuat.DataSource = new CSDL().SelectData("exec SelectAllPhieuXuat");

            dgvPhieuXuat.Columns["MaPhieu"].HeaderText = "Mã phiếu";
            dgvPhieuXuat.Columns["MaHang"].HeaderText = "Mã hàng";
            dgvPhieuXuat.Columns["NgayXuat"].HeaderText = "Ngày xuất";
            dgvPhieuXuat.Columns["NoiNhap"].HeaderText = "Nơi nhập";
        }

        private void btnPXThem_Click(object sender, EventArgs e)
        {
            new ThemPhieuXuat(null).ShowDialog();
            LoadPhieuXuat();
        }
    }
}
