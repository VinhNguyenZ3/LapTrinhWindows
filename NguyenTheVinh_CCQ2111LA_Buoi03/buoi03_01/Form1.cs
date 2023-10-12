using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox_A_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtBox_A.Text, out a)) 
                    throw new Exception("Số A không được để trống hoặc phải số.");
                if (!double.TryParse(txtBox_B.Text, out b)) 
                    throw new Exception("Số B không được để trống hoặc phải số.");
                txtBox_KQ.Text = (a + b).ToString();
            }
            catch(Exception ex) { 
                txtBox_KQ.Text = ex.Message;
            }
        }

        private void btnTru_Click_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtBox_A.Text, out a))
                    throw new Exception("Số A không được để trống hoặc phải số.");
                if (!double.TryParse(txtBox_B.Text, out b))
                    throw new Exception("Số B không được để trống hoặc phải số.");
                txtBox_KQ.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                txtBox_KQ.Text = ex.Message;
            }
        }

        private void btnNhan_Click_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtBox_A.Text, out a))
                    throw new Exception("Số A không được để trống hoặc phải số.");
                if (!double.TryParse(txtBox_B.Text, out b))
                    throw new Exception("Số B không được để trống hoặc phải số.");
                txtBox_KQ.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                txtBox_KQ.Text = ex.Message;
            }
        }

        private void btnChia_Click_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtBox_A.Text, out a))
                    throw new Exception("Số A không được để trống hoặc phải số.");
                if (!double.TryParse(txtBox_B.Text, out b))
                    throw new Exception("Số B không được để trống hoặc phải số.");
                if(b == 0)
                    throw new Exception("Số B không được bằng 0.");
                else
                    txtBox_KQ.Text = (a / b).ToString();
            }
            catch (Exception ex)
            {
                txtBox_KQ.Text = ex.Message;
            }
        }

        private void btnThoat_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
