using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH3_GiaoTrinh
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.Timer SplashTimer;

        int dem = 10;

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            dem = dem - 1;
            if(dem == 0)
            {
                SplashTimer.Stop();
                this.Close();
            }
            richTextBox1.Text = "Project 3 xuất hiện sau " + dem;
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SplashTimer = new System.Windows.Forms.Timer();
            SplashTimer.Tick += new EventHandler(SplashTimer_Tick);
            SplashTimer.Interval = 1000;
            SplashTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
