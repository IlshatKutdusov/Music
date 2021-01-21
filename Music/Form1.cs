using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void button1_Click(object sender, EventArgs e)
        {
            wplayer.URL = @"C:\Users\800216\Music\TRFire - Fruit Flying.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wplayer.controls.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            
        }
    }
}
