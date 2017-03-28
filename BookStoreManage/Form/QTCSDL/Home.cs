using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTCSDL
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

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

        }

    }
}
