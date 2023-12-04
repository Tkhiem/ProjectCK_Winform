using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWinForm_CK.QLyKhachHang
{
    public partial class UC_Addroom : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_Addroom()
        {
            InitializeComponent();
        }

        private void UC_Addroom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnThemDSPhong_Click_1(object sender, EventArgs e)
        {
            if (txtSoPhong.Text != "" && txtLoaiPhong.Text != "" && txtLoaiGiuong.Text != "" && txtGiaTien.Text != "")
            {
                string SoPhong = txtSoPhong.Text;
                string LoaiPhong = txtLoaiPhong.Text;
                string LoaiGiuong = txtLoaiGiuong.Text;
                Int64 GiaTien = Int64.Parse(txtGiaTien.Text);

                query = query = "insert into rooms (roomNo, roomType, bed, price) values ('" + SoPhong + "', '" + LoaiPhong + "', '" + LoaiGiuong + "', '" + GiaTien + "')";

                fn.SetData(query, "Đã Thêm Phòng");

                UC_Addroom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Xin vui lòng điền đẩy đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtSoPhong.Clear();
            txtLoaiPhong.SelectedIndex = -1;
            txtLoaiGiuong.SelectedIndex = -1;
            txtGiaTien.Clear();
        }

        private void UC_Addroom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_Addroom_Enter(object sender, EventArgs e)
        {
            UC_Addroom_Load(this,null); 
        }
    }
}
