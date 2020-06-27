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
    public partial class vddtsdta : Form
    {
        public vddtsdta()
        {
            InitializeComponent();
        }

        //kien truc ket noi: Sqlconnection, Sqlcommand
        string strKetNoi = @"Data Source=DESKTOP-1OASCOJ;Initial Catalog=QLSV;Integrated Security=True";
        SqlConnection sqlCon;        
        SqlDataAdapter sqlAdap;
        DataSet ds;
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
        //Ham phi ket noi
        DataSet phikn(string sql)
        {
            KetNoi();
            sqlAdap = new SqlDataAdapter(sql, sqlCon);
            ds = new DataSet();
            sqlAdap.Fill(ds);
            NgatKetNoi();
            return ds;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KetNoi();
            //Khoi tao doi tuog datadapter
            //sqlAdap = new SqlDataAdapter("Select * From SinhVien", sqlCon);
            ////Khoi tao dataset/datatable
            //ds = new DataSet();
            ////tao ban sao
            //sqlAdap.Fill(ds);

            ds = phikn("Select * From SinhVien");
            //dem so dong tren ban sao
            int dem = ds.Tables[0].Rows.Count;
            MessageBox.Show("SO dong cua bang la: " + dem);

            NgatKetNoi();

        }
        //cap nhat
        private void button2_Click(object sender, EventArgs e)
        {
            KetNoi();
            ds = phikn("Select * From SinhVien");

            //Giup them sua xoa cacs dtg tren Adqpter
            SqlCommandBuilder cb = new SqlCommandBuilder(sqlAdap);

            //Xoa dl
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //    if (dr["hoten"].ToString() == "Nguyễn Thị Nga")
            //        dr.Delete();
            //}

            ////sua dl
            //ds.Tables[0].Rows[1]["hoten"] = "Nguyễn Thị Thảo";
            //Them dl
            DataRow dr = ds.Tables[0].NewRow(); //Chọn bảng đầu tiên trong Dấtet
            dr["masv"] = "sv018";
            dr["hoten"] = "Nguyen Van B";
            dr["ngaysinh"] = "2000-03-23";
            //dr[""] = "";
            //dr[""] = "";
            //dr[""] = "";
            ds.Tables[0].Rows.Add(dr);
            sqlAdap.Update(ds);
            sqlCon.Close();
        }
    }
}
