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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        string insertupdate = "";
        SanPhamDAO sanphamDAO = new SanPhamDAO();
        LoaiSPDAO loaispDAO = new LoaiSPDAO();

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaSP.Enabled = false;
            btnXoa.Enabled = false;
            loadDSLoaiSP();
            loadDSSanPham();
            TongSanPham();
        }
        private void TongSanPham()
        {
            txtTongSV.Text = sanphamDAO.getCount().ToString();
        }
        private void loadDSLoaiSP()
        {
            txtMaLoai.DataSource = loaispDAO.getList();
            txtMaLoai.DisplayMember = "MaLoai";
            //txtMaLoai.ValueMember = "MaKhoa";
        }
        private void loadDSSanPham()
        {
            dgvDanhSach.DataSource = sanphamDAO.getList();
        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sản phẩm");
                }
                txtMaSP.Text = dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString();
                txtMaLoai.Text = dgvDanhSach.Rows[rowindex].Cells["MaLoai"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value.ToString();
                cbDonViTinh.Text = dgvDanhSach.Rows[rowindex].Cells["DVTinh"].Value.ToString();
                txtGiaMua.Text = dgvDanhSach.Rows[rowindex].Cells["GiaMua"].Value.ToString();
                txtGiaBan.Text = dgvDanhSach.Rows[rowindex].Cells["GiaBan"].Value.ToString();
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
                //double diemtb = 0;
                //if (!double.TryParse(txtDiemTB.Text, out diemtb))
                //    throw new Exception("Điểm sinh viên sô!");
                if (this.checkMSSP(txtMaSP.Text) == false && insertupdate == "insert")
                    throw new Exception("Mã sinh viên đã tồn tại.");
                string masp = txtMaSP.Text;
                string maloai = txtMaLoai.Text;
                string tensp = txtTenSP.Text;
                string donvitinh = cbDonViTinh.Text;
                string giamua = txtGiaMua.Text;
                string giaban = txtGiaBan.Text;
                SanPham sp = new SanPham(masp, maloai, tensp, donvitinh, giamua, giaban);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            sanphamDAO.InsertTwo(sp);
                            loadDSSanPham();
                            TongSanPham();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            sanphamDAO.UpdateTwo(sp);
                            loadDSSanPham();
                            TongSanPham();
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
        private bool checkMSSP(string sp)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSP"].Value.ToString() == sp)
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
                    throw new Exception("Mã sản phẩm không đúng!");
                }
                string masp = txtTongSV.Text;
                sanphamDAO.DeleteTwo(masp);
                loadDSSanPham();
                TongSanPham();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int donvitinh = int.Parse(cbDonViTinh.SelectedValue.ToString());
            dgvDanhSach.DataSource = sanphamDAO.getList(donvitinh);
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







        //-----------------Menu strip------------------------
        bool isFrmLoaiSP = false;
        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFrmLoaiSP)
            {
                frmLoaiSP frmloaisp = new frmLoaiSP();
                isFrmLoaiSP = true;
                frmloaisp.Closed += (s, args) => isFrmLoaiSP = false;
                frmloaisp.Show();
            }
            else
            {
                frmLoaiSP frmloaisp = Application.OpenForms.OfType<frmLoaiSP>().FirstOrDefault();
                frmloaisp?.BringToFront();
            }
        }
        bool isFrmDonHang = false;
        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFrmDonHang)
            {
                frmDonHang frmdonhang = new frmDonHang();
                isFrmDonHang = true;
                frmdonhang.Closed += (s, args) => isFrmDonHang = false;
                frmdonhang.Show();
            }
            else
            {
                frmDonHang frmdonhang = Application.OpenForms.OfType<frmDonHang>().FirstOrDefault();
                frmdonhang?.BringToFront();
            }
        }
        bool isFrmCTDonHang = false;
        private void đơnHàngChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFrmCTDonHang)
            {
                frmCTDonHang frmctdonhang = new frmCTDonHang();
                isFrmCTDonHang = true;
                frmctdonhang.Closed += (s, args) => isFrmCTDonHang = false;
                frmctdonhang.Show();
            }
            else
            {
                frmCTDonHang frmctdonhang = Application.OpenForms.OfType<frmCTDonHang>().FirstOrDefault();
                frmctdonhang?.BringToFront();
            }
        }

        private void txtMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDSLoaiSP();
        }
    }
}
