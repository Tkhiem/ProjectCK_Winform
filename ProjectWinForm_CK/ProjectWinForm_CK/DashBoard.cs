using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectWinForm_CK.QLyKhachHang; // Import namespace của UC_Addroom
using ProjectWinForm_CK.QLyKhachSan;

namespace ProjectWinForm_CK
{
    public partial class DashBoard : Form
    {
        private UC_Addroom ucAddroom; // Khai báo biến để lưu trữ UC_Addroom
        private UC_CustomerRegister ucCusTomerRegister;
        public DashBoard()
        {
            InitializeComponent();
            ucAddroom = new UC_Addroom(); // Khởi tạo UC_Addroom
            ucCusTomerRegister=new UC_CustomerRegister();//Khởi tạo UC_CustomerRegister
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashBoard_Load_1(object sender, EventArgs e)
        {
            // Thêm UC_Addroom vào form DashBoard, ví dụ sử dụng một Panel có tên là panelContainer
            ucAddroom.Dock = DockStyle.Fill; // Đặt Dock để điều chỉnh kích thước UC_Addroom theo panelContainer
            panelContainer.Controls.Add(ucAddroom); // Thêm UC_Addroom vào panelContainer
            ucCusTomerRegister.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucCusTomerRegister);
            uC_Addroom1.Visible = false;
            ucCusTomerRegister.Visible = false;
            btnThemPhong.PerformClick();

        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            PanelMove.Left = btnThemPhong.Left + 12;//Di chuyển thanh panel
            uC_Addroom1.Visible = true;//Hien thi tren user control uC_Addroom1
            uC_Addroom1.BringToFront();//Dùng để đưa user control lên trên cùng các control khác, đảm bảo hiển thị phía trước nhất trên giao diện người dùng

        }


        private void btnDKKHang_Click(object sender, EventArgs e)
        {
            PanelMove.Left = btnDKKHang.Left + 12;
            uC_CustomerRegister1.Visible = true;
            uC_CustomerRegister1.BringToFront();
        }
    }
}
