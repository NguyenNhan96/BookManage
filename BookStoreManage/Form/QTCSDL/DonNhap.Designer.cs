namespace QTCSDL
{
    partial class DonNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonNhap));
            this.dsDonNhap = new System.Windows.Forms.DataGridView();
            this.MADN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOINHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNoiNhap = new System.Windows.Forms.Label();
            this.txtNoiNhap = new System.Windows.Forms.TextBox();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblMaDon = new System.Windows.Forms.Label();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsDonNhap)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsDonNhap
            // 
            this.dsDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADN,
            this.NGAYNHAP,
            this.NOINHAP,
            this.TONGTIEN,
            this.MAKHO});
            this.dsDonNhap.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dsDonNhap.Location = new System.Drawing.Point(1, 303);
            this.dsDonNhap.Name = "dsDonNhap";
            this.dsDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsDonNhap.Size = new System.Drawing.Size(780, 245);
            this.dsDonNhap.TabIndex = 7;
            this.dsDonNhap.SelectionChanged += new System.EventHandler(this.dsDonNhap_SelectionChanged);
            this.dsDonNhap.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dsDonNhap_UserDeletingRow);
            // 
            // MADN
            // 
            this.MADN.DataPropertyName = "MADN";
            this.MADN.HeaderText = "Mã Đơn nhập";
            this.MADN.Name = "MADN";
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày Nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            // 
            // NOINHAP
            // 
            this.NOINHAP.DataPropertyName = "NOINHAP";
            this.NOINHAP.HeaderText = "Nơi Nhập";
            this.NOINHAP.Name = "NOINHAP";
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng Tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            // 
            // MAKHO
            // 
            this.MAKHO.DataPropertyName = "MAKHO";
            this.MAKHO.HeaderText = "Mã Kho";
            this.MAKHO.Name = "MAKHO";
            // 
            // lblNoiNhap
            // 
            this.lblNoiNhap.AutoSize = true;
            this.lblNoiNhap.BackColor = System.Drawing.SystemColors.Control;
            this.lblNoiNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoiNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNoiNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNoiNhap.Location = new System.Drawing.Point(31, 82);
            this.lblNoiNhap.Name = "lblNoiNhap";
            this.lblNoiNhap.Size = new System.Drawing.Size(54, 15);
            this.lblNoiNhap.TabIndex = 2;
            this.lblNoiNhap.Text = "Nơi Nhập";
            // 
            // txtNoiNhap
            // 
            this.txtNoiNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoiNhap.Location = new System.Drawing.Point(115, 79);
            this.txtNoiNhap.Name = "txtNoiNhap";
            this.txtNoiNhap.Size = new System.Drawing.Size(167, 20);
            this.txtNoiNhap.TabIndex = 5;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.BackColor = System.Drawing.SystemColors.Control;
            this.lblNgayNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNgayNhap.Location = new System.Drawing.Point(31, 55);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(66, 15);
            this.lblNgayNhap.TabIndex = 1;
            this.lblNgayNhap.Text = "Ngày Nhập:";
            // 
            // lblMaDon
            // 
            this.lblMaDon.AutoSize = true;
            this.lblMaDon.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaDon.Location = new System.Drawing.Point(31, 27);
            this.lblMaDon.Name = "lblMaDon";
            this.lblMaDon.Size = new System.Drawing.Size(50, 15);
            this.lblMaDon.TabIndex = 0;
            this.lblMaDon.Text = "Mã Đơn:";
            // 
            // txtMaDon
            // 
            this.txtMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDon.Location = new System.Drawing.Point(115, 22);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(111, 20);
            this.txtMaDon.TabIndex = 3;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnOK);
            this.grbThongTin.Controls.Add(this.dtNgayNhap);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.txtMaKho);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.txtTongTien);
            this.grbThongTin.Controls.Add(this.lblNoiNhap);
            this.grbThongTin.Controls.Add(this.txtNoiNhap);
            this.grbThongTin.Controls.Add(this.lblNgayNhap);
            this.grbThongTin.Controls.Add(this.lblMaDon);
            this.grbThongTin.Controls.Add(this.txtMaDon);
            this.grbThongTin.Enabled = false;
            this.grbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTin.Location = new System.Drawing.Point(351, 12);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(407, 207);
            this.grbThongTin.TabIndex = 9;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(142, 163);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 33);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgayNhap.Location = new System.Drawing.Point(115, 50);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(167, 20);
            this.dtNgayNhap.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(31, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Kho";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKho.Location = new System.Drawing.Point(115, 135);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(132, 20);
            this.txtMaKho.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(31, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Location = new System.Drawing.Point(115, 108);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(132, 20);
            this.txtTongTien.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mẹo: Chỉnh sửa các ô textbox phía trên để tiến hành:  ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(33, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 77);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hướng dẫn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "- Xem thông tin chi tiết từng đơn hàng.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "- Chỉnh sửa đơn hàng.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "- Xóa đơn hàng cũ.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "- Nhập đơn hàng mới.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChiTiet);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChiTiet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Image")));
            this.btnChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTiet.Location = new System.Drawing.Point(46, 126);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(140, 29);
            this.btnChiTiet.TabIndex = 5;
            this.btnChiTiet.Text = "Chi tiết đơn nhập";
            this.btnChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(177, 82);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 29);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(46, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 29);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Nhập Sách";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(177, 41);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 29);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(46, 82);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 29);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // DonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dsDonNhap);
            this.Controls.Add(this.grbThongTin);
            this.Name = "DonNhap";
            this.Text = "Đơn nhập hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DonNhap_FormClosing);
            this.Load += new System.EventHandler(this.DonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDonNhap)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsDonNhap;
        private System.Windows.Forms.Label lblNoiNhap;
        private System.Windows.Forms.TextBox txtNoiNhap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblMaDon;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOINHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnOK;

    }
}