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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Form f2 = new Form2();
            f2.Close();
            Form f1 = new Form1();
            f1.ShowDialog();
           
        }
        int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 10;
            if(i==150)
            {
                timer1.Stop();
                Form f1 = new Form1();
                f1.Show();
            }
            progressBar1.Value = i;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
