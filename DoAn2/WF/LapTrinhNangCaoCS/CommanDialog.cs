using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LapTrinhNangCaoCS
{
    public partial class CommanDialog : Form
    {
        public CommanDialog()
        {
            InitializeComponent();
        }

        private void CommanDialog_UserControl_Load(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có khỏe không?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                MessageBox.Show("Chọn Yes");
            else
                MessageBox.Show("Chọn No");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tiêu đề của Dialog
            openFileDialog2.Title = "Open File";
            //Thư mục khỏi tạo
            openFileDialog2.InitialDirectory = @"E:\";
            //chọn nhiều file 1 lúc
            openFileDialog2.Multiselect = true;
            //Xác dịnh kiểu file cần mở
            openFileDialog2.Filter = "Text Document|*.txt|Word 97-2003 Document|*.doc|Word Document|*.doc|All Files|*.*";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog2.FileName;
                StreamReader sr = new StreamReader(path);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }

        }
     
        //lưu file text
        private void button2_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "TEXT FILE(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //tạo đọc ghi
                Stream mystream = saveFileDialog1.OpenFile();
                //tạo đối tượng ghi file
                StreamWriter sw = new StreamWriter(mystream);
                //lưu nội dung
                sw.Write(textBox1.Text);

                sw.Close();
                mystream.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // cho phép chọn màu sắc từ hoopk font
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK) ;
            {
                //gán phông chữ chủa hộp thoại font cho textbox
                textBox1.Font = fontDialog1.Font;
                //gán màu chữ của hộp thoại cho textbox
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }
    }
}
