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
    public partial class DonXuat : Form
    {
        //GROUP BOX USER MODE
        // -1 : NO USE
        //  0 : CHANGE
        //  1 : ADD
        private int grbMode = -1;
        public DonXuat()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();
        private void DonXuat_Load(object sender, EventArgs e)
        {
            con.Open();
            hienThi();
        }

        private void DonXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void hienThi()
        {
            string sqlSelect = "select * from DONXUAT";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsDonXuat.DataSource = dt;
        }

        private void dsDonXuat_SelectionChanged(object sender, EventArgs e)
        {
            loadToTextBox();
        }
        public void loadToTextBox()
        {
            txtMaDon.DataBindings.Clear();
            txtMaDon.DataBindings.Add("Text", dsDonXuat.DataSource, "MADX");
            txtNoiXuat.DataBindings.Clear();
            txtNoiXuat.DataBindings.Add("Text", dsDonXuat.DataSource, "NOIXUAT");
            dtNgayXuat.DataBindings.Clear();
            dtNgayXuat.DataBindings.Add("Text", dsDonXuat.DataSource, "NGAYXUAT");
            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dsDonXuat.DataSource, "TONGTIEN");
            txtMaKho.DataBindings.Clear();
            txtMaKho.DataBindings.Add("Text", dsDonXuat.DataSource, "MAKHO");

        }
        
        public String bienTruyen = "";
        
       

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sqlThem = "insert into DONXUAT values(@MADX, @NGAYXUAT, @NOIXUAT, @TONGTIEN, @MAKHO)";
                SqlCommand comThem = new SqlCommand(sqlThem, con);// bat dau cau truy van
                comThem.Parameters.AddWithValue("MADX", txtMaDon.Text);
                comThem.Parameters.AddWithValue("NGAYXUAT", dtNgayXuat.Value);
                comThem.Parameters.AddWithValue("NOIXUAT", txtNoiXuat.Text);
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sqlSua = "update DONXUAT set NGAYXUAT=@NGAYXUAT, NOIXUAT=@NOIXUAT, TONGTIEN=@TONGTIEN, MAKHO=@makho where MADX=@MADX";
                SqlCommand comSua = new SqlCommand(sqlSua, con);
                comSua.Parameters.AddWithValue("MADX", txtMaDon.Text);
                comSua.Parameters.AddWithValue("NGAYXUAT", dtNgayXuat.Value);
                comSua.Parameters.AddWithValue("NOIXUAT", txtNoiXuat.Text);
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

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sqlXoa = "delete from DONXUAT where MADX=@MADX";
                SqlCommand comXoa = new SqlCommand(sqlXoa, con); //bat dau cau truy van
                comXoa.Parameters.AddWithValue("MADX", txtMaDon.Text);
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

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            hienThi();
        }
        private void btnChiTiet_Click_1(object sender, EventArgs e)
        {
            if (txtMaDon.Text != null)
            {
                bienTruyen = txtMaDon.Text.ToString();
                CTDX chiTietDonXuat = new CTDX(bienTruyen.ToString());
                chiTietDonXuat.TruyenGiaTien += chiTietDonXuat_TruyenGiaTien;
                chiTietDonXuat.Show();
            }
        }

        public void chiTietDonXuat_TruyenGiaTien(object sender, SuKien e)
        {
            txtTongTien.Text = e.So;
            string sqlSua = "update DONXUAT set NGAYXUAT=@NGAYXUAT, NOIXUAT=@NOIXUAT, TONGTIEN=@TONGTIEN, MAKHO=@makho where MADX=@MADX";
            SqlCommand comSua = new SqlCommand(sqlSua, con);
            comSua.Parameters.AddWithValue("MADX", txtMaDon.Text);
            comSua.Parameters.AddWithValue("NGAYXUAT", dtNgayXuat.Value);
            comSua.Parameters.AddWithValue("NOIXUAT", txtNoiXuat.Text);
            comSua.Parameters.AddWithValue("TONGTIEN", txtTongTien.Text);
            comSua.Parameters.AddWithValue("MAKHO", txtMaKho.Text);
            comSua.ExecuteNonQuery();
            hienThi();
        }
        //Hàm này dùng để vô hiệu hóa phím delete trên bàn phím người dùng.
        //tức là dữ liệu ở dataGridView sẽ không bị xóa đi khi nhấn delete trên bàn phím
        private void dsDonXuat_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }

        

    }
}
