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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            btncapnhat.Enabled = false;
        }
        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        private void rabtnB_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lboxA.Items.Count; i++)
            {
                if (lboxA.Items[i].ToString() == "")
                    lboxA.Items.RemoveAt(i);
            }
            if (rbtnA.Checked == true)
            {
                lboxA.Items.Add(textBox1.Text);

            }
            if (rabtnB.Checked == true)
            {
                lboxB.Items.Add(textBox1.Text);

            }
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == "")
                btncapnhat.Enabled = false;
            else
                btncapnhat.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                lboxB.Items.Add(lboxA.SelectedItem);
                lboxA.Items.Remove(lboxA.SelectedItem);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i=0; i<lboxA.Items.Count;i++)
            {
                lboxB.Items.Add(lboxA.Items[i]);
            }
            lboxA.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                lboxA.Items.Add(lboxB.SelectedItem);
                lboxB.Items.Remove(lboxB.SelectedItem);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lboxB.Items.Count; i++)
            {
                lboxA.Items.Add(lboxB.Items[i]);
            }
            lboxB.Items.Clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                lboxA.Items.Remove(lboxA.SelectedItem);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
            try 
            {
                lboxB.Items.Remove(lboxB.SelectedItem);
            }
            catch(Exception b)
            {
                MessageBox.Show(b.Message);
            }
        }
    }
}
