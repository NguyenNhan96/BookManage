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
    public partial class CTDN : Form
    {
        public CTDN()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NHANNGUYEN\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        public String maDon = "";
        private void CTDN_Load(object sender, EventArgs e)
        {
            con.Open();
            hienThi();
        }
        private void CTDN_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public CTDN(String a)
            : this()
        {
            maDon = a;
            txtMaDon.Text = a;
        }
        public void hienThi()
        {
            string sqlSelect = "select * from CTDN where MADN='"+txtMaDon.Text+"'";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsCTDN.DataSource = dt;
        }
        public void hienThiTatCa()
        {
            string sqlSelect = "select * from CTDN ";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsCTDN.DataSource = dt;
        }
        public void loadToTextBox()
        {
            txtMCTN.DataBindings.Clear();
            txtMCTN.DataBindings.Add("Text", dsCTDN.DataSource, "MACTN");
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", dsCTDN.DataSource, "MASACH");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dsCTDN.DataSource, "SL");
        }

        private void dsCTDN_SelectionChanged(object sender, EventArgs e)
        {
            loadToTextBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlThem = "insert into CTDN values(@MACTN,@MADN, @MASACH, @SL)";
                SqlCommand comThem = new SqlCommand(sqlThem, con);// bat dau cau truy van
                comThem.Parameters.AddWithValue("MACTN", txtMCTN.Text);
                comThem.Parameters.AddWithValue("MADN", txtMaDon.Text);
                comThem.Parameters.AddWithValue("MASACH", txtMaSach.Text);
                comThem.Parameters.AddWithValue("SL", txtSoLuong.Text);
                comThem.ExecuteNonQuery();
                hienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không thêm được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            hienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSua = "update CTDN set MADN=@MADN, MASACH=@MASACH, SL=@SL where MACTN=@MACTN";
                SqlCommand comSua = new SqlCommand(sqlSua, con);
                comSua.Parameters.AddWithValue("MADN", txtMaDon.Text);
                comSua.Parameters.AddWithValue("MASACH", txtMaSach.Text);
                comSua.Parameters.AddWithValue("SL", txtSoLuong.Text);
                comSua.Parameters.AddWithValue("MACTN", txtMCTN.Text);

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
                string sqlXoa = "delete from CTDN where MACTN=@MACTN";
                SqlCommand comXoa = new SqlCommand(sqlXoa, con); //bat dau cau truy van
                comXoa.Parameters.AddWithValue("MACTN", txtMCTN.Text);
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            hienThiTatCa();
        }

       
    }
}
