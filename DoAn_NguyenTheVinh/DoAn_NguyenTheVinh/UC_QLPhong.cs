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
    public partial class UC_QLPhong : UserControl
    {
        public UC_QLPhong()
        {
            InitializeComponent();

        }
        string insertupdate = "";
        RoomDAO roomDAO = new RoomDAO();
        private void UC_QLPhong_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            RefeshInput();
            OnlyRead();
            loadDS(); TongData();
        }
        private void TongData()
        {
            txtTongSV.Text = roomDAO.getCount().ToString();
        }
        private void RefeshInput()
        {
            txtRoomID.Text = "";
            txtRoomNumber.Text = "";
            cbRoomType.Text = "";
            nudPrice.Text = "";
            cbStatus.Text = "";
            txtDescription.Text = "";
        }
        private void OnlyRead()
        {
            txtRoomID.Enabled = false;
            txtRoomNumber.Enabled = false;
            cbRoomType.Enabled = false;
            nudPrice.Enabled = false;
            cbStatus.Enabled = false;
            txtDescription.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void loadDS()
        {
            dgvDanhSach.DataSource = roomDAO.getList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtRoomID.Enabled = true;
            txtRoomNumber.Enabled = true;
            cbRoomType.Enabled = true;
            nudPrice.Enabled = true;
            cbStatus.Enabled = true;
            txtDescription.Enabled = true;
            insertupdate = "insert";
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtRoomID.Enabled = true;
            txtRoomNumber.Enabled = true;
            cbRoomType.Enabled = true;
            nudPrice.Enabled = true;
            cbStatus.Enabled = true;
            txtDescription.Enabled = true;
            insertupdate = "update";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.checkIDRoom(int.Parse(txtRoomID.Text)) == false && insertupdate == "insert")
                    throw new Exception("ID phòng đã tồn tại.");
                if (this.checkRoomNumber(txtRoomNumber.Text) == false && insertupdate == "insert")
                    throw new Exception("Số phòng "+ txtRoomNumber.Text + " này đã tồn tại.");
                if (this.checkRoomNumber02(txtRoomNumber.Text) == false && insertupdate == "insert")
                    throw new Exception("Số phòng " + txtRoomNumber.Text + " không được có ký tự.");
                int roomid = int.Parse(txtRoomID.Text);
                string numberroom = txtRoomNumber.Text;
                string typerroom = cbRoomType.Text;
                decimal price = decimal.Parse(nudPrice.Text);
                string status = cbStatus.Text;
                string mota = txtDescription.Text;
                Room room = new Room(roomid, numberroom, typerroom, price,
                        mota, status);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            roomDAO.InsertTwo(room);
                            loadDS(); TongData();
                            OnlyRead();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "update":
                        {
                            roomDAO.UpdateTwo(room);
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
        private bool checkIDRoom(int idroom)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["RoomID"].Value.ToString() == idroom.ToString())
                    return false;
            }
            return true;
        }
        
        private bool checkRoomNumber02(string sophong)
        {
            if (!(Global.IsInteger(sophong))) 
                return false;
            return true;
        }
        private bool checkRoomNumber(string sophong)
        {
            if (dgvDanhSach.Rows.Count == 0) return true;
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["RoomNumber"].Value.ToString() == sophong)
                    return false;
            }
            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int roomid = int.Parse(txtRoomID.Text);
                if (MessageBox.Show("Bạn có muốn xóa ID phòng: " + roomid + " ?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    roomDAO.DeleteTwo(roomid);
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
                txtRoomID.Text = dgvDanhSach.Rows[rowindex].Cells["RoomID"].Value.ToString();
                txtRoomNumber.Text = dgvDanhSach.Rows[rowindex].Cells["RoomNumber"].Value.ToString();
                cbRoomType.Text = dgvDanhSach.Rows[rowindex].Cells["RoomType"].Value.ToString();
                nudPrice.Text = dgvDanhSach.Rows[rowindex].Cells["Price"].Value.ToString();
                txtDescription.Text = dgvDanhSach.Rows[rowindex].Cells["Description"].Value.ToString();
                cbStatus.Text = dgvDanhSach.Rows[rowindex].Cells["Status"].Value.ToString();
                
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
