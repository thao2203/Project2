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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            txthoten.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                txtdinhmuc.Text = "50";
            if (comboBox1.SelectedIndex == 1)
                txtdinhmuc.Text = "100";
            if (comboBox1.SelectedIndex == 2)
                txtdinhmuc.Text = "150";
        }

        private void txtcu_KeyUp(object sender, KeyEventArgs e)
        {
            System.Text.RegularExpressions.Regex nhapso = new System.Text.RegularExpressions.Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            if (!nhapso.IsMatch(txtcu.Text) || int.Parse(txtmoi.Text) < int.Parse(txtcu.Text))
            {
                errorProvider1.SetError(txttieuthu, "Nhập đúng định dạng/ Số không hợp lệ!");
                btntinhtien.Enabled = false;
            }
            else
            {
                btntinhtien.Enabled = true;
                errorProvider1.Clear();
            }

            try
            {
                int moi, cu, tieuthu;
                moi = int.Parse(txtmoi.Text);
                cu = int.Parse(txtcu.Text);
                tieuthu = moi - cu;
                txttieuthu.Text = tieuthu.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            try
            {
                int moi, cu, tieuthu;
                moi = int.Parse(txtmoi.Text);
                cu = int.Parse(txtcu.Text);
                if (txthoten.Text.Trim() == "" || txtdinhmuc.Text == "0")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                    goto end;
                }
                if (int.Parse(txttieuthu.Text) <= int.Parse(txtdinhmuc.Text))
                {
                    tieuthu = (moi - cu) * 500;
                }
                else
                {
                    tieuthu = (moi - cu) * 500;
                }
                txtthanhtien.Text = tieuthu.ToString();
                string[] row = { txthoten.Text, comboBox1.Text, txtdinhmuc.Text, txttieuthu.Text, txtthanhtien.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                int thanhtien = int.Parse(txtthanhtien.Text);
                txtdinhmuc.Clear();
                txthoten.Clear();
                txtmoi.Text = "0";
                txtcu.Text = "0";
                txttieuthu.Clear();
                txthoten.Focus();
                comboBox1.Text = "Chọn KV";

                int tong = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    tong += int.Parse(listView1.Items[i].SubItems[4].Text);

                }
                txttongtien.Text = tong.ToString();
            end:;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void txtmoi_KeyUp(object sender, KeyEventArgs e)
        {
            System.Text.RegularExpressions.Regex nhap = new System.Text.RegularExpressions.Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            if (!nhap.IsMatch(txtmoi.Text) || int.Parse(txtmoi.Text) < int.Parse(txtcu.Text))
            {
                btntinhtien.Enabled = false;
                errorProvider1.SetError(txttieuthu, "vui lòng nhập đúng định dạng,hoặc số điện không hợp lệ");
            }
            else
            {
                btntinhtien.Enabled = true;
                errorProvider1.Clear();
            }



            try
            {
                int moi, cu, tieuthu;
                moi = int.Parse(txtmoi.Text);
                cu = int.Parse(txtcu.Text);
                tieuthu = moi - cu;
                txttieuthu.Text = tieuthu.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnnhapmoi_Click(object sender, EventArgs e)
        {
            txtdinhmuc.Text = "0";
            txthoten.Clear();
            txtmoi.Text = "0";
            txtcu.Text = "0";
            txttieuthu.Clear();
            txthoten.Focus();
            txtthanhtien.Clear();
            comboBox1.Text = "Chọn KV";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xoá thông tin bạn chọn không ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                foreach (ListViewItem i in listView1.Items)
                    if (i.Selected == true)
                        i.Remove();
            }

            int t = 0;
            for (int j = 0; j < listView1.Items.Count; j++)
            {
                t += int.Parse(listView1.Items[j].SubItems[4].Text);

            }
            txttongtien.Text = t.ToString();
        }
    }
}
