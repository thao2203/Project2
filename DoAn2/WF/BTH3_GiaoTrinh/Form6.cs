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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtma.Text = txthoten.Text = txtdiachi.Text = comboBox1.Text = "";
            txtma.Focus();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            listView1.SmallImageList = ilsNho;
            if (txtma.Text == "" || txthoten.Text == "" || txtdiachi.Text == "" || comboBox1.SelectedItem == null || DateTime.Now.Year - dateTimePicker1.Value.Year < 18)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
            else
            {
                string[] txt = { txtma.Text, txthoten.Text, txtdiachi.Text, dateTimePicker1.Value.ToString(), comboBox1.SelectedItem.ToString() };
                var listViewItem = new ListViewItem(txt, 0);
                listView1.Items.Add(listViewItem);
                txtma.Text = txthoten.Text = txtdiachi.Text = comboBox1.Text = ""; ;               
                txtma.Focus();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtma.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txthoten.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtdiachi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            dateTimePicker1.Value = DateTime.Parse(listView1.SelectedItems[0].SubItems[3].Text);
            comboBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView1.Items)
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Hãy chọn thong tin học sinh");
                    break;
                }
                DialogResult x = MessageBox.Show("Ban co muon xoa thong tin da chon khong? ", "Canh bao", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    foreach (ListViewItem it in listView1.Items)
                    if (it.Selected == true)
                        it.Remove();
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(this, this.PointToClient(MousePosition));
        }

        private void largeicon_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void detail_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void small_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void list_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void title_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
    }
}
