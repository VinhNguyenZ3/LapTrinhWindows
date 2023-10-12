using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rowchoose;
        string[] danhsachkhoa = { "CNTT", "QTKD", "Kế Toán", "Ngoại ngữ", "Kỹ thuật ô tô", "Quản trị nhà hàng", "Quản trị khách sạn", "Cơ khí" };

        private void btnThem_Click(object sender, EventArgs e)
        {
           try
            {
                if (mtbMSSV.Text.Length != 10)
                    throw new Exception("Mã sinh viên phải đúng 10 số.");
                if (txtHoTen.Text.Length < 2)
                    throw new Exception("Họ tên sinh viên ít nhất 2 ký tự.");
                string mssv = mtbMSSV.Text;
                string hoten = txtHoTen.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;

                int rowindex = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value = mssv;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
       

    private void Form1_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.MaxDate = DateTime.Now;
            loadkhoa();
        }
        private void loadkhoa()
        {
            cbKhoa.DataSource = danhsachkhoa;
            cbKhoa.SelectedItem = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                    throw new Exception("Chưa chọn sinh viên cần cập nhật.");
                if (mtbMSSV.Text.Length != 10)
                    throw new Exception("Mã sinh viên phải đúng 10 số.");
                if (txtHoTen.Text.Length < 2)
                    throw new Exception("Họ tên sinh viên ít nhất 2 ký tự.");
                string masv = mtbMSSV.Text;
                string hoten = txtHoTen.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;

                dgvDanhSach.Rows[rowchoose].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowchoose].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowchoose].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowchoose].Cells["Khoa"].Value = khoa;
            }
            catch(Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Thông báo", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                    throw new Exception("Chưa chọn sinh viên cần xóa.");
                dgvDanhSach.Rows.RemoveAt(rowchoose);
                rowchoose = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Thông báo", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.RowIndex >= dgvDanhSach.Rows.Count - 1)
                    throw new Exception("Chưa chọn sinh viên");
                rowchoose = e.RowIndex;
                mtbMSSV.Text = dgvDanhSach.Rows[rowchoose].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowchoose].Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSach.Rows[rowchoose].Cells["NgaySinh"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowchoose].Cells["Khoa"].Value.ToString();
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                   ex.Message,
                   "Thông báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }
    }
}
