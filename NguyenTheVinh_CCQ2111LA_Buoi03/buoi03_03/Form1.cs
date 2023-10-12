using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi03_03
{
    public partial class Form1 : Form
    {
        int stt = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddList_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtB_TenSach.Text.Length.Equals(0))
                    throw new Exception("Tên sách không để rỗng.");
                string masach = mTxt_MS.Text;
                string tensach = txtB_TenSach.Text;
                string gia = mTxt_Gia.Text;
                string soluong = numUpDown.Text;
                txtDanhSach.Text += stt + ". Mã sách: " + masach + " Tên sách: " + tensach + " Giá: " + gia + " Số lượng: " + soluong + "\r\n";
                stt++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_RemoveList_Click(object sender, EventArgs e)
        {
            txtDanhSach.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
