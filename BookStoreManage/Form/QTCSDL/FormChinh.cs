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
    public partial class FormChinh : Form
    {
        private string userLogin;

        public string UserLogin
        {
            get { return userLogin; }
            set { userLogin = value; }
        }
       
        public FormChinh()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            DonNhap donNhap = new DonNhap();
            donNhap.Show();
        }

        private void BtnXuatSach_Click(object sender, EventArgs e)
        {
            DonXuat donXuat = new DonXuat();
            donXuat.Show();
        }

        private void btnKhoSach_Click(object sender, EventArgs e)
        {
            Kho kho = new Kho();
            kho.Show();
        }

        private void btnLoaiSach_Click(object sender, EventArgs e)
        {
            LoaiSach ls = new LoaiSach();
            ls.Show();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            con.Open();
            lblThongBao.Text = userLogin;
        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            lg.ResumeLayout();
            //this.Close();
           
        }

        private void cbxTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxTimKiem_MouseHover(object sender, EventArgs e)
        {
            cbxTimKiem.ForeColor = Color.Black;
        }

              

     
    }
}
