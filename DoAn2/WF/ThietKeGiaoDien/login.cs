using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ThietKeGiaoDien
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
            string a = "^[a-z0-9_-]{3,15}$";
            bool valid = Regex.IsMatch(textBox2.Text, a);
            if (textBox1.Text == null)
            {
                errorProvider1.SetError(textBox1, "Can not null");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Can not null");
            }
            else if (valid == false)
            {
                errorProvider1.SetError(textBox2, "Password must contain alphabet and numbers or char number must in range 3 and 15");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
