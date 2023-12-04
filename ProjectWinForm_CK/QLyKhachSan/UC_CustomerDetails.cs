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
    public partial class UC_CustomerDetails : UserControl
    {
        Function fn = new Function();
        String Query;
        public UC_CustomerDetails()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSearchBy.SelectedIndex == 0)
            {
                
            Query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid ";
                getRecord(Query);
            }else if (txtSearchBy.SelectedIndex == 1) {
                Query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where checkout is null";
                getRecord(Query);
            }
            else if (txtSearchBy.SelectedIndex == 2) {
                Query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where checkout is not null";
                getRecord(Query);
            }
        }
        private void getRecord(String Query)
        {
            DataSet ds = fn.getData(Query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
