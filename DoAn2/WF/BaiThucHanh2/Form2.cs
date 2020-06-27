using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = int.Parse(listBox1.Items[i].ToString()) * int.Parse(listBox1.Items[i].ToString());
                listBox1.Items[i] = x.ToString();
            }
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (!String.IsNullOrEmpty(listBox1.Items[i] as string))
                {
                    double tmp = Convert.ToDouble(listBox1.Items[i]);
                    tmp = Math.Pow(tmp, 2);
                    listBox1.Items[i] = tmp.ToString();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (var item in listBox1.Items)
            {
                int a = Convert.ToInt32(item);
                tong = tong + a;
            }
            MessageBox.Show(tong.ToString(), "Kết Quả");
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Focus();
            if (textBox1.Text == "")
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
            textBox1.Text = null;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Regex nhap = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            if (!nhap.IsMatch(textBox1.Text) && textBox1.Text != "")
            {
                errorProvider1.SetError(textBox1, "Vui lòng nhập lại");
                btnnhap.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnnhap.Enabled = true;
            }
        }

        private void btnxoadc_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                listBox1.Items.RemoveAt(0);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnxoachon_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count != 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void btntang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = int.Parse(listBox1.Items[i].ToString()) + 2;
                listBox1.Items[i] = x.ToString();
            }

        }

        private void btnchan_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = null;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (int.Parse(listBox1.Items[i].ToString()) % 2 == 0)
                {
                    listBox1.SelectedIndex = i;
                }
            }
        }

        private void btnle_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = null;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (int.Parse(listBox1.Items[i].ToString()) % 2 != 0)
                {
                    listBox1.SelectedIndex = i;
                }
            }
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
