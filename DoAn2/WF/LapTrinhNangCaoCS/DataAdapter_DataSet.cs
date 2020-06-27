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

namespace LapTrinhNangCaoCS
{
    public partial class DataAdapter_DataSet : Form
    {
        public DataAdapter_DataSet()
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

        //Phuong thuc 5. Load du lieu vao DataGridView
        void LoadDuLieuDataGridView(string strSelect)
        {
            dt = new DataTable();
            sqlAdap = new SqlDataAdapter(strSelect, strKetNoi);
            sqlAdap.Fill(dt);
            dgDSSV.DataSource = dt;
        }
        private void DataAdapter_DataSet_Load(object sender, EventArgs e)
        {

            KetNoi();
            sqlCom = new SqlCommand("Select * From dbo.Lop", sqlCon);

            sqlRea = sqlCom.ExecuteReader();
            while (sqlRea.Read())
            {
                comboBox1.Items.Add(sqlRea[0].ToString());
            }

            NgatKetNoi();

            LoadDuLieuDataGridView("Select * From SinhVien");
        }
    }
}
