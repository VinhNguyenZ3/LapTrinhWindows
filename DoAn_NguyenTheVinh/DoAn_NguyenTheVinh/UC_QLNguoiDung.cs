using DoAn_NguyenTheVinh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_NguyenTheVinh
{
    public partial class UC_QLNguoiDung : UserControl
    {
        public UC_QLNguoiDung()
        {
            InitializeComponent();
        }
        string insertupdate = "";
        UserDAO userDAO = new UserDAO();
        private void UC_QLNguoiDung_Load(object sender, EventArgs e)
        {
            
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            RefeshInput();
            OnlyRead();
            loadDS(); TongData();
        }
        private void TongData()
        {
            txtTongSV.Text = userDAO.getCount().ToString();
        }
        private void RefeshInput()
        {
            txtUserID.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            cbStatus.Text = "";
            cbRole.Text = "";
            txtAddress.Text = "";
            mtbPhoneNumber.Text = "";
            mtbDateOfBirth.Text = "";
        }
        private void OnlyRead()
        {
            txtUserID.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtFullName.Enabled = false;
            cbStatus.Enabled = false;
            cbRole.Enabled = false;
            txtAddress.Enabled = false;
            mtbPhoneNumber.Enabled = false;
            mtbDateOfBirth.Enabled = false;
        }
        private void loadDS()
        {
            dgvDanhSach.DataSource = userDAO.getList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtUserID.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtFullName.Enabled = true;
            cbStatus.Enabled = true;
            cbRole.Enabled = true;
            txtAddress.Enabled = true;
            mtbPhoneNumber.Enabled = true;
            mtbDateOfBirth.Enabled = true;
            insertupdate = "insert";
            btnLuu.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtUserID.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtFullName.Enabled = true;
            cbStatus.Enabled = true;
            cbRole.Enabled = true;
            txtAddress.Enabled = true;
            mtbPhoneNumber.Enabled = true;
            mtbDateOfBirth.Enabled = true;
            insertupdate = "update";
            btnLuu.Enabled = true;
        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn người dùng");
                }
                txtUserID.Text = dgvDanhSach.Rows[rowindex].Cells["UserID"].Value.ToString();
                txtUsername.Text = dgvDanhSach.Rows[rowindex].Cells["Username"].Value.ToString();
                txtPassword.Text = dgvDanhSach.Rows[rowindex].Cells["Password"].Value.ToString();
                txtFullName.Text = dgvDanhSach.Rows[rowindex].Cells["FullName"].Value.ToString();
                mtbPhoneNumber.Text = dgvDanhSach.Rows[rowindex].Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = dgvDanhSach.Rows[rowindex].Cells["Address"].Value.ToString();
                mtbDateOfBirth.Text = dgvDanhSach.Rows[rowindex].Cells["DateOfBirth"].Value.ToString();
                cbStatus.Text = dgvDanhSach.Rows[rowindex].Cells["Status"].Value.ToString();
                cbRole.Text = dgvDanhSach.Rows[rowindex].Cells["Role"].Value.ToString();
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
                //double diemtb = 0;
                //if (!double.TryParse(txtDiemTB.Text, out diemtb))
                //    throw new Exception("Điểm sinh viên sô!");
                if (this.checkUserID(txtUserID.Text) == false && insertupdate == "insert")
                    throw new Exception("ID người dùng đã tồn tại.");
                if (this.checkUsername(txtUsername.Text) == false && insertupdate == "insert")
                    throw new Exception("Tên đang nhập đã tồn tại.");
                int userid = int.Parse(txtUserID.Text);
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string fullname = txtFullName.Text;
                string status = cbStatus.Text;
                string phonenumber =mtbPhoneNumber.Text;
                string address = txtAddress.Text;
                string role = cbRole.Text;
                DateTime dateOfBirth;
                if (DateTime.TryParse(mtbDateOfBirth.Text, out dateOfBirth))
                {
                    User user = new User(userid, username, password, fullname, status, phonenumber, address, dateOfBirth, role);
                    switch (insertupdate)
                    {
                        case "insert":
                            {
                                userDAO.InsertTwo(user);
                                loadDS(); TongData();
                                OnlyRead();
                                MessageBox.Show("Thêm thành công", "Thông báo");
                                break;
                            }
                        case "update":
                            {
                                userDAO.UpdateTwo(user);
                                loadDS(); TongData();
                                OnlyRead();
                                MessageBox.Show("Cập nhật thành công", "Thông báo");
                                break;
                            }
                    }
                }
                else
                    MessageBox.Show("Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool checkUserID(string userid)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["UserID"].Value.ToString() == userid)
                    return false;
            }
            return true;
        }
        private bool checkUsername(string username)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["Username"].Value.ToString() == username)
                    return false;
            }
            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = int.Parse(txtUserID.Text);
                if (MessageBox.Show("Bạn có muốn xóa ID người dùng: " + userid + " ?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    userDAO.DeleteTwo(userid);
                    loadDS(); TongData();
                    RefeshInput();
                    OnlyRead();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            //int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
            //dgvDanhSach.DataSource = svDAO.getList(makhoa);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefeshInput();
        }
    }
}
