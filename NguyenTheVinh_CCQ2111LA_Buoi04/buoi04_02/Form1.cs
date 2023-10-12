using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi04_02
{
    public partial class Form1 : Form
    {
        int stt = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbBan.SelectedIndex == -1)
                MessageBox.Show("Vui lòng bàn.");
           /* if (nudSoLuong.Value > 0)
                MessageBox.Show("Vui lòng chọn số lượng lớn hơn 0!");*/
            else
            {
                string ban = cbBan.SelectedItem.ToString();
                string soluong = nudSoLuong.Value.ToString();
                string tenmon = lvDSMon.ItemSelectionChanged.Items[0].ToString();
                ListViewItem item = new ListViewItem(ban);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tenmon });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = soluong });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = soluong });
                lvDSDatMon.Items.Add(item);
            }
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

            ListViewItem item1 = new ListViewItem(1.ToString());
            item1.SubItems.Add("Cafe đá");
            item1.SubItems.Add("15000");
            lvDSMon.Items.Add(item1);
            ListViewItem item2 = new ListViewItem(2.ToString());
            item2.SubItems.Add("Cafe sữa");
            item2.SubItems.Add("18000");
            lvDSMon.Items.Add(item2);
            ListViewItem item3 = new ListViewItem(3.ToString());
            item3.SubItems.Add("Nước cam");
            item3.SubItems.Add("30000");
            lvDSMon.Items.Add(item3);
        }
    }
}
