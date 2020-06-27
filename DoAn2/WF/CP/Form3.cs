using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnxuly_Click(object sender, EventArgs e)
        {
            CrystalReport2 rp = new CrystalReport2();
            //dòng lệnh giúp chuyển dữ liệu liệu từ textbox sang report
            ((TextObject)rp.ReportDefinition.ReportObjects["txtTenSv"]).Text = textBox1.Text;
        }
    }
}
