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
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NHANNGUYEN\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            hienThi();
        }
        private void Kho_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dong ket noi 
            con.Close();
        }
        private void dsKho_SelectionChanged(object sender, EventArgs e)
        {
            //dsKho.CurrentRow.Selected = true;
            loadToTextBox();
        }
        public void loadToTextBox()
        {
            txtMaKho.DataBindings.Clear();
            txtMaKho.DataBindings.Add("Text", dsKho.DataSource, "MAKHO");
            txtTenKho.DataBindings.Clear();
            txtTenKho.DataBindings.Add("Text", dsKho.DataSource, "TENKHO");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dsKho.DataSource, "DIACHI");
        }

        private void hienThi()
        {
            try
            {
                String sqlSelect = "select * from KHOSACH";
                SqlCommand com = new SqlCommand(sqlSelect, con); //bat dau cau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); // van chuyen du lieu ve
                DataTable dt = new DataTable();
                //do du lieu vao kho
                da.Fill(dt);
                //do du lieu vao dataGridView
                dsKho.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlThem = "insert into KHOSACH values(@MAKHO, @TENKHO, @DIACHI)";
                SqlCommand comThem = new SqlCommand(sqlThem, con);// bat dau cau truy van
                comThem.Parameters.AddWithValue("MAKHO", txtMaKho.Text);
                comThem.Parameters.AddWithValue("TENKHO", txtTenKho.Text);
                comThem.Parameters.AddWithValue("DIACHI", txtDiaChi.Text);
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
                string sqlSua = "update KHOSACH set TENKHO=@TENKHO, DIACHI= @DIACHI where MAKHO=@MAKHO";
                SqlCommand comSua = new SqlCommand(sqlSua, con);
                comSua.Parameters.AddWithValue("MAKHO", txtMaKho.Text);
                comSua.Parameters.AddWithValue("TENKHO", txtTenKho.Text);
                comSua.Parameters.AddWithValue("DIACHI", txtDiaChi.Text);
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
                string sqlXoa = "delete from KHOSACH where MAKHO=@MAKHO";
                SqlCommand comXoa = new SqlCommand(sqlXoa, con); //bat dau cau truy van
                comXoa.Parameters.AddWithValue("MAKHO", txtMaKho.Text);
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
