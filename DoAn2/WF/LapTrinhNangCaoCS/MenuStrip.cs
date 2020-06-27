using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhNangCaoCS
{
    public partial class MenuStrip : Form
    {
        public MenuStrip()
        {
            InitializeComponent();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã click và black");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = mntscombo.SelectedItem.ToString();
            label1.Text = str;
        }

        private void mntscombo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuStrip_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
