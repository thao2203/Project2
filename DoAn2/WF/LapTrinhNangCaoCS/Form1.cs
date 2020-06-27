using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

namespace LapTrinhNangCaoCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Khai báo các đối tượng 
        string strKetNoi = @"Data Source=DESKTOP-1OASCOJ;Initial Catalog=QLSV;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRea;
        SqlDataAdapter sqlAdap;
        DataTable dt;

        //Cac phuong thuc
        //Phuong thuc 1. Mo ket noi voi CSDL
        void KetNoi()
        {
            sqlCon = new SqlConnection(strKetNoi);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        //Phuong thuc 2. Dong ket noi
        void NgatKetNoi()
        {
            sqlCon = new SqlConnection(strKetNoi);
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        //Phuong thuc 3. Kiem tra ma trung
        int KiemTraMaTrung(string strSelect)
        {
            int sbg = 0;
            //KetNoi();

            //sqlCom = new SqlCommand(strSelect, sqlCon);
            //sbg = (int)sqlCom.ExecuteScalar();

            //NgatKetNoi();

            DataTable dtSelect = new DataTable();
            sqlAdap = new SqlDataAdapter(strSelect, strKetNoi);
            sqlAdap.Fill(dtSelect);

            sbg = dtSelect.Rows.Count;

            return sbg;
        }

        //Phuong thuc 4. Thuc thi cau lenh SQL (them, sua, xoa)
        void ThucThi(string strSQL)
        {
            
            DataTable dtSQL = new DataTable();
            sqlAdap = new SqlDataAdapter(strSQL, strKetNoi);
            sqlAdap.Fill(dtSQL);
            
        }

        //doc du lieu
        //void DocDuLieu()
        //{
        //    KetNoi();
        //    string sql = "Select * From Lop";
        //    sqlCom = new SqlCommand(sql, sqlCon);
        //    sqlRea = sqlCom.ExecuteReader();
        //    while(sqlRea.Read())
        //    {
        //        dgvLop.Rows.Add(sqlRea[0].ToString(), sqlRea[1].ToString(), sqlRea[2].ToString(), sqlRea[3].ToString(), sqlRea[4].ToString(), sqlRea[5].ToString());
        //    }
        //    NgatKetNoi();
        //}

        //Phuong thuc 5. Load du lieu vao DataGridView
        void LoadDuLieuDataGridView(string strSelect)
        {
            dt = new DataTable();
            sqlAdap = new SqlDataAdapter(strSelect, strKetNoi);
            sqlAdap.Fill(dt);
            dgvLop.DataSource = dt;
        }

        //Form_Load
        private void Form1_Load(object sender, EventArgs e)
        {
           
            KetNoi();
            sqlCom = new SqlCommand("Select * From khoa", sqlCon);

            sqlRea = sqlCom.ExecuteReader();
            while (sqlRea.Read())
            {
                comboBox1.Items.Add(sqlRea[0].ToString());
            }

            NgatKetNoi();

            LoadDuLieuDataGridView("Select * From Lop");

        }

        

        private void btnmoi_Click(object sender, EventArgs e)
        {
            foreach (Control item in txtkhoa.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if(item is ComboBox)
                {
                    item.Text = "Chọn khoa";
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (KiemTraMaTrung("Select * form lop where malop='" + txtMalop.Text + "'") == 1)
            {
                MessageBox.Show("Ma: " + txtMalop.Text + " da ton tai. Vui long chon ma khac!");
            }
            else if (KiemTraMaTrung("Select * form lop where malop='" + txtMalop.Text + "'") == 0)
            {
                ThucThi("Insert Into lop Values('" + txtMalop.Text + "',N'" + txtTenlop.Text + "',N'" + textBox1.Text + "','" + txthedtao.Text + "','" + txtNamNhapHoc.Text + "','" + comboBox1.Text + "')");
                LoadDuLieuDataGridView("Select * from lop");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
            string strUpdate = "Update lop Set tenlop=N'" + txtTenlop.Text + "',khoa=N'" + textBox1.Text + "',hedaotao='" + txthedtao.Text + "',namnhathoc='" + txtNamNhapHoc.Text + "',makhoa='" + comboBox1.Text + "' where malop='" + txtMalop.Text + "' ";
            ThucThi(strUpdate);
           
            LoadDuLieuDataGridView("Select * from lop");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            
            string strDelete = "Delete from lop Where malop='" + txtMalop.Text + "' ";
            ThucThi(strDelete);
            
            LoadDuLieuDataGridView("Select * from lop");
        }

        private void btndoc_Click(object sender, EventArgs e)
        {
            KetNoi();

            sqlCom = new SqlCommand("Select * from lop", sqlCon);
            sqlRea = sqlCom.ExecuteReader();
            while (sqlRea.Read())
            {
                MessageBox.Show(sqlRea[1].ToString());
            }

            NgatKetNoi();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
            txtMalop.Text = dgvLop[0, HangChon].Value.ToString();
            txtTenlop.Text = dgvLop[1, HangChon].Value.ToString();
            textBox1.Text = dgvLop[2, HangChon].Value.ToString();
            txthedtao.Text = dgvLop[3, HangChon].Value.ToString();
            txtNamNhapHoc.Text = dgvLop[4, HangChon].Value.ToString();
            comboBox1.Text = dgvLop[5, HangChon].Value.ToString();
        }
    }
}
  