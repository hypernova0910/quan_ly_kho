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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void pnPhieuNhap_Click(object sender, EventArgs e)
        {
            QLPhieuNhapForm qLPhieuNhap = new QLPhieuNhapForm();
            qLPhieuNhap.Visible = true;
        }

        private void pnPhieuXuat_Click(object sender, EventArgs e)
        {
            QlPhieuXuatForm qlPhieuXuat = new QlPhieuXuatForm();
            qlPhieuXuat.Visible = true;
        }

        private void pnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeForm thongKe = new ThongKeForm();
            thongKe.Visible = true;
        }

        private void pnPhieuNhap_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
