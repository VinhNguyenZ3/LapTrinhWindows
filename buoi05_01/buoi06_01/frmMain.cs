using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi06_01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static string tendangnhap = null;
        public static List<string> listkhoa = new List<string>();
        private void frmMain_Load(object sender, EventArgs e)
        {
            if(tendangnhap == null)
            {
                Form frmlogin = new frmLogin();
                frmlogin.ShowDialog();
                toolStripLabel1.Text = tendangnhap;
            }
        }

    }
}
