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

        private string maKho, tenKho, diaChi;
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
            if (check)
            {
                int curRow;
                try
                {
                    curRow = this.dsKho.CurrentRow.Index;
                    this.maKho = this.dsKho.Rows[curRow].Cells[0].Value.ToString();
                    this.tenKho = this.dsKho.Rows[curRow].Cells[1].Value.ToString();
                    this.diaChi = this.dsKho.Rows[curRow].Cells[2].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            KhoFunction kf = new KhoFunction();
            kf.mode = 1;
            kf.Show();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            KhoFunction kf = new KhoFunction(maKho, tenKho, diaChi);
            kf.mode = 0;
            kf.Show();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sqlXoa = "delete from KHOSACH where MAKHO=@MAKHO";
                SqlCommand comXoa = new SqlCommand(sqlXoa, con); //bat dau cau truy van
                comXoa.Parameters.AddWithValue("MAKHO", maKho);
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

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
        //Hàm này dùng để vô hiệu hóa phím delete trên bàn phím người dùng.
        //tức là dữ liệu ở dataGridView sẽ không bị xóa đi khi nhấn delete trên bàn phím
        private void dsKho_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
