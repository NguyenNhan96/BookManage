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
    public partial class DonNhap : Form
    {
        //GROUP BOX USER MODE
        // -1 : NO USE
        //  0 : CHANGE
        //  1 : ADD
        private int grbMode = -1;
        public int temp;
        private string maDon, maKho, noiNhap, tongTien, ngayNhap;
        public DonNhap()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();
        
        private void DonNhap_Load(object sender, EventArgs e)
        {
            con.Open();
            hienThi();
            hienThiTextbox(false);
        }
        private void DonNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void hienThi()
        {
            string sqlSelect = "select * from DONNHAP";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dsDonNhap.DataSource = dt;
        }
        public void hienThiTextbox(Boolean chk)
        {
            if (chk == true)
            {
                txtMaDon.Enabled = true;
                txtMaKho.Enabled = true;
                txtNoiNhap.Enabled = true;
                dtNgayNhap.Enabled = true;
            }
            else
            {
                txtMaDon.Enabled = false;
                txtMaKho.Enabled = false;
                txtNoiNhap.Enabled = false;
                dtNgayNhap.Enabled = false;

            }
        }
        private void dsDonNhap_SelectionChanged(object sender, EventArgs e)
        {
            loadToTextBox(true);
        }
        public void loadToTextBox(Boolean check)
        {
            if (check)
            {
                txtMaDon.DataBindings.Clear();
                txtMaDon.DataBindings.Add("Text", dsDonNhap.DataSource, "MADN");
                txtNoiNhap.DataBindings.Clear();
                txtNoiNhap.DataBindings.Add("Text", dsDonNhap.DataSource, "NOINHAP");
                dtNgayNhap.DataBindings.Clear();
                dtNgayNhap.DataBindings.Add("Text", dsDonNhap.DataSource, "NGAYNHAP");
                lblTongTien.DataBindings.Clear();
                lblTongTien.DataBindings.Add("Text", dsDonNhap.DataSource, "TONGTIEN");
                txtMaKho.DataBindings.Clear();
                txtMaKho.DataBindings.Add("Text", dsDonNhap.DataSource, "MAKHO");
            }
            else
            {
                txtMaDon.Clear();
                txtMaKho.Clear();
                txtNoiNhap.Clear();
                lblTongTien.Text="";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            loadToTextBox(false);
            this.grbThongTin.Text = "Nhập Sách Cần Thêm";
            this.grbMode = 1;
            hienThiTextbox(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            loadToTextBox(true);
            this.grbThongTin.Text = "Chỉnh sửa thông tin";
            this.grbMode = 0;
            hienThiTextbox(true);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.loadToTextBox(true);
            this.grbThongTin.Text = "Thông tin chi tiết";
            this.grbMode = -1;
            this.hienThi();
            hienThiTextbox(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlXoa = "delete from DONNHAP where MADN=@MADN";
                SqlCommand comXoa = new SqlCommand(sqlXoa, con); //bat dau cau truy van
                comXoa.Parameters.AddWithValue("MADN", txtMaDon.Text);
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

        public String bienTruyen = "";

        private void btnChiTiet_Click_1(object sender, EventArgs e)
        {
            if (txtMaDon.Text != null)
            {
                this.bienTruyen = txtMaDon.Text.ToString();
                CTDN chiTietDonNhap = new CTDN(this.bienTruyen.ToString()); //truyen maDon qua
                chiTietDonNhap.TruyenGiaTien += chiTietDonNhap_TruyenGiaTien; //gõ "chiTietDonNhap.TruyenGiaTien+= " , nhấn tab, tab để tạo hàm dưới
                chiTietDonNhap.Show();
            }

        }

        //hàm bắt sự kiện trong form CTDN.
        private void chiTietDonNhap_TruyenGiaTien(object sender, SuKien e)
        {
            lblTongTien.Text = e.So;
            string sqlSua = "update DONNHAP set NGAYNHAP=@NGAYNHAP, NOINHAP=@NOINHAP, TONGTIEN=@TONGTIEN, MAKHO=@makho where MADN=@MADN";
            SqlCommand comSua = new SqlCommand(sqlSua, con);
            comSua.Parameters.AddWithValue("MADN", txtMaDon.Text);
            comSua.Parameters.AddWithValue("NGAYNHAP", dtNgayNhap.Value);
            comSua.Parameters.AddWithValue("NOINHAP", txtNoiNhap.Text);
            comSua.Parameters.AddWithValue("TONGTIEN", lblTongTien.Text);
            comSua.Parameters.AddWithValue("MAKHO", txtMaKho.Text);
            try
            {
                comSua.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lỗi, không hợp lệ. Vui lòng thực hiện lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            hienThi();
        }
        //Hàm này dùng để vô hiệu hóa phím delete trên bàn phím người dùng.
        //tức là dữ liệu ở dataGridView sẽ không bị xóa đi khi nhấn delete trên bàn phím
        private void dsDonNhap_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (grbMode)
            {
                case 1: //thêm đơn sách mới
                    try
                    {
                        string sqlThem = "insert into DONNHAP values(@MADN, @NGAYNHAP, @NOINHAP, @TONGTIEN, @MAKHO)";
                        SqlCommand comThem = new SqlCommand(sqlThem, con);// bat dau cau truy van
                        comThem.Parameters.AddWithValue("MADN", txtMaDon.Text);
                        comThem.Parameters.AddWithValue("NGAYNHAP", dtNgayNhap.Value);
                        comThem.Parameters.AddWithValue("NOINHAP", txtNoiNhap.Text);
                        comThem.Parameters.AddWithValue("TONGTIEN", lblTongTien.Text);
                        comThem.Parameters.AddWithValue("MAKHO", txtMaKho.Text);
                        comThem.ExecuteNonQuery();
                        MessageBox.Show("Thêm Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi, không thêm được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        hienThi();
                        this.grbMode = -1;
                        hienThiTextbox(false);
                    }
                    
                    break;
                case 0: //Sửa thông tin đơn sách
                    try
                    {
                        string sqlSua = "update DONNHAP set NGAYNHAP=@NGAYNHAP, NOINHAP=@NOINHAP, TONGTIEN=@TONGTIEN, MAKHO=@makho where MADN=@MADN";
                        SqlCommand comSua = new SqlCommand(sqlSua, con);
                        comSua.Parameters.AddWithValue("MADN", txtMaDon.Text);
                        comSua.Parameters.AddWithValue("NGAYNHAP", dtNgayNhap.Value);
                        comSua.Parameters.AddWithValue("NOINHAP", txtNoiNhap.Text);
                        comSua.Parameters.AddWithValue("TONGTIEN", lblTongTien.Text);
                        comSua.Parameters.AddWithValue("makho", txtMaKho.Text);

                        if (MessageBox.Show("Bạn muốn sửa?", "Thông báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            comSua.ExecuteNonQuery();
                            MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi, không sửa được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        hienThi(); 
                        this.grbMode = -1;
                        hienThiTextbox(false);
                    }
                    break;
            }
        }
        //hàm kiểm tra kí tự nhập vào tại ô txtTongTien. cho phép chỉ nhập kí tự là số
        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
