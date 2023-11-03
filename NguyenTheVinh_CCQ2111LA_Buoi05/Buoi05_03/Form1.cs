using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        int rowindex = -1;
        string[] listLoaiSP = { "Trang điểm", "Áo thun", "Quần dài" };
        string[] listDonViTinh = { "Cái", "Đôi" };
        private void Form1_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = listLoaiSP;
            cbDonViTinh.DataSource = listDonViTinh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double soluong, gia;
            try
            {
                if (txtMaSP.Text.Length < 2)
                    throw new Exception("Mã sản phẩm phải nhiều hơn 2 ký tự.");
                if (this.checkMaSP(txtMaSP.Text) == false)
                    throw new Exception("Mã SP đã tồn tại.");
                if (txtTenSP.Text.Length.Equals(0))
                    throw new Exception("Tên SP không được để trống.");
                if (!double.TryParse(nudSoLuong.Text, out soluong))
                    throw new Exception("Sô lượng không phải số.");
                if (!double.TryParse(txtGia.Text, out gia))
                    throw new Exception("Giá không phải số.");
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string loaisp = cbLoaiSP.Text;
                double gia1 = Convert.ToDouble(txtGia.Text);
                double thanhtien = (double)(gia1 * (double)nudSoLuong.Value);
                string donvitinh = cbDonViTinh.Text;

                int rowindex = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value = tensp;
                dgvDanhSach.Rows[rowindex].Cells["LoaiSP"].Value = loaisp;
                dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[rowindex].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[rowindex].Cells["ThanhTien"].Value = thanhtien;
                dgvDanhSach.Rows[rowindex].Cells["DonViTinh"].Value = donvitinh;
                /*txtMaSP.Text = "";
                txtTenSP.Text = "";
                txtGia.Text = "";*/
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

        private bool checkMaSP(string masp)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSP"].Value.ToString() == masp)
                    return false;
            }
            return true;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            double soluong, gia;
            try
            {
                if (txtMaSP.Text.Length < 2)
                    throw new Exception("Mã sản phẩm phải nhiều hơn 2 ký tự.");
                if (txtTenSP.Text.Length.Equals(0))
                    throw new Exception("Tên SP không được để trống.");
                if (!double.TryParse(nudSoLuong.Text, out soluong))
                    throw new Exception("Sô lượng không phải số.");
                if (!double.TryParse(txtGia.Text, out gia))
                    throw new Exception("Giá không phải số.");

                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string loaisp = cbLoaiSP.Text;
                string donvitinh = cbDonViTinh.Text;

                dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value = tensp;
                dgvDanhSach.Rows[rowindex].Cells["LoaiSP"].Value = loaisp;
                dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[rowindex].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[rowindex].Cells["ThanhTien"].Value = ((int)gia * soluong).ToString();
                dgvDanhSach.Rows[rowindex].Cells["DonViTinh"].Value = donvitinh;
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
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                    throw new Exception("Chưa chọn sinh viên cần xóa.");
                dgvDanhSach.Rows.RemoveAt(rowindex);
                rowindex = -1;
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
        private void btnLoc_Click(object sender, EventArgs e)
        {
            
        }


    private void btnThoat_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Bạn có muốn thoát không",
            "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        rowindex = e.RowIndex;
        if (rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
        {
            txtMaSP.Text = dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString();
            txtTenSP.Text = dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value.ToString();
            txtGia.Text = dgvDanhSach.Rows[rowindex].Cells["Gia"].Value.ToString();
            nudSoLuong.Text = dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value.ToString();
            string loaisp = dgvDanhSach.Rows[rowindex].Cells["LoaiSP"].Value.ToString();
            string donvitinh = dgvDanhSach.Rows[rowindex].Cells["DonViTinh"].Value.ToString();
            int i = 0;
            while (i < listLoaiSP.Length && listLoaiSP[i] != loaisp)
            {
                i++;
            }
            while (i < listDonViTinh.Length && listDonViTinh[i] != donvitinh)
            {
                i++;
            }
            cbLoaiSP.SelectedIndex = i;
            cbDonViTinh.SelectedIndex = i;

        }
    
    }
}
}