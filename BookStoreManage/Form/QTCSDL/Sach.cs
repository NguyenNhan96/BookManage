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

        //cac bien dung de luu tam de truyen qua form khac
        private string maSach, maKho, maLoai, nhaXB, tenSach, tacGia;
        private int gia, namXB, sL;
        /*--------  */
        //tao su kien lay thong tin sach chuyen qua form chinh sua
        //public delegate void EditHandler(string maSach,string tenSach, string tacGia, string nhaXB, int gia, int sL, int namXB, string maLoai, string maKho);
        //public event EditHandler EditEvent;
        /* ----------------------------*/
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
            loadToTextBox(true);
        }
        public void hienThi()
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
        //Viet 1 ham load du lieu khi minh click vao dataGridVieww, truyen cho cac bien.
        private void loadToTextBox(Boolean check)
        {
            if (check)
            {
                int curRow ;
                try
                {
                    curRow = this.dsSach.CurrentRow.Index;
                    //txtMaSach.Text = this.dsSach.Rows[curRow].Cells[0].Value.ToString();
                    this.maSach = this.dsSach.Rows[curRow].Cells[0].Value.ToString();
                    this.gia = Int32.Parse(this.dsSach.Rows[curRow].Cells[5].Value.ToString());                     //bi loi khi nhan vao dong cuoi cung ko co index
                    this.maLoai = this.dsSach.Rows[curRow].Cells[7].Value.ToString();
                    this.namXB = Int32.Parse(this.dsSach.Rows[curRow].Cells[4].Value.ToString());
                    this.nhaXB = this.dsSach.Rows[curRow].Cells[3].Value.ToString();
                    this.sL = Int32.Parse(this.dsSach.Rows[curRow].Cells[6].Value.ToString());
                    this.tenSach = this.dsSach.Rows[curRow].Cells[1].Value.ToString();
                    this.tacGia = this.dsSach.Rows[curRow].Cells[2].Value.ToString();
                    this.maKho = this.dsSach.Rows[curRow].Cells[8].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Không click vào ô trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Hàm này dùng để vô hiệu hóa phím delete trên bàn phím người dùng.
        //tức là dữ liệu ở dataGridView sẽ không bị xóa đi khi nhấn delete trên bàn phím
        private void dsSach_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }

        //Những hàm KeyPress dưới đây dùng để kiểm tra kí tự nhập vào. Chỉ cho phép nhập số
        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //----------------------------------------------------------------------------------------------------------------//
        private void btnThem2_Click(object sender, EventArgs e)
        {
            SachFunction sf = new SachFunction();
            sf.mode = 1; //truyen cho bien mode de xac dinh tien hanh them hoac sua.
            sf.Show();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            this.hienThi();
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlXoa = "delete from SACH where MASACH=@MASACH and MAKHO=@MAKHO";
                SqlCommand com = new SqlCommand(sqlXoa, con);// bat dau cau truy van
                com.Parameters.AddWithValue("MASACH", maSach);
                com.Parameters.AddWithValue("MAKHO", maKho);
                if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                hienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            SachFunction sf = new SachFunction(maSach, tenSach, tacGia, nhaXB, gia, sL, namXB, maLoai, maKho);
            sf.mode = 0;
            sf.Show();
        }

        private void txtTimMa_TextChanged(object sender, EventArgs e)
        {
            txtTimMa.ForeColor = Color.Black;
            txtTimTen.Text = "";
            seachDisplay();
        }

        private void txtTimten_TextChanged(object sender, EventArgs e)
        {
            txtTimMa.Text = "";
            txtTimTen.ForeColor = Color.Black;
            seachDisplay();
        }

        private void picTim_Click(object sender, EventArgs e)
        {
            seachDisplay();
        }
        private void seachDisplay()
        {
            DataTable dt = new DataTable();
            //dsSach.DataSource = dt;
            if (txtTimMa.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from SACH where MASACH like'%" + txtTimMa.Text + "%'", con);
                sda.Fill(dt);//do du lieu vao kho
            }
            else if (txtTimTen.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from SACH where [TENSACH] like N'%" + txtTimTen.Text + "%'", con);
                sda.Fill(dt);//do du lieu vao kho
            }
            dsSach.DataSource = dt;
        }

        private void txtTimMa_Enter(object sender, EventArgs e)
        {
            if (txtTimMa.Text == txtTimMa.Tag.ToString())
            {
                txtTimMa.Text = "";
                txtTimMa.ForeColor = Color.Black;
            }
        }

        private void txtTimMa_Leave(object sender, EventArgs e)
        {
            if (txtTimMa.Text.Trim() == "")
            {
                txtTimMa.Text = txtTimMa.Tag.ToString();
                txtTimMa.ForeColor = Color.Silver;
            }
        }

        private void txtTimten_Leave(object sender, EventArgs e)
        {
            if (txtTimTen.Text.Trim() == "")
            {
                txtTimTen.Text = txtTimTen.Tag.ToString();
                txtTimTen.ForeColor = Color.Silver;
            }
        }

        private void txtTimten_Enter(object sender, EventArgs e)
        {
            if (txtTimTen.Text == txtTimTen.Tag.ToString())
            {
                txtTimTen.Text = "";
                txtTimTen.ForeColor = Color.Black;
            }
        }


       
    }
}
