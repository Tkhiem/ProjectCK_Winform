
using Guna.UI2.WinForms;
namespace ProjectWinForm_CK.QLyKhachSan
{
    partial class UC_CustomerRegister
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQTich = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_GioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTime_NgSinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaDD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DateTime_NgDKy = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_LoaiGiuong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbo_Phong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbo_SoPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtGiaTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_ThemKH = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(88, 73);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "Nhập Họ Tên";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(306, 48);
            this.txtHoTen.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtHoTen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(88, 167);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "Nhập SĐT";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(306, 48);
            this.txtSDT.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSDT.TabIndex = 2;
            this.txtSDT.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quốc Tịch";
            // 
            // txtQTich
            // 
            this.txtQTich.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQTich.DefaultText = "";
            this.txtQTich.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQTich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQTich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQTich.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQTich.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQTich.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtQTich.ForeColor = System.Drawing.Color.Black;
            this.txtQTich.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQTich.Location = new System.Drawing.Point(88, 253);
            this.txtQTich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQTich.Name = "txtQTich";
            this.txtQTich.PasswordChar = '\0';
            this.txtQTich.PlaceholderText = "Nhập Quốc Tịch";
            this.txtQTich.SelectedText = "";
            this.txtQTich.Size = new System.Drawing.Size(306, 48);
            this.txtQTich.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtQTich.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giới Tính";
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cbo_GioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_GioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_GioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_GioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cbo_GioiTinh.ItemHeight = 30;
            this.cbo_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbo_GioiTinh.Location = new System.Drawing.Point(88, 350);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(306, 36);
            this.cbo_GioiTinh.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbo_GioiTinh.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày Sinh";
            // 
            // DateTime_NgSinh
            // 
            this.DateTime_NgSinh.BorderRadius = 18;
            this.DateTime_NgSinh.Checked = true;
            this.DateTime_NgSinh.FillColor = System.Drawing.Color.White;
            this.DateTime_NgSinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DateTime_NgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTime_NgSinh.Location = new System.Drawing.Point(89, 456);
            this.DateTime_NgSinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTime_NgSinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTime_NgSinh.Name = "DateTime_NgSinh";
            this.DateTime_NgSinh.Size = new System.Drawing.Size(275, 50);
            this.DateTime_NgSinh.TabIndex = 4;
            this.DateTime_NgSinh.Value = new System.DateTime(2023, 11, 30, 15, 17, 50, 823);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(510, 167);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "Nhập Địa Chỉ";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(306, 48);
            this.txtDiaChi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDiaChi.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Địa chỉ";
            // 
            // txtMaDD
            // 
            this.txtMaDD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDD.DefaultText = "";
            this.txtMaDD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaDD.ForeColor = System.Drawing.Color.Black;
            this.txtMaDD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDD.Location = new System.Drawing.Point(512, 73);
            this.txtMaDD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDD.Name = "txtMaDD";
            this.txtMaDD.PasswordChar = '\0';
            this.txtMaDD.PlaceholderText = "Nhập Mã Định Danh";
            this.txtMaDD.SelectedText = "";
            this.txtMaDD.Size = new System.Drawing.Size(306, 48);
            this.txtMaDD.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMaDD.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(509, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã Định Danh";
            // 
            // DateTime_NgDKy
            // 
            this.DateTime_NgDKy.BorderRadius = 18;
            this.DateTime_NgDKy.Checked = true;
            this.DateTime_NgDKy.FillColor = System.Drawing.Color.White;
            this.DateTime_NgDKy.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DateTime_NgDKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTime_NgDKy.Location = new System.Drawing.Point(510, 270);
            this.DateTime_NgDKy.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTime_NgDKy.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTime_NgDKy.Name = "DateTime_NgDKy";
            this.DateTime_NgDKy.Size = new System.Drawing.Size(306, 50);
            this.DateTime_NgDKy.TabIndex = 10;
            this.DateTime_NgDKy.Value = new System.DateTime(2023, 11, 30, 15, 17, 50, 823);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(519, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ngày Đăng Ký";
            // 
            // cbo_LoaiGiuong
            // 
            this.cbo_LoaiGiuong.BackColor = System.Drawing.Color.Transparent;
            this.cbo_LoaiGiuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_LoaiGiuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiGiuong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_LoaiGiuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_LoaiGiuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_LoaiGiuong.ForeColor = System.Drawing.Color.Black;
            this.cbo_LoaiGiuong.ItemHeight = 30;
            this.cbo_LoaiGiuong.Items.AddRange(new object[] {
            "Single",
            "Double",
            "KingSize"});
            this.cbo_LoaiGiuong.Location = new System.Drawing.Point(926, 73);
            this.cbo_LoaiGiuong.Name = "cbo_LoaiGiuong";
            this.cbo_LoaiGiuong.Size = new System.Drawing.Size(306, 36);
            this.cbo_LoaiGiuong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbo_LoaiGiuong.TabIndex = 13;
            this.cbo_LoaiGiuong.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiGiuong_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(923, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "Loại Giường";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(923, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 21);
            this.label14.TabIndex = 11;
            this.label14.Text = "Loại Phòng";
            // 
            // cbo_Phong
            // 
            this.cbo_Phong.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Phong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Phong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Phong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Phong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Phong.ForeColor = System.Drawing.Color.Black;
            this.cbo_Phong.ItemHeight = 30;
            this.cbo_Phong.Items.AddRange(new object[] {
            "VIP",
            "Normal"});
            this.cbo_Phong.Location = new System.Drawing.Point(926, 167);
            this.cbo_Phong.Name = "cbo_Phong";
            this.cbo_Phong.Size = new System.Drawing.Size(306, 36);
            this.cbo_Phong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbo_Phong.TabIndex = 13;
            this.cbo_Phong.SelectedIndexChanged += new System.EventHandler(this.cbo_Phong_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(923, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 21);
            this.label16.TabIndex = 11;
            this.label16.Text = "Số Phòng";
            // 
            // cbo_SoPhong
            // 
            this.cbo_SoPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbo_SoPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_SoPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SoPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_SoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_SoPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_SoPhong.ForeColor = System.Drawing.Color.Black;
            this.cbo_SoPhong.ItemHeight = 30;
            this.cbo_SoPhong.Location = new System.Drawing.Point(927, 241);
            this.cbo_SoPhong.Name = "cbo_SoPhong";
            this.cbo_SoPhong.Size = new System.Drawing.Size(306, 36);
            this.cbo_SoPhong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbo_SoPhong.TabIndex = 13;
            this.cbo_SoPhong.SelectedIndexChanged += new System.EventHandler(this.cbo_SoPhong_SelectedIndexChanged);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTien.DefaultText = "";
            this.txtGiaTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaTien.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGiaTien.ForeColor = System.Drawing.Color.Black;
            this.txtGiaTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaTien.Location = new System.Drawing.Point(927, 338);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.PasswordChar = '\0';
            this.txtGiaTien.PlaceholderText = "";
            this.txtGiaTien.ReadOnly = true;
            this.txtGiaTien.SelectedText = "";
            this.txtGiaTien.Size = new System.Drawing.Size(306, 48);
            this.txtGiaTien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGiaTien.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(923, 313);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 21);
            this.label18.TabIndex = 15;
            this.label18.Text = "Giá tiền";
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.BorderRadius = 18;
            this.btn_ThemKH.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btn_ThemKH.BorderThickness = 1;
            this.btn_ThemKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemKH.FillColor = System.Drawing.Color.White;
            this.btn_ThemKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemKH.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemKH.Location = new System.Drawing.Point(1053, 424);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(180, 45);
            this.btn_ThemKH.TabIndex = 17;
            this.btn_ThemKH.Text = "Thêm Khách Hàng";
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_CustomerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ThemKH);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbo_SoPhong);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbo_Phong);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbo_LoaiGiuong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DateTime_NgDKy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaDD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DateTime_NgSinh);
            this.Controls.Add(this.cbo_GioiTinh);
            this.Controls.Add(this.txtQTich);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_CustomerRegister";
            this.Size = new System.Drawing.Size(1320, 603);
            this.Load += new System.EventHandler(this.UC_CustomerRegister_Load);
            this.Leave += new System.EventHandler(this.UC_CustomerRegister_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna2TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private Guna2TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private Guna2TextBox txtQTich;
        private System.Windows.Forms.Label label6;
        private Guna2ComboBox cbo_GioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna2DateTimePicker DateTime_NgSinh;
        private Guna2TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private Guna2TextBox txtMaDD;
        private System.Windows.Forms.Label label9;
        private Guna2DateTimePicker DateTime_NgDKy;
        private System.Windows.Forms.Label label10;
        private Guna2ComboBox cbo_LoaiGiuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private Guna2ComboBox cbo_Phong;
        private System.Windows.Forms.Label label16;
        private Guna2ComboBox cbo_SoPhong;
        private Guna2TextBox txtGiaTien;
        private System.Windows.Forms.Label label18;
        private Guna2Button btn_ThemKH;
        private Guna2Elipse guna2Elipse1;
    }
}
