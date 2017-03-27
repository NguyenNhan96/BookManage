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
    public partial class DonNhap : Form
    {
        public DonNhap()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NHANNGUYEN\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");

        private void DonNhap_Load(object sender, EventArgs e)
        {
            con.Open();
            hienThi();
        }
        private void DonNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void hienThi()
        {
            string sqlSelect = "select * from DONNHAP";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsDonNhap.DataSource = dt;
        }

        private void dsDonNhap_SelectionChanged(object sender, EventArgs e)
        {
            loadToTextBox();
        }
        public void loadToTextBox()
        {
            txtMaDon.DataBindings.Clear();
            txtMaDon.DataBindings.Add("Text", dsDonNhap.DataSource, "MADN");
            txtNoiNhap.DataBindings.Clear();
            txtNoiNhap.DataBindings.Add("Text", dsDonNhap.DataSource, "NOINHAP");
            dtNgayNhap.DataBindings.Clear();
            dtNgayNhap.DataBindings.Add("Text", dsDonNhap.DataSource, "NGAYNHAP");
            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dsDonNhap.DataSource, "TONGTIEN");
            txtMaKho.DataBindings.Clear();
            txtMaKho.DataBindings.Add("Text", dsDonNhap.DataSource, "MAKHO");
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlThem = "insert into DONNHAP values(@MADN, @NGAYNHAP, @NOINHAP, @TONGTIEN, @MAKHO)";
                SqlCommand comThem = new SqlCommand(sqlThem, con);// bat dau cau truy van
                comThem.Parameters.AddWithValue("MADN", txtMaDon.Text);
                comThem.Parameters.AddWithValue("NGAYNHAP", dtNgayNhap.Value);
                comThem.Parameters.AddWithValue("NOINHAP", txtNoiNhap.Text);
                comThem.Parameters.AddWithValue("TONGTIEN", txtTongTien.Text);
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
                string sqlSua = "update DONNHAP set NGAYNHAP=@NGAYNHAP, NOINHAP=@NOINHAP, TONGTIEN=@TONGTIEN, MAKHO=@makho where MADN=@MADN";
                SqlCommand comSua = new SqlCommand(sqlSua, con);
                comSua.Parameters.AddWithValue("MADN", txtMaDon.Text);
                comSua.Parameters.AddWithValue("NGAYNHAP", dtNgayNhap.Value);
                comSua.Parameters.AddWithValue("NOINHAP", txtNoiNhap.Text);
                comSua.Parameters.AddWithValue("TONGTIEN", txtTongTien.Text);
                comSua.Parameters.AddWithValue("MAKHO", txtMaKho.Text);

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            hienThi();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlXoa = "delete from DONNHAP where MADN=@MADN";
                SqlCommand comXoa = new SqlCommand(sqlXoa, con); //bat dau cau truy van
                comXoa.Parameters.AddWithValue("MADN", txtMaDon.Text);
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

        public String bienTruyen="";
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (txtMaDon.Text != null)
            {
                bienTruyen = txtMaDon.Text.ToString();
                CTDN chiTietDonNhap = new CTDN(bienTruyen.ToString());
                chiTietDonNhap.Show();
            }
            
        }
       
    }
}
