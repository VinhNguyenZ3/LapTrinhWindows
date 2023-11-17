using DoAn_NguyenTheVinh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn_NguyenTheVinh
{
    public partial class UC_DoiMatKhau : UserControl
    {
        public string Data { get; set; }
        public UC_DoiMatKhau()
        {
            InitializeComponent();
        }

        UserDAO userDAO = new UserDAO();
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                string matkhaucu = (txtMatKhauCu.Text.Trim());
                if (txtTenDangNhap.Text == userDAO.checkAccount(userDAO.getUser(Data)))
                {
                    if (!userDAO.Equals(matkhaucu))
                        throw new Exception("Mật khẩu cũ không chính xác");
                    if (!txtMatKhauCu.Text.Trim().Equals(txtMatKhauMoi.Text.Trim()))
                        throw new Exception("Mật khẩu mới không khớp");
                    string password = (txtMatKhauMoi.Text.Trim());
                    User user = new User(password);
                    userDAO.UpdatePassword(user);
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void UC_DoiMatKhau_Load(object sender, EventArgs e)
        {
            string[] userArray = userDAO.getInfoUser(Data);
            //txtTenDangNhap.Text = userArray[2];

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
