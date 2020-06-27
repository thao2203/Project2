using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            labelR.Text = "R = " + trackBarR.Value;           
            Color n = new Color();
            n = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);
            panel1.BackColor = n;
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            labelG.Text = "G = " + trackBarG.Value;
            panel1.BackColor.ToArgb();
            Color n = new Color();
            n = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);
            panel1.BackColor = n;
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            labelB.Text = "B = " + trackBarB.Value;
            panel1.BackColor.ToArgb();
            Color n = new Color();
            n = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);
            panel1.BackColor = n;
        }
    }
}
