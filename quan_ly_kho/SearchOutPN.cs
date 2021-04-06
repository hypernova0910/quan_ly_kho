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
    public partial class SearchOutPN : Form
    {
        string sqlSearch;
        public SearchOutPN()
        {
            InitializeComponent();
        }

        public SearchOutPN(string sql)
        {
            sqlSearch = sql;
            InitializeComponent();
        }


        private void LoadDSPN()
        {
            dvgSearch.DataSource = new CSDL().SelectData(sqlSearch);
            dvgSearch.Columns["MaPhieu"].HeaderText = "Mã phiếu";
            dvgSearch.Columns["MaHang"].HeaderText = "Mã hàng";
            dvgSearch.Columns["TGNhap"].HeaderText = "Thời gian nhập";
            dvgSearch.Columns["NhaSanXuat"].HeaderText = "Nhà sản xuất";
        }

        private void SearchOutPN_Load_1(object sender, EventArgs e)
        {
            LoadDSPN();
        }
    }
}
