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
    public partial class Form1 : Form
    {
        KhoaDAO khoaDAO = new KhoaDAO();
        SinhVienDAO svDAO = new SinhVienDAO();


        string insertupdate = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            mtbMaSV.Enabled = false;
            btnXoa.Enabled = false;

            loadDSKhoa();
            loadDSSinhVien();
            TongSinhVien();
        }

        private void TongSinhVien()
        {
            txtTongSV.Text = svDAO.getCount().ToString();
        }

        private void loadDSKhoa()
        {
            cbKhoa.DataSource = khoaDAO.getList();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        private void loadDSSinhVien()
        {
            dgvDanhSach.DataSource = svDAO.getList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            mtbMaSV.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            mtbMaSV.Enabled = false;
        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }
                mtbMaSV.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["TenKhoa"].Value.ToString();
                txtDiemTB.Text = dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
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
                double diemtb = 0;
                if (mtbMaSV.Text.Length != 10)
                    throw new Exception("Mã sinh viên 10 ký tự số!");
                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                    throw new Exception("Điểm sinh viên sô!");
                if (this.checkMSSV(mtbMaSV.Text) == false && insertupdate == "insert")
                    throw new Exception("Mã sinh viên đã tồn tại.");
                string masv = mtbMaSV.Text;
                string hoten = txtHoTen.Text;
                int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
                SinhVien sv = new SinhVien(masv, hoten, makhoa.ToString(), diemtb.ToString());
                switch (insertupdate)
                {
                    case "insert":
                        {
                            svDAO.InsertTwo(sv);
                            loadDSSinhVien();
                            TongSinhVien();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            svDAO.UpdateTwo(sv);
                            loadDSSinhVien();
                            TongSinhVien();
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
        private bool checkMSSV(string sv)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaKhoa"].Value.ToString() == sv)
                    return false;
            }
            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtbMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên không đúng!");
                }
                string masv = txtTongSV.Text;
                svDAO.DeleteTwo(masv);
                loadDSSinhVien();
                TongSinhVien();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
            dgvDanhSach.DataSource = svDAO.getList(makhoa);
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            frmKhoa frmKhoa = new frmKhoa();
            frmKhoa.ShowDialog();
        }

        private void cbKhoa_MouseClick(object sender, MouseEventArgs e)
        {
            loadDSKhoa();
        }
    }
}
