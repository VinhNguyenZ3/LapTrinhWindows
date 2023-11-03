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
    public partial class frmThanhVien : Form
    {
        int RowIndex = 0;
        int matv = 0;
        string AddOrEdit = "";
        public static ThanhVien thanhvien = null;
        ThanhVienDAO thanhVienDAO = new ThanhVienDAO();
        public frmThanhVien()
        {
            InitializeComponent();
        }

        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = thanhVienDAO.getList();
            txtTongTV.Text = thanhVienDAO.getCount().ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string tendangnhap = txtTenDangNhap.Text.Trim();
                string matkhau = txtMatKhau.Text.Trim();
                string hoten = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string dienthoai = txtDienThoai.Text.Trim();
                string quyen = cbQuyen.Text;
                switch (AddOrEdit)
                {
                    case "Add":
                        {
                            ThanhVien tv = new ThanhVien();
                            tv.TenDangNhap = tendangnhap;
                            tv.MatKhau = matkhau;
                            tv.HoTen = hoten;
                            tv.Email = email;
                            tv.DienThoai = dienthoai;
                            tv.Quyen = quyen;
                            thanhVienDAO.Insert(tv);
                            txtTongTV.Text = thanhVienDAO.getCount().ToString();
                            dgvDanhSach.DataSource = thanhVienDAO.getList();
                            break;
                        }
                    case "Edit":
                        {
                            //ThanhVien tv = thanhVienDAO.getRow(matv);
                            ThanhVien tv = thanhVienDAO.getRow(tendangnhap);
                            tv.TenDangNhap = tendangnhap;
                            tv.MatKhau = matkhau;
                            tv.HoTen = hoten;
                            tv.Email = email;
                            tv.DienThoai = dienthoai;
                            tv.Quyen = quyen;
                            thanhVienDAO.Update(tv);
                            dgvDanhSach.DataSource = thanhVienDAO.getList();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }
       
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                int vt = e.RowIndex;
                matv = int.Parse(dgvDanhSach.Rows[vt].Cells["MaTV"].Value.ToString());
                //Dưa dữ liệu lên lưới
                txtTenDangNhap.Text = dgvDanhSach.Rows[vt].Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dgvDanhSach.Rows[vt].Cells["MatKhau"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[vt].Cells["HoTen"].Value.ToString();
                txtDienThoai.Text = dgvDanhSach.Rows[vt].Cells["DienThoai"].Value.ToString();
                txtEmail.Text = dgvDanhSach.Rows[vt].Cells["Email"].Value.ToString();
                cbQuyen.Text = dgvDanhSach.Rows[vt].Cells["Quyen"].Value.ToString();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTenDangNhap.Text.Trim();
            //-------------------------------------------
            ThanhVien tv = thanhVienDAO.getRow(tendangnhap);
            thanhVienDAO.Delete(tv);
            txtTongTV.Text = thanhVienDAO.getCount().ToString();
            dgvDanhSach.DataSource = thanhVienDAO.getList();
        }

       
    }
}
