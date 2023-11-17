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
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }
        string insertupdate = "";
        CustomerDAO customerDAO = new CustomerDAO();
        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            RefeshInput();
            OnlyRead();
            loadDS(); 
            TongData();
        }
        private void TongData()
        {
            txtTongSV.Text = customerDAO.getCount().ToString();
        }
        private void RefeshInput()
        {
            txtCustomerID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            mtbDateOfBirth.Text = "";
            cbNationality.Text = "";
            txtIDCardNumber.Text = "";
        }
        private void OnlyRead()
        {
            txtCustomerID.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            mtbDateOfBirth.Enabled = false;
            cbNationality.Enabled = false;
            txtIDCardNumber.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void loadDS()
        {
            dgvDanhSach.DataSource = customerDAO.getList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            mtbDateOfBirth.Enabled = true;
            cbNationality.Enabled = true;
            txtIDCardNumber.Enabled = true;
            insertupdate = "insert";
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            mtbDateOfBirth.Enabled = true;
            cbNationality.Enabled = true;
            txtIDCardNumber.Enabled = true;
            insertupdate = "update";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.checkIDCustomer(int.Parse(txtCustomerID.Text)) == false && insertupdate == "insert")
                    throw new Exception("ID khách hàng đã tồn tại.");
                if (this.checkEmail(txtEmail.Text) == false && insertupdate == "insert")
                    throw new Exception("Emai này đã tồn tại.");
                if (this.checkCCCD(txtIDCardNumber.Text) == false && insertupdate == "insert")
                    throw new Exception("CCCD đã tồn tại.");
                int idcustomer = int.Parse(txtCustomerID.Text);
                string firstname = txtFirstName.Text;
                string lastname = txtLastName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                string nationality = cbNationality.Text;
                string cccd = txtIDCardNumber.Text;
                DateTime dateOfBirth;

                if (DateTime.TryParse(mtbDateOfBirth.Text, out dateOfBirth))
                {
                    Customer customer = new Customer(idcustomer, firstname, lastname, email,
                        phone, address, dateOfBirth, nationality, cccd);
                    switch (insertupdate)
                    {
                        case "insert":
                            {
                                customerDAO.InsertTwo(customer);
                                loadDS(); TongData();
                                OnlyRead();
                                MessageBox.Show("Thêm thành công", "Thông báo");
                                break;
                            }
                        case "update":
                            {
                                customerDAO.UpdateTwo(customer);
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
        private bool checkIDCustomer(int idcustomer)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["CustomerID"].Value.ToString() == idcustomer.ToString())
                    return false;
            }
            return true;
        }
        private bool checkEmail(string email)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["Email"].Value.ToString() == email)
                    return false;
            }
            return true;
        }
        private bool checkCCCD(string cccd)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["IDCardNumber"].Value.ToString() == cccd)
                    return false;
            }
            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int customerid = int.Parse(txtCustomerID.Text);
                if (MessageBox.Show("Bạn có xóa ID khách hàng: " + customerid + " ?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    customerDAO.DeleteTwo(customerid);
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

        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefeshInput();
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
                txtCustomerID.Text = dgvDanhSach.Rows[rowindex].Cells["CustomerID"].Value.ToString();
                txtFirstName.Text = dgvDanhSach.Rows[rowindex].Cells["FirstName"].Value.ToString();
                txtLastName.Text = dgvDanhSach.Rows[rowindex].Cells["LastName"].Value.ToString();
                txtEmail.Text = dgvDanhSach.Rows[rowindex].Cells["Email"].Value.ToString();
                txtPhone.Text = dgvDanhSach.Rows[rowindex].Cells["Phone"].Value.ToString();
                txtAddress.Text = dgvDanhSach.Rows[rowindex].Cells["Address"].Value.ToString();
                mtbDateOfBirth.Text = dgvDanhSach.Rows[rowindex].Cells["DateOfBirth"].Value.ToString();
                cbNationality.Text = dgvDanhSach.Rows[rowindex].Cells["Nationality"].Value.ToString();
                txtIDCardNumber.Text = dgvDanhSach.Rows[rowindex].Cells["IDCardNumber"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}
