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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtname.Focus();
        }
        private void txtname_Leave(object sender, EventArgs e)
        {
            if(txtname.Text=="")
            {
                txtname.Focus();
                errorProvider1.SetError(txtname, "Vui lòng điền thông tin chính xác");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void maskdate_Leave(object sender, EventArgs e)
        {
            if (maskdate.MaskFull)
            {
                try
                {
                    DateTime.ParseExact(maskdate.Text, "dd/MM/yyyy", null);
                }
                catch
                {
                    MessageBox.Show("Ngày không hợp lệ");
                    maskdate.ResetText();
                    maskdate.Focus();
                }
            }
            else
            {
                maskdate.Focus();
                errorProvider1.SetError(maskdate, "Vui lòng điền thông tin chính xác");
            }
        }

        private void txtadrress_Leave(object sender, EventArgs e)
        {
            if (txtadrress.Text == "")
            {
                txtadrress.Focus();
                errorProvider1.SetError(txtadrress, "Vui lòng điền thông tin chính xác");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmp = comboBox1.SelectedItem.ToString();
            if(tmp=="Việt Nam")
            {
                listcity.Items.Clear();
                string[] m = new string[] { "Hồ chí minh", "Nha Trang", "Hà Nội" };
                listcity.Items.Add(m[0].ToString());
                listcity.Items.Add(m[1].ToString());
                listcity.Items.Add(m[2].ToString());
            }
            else
            {
                listcity.Items.Clear();
                string[] m = new string[] { "Bangkok", "ChiengMai", "Pattaya" };
                listcity.Items.Add(m[0].ToString());
                listcity.Items.Add(m[1].ToString());
                listcity.Items.Add(m[2].ToString());
            }
        }
        private void maskphone_Leave(object sender, EventArgs e)
        {
            if (maskphone.Text.Length != 11)
            {
                errorProvider1.SetError(maskphone, "Vui lòng điền thông tin chính xác");
                maskphone.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Focus();
                errorProvider1.SetError(txtemail, "Vui lòng điền thông tin chính xác");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                string k = "Tên : " + txtname.Text 
                    + "\nNgày sinh : " + maskdate.Text 
                    + "\nĐịa chỉ : " + txtadrress.Text 
                    + "\nThành phố : " + listcity.SelectedItem.ToString() 
                    + "\nQuốc tịch : " + comboBox1.SelectedItem 
                    + "\nTrình độ : " + listqua.SelectedItem.ToString() 
                    + "\nSố điện thoại : " + maskphone.Text 
                    + "\nEmail : " + txtemail.Text 
                    + "\nNgày tham gia : " + dateTimePicker1.Value;
                MessageBox.Show(k);
            }
            catch
            {
                MessageBox.Show("Vui lòng điền thông tin chính xác");
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskphone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadrress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
