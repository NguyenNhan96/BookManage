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
        //GROUP BOX USER MODE
        // -1 : NO USE
        //  0 : CHANGE
        //  1 : ADD
        private int grbMode = -1;
        public Kho()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();
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
            loadToTextBox(true);
        }
        public void loadToTextBox(Boolean check)
        {
            if (check) { 
            int curRow = this.dsKho.CurrentRow.Index;
            this.txtMaKho.Text = this.dsKho.Rows[curRow].Cells[0].Value.ToString();
            this.txtDiaChi.Text = this.dsKho.Rows[curRow].Cells[2].Value.ToString();
            this.txtTenKho.Text = this.dsKho.Rows[curRow].Cells[2].Value.ToString();
            }
            else
            {
                this.txtDiaChi.Clear();
                this.txtTenKho.Clear();
                this.txtMaKho.Clear();
            }
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            this.loadToTextBox(false);
            this.grbMode = 1;
            this.grbThongTin.Text = "Nhập Loại Sách Cần Thêm";
            this.grbThongTin.Enabled = true;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            this.grbMode = 0;
            this.grbThongTin.Enabled = true;
            this.loadToTextBox(true);
            this.grbThongTin.Text = "Nhập thông tin cần sửa";
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
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

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            this.hienThi();
            this.grbMode = -1;
            this.grbThongTin.Enabled = false;
            this.loadToTextBox(true);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (grbMode)
            {
                case 0:
                    this.grbMode = -1;
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
                    loadToTextBox(true);
                    this.grbThongTin.Enabled = false;
                    this.hienThi();
                    break;
                case 1:
                    this.grbMode = -1;
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
                    this.grbThongTin.Enabled = true;
                    this.loadToTextBox(true);
                    this.hienThi();
                    break;
            }
        }
        //Hàm này dùng để vô hiệu hóa phím delete trên bàn phím người dùng.
        //tức là dữ liệu ở dataGridView sẽ không bị xóa đi khi nhấn delete trên bàn phím
        private void dsKho_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
