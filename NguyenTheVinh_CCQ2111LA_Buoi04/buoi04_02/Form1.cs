using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace buoi04_02
{
    public partial class Form1 : Form
    {
        int stt = 1;
        int chon = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lvDSMon.View = View.Details;
            lvDSMon.Columns.Clear();
            lvDSMon.Items.Clear();
            lvDSMon.Columns.Add(new ColumnHeader());
            lvDSMon.Columns.Add(new ColumnHeader());
            lvDSMon.Columns.Add(new ColumnHeader());
            lvDSMon.Columns[0].Text = "STT";
            lvDSMon.Columns[1].Text = "Tên món";
            lvDSMon.Columns[2].Text = "Giá";
            ListViewItem item1 = new ListViewItem("    1    ".ToString());
            item1.SubItems.Add("Cafe đá");
            item1.SubItems.Add("15000");
            lvDSMon.Items.Add(item1);
            ListViewItem item2 = new ListViewItem("    2    ".ToString());
            item2.SubItems.Add("Cafe sữa");
            item2.SubItems.Add("18000");
            lvDSMon.Items.Add(item2);
            ListViewItem item3 = new ListViewItem("    3    ".ToString());
            item3.SubItems.Add("Nước cam");
            item3.SubItems.Add("30000");
            lvDSMon.Items.Add(item3);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbBan.SelectedIndex == -1)
                MessageBox.Show("Vui lòng bàn.");
            if (lvDSMon.SelectedItems.Count > 0)
            {
                int so = int.Parse(lvDSMon.SelectedItems[0].Text);
                ListViewItem selectedItem = lvDSMon.Items[so - 1];
                string tenmon = selectedItem.SubItems[1].Text;
                string gia = selectedItem.SubItems[2].Text;
                string soluong = nudSoLuong.Value.ToString();
                string ban = cbBan.SelectedItem.ToString();
                int tongGia = int.Parse(soluong) * int.Parse(gia);
                ListViewItem item = new ListViewItem(ban);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tenmon });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = soluong });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tongGia.ToString() });
                lvDSDatMon.Items.Add(item);
                chon = -1;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvDSDatMon.Items)
            {
                if (item.Selected)
                {
                    lvDSDatMon.Items.Remove(item);
                }
            }
        }
        private void lvDSMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
    }
}
