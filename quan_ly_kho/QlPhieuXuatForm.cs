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

        private void resetValue()
        {
            txbPhieuXuatTT.Text = "";
        }

        private void btnPXTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPhieuXuatTT.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbTimKiemPX.SelectedIndex != -1)
                {
                    String valueSearch = txbPhieuXuatTT.Text;
                    var db = new CSDL();
                    String sqlSearch = "";
                    if (cbbTimKiemPX.SelectedIndex == 0)
                    {
                        sqlSearch = "exec timKiemPhieuXuat '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutPX(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbTimKiemPX.SelectedIndex == 1)
                    {
                        sqlSearch = "exec timKiemMaHangXuat N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutPX(sqlSearch).Show();
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
