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
    
    public partial class ThemPhieuNhap : Form
    {
        public ThemPhieuNhap(string mhs)
        {
            this.mhs = mhs;
            InitializeComponent();
        }
            private string mhs;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ThemPhieuNhap_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Mã SV nhận được: " + msv);
            CSDL csdl = new CSDL();
            string getAllhang = "SELECT MaHang FROM HANG";
            DataTable mahangTable = csdl.SelectData(getAllhang);
            cbMaHang.DataSource = mahangTable.Copy();
            cbMaHang.DisplayMember = "MaHang";
            cbMaHang.ValueMember = "MaHang";
            if (!string.IsNullOrEmpty(mhs))
            {
                this.Text = "Cập nhật thông tin ";

                
            }
            else
            {
                this.Text = "Thêm mới phiếu nhập";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql="";
            string maPhieu = txtMaPhieu.Text;
            DateTime NgayNhap = dtpDate.Value;
            string NSX = txtNSX.Text;
            DataRowView drvMaHang = (DataRowView)cbMaHang.SelectedItem;
            string MaHang = drvMaHang.Row.Field<string>("MaHang");

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(mhs))
            {
                sql = "ThemMoiPhieuNhap";
            }


            lstPara.Add(new CustomParameter()
            {
                key = "@MaPhieu",
                value = maPhieu
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@TGNhap",
                value = NgayNhap.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@NhaSanXuat",
                value = NSX
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@MaHang",
                value = MaHang
            });
            



            var rs = new CSDL().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mhs))
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
