using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi06_02
{
    public partial class frmLoaiSP : Form
    {
        public frmLoaiSP()
        {
            InitializeComponent();
        }
        string insertupdate = "";
        LoaiSPDAO loaispDAO = new LoaiSPDAO();
        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaLoai.Enabled = false;
            btnXoa.Enabled = false;

            loadDSLoaiSP();
            TongLoaiSP();
        }
        private void TongLoaiSP()
        {
            txtTongSV.Text = loaispDAO.getCount().ToString();
        }
        private void loadDSLoaiSP()
        {
            dgvDanhSach.DataSource = loaispDAO.getList();
        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn mã loại");
                }
                txtMaLoai.Text = dgvDanhSach.Rows[rowindex].Cells["MaLoai"].Value.ToString();
                txtTenLoai.Text = dgvDanhSach.Rows[rowindex].Cells["TenLoai"].Value.ToString();
                txtChiTiet.Text = dgvDanhSach.Rows[rowindex].Cells["ChiTiet"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaLoai.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaLoai.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.checkMSSP(txtMaLoai.Text) == false && insertupdate == "insert")
                    throw new Exception("Mã loại đã tồn tại.");
                string maloai = txtMaLoai.Text;
                string tenloai = txtTenLoai.Text;
                string chitiet = txtChiTiet.Text;
                LoaiSP loaisp = new LoaiSP(maloai, tenloai, chitiet);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            loaispDAO.InsertTwo(loaisp);
                            loadDSLoaiSP();
                            TongLoaiSP();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            loaispDAO.UpdateTwo(loaisp);
                            loadDSLoaiSP();
                            TongLoaiSP();
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
        private bool checkMSSP(string ml)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaLoai"].Value.ToString() == ml)
                    return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLoai.Text.Length != 10)
                {
                    throw new Exception("Tên loại không đúng!");
                }
                string maloai = txtMaLoai.Text;
                loaispDAO.DeleteTwo(maloai);
                loadDSLoaiSP();
                TongLoaiSP();
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
                this.Close();
            }
        }
    }
}
