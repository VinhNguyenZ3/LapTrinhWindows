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
    public partial class frmCTDonHang : Form
    {
        public frmCTDonHang()
        {
            InitializeComponent();
        }
        string insertupdate = "";
        DonHangChiTietDAO dhctDAO = new DonHangChiTietDAO();
        private void frmCTDonHang_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaSP.Enabled = false;
            btnXoa.Enabled = false;

            loadDSCTDH();
            TongCTDH();
        }
        private void TongCTDH()
        {
            txtTongSV.Text = dhctDAO.getCount().ToString();
        }
        private void loadDSCTDH()
        {
            dgvDanhSach.DataSource = dhctDAO.getList();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn chi tiết đơn hàng");
                }
                txtMaCTDH.Text = dgvDanhSach.Rows[rowindex].Cells["MaCTDH"].Value.ToString();
                txtMaDH.Text = dgvDanhSach.Rows[rowindex].Cells["MaDH"].Value.ToString();
                txtMaSP.Text = dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value.ToString();
                cbDVTinh.Text = dgvDanhSach.Rows[rowindex].Cells["DVTinh"].Value.ToString();
                txtDonGia.Text = dgvDanhSach.Rows[rowindex].Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value.ToString();
                txtGhiChu.Text = dgvDanhSach.Rows[rowindex].Cells["GhiChu"].Value.ToString();
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
            txtMaSP.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaSP.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.checkMCTDH(txtMaSP.Text) == false && insertupdate == "insert")
                    throw new Exception("Mã chi tiết đơn hàng đã tồn tại.");
                string mactdh = txtMaCTDH.Text;
                string madh = txtMaDH.Text;
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string donvitinh = cbDVTinh.Text;
                string dongia = txtDonGia.Text;
                string soluong = txtSoLuong.Text;
                string ghichu = txtGhiChu.Text;
                DonHangChiTiet ctdh = new DonHangChiTiet(mactdh, madh, masp, tensp, donvitinh, dongia, soluong, ghichu);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            dhctDAO.InsertTwo(ctdh);
                            loadDSCTDH();
                            TongCTDH();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            dhctDAO.UpdateTwo(ctdh);
                            loadDSCTDH();
                            TongCTDH();
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
        private bool checkMCTDH(string mactdh)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaCTDH"].Value.ToString() == mactdh)
                    return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSP.Text.Length != 10)
                {
                    throw new Exception("Mã chi tiết đơn hàng không đúng!");
                }
                string masp = txtTongSV.Text;
                dhctDAO.DeleteTwo(masp);
                loadDSCTDH();
                TongCTDH();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int donvitinh = int.Parse(cbDVTinh.SelectedValue.ToString());
            dgvDanhSach.DataSource = dhctDAO.getList(donvitinh);
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
