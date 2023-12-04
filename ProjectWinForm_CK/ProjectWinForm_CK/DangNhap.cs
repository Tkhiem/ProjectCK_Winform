using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWinForm_CK
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();//Dừng chương trình
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text == "NguyenKhiem" && txtPassWord.Text == "123")
            {
                lblError.Visible = false;
                DashBoard ds = new DashBoard();
                this.Hide();
                ds.Show();
            }
            else
            {
                lblError.Visible = true;
                txtPassWord.Clear();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
