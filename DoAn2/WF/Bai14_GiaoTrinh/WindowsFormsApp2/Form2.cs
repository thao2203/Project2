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
    public partial class Form2 : Form
    {
        public Form2()
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

        void loadmalop()
        {
            KetNoi();
            sqlCom = new SqlCommand("select * from MONHOC",sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            while(sqlRe.Read())
            {
              //  MessageBox.Show(sqlRe[0].ToString());
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
            LoadDuLieuDataGridView("Select * from SINHVIEN");
            loadmalop();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = string.Format(" SELECT * FROM SINHVIEN WHERE MAMONHOC IN(SELECT MAMONHOC FROM MONHOC WHERE MAMONHOC = '{0}')",comboBox1.SelectedItem.ToString());
            KetNoi();
            dt = new DataTable();
            sqlAdap = new SqlDataAdapter(sql, strKetNoi);
            sqlAdap.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCom = new SqlCommand("select * from monhoc where mamonhoc='"+comboBox1.Text+"'",sqlCon);
            sqlRe = sqlCom.ExecuteReader() ;
            while (sqlRe.Read())
            {
                txtSoTiet.Text = sqlRe[2].ToString();
                txtTenMon.Text = sqlRe[1].ToString();
            }
            NgatKetNoi();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
