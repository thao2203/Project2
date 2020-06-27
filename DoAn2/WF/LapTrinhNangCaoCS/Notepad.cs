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
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Notepad_Load(object sender, EventArgs e)
        {
        }

        private void newWindownToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //cho phép chọn màu sắc từ hoopk font
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK) ;
            {
                //gán phông chữ chủa hộp thoại font cho textbox
                rtBox.Font = fontDialog1.Font;
                //gán màu chữ của hộp thoại cho textbox
                rtBox.ForeColor = fontDialog1.Color;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                rtBox.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripStatusLabel7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel7.Text = DateTime.Now.ToString();
        }

        private void openToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Tiêu đề của Dialog
            openFileDialog1.Title = "Open File";
            //Thư mục khỏi tạo
            openFileDialog1.InitialDirectory = @"D:\";
            //chọn nhiều file 1 lúc
            openFileDialog1.Multiselect = true;
            //Xác dịnh kiểu file cần mở
            openFileDialog1.Filter = "Text Document|*.txt|Word 97-2003 Document|*.doc|Word Document|*.doc|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(path);
                rtBox.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "TEXT FILE(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //tạo đọc ghi
                Stream mystream = saveFileDialog1.OpenFile();
                //tạo đối tượng ghi file
                StreamWriter sw = new StreamWriter(mystream);
                //lưu nội dung
                sw.Write(rtBox.Text);

                sw.Close();
                mystream.Close();
            }
        }
    }
}
