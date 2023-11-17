using DoAn_NguyenTheVinh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn_NguyenTheVinh
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username = txtTenDangNhap.Text.Trim();
            string password = txtPassword.Text.Trim();
            UserDAO userDAO = new UserDAO();
            
            if (username == userDAO.checkAccount(username))
            {
                if (("Active" == userDAO.checkUserStatus(username)) || 
                    ("Đang hoạt động" == userDAO.checkUserStatus(username)))
                {
                    if (password == userDAO.checkPassword(password))
                    {
                        UC_QLDVPhong qldvp = new UC_QLDVPhong();
                        qldvp.Data = username;
                        Main main = new Main();
                        main.Data = username;
                        UC_DoiMatKhau mk = new UC_DoiMatKhau();
                        mk.Data = username;
                        this.Hide();
                        main.ShowDialog();
                        this.Show();
                    }
                    else
                        lbThongBao.Text = "Sai mật khẩu!";
                }
                else if ("Bị khóa" == userDAO.checkUserStatus(username))
                    lbThongBao.Text = "Tên tài khoản hiện bị khóa";
            }
            else
                lbThongBao.Text = "Tài khoản không tồn tại!";
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo",
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
