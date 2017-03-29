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
        //GROUP BOX USER MODE
        // -1 : NO USE
        //  0 : CHANGE
        //  1 : ADD
        private int grbMode = -1;
        public LoaiSach()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();
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
            loadToTextBox(true);
        }
        public void loadToTextBox(Boolean check)
        {
            if (check)
            {
                int curRow = this.dsLoai.CurrentRow.Index;
                this.txtMaLoai.Text = this.dsLoai.Rows[curRow].Cells[0].Value.ToString();
                this.txtTenLoai.Text = this.dsLoai.Rows[curRow].Cells[1].Value.ToString();
                this.txtMoTa.Text = this.dsLoai.Rows[curRow].Cells[2].Value.ToString();
                //this.txtMaKho.Text = this.dsLoai.Rows[curRow].Cells[3].Value.ToString();
            }
            else
            {
                //this.txtMaKho.Clear();
                this.txtMaLoai.Clear();
                this.txtMoTa.Clear();
                this.txtTenLoai.Clear();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (grbMode)
            {
                case 0:
                    this.grbMode = -1;
                    try
                    {
                        string sqlSua = "update LOAI set TENLOAI=@TENLOAI, MOTA= @MOTA where MALOAI=@MALOAI";
                        SqlCommand comSua = new SqlCommand(sqlSua, con);
                        comSua.Parameters.AddWithValue("MALOAI", txtMaLoai.Text);
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
                    loadToTextBox(true);
                    this.grbThongTin.Enabled = false;
                    this.hienThi();
                    break;
                case 1:
                    this.grbMode = -1;
                    try
                    {
                        string sqlThem = "insert into LOAI values(@MALOAI, @TENLOAI, @MOTA)";
                        SqlCommand comThem = new SqlCommand(sqlThem, con);// bat dau cau truy van
                        comThem.Parameters.AddWithValue("MALOAI", txtMaLoai.Text);
                        comThem.Parameters.AddWithValue("TENLOAI", txtTenLoai.Text);
                        comThem.Parameters.AddWithValue("MOTA", txtMoTa.Text);
                        comThem.ExecuteNonQuery();
                        hienThi();
                        MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi, không thêm được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.loadToTextBox(true);
                    this.grbThongTin.Enabled = false;
                    this.hienThi();
                    break;
            }
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
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            this.loadToTextBox(true);
            this.grbThongTin.Enabled = false;
            this.grbMode = -1;
            this.hienThi();
        }
        //Hàm này dùng để vô hiệu hóa phím delete trên bàn phím người dùng.
        //tức là dữ liệu ở dataGridView sẽ không bị xóa đi khi nhấn delete trên bàn phím
        private void dsLoai_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
