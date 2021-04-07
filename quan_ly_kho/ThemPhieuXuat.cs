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
    public partial class ThemPhieuXuat : Form
    {
        private string maPhieu;
        public ThemPhieuXuat(string maPhieu)
        {
            this.maPhieu = maPhieu;
            InitializeComponent();
        }
        private void ThemPhieuXuat_Load(object sender, EventArgs e)
        {
            CSDL csdl = new CSDL();
            string getAllhang = "SELECT MaHang FROM HANG WHERE DaXuat = 0";
            DataTable mahangTable = csdl.SelectData(getAllhang);
            cbbMaHang.DataSource = mahangTable.Copy();
            cbbMaHang.DisplayMember = "MaHang";
            cbbMaHang.ValueMember = "MaHang";
            if (!string.IsNullOrEmpty(maPhieu))
            {
                this.Text = "Cập nhật thông tin ";
            }
            else
            {
                this.Text = "Thêm mới phiếu xuất";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            //string maP = txbMaPhieu.Text;
            DateTime ngayXuat = dtpNgayXuat.Value;
            string noiNhap = txbNoiNhap.Text;
            DataRowView drvMaHang = (DataRowView)cbbMaHang.SelectedItem;
            string maHang = drvMaHang.Row.Field<string>("MaHang");

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(maPhieu))
            {
                sql = "xuatHang";
            }

            //lstPara.Add(new CustomParameter()
            //{
            //    key = "@MaPhieu",
            //    value = maP
            //});

            lstPara.Add(new CustomParameter()
            {
                key = "@TGXuat",
                value = ngayXuat.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@maHang",
                value = maHang
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@NoiNhap",
                value = noiNhap
            });

            var rs = new CSDL().ExeCute(sql, lstPara);
            if (rs == 2)
            {
                if (string.IsNullOrEmpty(maPhieu))
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
