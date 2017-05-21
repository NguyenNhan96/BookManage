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
        private string maLoai, tenLoai, moTa;
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
                int curRow ;
                try
                {
                    curRow = this.dsLoai.CurrentRow.Index;
                    this.maLoai = this.dsLoai.Rows[curRow].Cells[0].Value.ToString();
                    this.tenLoai = this.dsLoai.Rows[curRow].Cells[1].Value.ToString();
                    this.moTa = this.dsLoai.Rows[curRow].Cells[2].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            LoaiFunction lf = new LoaiFunction();
            lf.mode = 1;
            lf.Show();
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            LoaiFunction lf = new LoaiFunction(maLoai, tenLoai, moTa);
            lf.mode = 0;
            lf.Show();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlXoa = "delete from LOAI where MALOAI=@MALOAI";
                SqlCommand comXoa = new SqlCommand(sqlXoa, con); //bat dau cau truy van
                comXoa.Parameters.AddWithValue("MALOAI", maLoai);
                if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    comXoa.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
        //Hàm này dùng để vô hiệu hóa phím delete trên bàn phím người dùng.
        //tức là dữ liệu ở dataGridView sẽ không bị xóa đi khi nhấn delete trên bàn phím
        private void dsLoai_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
