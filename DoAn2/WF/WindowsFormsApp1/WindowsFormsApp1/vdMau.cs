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

namespace WindowsFormsApp1
{
    public partial class vdMau : Form
    {
        public vdMau()
        {
            InitializeComponent();
        }
        //Khai bao cac doi tuong
        string strKetNoi = @"Data Source = DESKTOP - CDO0SQ2; Initial Catalog = QLSV; Integrated Security = True";

        SqlConnection sqlCon; //để kết nối
        SqlCommand sqlCom; //dòng lệnh sql
        SqlDataReader sqlRe; //Đọc dữ liệu nhưng ko lưu mà nhớ tạm
        SqlDataAdapter sqlAdap; //Đọc dữ liệu và đổ vào nguồn
        DataTable dt; //Bảng dữ liệu

        //Cac phuong thuc
        //PT1: Mo ket noi den CSDL
        void KetNoi()
        {
            sqlCon = new SqlConnection(strKetNoi);
            if(sqlCon.State==ConnectionState.Closed)
            {
                sqlCon.Open();
            }    
        }

        //PT2: Phương thức đóng kết nối
        void NgatKetNoi()
        {
            sqlCon.Close();
        }

        //PT3: Kiểm tra mã trùng
        int KiemTraMaTrung(string strSelecct)
        {
            int sbg = 0;
            KetNoi();
            sqlCom = new SqlCommand(strSelecct, sqlCon);
            sbg = (int)sqlCom.ExecuteScalar();
            NgatKetNoi();
            //
            return sbg;
        }

        //PT4: Thực thi câu lệnh SQL(Thêm, Sửa, Xóa)
        void ThucThi(string strSQL)
        {
            //B1
            KetNoi();
            //B2
            sqlCom = new SqlCommand(strSQL, sqlCon);
            sqlCom.ExecuteNonQuery();
            //B3
            NgatKetNoi();
        }

        //PT5: Load dữ liệu vào DataGridView
        void LoadDuLieuDataGridView(string strSelect)
        {
            dt = new DataTable();
            sqlAdap = new SqlDataAdapter(strSelect, strKetNoi);
            sqlAdap.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        //Form_Load
        private void vdMau_Load(object sender, EventArgs e)
        {
            LoadDuLieuDataGridView("select*from Lop");
        }


        //Sự kiện Cell Click: chọn bản ghi cần sửa trên DataGridView
        //Hiển thị hàng ghi  được chọn xuống các Textbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int HangChon = e.RowIndex;
        }

        

    }
}
