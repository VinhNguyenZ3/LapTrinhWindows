﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi06_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "admin" && txtPassword.Text == "123")
            {
                frmMain.tendangnhap = txtUserName.Text;
                this.Close();
            }
            else
            {
                lbThongBao.Text = "Tài khoản không hợp lệ!";
            }
        }
            
    }
}