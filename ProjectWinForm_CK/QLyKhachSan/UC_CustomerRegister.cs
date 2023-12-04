using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectWinForm_CK.QLyKhachSan
{
    public partial class UC_CustomerRegister : UserControl
    {
        Function fn = new Function();
        string Query;
        public UC_CustomerRegister()
        {
            InitializeComponent();
        }
        public void setcomboBox(string Query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getforCombo(Query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
            private void guna2TextBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void UC_CustomerRegister_Load(object sender, EventArgs e)
            {

            }

            private void cbo_LoaiGiuong_SelectedIndexChanged(object sender, EventArgs e)
            {
            cbo_Phong.SelectedIndex = -1;
            cbo_SoPhong.Items.Clear();
            }

        private void cbo_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_SoPhong.Items.Clear();
            Query = "select roomNo from rooms where bed = '" + cbo_LoaiGiuong.Text + "' and roomType ='" + cbo_Phong.Text + "'and booked = 'NO'";
            setcomboBox(Query, cbo_SoPhong);
        }
        int rid;
        private void cbo_SoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query = "select price ,roomid from rooms where roomNo ='" + cbo_SoPhong.Text + "'";
            DataSet ds = fn.getData(Query);
            txtGiaTien.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0]["roomid"].ToString());
        }


        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtSDT.Text != "" && txtQTich.Text != "" && cbo_GioiTinh.Text != "" && DateTime_NgSinh.Text != "" && txtMaDD.Text != "" && txtDiaChi.Text != "" && DateTime_NgDKy.Text != "" && txtGiaTien.Text != "")
            {
                string name = txtHoTen.Text;
                Int64 mobile=Int64.Parse(txtSDT.Text);
                string national=txtQTich.Text;
                string gender = cbo_GioiTinh.Text;
                string dob = DateTime_NgSinh.Text;
                string idproof = txtMaDD.Text;
                string address = txtDiaChi.Text;
                string checkin = DateTime_NgDKy.Text;

                Query = "insert into customer (cname,mobile,nationality,gender,dob,idproof,address,checkin,roomid) values ('" + name + "','" + mobile + "','" + national + "','" + gender + "','"+dob+"','"+ idproof + "','" + address + "','" + checkin + "','" + rid + "') update rooms set booked = 'YES' where roomNo= '" + cbo_SoPhong.Text + "'";
                fn.SetData(Query," Số phòng "+cbo_SoPhong.Text +"Đăng ký khách hàng thành công");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin ", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ClearAll()
        {
            txtHoTen.Clear();
            txtSDT.Clear();
            txtQTich.Clear();
            cbo_GioiTinh.SelectedIndex = -1;
            DateTime_NgSinh.ResetText();
            txtMaDD.Clear();
            txtDiaChi.Clear();
            DateTime_NgDKy.ResetText();
            cbo_LoaiGiuong.SelectedIndex = -1;
            cbo_Phong.SelectedIndex = -1;
            cbo_SoPhong.Items.Clear();
            txtGiaTien.Clear();
        }

        private void UC_CustomerRegister_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
