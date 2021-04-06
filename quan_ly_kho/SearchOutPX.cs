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
    public partial class SearchOutPX : Form
    {
        string sqlSearch;
        public SearchOutPX()
        {
            InitializeComponent();
        }

        public SearchOutPX(string sql)
        {
            sqlSearch = sql;
            InitializeComponent();
        }


        private void LoadDSPX()
        {
            dvgSearch.DataSource = new CSDL().SelectData(sqlSearch);
            dvgSearch.Columns["MaPhieu"].HeaderText = "Mã phiếu";
            dvgSearch.Columns["MaHang"].HeaderText = "Mã hàng";
            dvgSearch.Columns["NgayXuat"].HeaderText = "Ngày xuất";
            dvgSearch.Columns["NoiNhap"].HeaderText = "Nơi nhập";
        }

        private void dvgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchOutPX_Load(object sender, EventArgs e)
        {
            LoadDSPX();
        }
    }
}
