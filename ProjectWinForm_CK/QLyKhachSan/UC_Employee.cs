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
    public partial class UC_Employee : UserControl
    {
        Function fn = new Function();
        String Query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            GetMaxID();
        }
        // >>>>>>>>>>>>>>>>>>>>>>
        public void GetMaxID()
        {
            Query = "select max(eid) from employee ";
            DataSet ds = fn.getData(Query);
            if (ds.Tables[0].Rows[0][0].ToString()!="")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num+1).ToString();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String userName = txtUserName.Text;
                String password = txtPassword.Text;

                Query = "insert into employee (ename, mobile, gender, emailid, username, pass) values ('" + name + "', " + mobile + ", '" + gender + "', '" + email + "', '" + userName + "', '" + password + "')";
                fn.SetData(Query, "Đăng ký nhân viên thành công !!");

                clearAll();
                GetMaxID();
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtUserName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabEmployee.SelectedIndex == 1) 
            {
                setEmployee(guna2DataGridView1); 
            } else if( tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }
        public void setEmployee(DataGridView dvg)
        {
            Query = "select * from employee";
            DataSet ds = fn.getData(Query);
            dvg.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Query = "DELETE FROM employee WHERE eid = " + txtID.Text;
                    fn.SetData(Query, "Thông tin nhân viên đã được xóa !!!");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }


        private void tabEmployee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
