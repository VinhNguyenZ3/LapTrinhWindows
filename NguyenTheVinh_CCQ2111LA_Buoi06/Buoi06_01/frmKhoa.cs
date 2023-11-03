using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi06_01
{
    public partial class frmKhoa : Form
    {
        KhoaDAO khoaDAO = new KhoaDAO();

        string insertupdate = "";
        public frmKhoa()
        {
            InitializeComponent();
        }
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaKhoa.Enabled = false;
            btnXoa.Enabled = false;
            loadDSKhoa();
        }

        private void loadDSKhoa()
        {
            dgvDanhSach.DataSource = khoaDAO.getList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaKhoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaKhoa.Enabled = false;
        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn khoa");
                }
                txtMaKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["MaKhoa"].Value.ToString();
                txtTenKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["TenKhoa"].Value.ToString();
                txtGhiChu.Text = dgvDanhSach.Rows[rowindex].Cells["GhiChu"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                /*double diemtb = 0;
                if (txtMaKhoa.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên 10 ký tự số!");
                }
                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("Điểm sinh viên sô!");
                }*/
                if (this.checkMaKhoa(txtMaKhoa.Text) == false && insertupdate== "insert")
                    throw new Exception("Mã khoa đã tồn tại.");
                MessageBox.Show("Thêm thành công", "Thông báo");
                string makhoa = txtMaKhoa.Text;
                string tenkhoa = txtTenKhoa.Text;
                string ghichu = txtGhiChu.Text;
                Khoa khoa = new Khoa(makhoa, tenkhoa, ghichu);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            khoaDAO.InsertTwo(khoa);
                            loadDSKhoa();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            
                            khoaDAO.UpdateTwo(khoa);
                            loadDSKhoa();
                            MessageBox.Show("Cập nhật thành công", "Thông báo");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool checkMaKhoa(string makhoa)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaKhoa"].Value.ToString() == makhoa)
                    return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                /*if (txt.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên không đúng!");
                }*/
                string makhoa = txtMaKhoa.Text;
                khoaDAO.DeleteTwo(makhoa);
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

    }
}
