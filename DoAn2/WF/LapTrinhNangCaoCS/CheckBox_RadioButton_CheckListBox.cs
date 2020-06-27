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
    public partial class CheckBox_RadioButton_CheckListBox : Form
    {
        public CheckBox_RadioButton_CheckListBox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string choose = "";
            foreach(Control chk in this.Controls)
            {
                if(chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked == true)
                        choose += chk.Text + ",";
                }
            }
            MessageBox.Show("Các lựa chọn: " + choose);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string t = " ";
            foreach (object i in checkedListBox1.CheckedItems)
            {
                t += i + ",";
                MessageBox.Show("Chọn thời gian: " + t);
            }
        }
    }
}
