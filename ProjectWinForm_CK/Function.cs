using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Ket noi sql
using System.Data;
using System.Windows.Forms;

namespace ProjectWinForm_CK
{
    internal class Function
    {
        protected SqlConnection getconnection()
        {
            SqlConnection com = new SqlConnection();
            //Tạo chuỗi kết nối SQL Server
            com.ConnectionString = "Data Source=WAGZINH\\SQLEXPRESS2022;Initial Catalog=MyHotel;Integrated Security=True";
            return com;
        }

        public DataSet getData(string Query) //Lấy dữ liệu từ database
        {
            SqlConnection com = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = com;
            cmd.CommandText = Query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void SetData(string Query, string message) //Update lại dữ liệu
        {
            SqlConnection com = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = com;
            com.Open();
            cmd.CommandText = Query;
            cmd.ExecuteNonQuery();
            com.Close();
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public SqlDataReader getforCombo(string query)
        {
            SqlConnection com = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = com;
            com.Open();
            cmd = new SqlCommand(query, com);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
