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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();//xoá các item cũ
            //hiện toàn bộ học sinh khi bấm vào khoa
            {
                if (treeView1.SelectedNode.Name == "khoa")
                    for (int t = 0; t < treeView1.SelectedNode.Nodes.Count; t++)//đếm số lớp của khoa
                        for (int r = 0; r < treeView1.SelectedNode.Nodes[t].Nodes.Count; r++)//đếm số hs của từng lớp
                        {
                            string[] list = treeView1.SelectedNode.Nodes[t].Nodes[r].Text.Split(',');
                            var listViewItem = new ListViewItem(list);
                            listView1.Items.Add(listViewItem);
                        }

            }
            //hiện học sinh khi bấm vào lớp
            {
                if (treeView1.SelectedNode.Name == "lop")
                    for (int r = 0; r < treeView1.SelectedNode.Nodes.Count; r++)//đếm số hs của từng lớp
                    {
                        string[] list = treeView1.SelectedNode.Nodes[r].Text.Split(',');
                        var listViewItem = new ListViewItem(list);
                        listView1.Items.Add(listViewItem);
                    }

            }
            //hiển thị thông tin học sinh khi bấm vào học sinh
            {
                if (treeView1.SelectedNode.Name == "hs")
                {
                    string[] list = treeView1.SelectedNode.Text.Split(',');
                    var listViewItem = new ListViewItem(list);
                    listView1.Items.Add(listViewItem);
                }
            }
        }

        private TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;//giá trị khởi đầu rỗng
            while (StartNode != null)//node khác rỗng
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    node = StartNode;
                    break;
                };
                if (StartNode.Nodes.Count != 0)
                {
                    node = SearchNode(SearchText, StartNode.Nodes[0]);
                    if (node != null)
                    {
                        break;
                    };
                };
                StartNode = StartNode.NextNode;
            };
            return node;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // listView1.Clear();//xoá danh sách
            string SearchText = this.textBox1.Text;//gán tên để tìm
            if (SearchText == "")//nếu rỗng bỏ qua
            {
                return;
            }
            TreeNode SelectedNode = SearchNode(SearchText, treeView1.SelectedNode);//tìm từ node đang chọn
            if (SelectedNode != null)
            {
                this.treeView1.SelectedNode = SelectedNode;//chọn node
                this.treeView1.Select();//khi tìm thấy thì chọn học sinh đồng thời cho vào list view
            }
        }
    }
}
