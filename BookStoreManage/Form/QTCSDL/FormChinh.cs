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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            DonNhap donNhap = new DonNhap();
            donNhap.Show();
        }

        private void BtnXuatSach_Click(object sender, EventArgs e)
        {
            DonXuat donXuat = new DonXuat();
            donXuat.Show();
        }

        private void btnKhoSach_Click(object sender, EventArgs e)
        {
            Kho kho = new Kho();
            kho.Show();
        }

        private void btnLoaiSach_Click(object sender, EventArgs e)
        {
            LoaiSach ls = new LoaiSach();
            ls.Show();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSelect = "select COUNT(*) from TAIKHOAN where USERNAME= @USERNAME and PASS=@PASS";
                SqlCommand com = new SqlCommand(sqlSelect, con);
                com.Parameters.AddWithValue("USERNAME", txtTenDangNhap.Text);
                com.Parameters.AddWithValue("PASS", txtMatKhau.Text);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //vận chuyển dữ liệu về
                DataTable dt = new DataTable();// tạo một kho ảo để chứa dữ liệu
                da.Fill(dt);// đổ dữ liệu vào kho
                
                //hiển thị tên tài khoản vào label.
                SqlCommand com2 = new SqlCommand("select HOTEN from TAIKHOAN where USERNAME = @USERNAME ", con);
                com2.Parameters.AddWithValue("USERNAME", txtTenDangNhap.Text);
                com2.CommandType = CommandType.Text;
                SqlDataAdapter da2 = new SqlDataAdapter(com2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                //com.ExecuteNonQuery();
                //Kiểm tra xem trong dataTable có kết quả hay không.
                if (dt.Rows[0][0].ToString() == "1") //tìm thấy kết quả phù hợp
                {
                    lblThongBao.Text = "";
                    lblXinChao.Text = "Xin chào: " + dt2.Rows[0][0].ToString() + "";
                    //ẩn hiện các chức năng người dùng
                    grbThaoTac.Enabled = true;
                    grbThanhPhan.Enabled = true;
                    txtTenDangNhap.Enabled = false;
                    txtMatKhau.Enabled = false;
                    btnDangNhap.Enabled = false;
                    btnDangXuat.Enabled = true;
                }
                else
                {
                    lblThongBao.Text = "Tài khoản hoặc mật khẩu không đúng.";
                    txtMatKhau.Text = "";
                    txtTenDangNhap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối Database.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "Vui lòng đăng nhập để quản lí.";
            lblXinChao.Text = "";
            txtMatKhau.Text = "";
            //ẩn hiện các chức năng người dùng
            grbThanhPhan.Enabled = false;
            grbThaoTac.Enabled = false;
            txtMatKhau.Enabled = true;
            txtTenDangNhap.Enabled = true;
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;

        }
    }
}
