using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi03_02
{
    public partial class Form1 : Form
    {
        int stt = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gBox_Info_Enter(object sender, EventArgs e)
        {

        }

        private void mTxt_Mssv_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_AddList_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox_Name.Text.Length.Equals(0))
                    throw new Exception("Họ tên sinh viên không để rỗng.");
                string hoten = txtBox_Name.Text;
                string mssv = mTxt_Mssv.Text;
                string ngaysinh = mTxt_Date.Text;
                string gioitinh = (rb_Nam.Checked)?"Nam" : "Nữ";
                string sothich = null;
                string listSoThich = " Sở thích: ";
                if (cb_DuLich.Checked)
                    sothich += "Du lịch, ";
                if (cb_TheThao.Checked)
                    sothich += "Thể thao, ";
                if (cb_MuaSam.Checked)
                    sothich += "Mua sắm ";
                if (sothich != null)
                    listSoThich += sothich;
                txtDanhSach.Text += stt + ". Họ tên: " + hoten + " Ngày sinh: " + ngaysinh + " Giới tính: " + gioitinh + listSoThich + "\r\n";
                stt++;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
