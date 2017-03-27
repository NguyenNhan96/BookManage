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
    public partial class CTDX : Form
    {
        public CTDX()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NHANNGUYEN\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        public String maDon = "";

        private void CTDX_Load(object sender, EventArgs e)
        {
            con.Open();
            hienThi();
        }

        private void CTDX_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public CTDX(String a)
            : this()
        {
            maDon = a;
            txtMaDon.Text = a;
        }
        public void hienThi()
        {
            string sqlSelect = "select * from CTDX where MADX='" + txtMaDon.Text + "'";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsCTDX.DataSource = dt;
        }
        public void hienThiTatCa()
        {
            string sqlSelect = "select * from CTDX ";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsCTDX.DataSource = dt;
        }
        public void loadToTextBox()
        {
            txtMCTX.DataBindings.Clear();
            txtMCTX.DataBindings.Add("Text", dsCTDX.DataSource, "MACTX");
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", dsCTDX.DataSource, "MASACH");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dsCTDX.DataSource, "SL");
        }

        private void dsCTDX_SelectionChanged(object sender, EventArgs e)
        {
            loadToTextBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlThem = "insert into CTDX values(@MACTX,@MADX, @MASACH, @SL)";
                SqlCommand comThem = new SqlCommand(sqlThem, con);// bat dau cau truy van
                comThem.Parameters.AddWithValue("MACTN", txtMCTX.Text);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSua = "update CTDX set MADX=@MADN, MASACH=@MASACH, SL=@SL where MACTX=@MACTX";
                SqlCommand comSua = new SqlCommand(sqlSua, con);
                comSua.Parameters.AddWithValue("MADX", txtMaDon.Text);
                comSua.Parameters.AddWithValue("MASACH", txtMaSach.Text);
                comSua.Parameters.AddWithValue("SL", txtSoLuong.Text);
                comSua.Parameters.AddWithValue("MACTX", txtMCTX.Text);

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
                string sqlXoa = "delete from CTDX where MACTX=@MACTX";
                SqlCommand comXoa = new SqlCommand(sqlXoa, con); //bat dau cau truy van
                comXoa.Parameters.AddWithValue("MACTX", txtMCTX.Text);
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            hienThiTatCa();
        }
    }
}
