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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //Thành viên đang đăng nhập
                ThanhVien thanhvien = frmMain.thanhvien;
                string matkhaucu = MaHoa.ToMD5(txtMKCu.Text.Trim());
                if (!thanhvien.MatKhau.Equals(matkhaucu))
                    throw new Exception("Mật khẩu cũ không chính xác");
                if (!txtMKCu.Text.Trim().Equals(txtMKXacNhan.Text.Trim()))
                    throw new Exception("Mật khẩu mới không khớp");
                string matkhau = MaHoa.ToMD5(txtMKMoi.Text.Trim());
                thanhvien.MatKhau = matkhau; //Cập nhật một khâu
                ThanhVienDAO tvDAO = new ThanhVienDAO();
                tvDAO.Update(thanhvien);
                MessageBox.Show("Cập nhật thành công");
                frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbDoiMatKhau"]);
            }catch (Exception ex) {
                MessageBox.Show(ex.Message, "Thông báo");

            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbDoiMatKhau"]);
        }

       
    }
}
