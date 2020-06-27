using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhNangCaoCS
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
            LoadlistView4();
        }

        ImageList imgListSmall;
        ImageList imgListlarge;

        void LoadImageList()
        {
            imgListlarge = new ImageList() { ImageSize = new Size(68, 68) };
            imgListlarge.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\1.png"));
            imgListlarge.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\2.png"));
            imgListlarge.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\3.png"));

            imgListSmall = new ImageList() { ImageSize = new Size(16, 16) };
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\1.png"));
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\2.png"));
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\3.png"));
        }

        void LoadlistView4()
        {
            LoadImageList();

            listView4.FullRowSelect = true;
            listView4.GridLines = true;
            listView4.LargeImageList = imgListlarge;
            listView4.SmallImageList = imgListSmall;

            listView4.Columns.Add("Columns 1");
            listView4.Columns.Add("Columns 2");
            listView4.Columns.Add("Columns 3");

            ListViewItem item1 = new ListViewItem();
            item1.Text = "Item1";
            item1.ImageIndex= 0;
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Subitem 1" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Subitem 2" });

            ListViewItem item2= new ListViewItem();
            item2.Text = "Item2";
            item2.ImageIndex = 1;
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Subitem 1" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Subitem 2" });

            ListViewItem item3 = new ListViewItem();
            item3.Text = "Item3";
            item3.ImageIndex = 2;
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Subitem 1" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Subitem 2" });

            listView4.Items.Add(item1);
            listView4.Items.Add(item2);
            listView4.Items.Add(item3);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView4.View = View.LargeIcon;
            listView4.CheckBoxes = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView4.View = View.Details;
            listView4.CheckBoxes = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView4.View = View.SmallIcon;
            listView4.CheckBoxes = false;
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;

            if(lsv.listView4.SelectedItems.Count>0)
            {
                ListViewItem item = lsv.listView4.SelectedItems[0];
                MessageBox.Show(item.Text);
            }
        }
    }
}
