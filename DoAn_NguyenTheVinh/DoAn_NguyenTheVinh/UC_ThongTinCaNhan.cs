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

namespace DoAn_NguyenTheVinh
{
    public partial class UC_ThongTinCaNhan : UserControl
    {
        public UC_ThongTinCaNhan()
        {
            InitializeComponent();
        }
        public string Data { get; set; }
        UserDAO userDAO = new UserDAO();

    private void UC_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            string[] userArray = userDAO.getInfoUser(Data);
            txtUserID.Text = userArray[0];
            txtUsername.Text = userArray[1];
            txtFullName.Text = userArray[3];
            txtStatus.Text = userArray[4];
            txtPhoneNumber.Text = userArray[5];
            txtAddress.Text = userArray[6];
            txtDateOfBirth.Text = userArray[7];
            txtRole.Text = userArray[8];
        }
    }
}
