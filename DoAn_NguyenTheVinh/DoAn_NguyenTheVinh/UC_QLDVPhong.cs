using DoAn_NguyenTheVinh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoAn_NguyenTheVinh.Main;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoAn_NguyenTheVinh
{
    public partial class UC_QLDVPhong : UserControl
    {
        public UC_QLDVPhong()
        {
            InitializeComponent();
        }
        public string Data { get; set; }
        string insertupdate = "";
        RoomServiceDAO roomserviceDAO = new RoomServiceDAO();
        ReservationDAO reservationDAO = new ReservationDAO();
        private void UC_QLDVPhong_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            RefeshInput();
            OnlyRead();
            loadDS(); TongData(); loadDSIDReservation();
        }
        private void loadDSIDReservation()
        {
            txtReservationID.DataSource = reservationDAO.getList();
            txtReservationID.DisplayMember = "ReservationID";
            txtReservationID.ValueMember = "ReservationID";
        }
        private void TongData()
        {
            txtTongSV.Text = roomserviceDAO.getCount().ToString();
        }
        private void RefeshInput()
        {
            txtServiceID.Text = "";
            txtReservationID.Text = "";
            txtServiceName.Text = "";
            nudServiceCharge.Text = "";
        }
        private void OnlyRead()
        {
            txtServiceID.Enabled = false;
            txtReservationID.Enabled = false;
            txtServiceName.Enabled = false;
            nudServiceCharge.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void loadDS()
        {
            dgvDanhSach.DataSource = roomserviceDAO.getList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtServiceID.Enabled = true;
            txtReservationID.Enabled = true;
            txtServiceName.Enabled = true;
            nudServiceCharge.Enabled = true;
            insertupdate = "insert";
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtServiceID.Enabled = true;
            txtReservationID.Enabled = true;
            txtServiceName.Enabled = true;
            nudServiceCharge.Enabled = true;
            insertupdate = "update";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.checkIDService(int.Parse(txtServiceID.Text)) == false && insertupdate == "insert")
                    throw new Exception("ID dịch này đã tồn tại.");
                if (this.checkIDReservation(int.Parse(txtReservationID.Text)) == false && insertupdate == "insert")
                    throw new Exception("ID đặt phòng này đã tồn tại.");
                if (this.checkIDReservation02(txtReservationID.Text) == false && insertupdate == "insert")
                    throw new Exception("ID đặt phòng " + txtReservationID.Text + " không được có ký tự.");
                if (this.checkIDService02(txtServiceID.Text) == false && insertupdate == "insert")
                    throw new Exception("ID dịch vụ " + txtServiceID.Text + " không được có ký tự.");
                int idservice = int.Parse(txtServiceID.Text);
                int idreservation = int.Parse(txtReservationID.Text);
                string nameservice = txtServiceName.Text;
                decimal price = decimal.Parse(nudServiceCharge.Text);
                RoomService roomservice = new RoomService(idservice, idreservation, nameservice, price);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            roomserviceDAO.InsertTwo(roomservice);
                            loadDS(); TongData();
                            OnlyRead();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            roomserviceDAO.UpdateTwo(roomservice);
                            loadDS(); TongData();
                            OnlyRead();
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
        private bool checkIDService02(string idservice)
        {
            if (!(Global.IsInteger(idservice)))
                return false;
            return true;
        }
        private bool checkIDReservation02(string idreservation)
        {
            if (!(Global.IsInteger(idreservation)))
                return false;
            return true;
        }
        private bool checkIDService(int idservice)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["CustomerID"].Value.ToString() == idservice.ToString())
                    return false;
            }
            return true;
        }
        private bool checkIDReservation(int idreservation)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["CustomerID"].Value.ToString() == idreservation.ToString())
                    return false;
            }
            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int customerid = int.Parse(txtServiceID.Text);
                if (MessageBox.Show("Bạn có muốn xóa ID dịch vụ: " + customerid + " ?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    roomserviceDAO.DeleteTwo(customerid);
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
                    throw new Exception("Chưa chọn dịch vụ phòng");
                }
                txtServiceID.Text = dgvDanhSach.Rows[rowindex].Cells["ServiceID"].Value.ToString();
                txtReservationID.Text = dgvDanhSach.Rows[rowindex].Cells["ReservationID"].Value.ToString();
                txtServiceName.Text = dgvDanhSach.Rows[rowindex].Cells["ServiceName"].Value.ToString();
                nudServiceCharge.Text = dgvDanhSach.Rows[rowindex].Cells["ServiceCharge"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
