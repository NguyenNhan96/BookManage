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
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NHANNGUYEN\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        //ham ket noi
        private void Form2_Load(object sender, EventArgs e)
        {
            //goi ham ketnoiCSDL phia tren xuong
            con.Open();
            hienThi();
        }
        private void Sach_FormClosing(object sender, FormClosingEventArgs e)
        {
            //dong ket noi
            con.Close();
        }
        private void dsSach_SelectionChanged_1(object sender, EventArgs e)
        {
            //dsSach.CurrentRow.Selected = true; //dữ liệu được chọn cả dòng, giờ đổ dữ liệu lên các textbox
            loadToTextBox();
        }
        private void hienThi()
        {
            try
            {
                //Tao chuoi ket noi
                string sqlSelect = "select * from SACH";
                SqlCommand com = new SqlCommand(sqlSelect, con);// bat dau cau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //van chuyen du lieu ve
                DataTable dt = new DataTable();
                //tao  mot kho ao de luu tru du lieu 
                da.Fill(dt);//do du lieu vao kho
                //do du lieu vao dataGridView
                dsSach.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Viet 1 ham load du lieu vao cac textbox
        private void loadToTextBox()
        {
            //kieu bindings, dem du lieu tu dataGridView dsSach vao tung o textBox thich hop
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", dsSach.DataSource, "MASACH");//text la mac dinh kieu chuoi, MASACH tuong ung voi ten cot trong dataGridView
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", dsSach.DataSource, "TENSACH");
            txtTacGia.DataBindings.Clear();
            txtTacGia.DataBindings.Add("Text", dsSach.DataSource, "TACGIA");
            txtNhaXB.DataBindings.Clear();
            txtNhaXB.DataBindings.Add("Text", dsSach.DataSource, "NHAXB");
            txtNamXB.DataBindings.Clear();
            txtNamXB.DataBindings.Add("Text", dsSach.DataSource, "NAMXB");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dsSach.DataSource, "GIA");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dsSach.DataSource, "SOLUONG");
            txtMaLoai.DataBindings.Clear();
            txtMaLoai.DataBindings.Add("Text", dsSach.DataSource, "MALOAI");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try {
                string sqlThem = "INSERT INTO SACH VALUES(@MASACH, @TENSACH, @TACGIA, @NHAXB, @NAMXB,@GIA, @SOLUONG,@MALOAI)";
                SqlCommand com = new SqlCommand(sqlThem, con);// bat dau cau truy van
                com.Parameters.AddWithValue("MASACH", txtMaSach.Text); 
                com.Parameters.AddWithValue("TENSACH", txtTenSach.Text);
                com.Parameters.AddWithValue("TACGIA", txtTacGia.Text);
                com.Parameters.AddWithValue("NHAXB", txtNhaXB.Text);
                com.Parameters.AddWithValue("NAMXB", txtNamXB.Text);
                com.Parameters.AddWithValue("GIA", txtGia.Text);
                com.Parameters.AddWithValue("SOLUONG", txtSL.Text);
                com.Parameters.AddWithValue("MALOAI", txtMaLoai.Text);
                com.ExecuteNonQuery();
                hienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không thêm được.","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            hienThi();
            //loadToTextBox();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSua = "update SACH set TENSACH= @TENSACH, TACGIA=@TACGIA, NHAXB=@NHAXB, NAMXB=@NAMXB, GIA=@GIA, SOLUONG=@SOLUONG, MALOAI=@MALOAI where MASACH=@MASACH";
                SqlCommand com = new SqlCommand(sqlSua, con);// bat dau cau truy van
                com.Parameters.AddWithValue("MASACH", txtMaSach.Text);
                com.Parameters.AddWithValue("TENSACH", txtTenSach.Text);
                com.Parameters.AddWithValue("TACGIA", txtTacGia.Text);
                com.Parameters.AddWithValue("NHAXB", txtNhaXB.Text);
                com.Parameters.AddWithValue("NAMXB", txtNamXB.Text);
                com.Parameters.AddWithValue("GIA", txtGia.Text);
                com.Parameters.AddWithValue("SOLUONG", txtSL.Text);
                com.Parameters.AddWithValue("MALOAI", txtMaLoai.Text);
                if (MessageBox.Show("Bạn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    com.ExecuteNonQuery();
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
                string sqlXoa = "delete from SACH where MASACH=@MASACH";
                SqlCommand com = new SqlCommand(sqlXoa, con);// bat dau cau truy van
                com.Parameters.AddWithValue("MASACH", txtMaSach.Text);
                if( MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
                {
                    com.ExecuteNonQuery();
                }
                hienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
