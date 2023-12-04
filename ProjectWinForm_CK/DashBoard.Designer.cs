﻿using Guna.UI2.WinForms;
namespace ProjectWinForm_CK
{
    partial class DashBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnMini = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMove = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThongTinKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDKKHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemPhong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Employee1 = new ProjectWinForm_CK.QLyKhachSan.UC_Employee();
            this.uC_CustomerDetails1 = new ProjectWinForm_CK.QLyKhachSan.UC_CustomerDetails();
            this.uC_CheckOut1 = new ProjectWinForm_CK.QLyKhachSan.UC_CheckOut();
            this.uC_CustomerRegister1 = new ProjectWinForm_CK.QLyKhachSan.UC_CustomerRegister();
            this.uC_Addroom1 = new ProjectWinForm_CK.QLyKhachHang.UC_Addroom();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThoat.Location = new System.Drawing.Point(4, 2);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 41);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnMini
            // 
            this.btnMini.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMini.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMini.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMini.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMini.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMini.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMini.Location = new System.Drawing.Point(4, 50);
            this.btnMini.Margin = new System.Windows.Forms.Padding(4);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(40, 41);
            this.btnMini.TabIndex = 0;
            this.btnMini.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.uC_Employee1);
            this.panelContainer.Controls.Add(this.uC_CustomerDetails1);
            this.panelContainer.Controls.Add(this.uC_CheckOut1);
            this.panelContainer.Controls.Add(this.uC_CustomerRegister1);
            this.panelContainer.Controls.Add(this.uC_Addroom1);
            this.panelContainer.Location = new System.Drawing.Point(52, 15);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1737, 708);
            this.panelContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PanelMove);
            this.panel1.Controls.Add(this.btnThongTinKH);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnDKKHang);
            this.panel1.Controls.Add(this.btnThemPhong);
            this.panel1.Location = new System.Drawing.Point(113, 752);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1629, 134);
            this.panel1.TabIndex = 3;
            // 
            // PanelMove
            // 
            this.PanelMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelMove.Location = new System.Drawing.Point(39, 122);
            this.PanelMove.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMove.Name = "PanelMove";
            this.PanelMove.Size = new System.Drawing.Size(240, 5);
            this.PanelMove.TabIndex = 4;
            // 
            // btnThongTinKH
            // 
            this.btnThongTinKH.BorderRadius = 18;
            this.btnThongTinKH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongTinKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongTinKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongTinKH.FillColor = System.Drawing.Color.SlateBlue;
            this.btnThongTinKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinKH.ForeColor = System.Drawing.Color.White;
            this.btnThongTinKH.Location = new System.Drawing.Point(1007, 34);
            this.btnThongTinKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongTinKH.Name = "btnThongTinKH";
            this.btnThongTinKH.Size = new System.Drawing.Size(292, 85);
            this.btnThongTinKH.TabIndex = 0;
            this.btnThongTinKH.Text = "Thông Tin Khách Hàng";
            this.btnThongTinKH.Click += new System.EventHandler(this.btnThongTinKH_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BorderRadius = 18;
            this.btnNhanVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.FillColor = System.Drawing.Color.SlateBlue;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(1340, 34);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(267, 85);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderRadius = 18;
            this.btnThanhToan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.SlateBlue;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(683, 34);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(267, 85);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDKKHang
            // 
            this.btnDKKHang.BorderRadius = 18;
            this.btnDKKHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDKKHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDKKHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDKKHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDKKHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDKKHang.FillColor = System.Drawing.Color.SlateBlue;
            this.btnDKKHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDKKHang.ForeColor = System.Drawing.Color.White;
            this.btnDKKHang.Location = new System.Drawing.Point(356, 34);
            this.btnDKKHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnDKKHang.Name = "btnDKKHang";
            this.btnDKKHang.Size = new System.Drawing.Size(267, 85);
            this.btnDKKHang.TabIndex = 0;
            this.btnDKKHang.Text = "Đăng Ký Khách Hàng";
            this.btnDKKHang.Click += new System.EventHandler(this.btnDKKHang_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BorderRadius = 18;
            this.btnThemPhong.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThemPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemPhong.FillColor = System.Drawing.Color.SlateBlue;
            this.btnThemPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.ForeColor = System.Drawing.Color.White;
            this.btnThemPhong.Location = new System.Drawing.Point(25, 34);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(267, 85);
            this.btnThemPhong.TabIndex = 0;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(-2, -1);
            this.uC_Employee1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1712, 708);
            this.uC_Employee1.TabIndex = 4;
            // 
            // uC_CustomerDetails1
            // 
            this.uC_CustomerDetails1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetails1.Location = new System.Drawing.Point(-1, -1);
            this.uC_CustomerDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_CustomerDetails1.Name = "uC_CustomerDetails1";
            this.uC_CustomerDetails1.Size = new System.Drawing.Size(1760, 742);
            this.uC_CustomerDetails1.TabIndex = 3;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CheckOut1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_CheckOut1.Location = new System.Drawing.Point(-13, -14);
            this.uC_CheckOut1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1748, 741);
            this.uC_CheckOut1.TabIndex = 2;
            // 
            // uC_CustomerRegister1
            // 
            this.uC_CustomerRegister1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegister1.Location = new System.Drawing.Point(-1, -1);
            this.uC_CustomerRegister1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_CustomerRegister1.Name = "uC_CustomerRegister1";
            this.uC_CustomerRegister1.Size = new System.Drawing.Size(1760, 742);
            this.uC_CustomerRegister1.TabIndex = 1;
            // 
            // uC_Addroom1
            // 
            this.uC_Addroom1.BackColor = System.Drawing.Color.White;
            this.uC_Addroom1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Addroom1.ForeColor = System.Drawing.Color.Black;
            this.uC_Addroom1.Location = new System.Drawing.Point(-1, -14);
            this.uC_Addroom1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Addroom1.Name = "uC_Addroom1";
            this.uC_Addroom1.Size = new System.Drawing.Size(1759, 741);
            this.uC_Addroom1.TabIndex = 0;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1805, 970);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load_1);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Button btnThoat;
        private Guna2Button btnMini;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private Guna2Button btnThongTinKH;
        private Guna2Button btnNhanVien;
        private Guna2Button btnThanhToan;
        private Guna2Button btnDKKHang;
        private Guna2Button btnThemPhong;
        private Guna2Panel PanelMove;
        private Guna2Elipse guna2Elipse1;
        private QLyKhachHang.UC_Addroom uC_Addroom1;
        private Guna2Elipse guna2Elipse2;
        private Guna2Elipse guna2Elipse3;
        private QLyKhachSan.UC_CustomerRegister uC_CustomerRegister1;
        private QLyKhachSan.UC_CheckOut uC_CheckOut1;
        private Guna2Elipse guna2Elipse4;
        private QLyKhachSan.UC_CustomerDetails uC_CustomerDetails1;
        private Guna2Elipse guna2Elipse5;
        private QLyKhachSan.UC_Employee uC_Employee1;
    }
}