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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.Design;

namespace DoAn_NguyenTheVinh
{
    public partial class UC_QLThanhToan : UserControl
    {
        public UC_QLThanhToan()
        {
            InitializeComponent();
        }
        string insertupdate = "";
        PaymentDAO paymentDAO = new PaymentDAO();
        ReservationDAO reservationDAO = new ReservationDAO();
        private void UC_QLThanhToan_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            RefeshInput();
            OnlyRead();
            loadDS(); TongData();
            loadDSIDReservation();
        }
        private void loadDSIDReservation()
        {
            txtReservationID.DataSource = reservationDAO.getList();
            txtReservationID.DisplayMember = "ReservationID";
            txtReservationID.ValueMember = "ReservationID";
        }
        private void TongData()
        {
            txtTongSV.Text = paymentDAO.getCount().ToString();
        }
        private void RefeshInput()
        {
            txtPaymentID.Text = "";
            txtReservationID.Text = "";
            mtbPaymentDate.Text = "";
            cbPaymentMethod.Text = "";
            cbPaymentStatus.Text = "";
            mtbAmount.Text = "";
            mtbRefundAmount.Text = "";
            cbPaymentStatus.Text = "";
        }
        private void OnlyRead()
        {
            txtPaymentID.Enabled = false;
            txtReservationID.Enabled = false;
            mtbPaymentDate.Enabled = false;
            cbPaymentMethod.Enabled = false;
            cbPaymentStatus.Enabled = false;
            mtbAmount.Enabled = false;
            mtbRefundAmount.Enabled = false;
            cbPaymentStatus.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void loadDS()
        {
            dgvDanhSach.DataSource = paymentDAO.getList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtPaymentID.Enabled = true;
            txtReservationID.Enabled = true;
            mtbPaymentDate.Enabled = true;
            cbPaymentMethod.Enabled = true;
            cbPaymentStatus.Enabled = true;
            mtbAmount.Enabled = true;
            mtbRefundAmount.Enabled = true;
            cbPaymentStatus.Enabled = true;
            insertupdate = "insert";
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtPaymentID.Enabled = true;
            txtReservationID.Enabled = true;
            mtbPaymentDate.Enabled = true;
            cbPaymentMethod.Enabled = true;
            cbPaymentStatus.Enabled = true;
            mtbAmount.Enabled = true;
            mtbRefundAmount.Enabled = true;
            cbPaymentStatus.Enabled = true;
            insertupdate = "update";
            btnLuu.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.checkIDPayment(int.Parse(txtPaymentID.Text)) == false && insertupdate == "insert")
                    throw new Exception("ID thanh toán này đã tồn tại.");
                if (this.checkIDPayment02(txtPaymentID.Text) == false && insertupdate == "insert")
                    throw new Exception("ID thanh toán " + txtPaymentID.Text + " không được có ký tự.");
                int idpayment = int.Parse(txtPaymentID.Text);
                int idreservation = int.Parse(txtReservationID.Text);
                string paymentmethod = cbPaymentMethod.Text;
                string paymentstatus = cbPaymentStatus.Text;
                decimal amount = decimal.Parse(mtbAmount.Text);
                decimal refundamount = decimal.Parse(mtbRefundAmount.Text);
                string refundstatus = cbRefundStatus.Text;
                DateTime paymentDate;
                if (DateTime.TryParse(mtbPaymentDate.Text, out paymentDate))
                {
                    Payment payment = new Payment(idpayment, idreservation, paymentDate, paymentmethod, paymentstatus,
                        amount, refundamount, refundstatus);
                    switch (insertupdate)
                    {
                        case "insert":
                            {
                                paymentDAO.InsertTwo(payment);
                                loadDS(); TongData();
                                MessageBox.Show("Thêm thành công", "Thông báo");
                                break;
                            }
                        case "update":
                            {
                                paymentDAO.UpdateTwo(payment);
                                loadDS(); TongData();
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
        private bool checkIDPayment02(string idpayment)
        {
            if (!(Global.IsInteger(idpayment)))
                return false;
            return true;
        }
    
        private bool checkIDPayment(int idpayment)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["PaymentID"].Value.ToString() == idpayment.ToString())
                    return false;
            }
            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int paymentid = int.Parse(txtPaymentID.Text);
                if (MessageBox.Show("Bạn có muốn xóa ID thanh toán: " + paymentid + " ?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    paymentDAO.DeleteTwo(paymentid);
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
                    throw new Exception("Chưa chọn id thanh toán");
                }
                txtPaymentID.Text = dgvDanhSach.Rows[rowindex].Cells["PaymentID"].Value.ToString();
                txtReservationID.Text = dgvDanhSach.Rows[rowindex].Cells["ReservationID"].Value.ToString();
                mtbPaymentDate.Text = dgvDanhSach.Rows[rowindex].Cells["PaymentDate"].Value.ToString();
                cbPaymentMethod.Text = dgvDanhSach.Rows[rowindex].Cells["PaymentMethod"].Value.ToString();
                cbPaymentStatus.Text = dgvDanhSach.Rows[rowindex].Cells["PaymentStatus"].Value.ToString();
                mtbAmount.Text = dgvDanhSach.Rows[rowindex].Cells["Amount"].Value.ToString();
                mtbRefundAmount.Text = dgvDanhSach.Rows[rowindex].Cells["RefundAmount"].Value.ToString();
                cbRefundStatus.Text = dgvDanhSach.Rows[rowindex].Cells["RefundStatus"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
