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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            for(int i=DateTime.Now.Year-30; i<DateTime.Now.Year;i++)
            {
                comboBox1.Items.Add(i);
            }
            textBox1.Focus();
            btnDangKy.Enabled = false;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string kihoc = "";
            string monhoc = "";
            if (radioButton1.Checked == true) { kihoc = "I"; }
            if (radioButton2.Checked == true) { kihoc = "II"; }
            if (radioButton3.Checked == true) { kihoc = "III"; }
            if (radioButton4.Checked == true) { kihoc = "IV"; }
            int x = 1;
            for(int i=0;i<checkedListBox1.Items.Count;i++)
            {
                if (checkedListBox1.GetItemChecked(i) == true)
                {
                    monhoc += x.ToString() + ". " + checkedListBox1.Items[i].ToString()+"\n";
                    x++;
                }
            }
            string show = ("Sinh Viên: " + textBox1.Text
                        + "\nLớp: " + comboBox2.SelectedItem.ToString()
                        + "\nNiên Khóa: " + comboBox1.SelectedItem.ToString()
                        + "\nĐã đăng ký học kỳ " + kihoc + " Các môn như sau:"
                        + "\n" + monhoc);
            MessageBox.Show(show);
        }
        public bool check()
        {
            int monhoc = 0;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {

                if (checkedListBox1.GetItemChecked(i) == true)
                {
                    monhoc++;
                }
            }
            if (monhoc != 0)
                return true;
            return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Form4 NewForm = new Form4();
            NewForm.Show();
            this.Dispose(false);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || checkedListBox1 == null || textBox1.Text == "" || textBox2.Text == "" || !check())
                btnDangKy.Enabled = false;
            else
                btnDangKy.Enabled = true;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null|| checkedListBox1 == null || textBox1.Text == "" || textBox2.Text == "" || !check())
                btnDangKy.Enabled = false;
            else
                btnDangKy.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || checkedListBox1 == null || textBox1.Text == "" || textBox2.Text == "" || !check())
                btnDangKy.Enabled = false;
            else
                btnDangKy.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || checkedListBox1 == null || textBox1.Text == "" || textBox2.Text == "" || !check())
                btnDangKy.Enabled = false;
            else
                btnDangKy.Enabled = true;
        }

        private void checkedListBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || checkedListBox1 == null || textBox1.Text == "" || textBox2.Text == "" || !check())
                btnDangKy.Enabled = false;
            else
                btnDangKy.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
