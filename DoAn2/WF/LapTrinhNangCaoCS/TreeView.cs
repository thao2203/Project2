using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhNangCaoCS
{
    public partial class TreeView : Form
    {
        string path = @"D:\";
        public TreeView()
        {
            InitializeComponent();
            //ktra o dia co ton tai hay khong
            if (Directory.Exists(path))
            {
                TreeNode root = new TreeNode() { Text = path };
                tvShow.Nodes.Add(root);
                LoadExplorer(root);
            }

            //LoadTreeView();
        }

        void LoadExplorer(TreeNode root)
        {
            if (root == null)
                return;

            tvShow.Nodes.Add(root);

            //lay danh sach forder been trong no

            try
            {
                var folderList = new DirectoryInfo(root.Text).GetDirectories();

                if (folderList.Count() == 0)
                {
                    return;
                }

                foreach (DirectoryInfo item in folderList)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = item.FullName };
                        root.Nodes.Add(node);
                        LoadExplorer(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        void LoadTreeView()
        {
            tvShow.CheckBoxes = true;
            tvShow.NodeMouseClick += tvShow_NodeMouseClick;

            TreeNode root1 = new TreeNode();
            root1.Text = "Root1";
            root1.ImageIndex = 0;

            TreeNode node1 = new TreeNode() { Text = "Node1" };
            root1.Nodes.Add(node1);
            node1.ImageIndex = 1;
            node1.Checked = true;

            TreeNode root2 = new TreeNode();
            root2.Text = "Root1";
            root2.ImageIndex = 2;

            tvShow.Nodes.Add(root1);
            tvShow.Nodes.Add(root2);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void TreeView_Load(object sender, EventArgs e)
        {

        }

        private void tvShow_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
            e.Node.Checked = !e.Node.Checked;
        }
    }
}
