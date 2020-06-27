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
    public partial class DemoListBox : Form
    {
        public DemoListBox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //nhập ptu mới chưa có thêm có r thì boi đen
            if (lbx.Items.IndexOf(txtbox.Text) >= 0)
                lbx.SelectedItem = txtbox.Text;
            else if (txtbox.Text.Length > 0)
                lbx.Items.Add(txtbox.Text);
        }

        private void lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Chọn và xóa phần tử 
            if (lbx.SelectedIndex >= 0)
               lbx.Items.RemoveAt(lbx.SelectedIndex);
        }
    }
}
