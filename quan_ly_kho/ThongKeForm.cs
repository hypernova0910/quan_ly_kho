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
    public partial class ThongKeForm : Form
    {
        public ThongKeForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            LoadTKHH();
        }

        void LoadTKHH()
        {
            dgvHHTK.DataSource = new CSDL().SelectData("exec selectAllHangHoa");

            dgvHHTK.Columns["MaHang"].HeaderText = "Mã Hàng Hóa";
            dgvHHTK.Columns["TenHang"].HeaderText = "Tên Hàng Hóa";
            dgvHHTK.Columns["KhoiLuong"].HeaderText = "Khối Lượng";
            dgvHHTK.Columns["GiaTri"].HeaderText = "Giá Trị";
            dgvHHTK.Columns["DaXuat"].HeaderText = "Xuất Hàng";
        }

        void LoadTKNX()
        {
            dgvNXTK.DataSource = new CSDL().SelectData("exec selectAll_IO");

            dgvNXTK.Columns["TenHang"].HeaderText = "Tên Hàng Hóa";
            dgvNXTK.Columns["GiaTri"].HeaderText = "Giá Trị";
            dgvNXTK.Columns["TGNhap"].HeaderText = "Thời Gian Nhập";
            dgvNXTK.Columns["Ngayxuat"].HeaderText = "Thời Gian Xuất";
        }

        private void dgvHHTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
            LoadTKHH();
            LoadTKNX();
        }
        private void resetValue()
        {
            txbHangTT.Text = "";
        }

        private void btnHangTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbHangTT.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbTimKiemHang.SelectedIndex != -1)
                {
                    String valueSearch = txbHangTT.Text;
                    var db = new CSDL();
                    String sqlSearch = "";
                    if (cbbTimKiemHang.SelectedIndex == 0)
                    {
                        sqlSearch = "exec timKiemMaHang '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutHang(sqlSearch).Show();
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
