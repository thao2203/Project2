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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.SmallImageList = imageList1;
            if(txtlastname.Text.Trim()==""||txtfirstname.Text.Trim()==""||txtphone.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
            else
            {
                string[] txt = { txtlastname.Text, txtfirstname.Text, txtphone.Text };
                var listViewItem = new ListViewItem(txt, 0);  //đây là chỉ sô của ảnh
                listView1.Items.Add(listViewItem);
                txtlastname.Text = txtfirstname.Text = txtphone.Text = "";
                txtlastname.Focus();
            }
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void txtlastname_Leave(object sender, EventArgs e)
        {
            if (txtlastname.Text == "")
            {
                txtlastname.Focus();
                errorProvider1.SetError(txtlastname, "Vui lòng điền thông tin chính xác");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtfirstname_Leave(object sender, EventArgs e)
        {
            if (txtfirstname.Text == "")
            {
                txtfirstname.Focus();
                errorProvider1.SetError(txtfirstname, "Vui lòng điền thông tin chính xác");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "")
            {
                txtphone.Focus();
                errorProvider1.SetError(txtphone, "Vui lòng điền thông tin chính xác");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                listView1.BackColor = colorDialog1.Color;
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
