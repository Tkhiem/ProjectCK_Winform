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
        Function fn = new Function();
        String Query;
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
            Query = "select username,pass from employee where username = '" + txtTenTK.Text + "' and pass = '" + txtPassWord.Text + "'";
            DataSet ds = fn.getData(Query);
            if (ds.Tables[0].Rows.Count!=0)
            {
                lblError.Visible = false;
                DashBoard dash = new DashBoard();
                this.Hide();
                dash.Show();
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
