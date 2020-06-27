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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form t = new Form1();
            t.Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form t = new Form2();
            t.Show();
        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form t = new Form5();
            t.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form t = new Splash();
            t.ShowDialog();
        }

        private void đềTàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bài tập thực hành 3");
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void module1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bài6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form t = new Form6();
            t.Show();
        }

        private void bài7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form t = new Form7();
            t.Show();
        }

        private void bài8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form t = new Form8();
            t.Show();
        }

        private void bài9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form t = new Form9();
            t.Show();
        }

        private void bài10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form t = new Form10();
            t.Show();
        }
    }
}
