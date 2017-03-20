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

namespace QTCSDL
{
    public partial class LoaiSach : Form
    {
        public LoaiSach()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NHANNGUYEN\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        private void LoaiSach_Load(object sender, EventArgs e)
        {
            con.Open();
            hienThi();
        }
        private void LoaiSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void hienThi()
        {
            try
            {
                
                string sqlSelect = "select * from LOAI";
                SqlCommand com = new SqlCommand(sqlSelect, con);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dsLoai.DataSource = dt;
               
                
                //loadToComboBox();
               

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // load du lieu vao combobox
        public void loadToComboBox()
        {
            Kho kho1 = new Kho();
            string sqlSelect = "select TENKHO from KHOSACH A, LOAI B where B.MAKHO=A.MAKHO ";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //cbTenKho.DisplayMember = "TENKHO";
            //cbTenKho.DataSource = dt;
        }

        private void dsLoai_SelectionChanged(object sender, EventArgs e)
        {
            loadToTextBox();
        }

        public void loadToTextBox()
        {
            txtMaLoai.DataBindings.Clear();
            txtMaLoai.DataBindings.Add("Text", dsLoai.DataSource, "MALOAI");
            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", dsLoai.DataSource, "TENLOAI");
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dsLoai.DataSource, "MOTA");
            txtMaKho.DataBindings.Clear();
            txtMaKho.DataBindings.Add("Text", dsLoai.DataSource, "MAKHO");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlThem = "insert into LOAI values(@MALOAI, @TENLOAI, @MOTA, @MAKHO)";
                SqlCommand comThem = new SqlCommand(sqlThem, con);// bat dau cau truy van
                comThem.Parameters.AddWithValue("MALOAI", txtMaLoai.Text);
                comThem.Parameters.AddWithValue("TENLOAI", txtTenLoai.Text);
                comThem.Parameters.AddWithValue("MOTA", txtMoTa.Text);
                comThem.Parameters.AddWithValue("MAKHO", txtMaKho.Text);
                comThem.ExecuteNonQuery();
                hienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không thêm được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSua = "update LOAI set TENLOAI=@TENLOAI, MOTA= @MOTA, MAKHO=@MAKHO where MALOAI=@MALOAI";
                SqlCommand comSua = new SqlCommand(sqlSua, con);
                comSua.Parameters.AddWithValue("MALOAI", txtMaLoai.Text);
                comSua.Parameters.AddWithValue("MAKHO", txtMaKho.Text);
                comSua.Parameters.AddWithValue("TENLOAI", txtTenLoai.Text);
                comSua.Parameters.AddWithValue("MOTA", txtMoTa.Text);
                if (MessageBox.Show("Bạn muốn sửa?", "Thông báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    comSua.ExecuteNonQuery();
                }
                hienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlXoa = "delete from LOAI where MALOAI=@MALOAI";
                SqlCommand comXoa = new SqlCommand(sqlXoa, con); //bat dau cau truy van
                comXoa.Parameters.AddWithValue("MALOAI", txtMaLoai.Text);
                if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    comXoa.ExecuteNonQuery();
                }
                hienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            hienThi();
        }

    }
}
