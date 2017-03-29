﻿using System;
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
        SqlConnection con = DBConnecter.sqlConnector();
        public String maDon = "";
        public int tong = 0;
        private void CTDN_Load(object sender, EventArgs e)
        {
            con.Open();
            hienThi();
            tinhTongTien();
        }
        private void CTDN_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DonNhap don = new DonNhap(this.tong);
            con.Close();
            truyenGiaTien(this, new SuKien(lblTongGiaDonHang.Text)); //gọi sự kiện
        }
        public CTDN(String a)
            : this()
        {
            maDon = a;
            txtMaDon.Text = a;
        }

        // tạo eventHandler để truyền giá trị trong lblTongGiaDonHang 
        private event EventHandler<SuKien> truyenGiaTien;
        public event EventHandler<SuKien> TruyenGiaTien
        {
            add{ truyenGiaTien+= value;}
            remove{truyenGiaTien -= value;}
        }

        public void hienThi()
        {
            string sqlSelect = "select * from CTDN where MADN='" + txtMaDon.Text + "'";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsCTDN.DataSource = dt;
            tinhTongTien();
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
        //Hàm này để tính giá tiền của chi tiết đơn hàng, kết quả lấy từ giá tiền của sách *số lượng mình nhập vào.
        public void tinhTien()
        {
            int soLuong = 0;
            int gia = 0;
            if (txtGia.Text == "" || txtSoLuong.Text == "") //xét trường hợp nếu trong ô text rỗng.nếu ko có điều kiện này thì sẽ bị lỗi nhân với 0 chẳng hạn :v
            {
                lblTongTien.Text = "";
            }
            else
            {
                //dùng tr-catch để bắt lỗi, lỗi nhập vào quá giới hạn kiểu Int, lỗi nhập vào là kí tự không phải số...
                try
                {
                    soLuong = Int32.Parse(txtSoLuong.Text.ToString()); //ép kiểu int cho giá trị ô text mình nhập vào
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuong.Clear(); // xóa giá trị bị lỗi vừa nhập vào.trả lại ô trống để người dùng nhập lại
                }
                //tương tự dùng bắt lỗi ở ô txtGia
                try
                {
                    gia = Int32.Parse(txtGia.Text.ToString());
                }
                catch
                {
                    MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGia.Clear();

                }
                lblTongTien.Text = (soLuong * gia).ToString(); //Tổng giá tiền đơn hàng chi tiết.
            }



        }
        //Hàm tính tổng giá tiền của đơn hàng từ các đơn hàng chi tiết.
        public void tinhTongTien()
        {
            int tongGia = 0;
            foreach (DataGridViewRow row in dsCTDN.Rows)
            {
                int temp = Int32.Parse(row.Cells[3].Value.ToString()) * Int32.Parse(row.Cells[4].Value.ToString());
                tongGia += temp;
            }
            lblTongGiaDonHang.Text = (tongGia.ToString());
            this.tong = tongGia;
        }
       
        public void loadToTextBox()
        {
            txtMCTN.DataBindings.Clear();
            txtMCTN.DataBindings.Add("Text", dsCTDN.DataSource, "MACTN");
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", dsCTDN.DataSource, "MASACH");
            txtGia.DataBindings.Add("Text", dsCTDN.DataSource, "GIA");
            txtGia.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dsCTDN.DataSource, "SL");
            txtSoLuong.DataBindings.Clear();
            tinhTien();
        }

        private void dsCTDN_SelectionChanged(object sender, EventArgs e)
        {
            loadToTextBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlThem = "insert into CTDN values(@MACTN,@MADN, @MASACH,@GIA, @SL)";
                SqlCommand comThem = new SqlCommand(sqlThem, con);// bat dau cau truy van
                comThem.Parameters.AddWithValue("MACTN", txtMCTN.Text);
                comThem.Parameters.AddWithValue("MADN", txtMaDon.Text);
                comThem.Parameters.AddWithValue("MASACH", txtMaSach.Text);
                comThem.Parameters.AddWithValue("GIA", txtGia.Text);
                comThem.Parameters.AddWithValue("SL", txtSoLuong.Text);
                comThem.ExecuteNonQuery();
                hienThi();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lỗi, không thêm được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            hienThi();
            tinhTongTien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSua = "update CTDN set MADN=@MADN, MASACH=@MASACH,GIA=@GIA, SL=@SL where MACTN=@MACTN";
                SqlCommand comSua = new SqlCommand(sqlSua, con);
                comSua.Parameters.AddWithValue("MADN", txtMaDon.Text);
                comSua.Parameters.AddWithValue("MASACH", txtMaSach.Text);
                comSua.Parameters.AddWithValue("GIA", txtGia.Text);
                comSua.Parameters.AddWithValue("SL", txtSoLuong.Text);
                comSua.Parameters.AddWithValue("MACTN", txtMCTN.Text);
                if (MessageBox.Show("Bạn muốn sửa?", "Thông báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    comSua.ExecuteNonQuery();
                }
                hienThi();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            tinhTien();

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            tinhTien();
        }

        /*
        * Hàm kiểm tra giá trị nhập vào tại ô textBox txtGia. Trong đó:
        * Char.IsDigit(e.KeyChar) --> kiểm tra xem phím vừa nhập vào textbox có phải là ký tự số hay không, hàm này trả về kiểu bool
        * Char.IsContro(e.KeyChar) --> kiểm tra xem phím vừa nhập vào textbox có phải là các ký tự điều khiển, 
          (các phím mũi tên,Delete,Insert,backspace,space bar) hay không, mục đích dùng hàm này là để cho phép người dùng xóa số trong trường hợp nhập sai.
        * Lưu ý: hàm này không cho người dùng nhập vào kí tự khác kí tự số, 
             Nhưng nó ko xét trường hợp người dùng copy-paste, tức là copy-paste vào vẫn được.
            -> Vì vậy ta mới thêm try- catch bắt ở ô txtSoLuong và txtGia ở trong hàm tinhTien() để bắt lỗi,rồi show ra "giá trị nhập vào không hợp lệ ".
       */
        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Hàm kiểm tra giá trị nhập vào tại ô textBox txtSoLuong
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /* -------------------------- */
        //Hàm này dùng để vô hiệu hóa phím delete trên bàn phím người dùng.
        //tức là dữ liệu ở dataGridView sẽ không bị xóa đi khi nhấn delete trên bàn phím
        private void dsCTDN_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }
        
    }
}
