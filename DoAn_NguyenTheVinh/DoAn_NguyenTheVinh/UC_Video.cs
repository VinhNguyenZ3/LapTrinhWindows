using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_NguyenTheVinh
{
    public partial class UC_Video : UserControl
    {
        public UC_Video()
        {
            InitializeComponent();
        }

        private void UC_Video_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\thvin\\Downloads\\video_defaut.mp4";
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
    }
}
