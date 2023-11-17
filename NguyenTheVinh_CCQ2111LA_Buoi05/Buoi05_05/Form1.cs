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

namespace Buoi05_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "MP4 File|*.mp4| AVI File|*.avi";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFile.FileName;
            }
            else
            {
                // Nếu người dùng không chọn file, mặc định sử dụng video cố định
                axWindowsMediaPlayer1.URL = "video_defaut.mp4";
            }

            // Thiết lập để video tự động phát lại
            axWindowsMediaPlayer1.settings.setMode("loop", true);

            //OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "AVI File|*.avi| MP4 File|*.mp4";
            //if(openFile.ShowDialog() == DialogResult.OK)
            //    axWindowsMediaPlayer1.URL = openFile.FileName;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "AVI File|*.avi| MP4 File|*.mp4";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFile.FileName, FileMode.Open);
                StreamReader stream = new StreamReader(fs, Encoding.UTF8);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "MP4 File|*.mp4| AVI File|*.avi";
            axWindowsMediaPlayer1.URL = "C:\\Users\\thvin\\Downloads\\video_defaut.mp4";

            axWindowsMediaPlayer1.settings.autoStart = false;
            //axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
    }
}
