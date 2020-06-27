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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strKetNoi = @"Data Source=DESKTOP-CDO0SQ2;Initial Catalog=QLSV_WF;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRe;
        SqlDataAdapter sqlAdap;
        DataTable dt;
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
        int KiemTraMaTrung(string strSelect)
        {
            int sbg = 0;
            KetNoi();
            sqlCom = new SqlCommand(strSelect, sqlCon);
            sbg = (int)sqlCom.ExecuteScalar();
            NgatKetNoi();
            return sbg;
        }
        void ThucThi(string strSQL)
        {
            KetNoi();
            sqlCom = new SqlCommand(strSQL, sqlCon);
            sqlCom.ExecuteNonQuery();
            NgatKetNoi();
        }
        void LoadDuLieuDataGridView(string strSelect)
        {
            KetNoi();
            dt = new DataTable();
            sqlAdap = new SqlDataAdapter(strSelect, strKetNoi);
            sqlAdap.Fill(dt);
            dataGridView1.DataSource = dt;
            NgatKetNoi();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[HangChon].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[HangChon].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[HangChon].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[HangChon].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (KiemTraMaTrung("Select count(Malop) from lop where Malop='" + textBox1.Text + "'") == 0)
            {
                ThucThi("Insert Into lop values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "',N'" + textBox4.Text + "')");
                LoadDuLieuDataGridView("Select * from lop");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strUpdate = "update lop set TenLop='" + textBox2.Text + "',SiSo='" + textBox3.Text + "',GhiChu='" + textBox4.Text + "' where MaLop='" + textBox1.Text + "'";
            ThucThi(strUpdate);
            LoadDuLieuDataGridView("Select *from lop");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strDelete = "Delete from lop where MaLop='" + textBox1.Text + "'";
            ThucThi(strDelete);
            LoadDuLieuDataGridView("Select * from lop");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KetNoi();
            sqlCom = new SqlCommand("Select * from lop", sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            while (sqlRe.Read())
            {
                MessageBox.Show(sqlRe[1].ToString());
            }
            NgatKetNoi();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadDuLieuDataGridView("Select * from lop");

        }
    }
}

