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
        int chon = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            lbSinhVien.Items.Add("Nguyễn thế vinh");
            lbSinhVien.Items.Add("Nguyễn văn thế");
            lbSinhVien.Items.Add("Nguyễn chính");
            lbSinhVien.Items.Add("Lê văn be");
            lbSinhVien.Items.Add("trần văn chính");
            lbSinhVien.Items.Add("mai hữu danh");
            lbSinhVien.Items.Add("hồ văn en");
            cbKhoa.SelectedIndex = 0;
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    if (cbKhoa.SelectedIndex == -1)
        //        MessageBox.Show("Vui lòng chọn khoa");
        //    //if (lbSinhVien.SelectedIndex == -1)
        //    //    MessageBox.Show("Vui lòng chọn tên");
        //    else
        //    {
        //        string khoa = cbKhoa.SelectedItem.ToString();
        //        string hoten = txtB_HoTen.ToString();
        //        ListViewItem item = new ListViewItem(hoten);
        //        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
        //        lvLop.Items.Add(item);
        //        //lbSinhVien.Items.RemoveAt(lbSinhVien.SelectedIndex);
        //    }
        //}
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtB_HoTen.Text.Length.Equals(0))
                    throw new Exception("Vui lòng nhập họ tên");
                string hoten = txtB_HoTen.Text;
                lbSinhVien.Items.Add(hoten);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnChonSV_Click(object sender, EventArgs e)
        {
            if( chon != 1)
            {
                string hoten = lbSinhVien.SelectedItem.ToString();
                string khoa = cbKhoa.SelectedItem.ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lvLop.Items.Add(item);
                lbSinhVien.Items.RemoveAt(lbSinhVien.SelectedIndex);
                chon = -1;
            }
        }

        private void btnThemAll_Click(object sender, EventArgs e)
        {
            int count = lbSinhVien.Items.Count;
            for (int vt = 0; vt < count; vt++)
            {
                string khoa = cbKhoa.SelectedItem.ToString();
                string hoten = lbSinhVien.Items[vt].ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lvLop.Items.Add(item);
            }
            lbSinhVien.Items.Clear();
        }
        private void btnXoa1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvLop.Items)
            {
                if (item.Checked)
                {
                    lvLop.Items.Remove(item);
                    lbSinhVien.Items.Add(item.Text);
                }
            }
        }
        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvLop.Items)
            {
                lvLop.Items.Remove(item);
                lbSinhVien.Items.Add(item.Text);
            }
        }

        private void lbSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
