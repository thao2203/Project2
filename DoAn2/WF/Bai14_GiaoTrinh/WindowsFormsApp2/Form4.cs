using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        string strKetNoi = @"Data Source=DESKTOP-CDO0SQ2;Initial Catalog=Student_wf;Integrated Security=True";
        SqlConnection sqlCon; //để kết nối
        SqlCommand sqlCom; //dòng lệnh sql
        SqlDataReader sqlRe;  //Đọc dữ liệu nhưng ko lưu mà nhớ tạm
        SqlDataAdapter sqlAdap; //Đọc dữ liệu và đổ vào nguồn
        DataTable dt; //Bảng dữ liệu
        public Form4()
        {
            InitializeComponent();
        }
        void KetNoi()
        {
            sqlCon = new SqlConnection(strKetNoi);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }
        void NgatKetNoi()
        {
            sqlCon.Close();
        }
        void loadmalop()
        {
            KetNoi();
            sqlCom = new SqlCommand("Select * from StudentClass", sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            while (sqlRe.Read())
            {
                comboBox1.Items.Add(sqlRe[0]);
            }
            NgatKetNoi();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            loadmalop();
            loaddata();
        }

        void loaddata()
        {
            string sql = string.Format("select * from StudentClass");
            KetNoi();
            dt = new DataTable();
            sqlAdap = new SqlDataAdapter(sql, strKetNoi);
            sqlAdap.Fill(dt);
            dataGridView1.DataSource = dt;
            NgatKetNoi();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KetNoi();
            sqlCom = new SqlCommand("select * from StudentClass where classNo='" + comboBox1.Text + "'", sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            while (sqlRe.Read())
            {
                textBox1.Text = sqlRe[3].ToString();
                textBox2.Text = sqlRe[2].ToString();
            }
            NgatKetNoi();
        }
    }
}
