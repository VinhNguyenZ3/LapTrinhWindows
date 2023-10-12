using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi06_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddFormToPanel(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;

            pMain.Dock = DockStyle.Fill;
            pMain.Controls.Clear();
            pMain.Controls.Add(frm);
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form frm = new frmSinhVien();
            AddFormToPanel(frm);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form frm = new frmKhoa();
            AddFormToPanel(frm);
        }
    }
}
