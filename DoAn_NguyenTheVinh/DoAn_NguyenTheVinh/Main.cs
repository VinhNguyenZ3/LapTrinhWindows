using AxWMPLib;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn_NguyenTheVinh
{
    public partial class Main : Form
    {
        public class Global
        {
            public static bool IsInteger(string input)
            {
                return int.TryParse(input, out _);
            }
        }
       
        public string Data { get; set; }
        public Main()
        {
            InitializeComponent();
        }
        UserDAO userDAO = new UserDAO();
        int i = 1;
        private void Main_Load(object sender, EventArgs e)
        {
            loadDS();
            tssl_name.Text = userDAO.getUser(Data);
            username.Text = userDAO.getUserName(Data);

            //UC_QLDVPhong qldvp = new UC_QLDVPhong();
            //qldvp.Data = userDAO.getUser(Data);

            //UC_Video video = new UC_Video();
            //this.Controls.Add(video);
            //video.Dock = DockStyle.Fill;
            //video.BringToFront();
            if ( i == 1)
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\thvin\\Downloads\\video_defaut.mp4";
                axWindowsMediaPlayer1.settings.autoStart = false;
                axWindowsMediaPlayer1.settings.setMode("loop", true);
                i++;
            }
        }
        private void loadDS()
        {
            //dgvDanhSach.DataSource = userDAO.getList();
        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;

            UC_DatPhong bookingControl = new UC_DatPhong();
            this.Controls.Add(bookingControl);
            bookingControl.Dock = DockStyle.Fill;
            bookingControl.BringToFront();
        }

        private void danhSáchKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;

            UC_KhachHang khachhang = new UC_KhachHang();
            this.Controls.Add(khachhang);
            khachhang.Dock = DockStyle.Fill;
            khachhang.BringToFront();
        }

        private void quảnLýPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;

            UC_QLPhong qlphong = new UC_QLPhong();
            this.Controls.Add(qlphong);
            qlphong.Dock = DockStyle.Fill;
            qlphong.BringToFront();
        }

        private void quảnLýDịchVụPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;

            UC_QLDVPhong qldichvuphong = new UC_QLDVPhong();
            this.Controls.Add(qldichvuphong);
            qldichvuphong.Dock = DockStyle.Fill;
            qldichvuphong.BringToFront();
        }

        private void quảnLýThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;

            UC_QLThanhToan qlthanhtoan = new UC_QLThanhToan();
            this.Controls.Add(qlthanhtoan);
            qlthanhtoan.Dock = DockStyle.Fill;
            qlthanhtoan.BringToFront();
        }  
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;

            UC_ThongTinCaNhan thongtincanhan = new UC_ThongTinCaNhan();
            thongtincanhan.Data = Data;
            this.Controls.Add(thongtincanhan);
            thongtincanhan.Dock = DockStyle.Fill;
            thongtincanhan.BringToFront();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;

            UC_DoiMatKhau doimatkhau = new UC_DoiMatKhau();
            this.Controls.Add(doimatkhau);
            doimatkhau.Dock = DockStyle.Fill;
            doimatkhau.BringToFront();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;

            UC_QLNguoiDung quanlynguoidung = new UC_QLNguoiDung();
            this.Controls.Add(quanlynguoidung);
            quanlynguoidung.Dock = DockStyle.Fill;
            quanlynguoidung.BringToFront();
        }

        private void thayẢnhNềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Visible = false;
            OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "jpg|*.jpg|png|*.png|gif|*.gif|bmp|&.bmp|Tất cả|*.*";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string pathFile = openFile.FileName;
                    picBox.Image = new Bitmap(pathFile);
                }
        }

        private void thayĐổiVideoNềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "MP4 File|*.mp4| AVI File|*.avi";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFile.FileName;
            }
            else
            {
                // Nếu người dùng không chọn file, mặc định sử dụng video cố định
                axWindowsMediaPlayer1.URL = "video_defaut.mp4";
            }

            // Thiết lập để video tự động phát lại
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Main main = new Main();
            //this.Close();
            //this.ShowDialog();
            this.Show();
        }
    }
}
