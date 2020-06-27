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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string strKetNoi = @"Data Source=DESKTOP-CDO0SQ2;Initial Catalog=QLSV_WF_BAI14;Integrated Security=True";
        SqlConnection sqlCon; //để kết nối
        SqlCommand sqlCom; //dòng lệnh sql
        SqlDataReader sqlRe;  //Đọc dữ liệu nhưng ko lưu mà nhớ tạm
        SqlDataAdapter sqlAdap; //Đọc dữ liệu và đổ vào nguồn
        DataTable dt; //Bảng dữ liệu
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

        void LoadMaKhoa ()
        {
            KetNoi();
            sqlCom = new SqlCommand("Select * from Khoa",sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            while(sqlRe.Read())
            {
                comboBox1.Items.Add(sqlRe[0]);
            }
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
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tong=0;
            string sql = string.Format(" SELECT * FROM SINHVIEN WHERE MAKHOA IN(SELECT MAKHOA FROM KHOA WHERE MAKHOA = '{0}')", comboBox1.SelectedItem.ToString());
            KetNoi();
            string sql1 = string.Format("select COUNT(MASINHVIEN) from SINHVIEN where MAKHOA = '{0}'",comboBox1.Text);
            sqlCom = new SqlCommand(sql1, sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            while (sqlRe.Read())
            {
                tong += int.Parse(sqlRe[0].ToString());
            }
            textBox2.Text = tong.ToString();
            sqlRe.Close();
            dt = new DataTable();
            sqlAdap = new SqlDataAdapter(sql, strKetNoi);
            sqlAdap.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCom = new SqlCommand("select * from KHOA where MAKHOA='" + comboBox1.Text + "'", sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            while (sqlRe.Read())
            {
                textBox1.Text = sqlRe[1].ToString();
            }
            NgatKetNoi();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            LoadDuLieuDataGridView("Select * from SINHVIEN");
            LoadMaKhoa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
