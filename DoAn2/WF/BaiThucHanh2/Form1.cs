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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtso.Focus();
        }

        private void txtso_KeyUp(object sender, KeyEventArgs e)
        {
            Regex nhap = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            if (!nhap.IsMatch(txtso.Text) && txtso.Text != "")
            {
                errorProvider1.SetError(txtso, "Nhâp lại");
                btnCapNhat.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnCapNhat.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtso.Text != "")
                comboBox1.Items.Add(txtso.Text);
            txtso.Text = "";
            txtso.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = int.Parse(comboBox1.SelectedItem.ToString());
            while (n < 1) ;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    listBox1.Items.Add(i);
        }
        public bool snt(int x)
        {
            int biendem = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                    biendem++;
            }

            if (biendem == 2)
                return true;
            else
                return false;
        }

        private void btntonguoc_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                tong += int.Parse(listBox1.Items[i].ToString());
            }
            MessageBox.Show("Tổng các ước số là :" + tong);
        }

        private void btnuocchan_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (int.Parse(listBox1.Items[i].ToString()) % 2 == 0)
                {
                    tong++;
                }
            }
            MessageBox.Show("Số lượng các ước số chẵn là :" + tong);
        }

        private void btnuocnguyento_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 1; i <= listBox1.Items.Count; i++)
            {
                if (snt(int.Parse(listBox1.Items[i - 1].ToString())) || int.Parse(listBox1.Items[i - 1].ToString()) == 2)
                {
                    dem++;
                }
            }
            MessageBox.Show("Số lượng các số nguyên tố là : " + dem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
