using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TH12_115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strKetNoi = @"Data Source=(local);Initial Catalog=QLDT_TH;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataTable table;
        void KetNoi()
        {
            connection = new SqlConnection(strKetNoi);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        void NgatKetNoi()
        {
            connection.Close();
        }
        int KiemTraMaTrung(string strSelect)
        {
            int sbg = 0;
            KetNoi();
            command = new SqlCommand(strSelect, connection);
            NgatKetNoi();
            return sbg;
        }
        void ThucThi(string strSQL)
        {
            KetNoi();
            command = new SqlCommand(strSQL, connection);
            command.ExecuteNonQuery();
            NgatKetNoi();
        }
        void LoadDuLieuDataGridView(string strSelect)
        {
            table = new DataTable();
            adapter = new SqlDataAdapter(strSelect, strKetNoi);
            adapter.Fill(table);
            dgLop.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDuLieuDataGridView("select*from lop");
        }

        private void dgLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            txtMalop.Text = dgLop[0, HangChon].Value.ToString();
            txtTenlop.Text = dgLop[1, HangChon].Value.ToString();
            txtSiso.Text = dgLop[2, HangChon].Value.ToString();
            txtGhichu.Text = dgLop[3, HangChon].Value.ToString();
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            txtMalop.Text = "";
            txtTenlop.Text = "";
            txtSiso.Text = "";
            txtGhichu.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (KiemTraMaTrung("select count(malop) from lop where malop='" + txtMalop.Text + "'") == 1)
                MessageBox.Show("Mã:" + txtMalop.Text + "đã tồn tại.Vui lòng chọn mã khác");
            else if(KiemTraMaTrung("select count(malop) from lop where malop='" + txtMalop.Text + "'") == 0)
            {
                ThucThi("insert into lop values('" + txtMalop.Text + "','" + txtTenlop.Text + "','" + txtSiso.Text + "','" + txtGhichu.Text + "')");
                LoadDuLieuDataGridView("select*from lop");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string strUpdate = "update lop set tenlop='" + txtTenlop.Text + "',Siso='" + txtSiso.Text + "',Ghichu='" + txtGhichu.Text + "' where malop='" + txtMalop.Text + "'";
            ThucThi(strUpdate);
            LoadDuLieuDataGridView("select * from lop");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string strDelete = "delete from lop where malop='" + txtMalop.Text + "'";
            ThucThi(strDelete);
            LoadDuLieuDataGridView("select*from lop");
        }

        private void btDoc_Click(object sender, EventArgs e)
        {
            KetNoi();
            command = new SqlCommand("select*from lop", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader[1].ToString());
            }
            NgatKetNoi();
        }
    }
}
