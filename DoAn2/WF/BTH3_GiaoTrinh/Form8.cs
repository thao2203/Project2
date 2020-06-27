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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("#");
            char i = 'a';
            for (i = 'a'; i <= 'z'; i++)
                treeView1.Nodes.Add(i.ToString().ToUpper());
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char i = 'a';
            int j = 0;
            for (i = 'a'; i <= 'z'; i++)
            {
                j++;
                if (txtl.Text.Substring(0, 1) == i.ToString())
                {
                    treeView1.Nodes[j].Nodes.Add(txtf.Text + " " + txtl.Text);
                    //thoát 
                    goto k;
                }
            }
            //nếu là số hoặc tiếng việt sẽ cho vào #
            treeView1.Nodes[0].Nodes.Add(txtf.Text + " " + txtl.Text);
        k:;
            txtf.Text = txtl.Text = "";
            txtf.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtl_KeyUp(object sender, KeyEventArgs e)
        {
            //tìm tên 
            int j = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                j++;
                if (e.KeyCode.ToString().ToUpper() == i.ToString().ToUpper())
                    treeView1.Nodes[j].ExpandAll();

            }

            if (txtl.Text.Length == 0)
                button1.Enabled = false;
            else button1.Enabled = true;
        }

        private void txtf_KeyUp(object sender, KeyEventArgs e)
        {
            int j = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                j++;
                if (e.KeyCode.ToString().ToUpper() == i.ToString().ToUpper())
                    treeView1.Nodes[j].ExpandAll();
            }
        }
    }
}
