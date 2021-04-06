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

        private void resetValue()
        {
            txbPhieuNhapTT.Text = "";
        }

        private void btnPNTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPhieuNhapTT.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbTimKiemPN.SelectedIndex != -1)
                {
                    String valueSearch = txbPhieuNhapTT.Text;
                    var db = new CSDL();
                    String sqlSearch = "";
                    if (cbbTimKiemPN.SelectedIndex == 0)
                    {
                        sqlSearch = "exec timKiemPhieuNhap '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutPN(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbTimKiemPN.SelectedIndex == 1)
                    {
                        sqlSearch = "exec timKiemMaHangNhap N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutPN(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                resetValue();
            }
        }
    }
}
