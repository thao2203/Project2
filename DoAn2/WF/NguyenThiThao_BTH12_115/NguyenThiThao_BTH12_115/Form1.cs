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

namespace NguyenThiThao_BTH12_115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strConnect = @"Data Source=DESKTOP-CDO0SQ2;Initial Catalog=QLSV_WF;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlDataRead;

        // Các biến để thao tác trong form
        string maLop;
        string tenLop;
        int siSo;
        string ghiChu;

        // Các phương thức thực thi
        // Phương thức kết nối
        void KetNoi()
        {
            sqlCon = new SqlConnection(strConnect);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }
        // Phương thức ngắt kế nối
        void NgatKetNoi()
        {
            sqlCon = new SqlConnection(strConnect);
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        // Phương thức sửa - thêm - xóa dữ liệu
        void ThucThi(string cauTruyVan)
        {
            KetNoi();
            sqlCom = new SqlCommand(cauTruyVan, sqlCon);
            sqlCom.ExecuteNonQuery();
            NgatKetNoi();
        }
        // Kiểm tra xem mã lớp có trùng không
        int KiemTraMatrung(string cauTruyVan)
        {
            int kiemTra;
            KetNoi();
            sqlCom = new SqlCommand(cauTruyVan, sqlCon);
            kiemTra = (int)sqlCom.ExecuteScalar();
            NgatKetNoi();
            return kiemTra;

        }

        // doDuLieuDataRead
        void DoDuLieuDataReader(string cauTruyVan)
        {
            KetNoi();
            sqlCom = new SqlCommand(cauTruyVan, sqlCon);
            sqlDataRead = sqlCom.ExecuteReader();
            int i = 0;
            while (sqlDataRead.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = sqlDataRead[0].ToString();
                dataGridView1[1, i].Value = sqlDataRead[1].ToString();
                dataGridView1[2, i].Value = sqlDataRead[2].ToString();
                dataGridView1[3, i].Value = sqlDataRead[3].ToString();
                i++;
            }
            NgatKetNoi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo các cột trong datagridview
            dataGridView1.Columns.Add("clMaLop", "Mã Lớp");
            dataGridView1.Columns.Add("clTenLop", "Tên Lớp");
            dataGridView1.Columns.Add("clSiSo", "Sĩ Số");
            dataGridView1.Columns.Add("clGhiChu", "Ghi Chú");

            // Các cột trong datagridview nhận các giá trị từ các cột tương ứng
            dataGridView1.Columns[0].DataPropertyName = "MaLop";
            dataGridView1.Columns[1].DataPropertyName = "TenLop";
            dataGridView1.Columns[2].DataPropertyName = "SiSo";
            dataGridView1.Columns[3].DataPropertyName = "GhiChu";

            // Để cho các cột trong DataGridView tự đầy khi hiện thị
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đổ dữ liệu vafoo trong datagirdview
            DoDuLieuDataReader("Select * From dbo.tbLop");

            // Khi load form thì nút thêm sẽ bị ẩn đi 
            btnThem.Enabled = false;
        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            if (txtMaLop.Text.Trim() == "" || txtTenLop.Text.Trim() == "" || txtSiSo.Text.Trim() == "")
            {
                btnThem.Enabled = false;
            }
            else
            {
                if (txtMaLop.Text.Trim().Length > 10 || txtTenLop.Text.Trim().Length > 10 || txtGhiChu.Text.Trim().Length > 50)
                {
                    btnThem.Enabled = false;
                    errorProvider1.SetError(txtMaLop, "Mã lớp không được quá 10 kí tự");
                }
                else
                {
                    btnThem.Enabled = true;
                    errorProvider1.Clear();
                }
            }
            try
            {
                int a = int.Parse(txtSiSo.Text);
            }
            catch
            {
                btnThem.Enabled = false;
            }
        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            if (txtMaLop.Text.Trim() == "" || txtTenLop.Text.Trim() == "" || txtSiSo.Text.Trim() == "")
            {
                btnThem.Enabled = false;
            }
            else
            {
                if (txtMaLop.Text.Trim().Length > 10 || txtTenLop.Text.Trim().Length > 10 || txtGhiChu.Text.Trim().Length > 50)
                {
                    btnThem.Enabled = false;
                    errorProvider1.SetError(txtTenLop, "Tên lớp không được quá 10 kí tự");
                }
                else
                {
                    btnThem.Enabled = true;
                    errorProvider1.Clear();
                }
            }
            try
            {
                int a = int.Parse(txtSiSo.Text);
            }
            catch
            {
                btnThem.Enabled = false;
            }
        }

        private void txtSiSo_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            if (txtMaLop.Text.Trim() == "" || txtTenLop.Text.Trim() == "" || txtSiSo.Text.Trim() == "")
            {
                btnThem.Enabled = false;
            }
            try
            {
                int a = int.Parse(txtSiSo.Text);
            }
            catch
            {
                btnThem.Enabled = false;
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            if (txtMaLop.Text.Trim() == "" || txtTenLop.Text.Trim() == "" || txtSiSo.Text.Trim() == "")
            {
                btnThem.Enabled = false;
            }
            else
            {
                if (txtMaLop.Text.Trim().Length > 10 || txtTenLop.Text.Trim().Length > 10 || txtGhiChu.Text.Trim().Length > 50)
                {
                    btnThem.Enabled = false;
                    errorProvider1.SetError(txtGhiChu, "Ghi chú không được quá 50 kí tự");
                }
                else
                {
                    btnThem.Enabled = true;
                    errorProvider1.Clear();
                }
            }
            try
            {
                int a = int.Parse(txtSiSo.Text);
            }
            catch
            {
                btnThem.Enabled = false;
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maLop = txtMaLop.Text;
            tenLop = txtTenLop.Text;
            siSo = int.Parse(txtSiSo.Text);
            ghiChu = txtGhiChu.Text;

            string cauTruyVan = string.Format(
                        @"Insert Into dbo.tbLop 
                            (MaLop,TenLop,SiSo,GhiChu)
                            Values('{0}','{1}','{2}','{3}')
                            ", maLop, tenLop, siSo, ghiChu);
            string cauKiemTra = string.Format("Select Count({0}) From dbo.tbLop Where MaLop = '{0}'", maLop);
            if (KiemTraMatrung(cauKiemTra) == 1)
            {
                MessageBox.Show("Mã: " + maLop + " đã tồn tại. Vui lòng nhập 1 mã lớp khác");
            }
            else if (KiemTraMatrung(cauKiemTra) == 0)
            {
                ThucThi(cauTruyVan);
                dataGridView1.Rows.Clear();
                DoDuLieuDataReader("Select * From dbo.tbLop");
            }
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            maLop = txtMaLop.Text;
            string cauTruyVan = string.Format("Delete From dbo.Lop Where MaLop ='{0}'", maLop);
            ThucThi(cauTruyVan);
            dataGridView1.Rows.Clear();
            DoDuLieuDataReader("Select * From dbo.Lop");
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            maLop = txtMaLop.Text;
            tenLop = txtTenLop.Text;
            siSo = int.Parse(txtSiSo.Text);
            ghiChu = txtGhiChu.Text;

            string cauTruyVan = string.Format("Update dbo.Lop Set TenLop = '{0}', SiSo ={1} , GhiChu = '{2}' Where MaLop ='{3}'",
                                                tenLop, siSo, ghiChu, maLop);
            ThucThi(cauTruyVan);
            dataGridView1.Rows.Clear();
            DoDuLieuDataReader("Select * From dbo.Lop");
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            KetNoi();
            sqlCom = new SqlCommand("Select * From dbo.Lop", sqlCon);
            sqlDataRead = sqlCom.ExecuteReader();
            string ChuoiHienThi = "";
            string Form = string.Format("{0,-10}{1,-10}{2,-10}{3,-50}", "Mã Lớp", "Tên Lớp", "Sĩ Số", "Ghi Chú");
            while (sqlDataRead.Read())
            {
                string Chuoi = sqlDataRead[0].ToString() + "\t" + sqlDataRead[1].ToString() + "\t" + sqlDataRead[2].ToString() + "\t" + sqlDataRead[3].ToString();
                ChuoiHienThi += Chuoi + "\n";
            }
            MessageBox.Show(Form + "\n" + ChuoiHienThi);
            NgatKetNoi();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Hang = e.RowIndex;
            txtMaLop.Text = dataGridView1[0, Hang].Value.ToString();
            txtTenLop.Text = dataGridView1[1, Hang].Value.ToString();
            txtSiSo.Text = dataGridView1[2, Hang].Value.ToString();
            txtGhiChu.Text = dataGridView1[3, Hang].Value.ToString();
        }
    }
}
