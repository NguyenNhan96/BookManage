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
        //GROUP BOX USER MODE
        // -1 : NO USE
        //  0 : CHANGE
        //  1 : ADD
        private int grbMode = -1;
        public Sach()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();
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
            this.grbThongTin.Enabled = false;
            loadToTextBox(true);
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
                DataTable dt = new DataTable(); //tao  mot kho ao de luu tru du lieu 
                da.Fill(dt);//do du lieu vao kho
                dsSach.DataSource = dt;//do du lieu vao dataGridView
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Viet 1 ham load du lieu vao cac textbox
        private void loadToTextBox(Boolean check)
        {
            if (check)
            {
                int curRow = this.dsSach.CurrentRow.Index;
                txtMaSach.Text = this.dsSach.Rows[curRow].Cells[0].Value.ToString();
                txtGia.Text = this.dsSach.Rows[curRow].Cells[5].Value.ToString();
                txtMaLoai.Text = this.dsSach.Rows[curRow].Cells[7].Value.ToString();
                txtNamXB.Text = this.dsSach.Rows[curRow].Cells[4].Value.ToString();
                txtNhaXB.Text = this.dsSach.Rows[curRow].Cells[3].Value.ToString();
                txtSL.Text = this.dsSach.Rows[curRow].Cells[6].Value.ToString();
                txtTenSach.Text = this.dsSach.Rows[curRow].Cells[1].Value.ToString();
                txtTacGia.Text = this.dsSach.Rows[curRow].Cells[2].Value.ToString();
            }
            else
            {
                txtMaSach.Clear();
                txtGia.Clear();
                txtMaLoai.Clear();
                txtNamXB.Clear();
                txtNhaXB.Clear();
                txtSL.Clear();
                txtTenSach.Clear();
                txtTacGia.Clear();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            loadToTextBox(false);
            this.grbThongTin.Enabled = true;
            this.grbThongTin.Text = "Nhập Sách Cần Thêm";
            this.grbMode = 1;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            loadToTextBox(true);
            this.grbThongTin.Text = "Nhập thông tin cần sửa";
            this.grbThongTin.Enabled = true;
            this.grbMode = 0;
        }
        private void dsSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dsSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (grbMode)
            {
                case 1:
                    try{
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
                        MessageBox.Show("Thêm Sách Thành Công !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi, không thêm được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        hienThi();
                    }
                    this.grbThongTin.Enabled = false;
                    this.hienThi();
                    this.grbMode = -1;
                    break;

                case 0:
                    try{
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
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi, không sửa được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        hienThi();
                    }
                    this.grbThongTin.Enabled = false;
                    this.hienThi();
                    this.grbMode = -1;
                    break;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.loadToTextBox(true);
            this.grbThongTin.Enabled = false;
            this.grbMode = -1;
            this.hienThi();
        }
        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string sqlXoa = "delete from SACH where MASACH=@MASACH";
                SqlCommand com = new SqlCommand(sqlXoa, con);// bat dau cau truy van
                com.Parameters.AddWithValue("MASACH", txtMaSach.Text);
                if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
        //Hàm này dùng để vô hiệu hóa phím delete trên bàn phím người dùng.
        //tức là dữ liệu ở dataGridView sẽ không bị xóa đi khi nhấn delete trên bàn phím
        private void dsSach_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
