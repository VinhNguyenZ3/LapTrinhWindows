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
using static DoAn_NguyenTheVinh.Main;

namespace DoAn_NguyenTheVinh
{
    public partial class UC_DatPhong : UserControl
    {
        public UC_DatPhong()
        {
            InitializeComponent();
        }
        ReservationDAO reservationDAO = new ReservationDAO();
        RoomDAO roomDAO = new RoomDAO();
        CustomerDAO customerDAO = new CustomerDAO();
        string insertupdate = "";
        private void uc_DatPhong_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            RefeshInput();
            OnlyRead();
            loadDS();
            TongData(); 
            loadDSIDRoom();
            loadDSIDCustomer();
        }
        private void loadDSIDCustomer()
        {
            txtCustomerID.DataSource = customerDAO.getList();
            txtCustomerID.DisplayMember = "CustomerID";
            txtCustomerID.ValueMember = "CustomerID";
        }
        private void loadDSIDRoom()
        {
            txtRoomID.DataSource = roomDAO.getList();
            txtRoomID.DisplayMember = "RoomID";
            txtRoomID.ValueMember = "RoomID";
        }
        private void TongData()
        {
            txtTongSV.Text = reservationDAO.getCount().ToString();
        }
        private void RefeshInput()
        {
            txtReservationID.Text = "";
            txtCustomerID.Text = "";
            txtRoomID.Text = "";
            txtNumberOfAdults.Text = "";
            txtNumberOfChildren.Text = "";
            mtbCheckInDate.Text = "";
            mtbCheckOutDate.Text = "";
            cbCheckInStatus.Text = "";
            cbCheckOutStatus.Text = "";
            cbPaymentStatus.Text = "";
            txtSpecialRequests.Text = "";
            mtbTotalAmount.Text = "";
        }
        private void OnlyRead()
        {
            txtCustomerID.Enabled = false;
            txtReservationID.Enabled = false;
            txtCustomerID.Enabled = false;
            txtRoomID.Enabled = false;
            txtNumberOfAdults.Enabled = false;
            txtNumberOfChildren.Enabled = false;
            mtbCheckInDate.Enabled = false;
            mtbCheckOutDate.Enabled = false;
            cbCheckInStatus.Enabled = false;
            cbCheckOutStatus.Enabled = false;
            cbPaymentStatus.Enabled = false;
            txtSpecialRequests.Enabled = false;
            mtbTotalAmount.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void loadDS()
        {
            dgvDanhSach.DataSource = reservationDAO.getList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = true;
            txtReservationID.Enabled = true;
            txtCustomerID.Enabled = true;
            txtRoomID.Enabled = true;
            txtNumberOfAdults.Enabled = true;
            txtNumberOfChildren.Enabled = true;
            mtbCheckInDate.Enabled = true;
            mtbCheckOutDate.Enabled = true;
            cbCheckInStatus.Enabled = true;
            cbCheckOutStatus.Enabled = true;
            cbPaymentStatus.Enabled = true;
            txtSpecialRequests.Enabled = true;
            mtbTotalAmount.Enabled = true;
            insertupdate = "insert";
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = true;
            txtReservationID.Enabled = true;
            txtCustomerID.Enabled = true;
            txtRoomID.Enabled = true;
            txtNumberOfAdults.Enabled = true;
            txtNumberOfChildren.Enabled = true;
            mtbCheckInDate.Enabled = true;
            mtbCheckOutDate.Enabled = true;
            cbCheckInStatus.Enabled = true;
            cbCheckOutStatus.Enabled = true;
            cbPaymentStatus.Enabled = true;
            txtSpecialRequests.Enabled = true;
            mtbTotalAmount.Enabled = true;
            insertupdate = "update";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.checkIDReservation(int.Parse(txtReservationID.Text)) == false && insertupdate == "insert")
                    throw new Exception("ID đặt phòng đã tồn tại.");
                if (this.checkIDReservation02(txtReservationID.Text) == false && insertupdate == "insert")
                    throw new Exception("ID đặt phòng " + txtReservationID.Text + " không được có ký tự.");
                if (this.checkSoLuongNgLon02(txtNumberOfAdults.Text) == false && insertupdate == "insert")
                    throw new Exception("Số lượng người lớn " + txtNumberOfAdults.Text + " phải là số.");
                if (this.checkSoLuongTreEm02(txtNumberOfChildren.Text) == false && insertupdate == "insert")
                    throw new Exception("Số lượng trẻ en " + txtNumberOfChildren.Text + " phải là số.");
                if (this.checkTongTien02(mtbTotalAmount.Text) == false && insertupdate == "insert")
                    throw new Exception("Tổng tiền " + mtbTotalAmount.Text + " phải là số.");
                int idreservation = int.Parse(txtReservationID.Text);
                int idcustomer = int.Parse(txtCustomerID.Text);
                int idroom = int.Parse(txtRoomID.Text);
                string paymentstatus = cbPaymentStatus.Text;
                string specialrequests = txtSpecialRequests.Text;
                int slnglon = int.Parse(txtNumberOfAdults.Text);
                int sltreem = int.Parse(txtNumberOfChildren.Text);
                decimal tongtien = decimal.Parse(mtbTotalAmount.Text);
                string checkinstatus = cbCheckInStatus.Text;
                string checkoutstatus = cbCheckOutStatus.Text;
                DateTime checkInDate;
                DateTime checkOutDate;

                if ((DateTime.TryParse(mtbCheckInDate.Text, out checkInDate)) && ((DateTime.TryParse(mtbCheckOutDate.Text, out checkOutDate))))
                {
                    Reservation reservation = new Reservation(idreservation, idcustomer, idroom, paymentstatus, specialrequests,
                        slnglon, sltreem, checkInDate , checkOutDate, tongtien, checkinstatus , checkoutstatus);
                    switch (insertupdate)
                    {
                        case "insert":
                            {
                                reservationDAO.InsertTwo(reservation);
                                loadDS();
                                TongData();
                                OnlyRead();
                                MessageBox.Show("Thêm thành công", "Thông báo");
                                break;
                            }
                        case "update":
                            {
                                reservationDAO.UpdateTwo(reservation);
                                loadDS();
                                TongData();
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
        private bool checkSoLuongNgLon02(string nglon)
        {
            if (!(Global.IsInteger(nglon)))
                return false;
            return true;
        }
        private bool checkSoLuongTreEm02(string treem)
        {
            if (!(Global.IsInteger(treem)))
                return false;
            return true;
        }
        private bool checkTongTien02(string tien)
        {
            if (!(Global.IsInteger(tien)))
                return false;
            return true;
        }
        private bool checkIDReservation02(string idreservation)
        {
            if (!(Global.IsInteger(idreservation)))
                return false;
            return true;
        }
        private bool checkIDReservation(int idreservation)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["ReservationID"].Value.ToString() == idreservation.ToString())
                    return false;
            }
            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int idreservation = int.Parse(txtCustomerID.Text);
                if (MessageBox.Show("Bạn có xóa ID đặt phòng: " + idreservation + " ?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    reservationDAO.DeleteTwo(idreservation);
                    loadDS();
                    TongData();
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
            //int idphong = int.Parse(txtRoomID.SelectedValue.ToString());
            //dgvDanhSach.DataSource = reservationDAO.getList(321);
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
                    throw new Exception("Chưa chọn id đặt phòng");
                }
                txtReservationID.Text = dgvDanhSach.Rows[rowindex].Cells["ReservationID"].Value.ToString();
                txtCustomerID.Text = dgvDanhSach.Rows[rowindex].Cells["CustomerID"].Value.ToString();
                txtRoomID.Text = dgvDanhSach.Rows[rowindex].Cells["RoomID"].Value.ToString();
                cbPaymentStatus.Text = dgvDanhSach.Rows[rowindex].Cells["PaymentStatus"].Value.ToString();
                txtSpecialRequests.Text = dgvDanhSach.Rows[rowindex].Cells["SpecialRequests"].Value.ToString();
                txtNumberOfAdults.Text = dgvDanhSach.Rows[rowindex].Cells["NumberOfAdults"].Value.ToString();
                txtNumberOfChildren.Text = dgvDanhSach.Rows[rowindex].Cells["NumberOfChildren"].Value.ToString();
                mtbCheckInDate.Text = dgvDanhSach.Rows[rowindex].Cells["CheckInDate"].Value.ToString();
                mtbCheckOutDate.Text = dgvDanhSach.Rows[rowindex].Cells["CheckOutDate"].Value.ToString();
                mtbTotalAmount.Text = dgvDanhSach.Rows[rowindex].Cells["TotalAmount"].Value.ToString();
                cbCheckInStatus.Text = dgvDanhSach.Rows[rowindex].Cells["CheckInStatus"].Value.ToString();
                cbCheckOutStatus.Text = dgvDanhSach.Rows[rowindex].Cells["CheckOutStatus"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
