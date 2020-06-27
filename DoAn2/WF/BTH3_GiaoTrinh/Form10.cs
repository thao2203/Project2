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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        bool check = true;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void txtma_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtdiachi.Text.Length == 0 || txtten.Text.Length == 0 || txtma.Text.Length == 0)
                btncapnhat.Enabled = false;
            else
                btncapnhat.Enabled = true;
        }

        private void txtten_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtdiachi.Text.Length == 0 || txtten.Text.Length == 0 || txtma.Text.Length == 0)
                btncapnhat.Enabled = false;
            else
                btncapnhat.Enabled = true;
        }

        private void txtdiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtdiachi.Text.Length == 0 || txtten.Text.Length == 0 || txtma.Text.Length == 0)
                btncapnhat.Enabled = false;
            else
                btncapnhat.Enabled = true;
        }
        private TreeNode FindNode(TreeNode node, string searchText)
        {
            TreeNode result = null;

            for (int i = 0; i < node.Nodes.Count; i++)
            {
                string[] l = node.Nodes[i].Text.Split('-');
                if (l[0] == searchText)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại");
                    check = false;
                    break;
                }
            }
            return result;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < treeView1.Nodes[0].Nodes.Count; i++)
            {
                FindNode(treeView1.Nodes[0].Nodes[i], txtma.Text);
                if (check == false)
                    txtma.Focus();
                goto t;
            }


            string them = this.txtma.Text + "-" + this.txtten.Text + "-" + this.txtdiachi.Text;
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Chọn lớp để thêm sinh viên");
                return;
            }
            if (treeView1.SelectedNode.Name == "lop")
            {
                treeView1.SelectedNode.Nodes.Add(them);
                txtdiachi.Text = txtma.Text = txtten.Text = "";
                btncapnhat.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chọn lớp để thêm sinh viên");
            }
        t:;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Name != "lop")
            {
                DialogResult dig = MessageBox.Show("Bạn có muốn xoá thông tin bạn chọn không ?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (dig == DialogResult.Yes)
                {
                    treeView1.SelectedNode.Remove();
                }
            }
        }
    }
}
