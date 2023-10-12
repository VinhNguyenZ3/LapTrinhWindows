using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi04_01
{
    public partial class Form1 : Form
    {
        int chon = 1;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbDanhSach.Items.Add("Nguyễn thế vinh");
            lbDanhSach.Items.Add("Nguyễn văn thế");
            lbDanhSach.Items.Add("Nguyễn chính");
            lbDanhSach.Items.Add("Lê văn be");
            lbDanhSach.Items.Add("trần văn chính");
            lbDanhSach.Items.Add("mai hữu danh");
            lbDanhSach.Items.Add("hồ văn en");
            cbKhoa.SelectedIndex = 0;
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtB_HoTen.Text.Length.Equals(0))
                    throw new Exception("Họ tên chưa nhập.");
                string hoten = txtB_HoTen.Text;
                lbDanhSach.Items.Add(hoten);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedIndex == -1)
                MessageBox.Show("Vui lòng chọn khoa");
            if (lbDanhSach.SelectedIndex == -1)
                MessageBox.Show("Vui lòng chọn tên");
            else
            {
                string khoa = cbKhoa.SelectedItem.ToString();
                string hoten = lbDanhSach.SelectedItem.ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lbSinhVien.Items.Add(item);
                lbDanhSach.Items.RemoveAt(lbDanhSach.SelectedIndex);
            }
        }
        private void btnThemAll_Click_Click(object sender, EventArgs e)
        {
            int count = lbDanhSach.Items.Count;
            for (int vt = 0; vt < count; vt++)
            {
                string khoa = cbKhoa.SelectedItem.ToString();
                string hoten = lbDanhSach.Items[vt].ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lbSinhVien.Items.Add(item);
            }
            lbDanhSach.Items.Clear();   
        }

        private void btnXoa1_Click_Click(object sender, EventArgs e)
        {
            foreach( ListViewItem item in lbSinhVien.Items )
            {
                if(item.Checked)
                {
                    lbSinhVien.Items.Remove(item);
                    lbDanhSach.Items.Add(item.Text);
                }
            }
        }

        private void btnXoaAll_Click_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lbSinhVien.Items)
            {
                lbSinhVien.Items.Remove(item);
                lbDanhSach.Items.Add(item.Text);
                
            }
        }

        private void lbDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
