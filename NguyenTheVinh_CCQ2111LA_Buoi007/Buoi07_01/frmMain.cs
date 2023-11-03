using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static ThanhVien thanhvien = null;
        public static TabControl tabControl = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (thanhvien == null)
            {
                Form frm = new frmDangNhap();
                frm.ShowDialog();
            }
            toolStripLabelTenDangNhap.Text = thanhvien.HoTen;
            //load hinh anh
            //tabControlMain.ImageList = LoadImageList();

            tabControl = tabControlMain;
        }
        private ImageList LoadImageList()
        {
            ImageList iconList = new ImageList();
            iconList.TransparentColor = Color.Blue;
            iconList.ColorDepth = ColorDepth.Depth32Bit;
            iconList.ImageSize = new Size(25, 25);
            iconList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\hethong.png"));
            iconList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\sinhvien.png"));
            iconList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\khoa.png"));
            iconList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\thanhvien.png"));
            iconList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\trogiup.png"));
            return iconList;
        }
        private bool ExistTabPage(TabControl control, string tabPageName)
        {
            bool check = false;
            for (int i = 0; i < control.TabPages.Count; i++)
            {
                if (control.TabPages[i].Name == tabPageName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void SinhVienToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Sinh Viên";
            tab.Name = "tbSinhVien";
            tab.ImageIndex = 1;
            //tạo form và add vào tabpage trên tab
            Form frm = new frmSinhVien();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //Kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và tabcontrol
            if (!ExistTabPage(tabControlMain, "tbSinhVien"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbSinhVien"];
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmMain();
            frmMain.thanhvien = null;
            frmMain.ActiveForm.Hide();
            frm.ShowDialog();
        }
 //------------------------------------------------FORM SINH VIEN------------------------------------------------
        private void tbSinhVien_Click(object sender, EventArgs e)
        {

        }
 //------------------------------------------------FORM THONG TIN SINH VIEN ------------------------------------------------

        private void tbThongTinTV_Click(object sender, EventArgs e)
        {

        }
        //------------------------------------------------FORM DOI MAT KHAU ------------------------------------------------
        private void tbDoiMatKhau_Click(object sender, EventArgs e)
        {

        }
        //------------------------------------------------FORM THANH VIEN ------------------------------------------------
        private void tbThanhVien_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
