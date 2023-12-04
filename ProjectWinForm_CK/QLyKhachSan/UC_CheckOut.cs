using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWinForm_CK.QLyKhachSan
{
    public partial class UC_CheckOut : UserControl
    {
        Function fn = new Function();
        string Query;
        public UC_CheckOut()
        {
            InitializeComponent();
        }

      

        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            Query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where checkout='NO'";
            DataSet ds = fn.getData(Query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where cname like '"+txtName.Text+"%' and checkout ='NO'";
            DataSet ds = fn.getData(Query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); 
                txtSoPhong.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if(MessageBox.Show("Bạn có chắc chắn không","Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
                {
                    string cdate = CheckOut_Date.Text;
                    Query = "update customer set chekout = 'YES' ,checkout ='" + cdate + "'where cid =" + id + "update rooms set booked ='NO' where roomNo='"+txtSoPhong.Text+"'";
                    fn.SetData(Query, "Thanh Toán Thành Công");
                    UC_CheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Không có khách hàng thanh toán ", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
        }
        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtSoPhong.Clear();
            CheckOut_Date.ResetText();
        }

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
