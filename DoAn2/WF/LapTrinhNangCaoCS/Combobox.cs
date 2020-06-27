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
    public partial class Combobox : Form
    {
        public Combobox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ban vua chon phan tu thu: " + cbo.SelectedItem);
            /*  cbo.Items[cbb.SelectedIndex].ToString();
             Them: cbo.Items.Add(cbb.SelectedItem);
             Xoa: cbo.Iteams.RemoveAt(cs);
             -foreach (KDL tên_biến in DanhSach)*/
        }
        private void lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chọn nhieu ptu
            string t = " ";
            foreach (string i in lbx.SelectedItems)
                t += i + ",";
            MessageBox.Show("Cac phan tu chon la: ", t);
        }
    }
}
