using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_01
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = MaHoa.ToMD5(txtMatKhau.Text.Trim());
            ThanhVienDAO thanhvienDAO = new ThanhVienDAO();
            ThanhVien tv = thanhvienDAO.getRow(username);
            if (tv == null)
            {
                lblThongBao.Text = "Tài khoản không tồn tại!";
            }
            else
            {
                if (password == tv.MatKhau)
                {
                    frmMain.thanhvien = tv;
                    this.Close();
                }
                else
                {
                    frmMain.thanhvien = tv;
                    this.Close();
                    //lblThongBao.Text = "Mật khẩu không chính xác!";
                }
            }
        }
    }
}
