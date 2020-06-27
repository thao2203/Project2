using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Bai11_102_giaotrinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btXML2Text_Click(object sender, EventArgs e)
        {
            string strSinhVien = "";
            string strTenNode = "";
            //
            XmlTextReader read = new XmlTextReader("SinhVien.xml");
            //
            while(read.Read())
            {
                switch(read.NodeType)
                {
                    case XmlNodeType.Element:
                        strTenNode = read.Name;
                        break;
                    case XmlNodeType.Text:
                        switch(strTenNode)
                        {
                            case "Ten":
                                strSinhVien += read.Value;
                                strSinhVien += ",";//Hai thông tin ngăn cách bởi dấu ,
                                break;
                            case "NamSinh":
                                strSinhVien += read.Value;
                                MessageBox.Show(strSinhVien);//In từng bản ghi
                                strSinhVien = "";
                                break;
                        }
                        break;
                }    
            }    
        }

        private void btText2XML_Click(object sender, EventArgs e)
        {
            XmlTextWriter xmlText = new XmlTextWriter("SinhVien.xml", null);

            //Ghi chú
            xmlText.WriteComment("Đọc ra file XML");

            //Ghi dữ liệu : 1 lớp có nhiều sinh viên (tên, năm sinh)
            xmlText.WriteStartElement("Lop");

            //Bản ghi thứ nhất
            xmlText.WriteStartElement("SinhVien");
            xmlText.WriteAttributeString("ID", "1");

            xmlText.WriteStartElement("Ten");
            xmlText.WriteString("Hoàng Quốc Việt");
            xmlText.WriteEndElement(); //<Name>

            xmlText.WriteStartElement("NamSinh");
            xmlText.WriteValue(1985);
            xmlText.WriteEndElement();

            xmlText.WriteEndElement();

            //Bản ghi thứ hai
            xmlText.WriteStartElement("SinhVien");
            xmlText.WriteAttributeString("ID", "2");

            xmlText.WriteStartElement("Ten");
            xmlText.WriteString("Nguyễn Anh Tuấn");
            xmlText.WriteEndElement(); //<Name>

            xmlText.WriteStartElement("NamSinh");
            xmlText.WriteValue(1986);
            xmlText.WriteEndElement();

            xmlText.WriteEndElement();

            //Đóng file
            xmlText.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString();
            string s1 = s.Substring(s.IndexOf(" ") + 1, s.Length - s.IndexOf(" ") - 1);
            label1.Text = s1;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
