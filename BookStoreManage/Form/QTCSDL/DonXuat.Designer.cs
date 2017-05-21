namespace QTCSDL
{
    partial class DonXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonXuat));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dsDonXuat = new System.Windows.Forms.DataGridView();
            this.MADX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoiNhap = new System.Windows.Forms.Label();
            this.txtNoiXuat = new System.Windows.Forms.TextBox();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblMaDon = new System.Windows.Forms.Label();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDonXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "- Xuất đơn hàng mới.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(1, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 85);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hướng dẫn";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mẹo: Chỉnh sửa các ô textbox phía trên để tiến hành:  ";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChiTiet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Image")));
            this.btnChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTiet.Location = new System.Drawing.Point(6, 11);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(141, 29);
            this.btnChiTiet.TabIndex = 5;
            this.btnChiTiet.Text = "Chi tiết đơn xuất";
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
            this.btnRefresh.Location = new System.Drawing.Point(432, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 29);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // dsDonXuat
            // 
            this.dsDonXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsDonXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDonXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADX,
            this.NGAYXUAT,
            this.NOIXUAT,
            this.TONGTIEN,
            this.MAKHO});
            this.dsDonXuat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dsDonXuat.Location = new System.Drawing.Point(1, 45);
            this.dsDonXuat.Name = "dsDonXuat";
            this.dsDonXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsDonXuat.Size = new System.Drawing.Size(760, 237);
            this.dsDonXuat.TabIndex = 12;
            this.dsDonXuat.SelectionChanged += new System.EventHandler(this.dsDonXuat_SelectionChanged);
            this.dsDonXuat.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dsDonXuat_UserDeletingRow);
            // 
            // MADX
            // 
            this.MADX.DataPropertyName = "MADX";
            this.MADX.HeaderText = "Mã đơn xuất";
            this.MADX.Name = "MADX";
            // 
            // NGAYXUAT
            // 
            this.NGAYXUAT.DataPropertyName = "NGAYXUAT";
            this.NGAYXUAT.HeaderText = "Ngày xuất";
            this.NGAYXUAT.Name = "NGAYXUAT";
            // 
            // NOIXUAT
            // 
            this.NOIXUAT.DataPropertyName = "NOIXUAT";
            this.NOIXUAT.HeaderText = "Nơi xuất";
            this.NOIXUAT.Name = "NOIXUAT";
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
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(153, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 29);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Nhập đơn hàng mới";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(309, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(54, 29);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(376, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(51, 29);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChiTiet);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(234, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 50);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.lblTongTien);
            this.grbThongTin.Controls.Add(this.btnOK);
            this.grbThongTin.Controls.Add(this.dtNgayXuat);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.txtMaKho);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.lblNoiNhap);
            this.grbThongTin.Controls.Add(this.txtNoiXuat);
            this.grbThongTin.Controls.Add(this.lblNgayNhap);
            this.grbThongTin.Controls.Add(this.lblMaDon);
            this.grbThongTin.Controls.Add(this.txtMaDon);
            this.grbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTin.Location = new System.Drawing.Point(1, 332);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(760, 86);
            this.grbThongTin.TabIndex = 16;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(594, 27);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(38, 33);
            this.btnOK.TabIndex = 11;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtNgayXuat
            // 
            this.dtNgayXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgayXuat.Location = new System.Drawing.Point(101, 50);
            this.dtNgayXuat.Name = "dtNgayXuat";
            this.dtNgayXuat.Size = new System.Drawing.Size(159, 20);
            this.dtNgayXuat.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(278, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Kho";
            // 
            // txtMaKho
            // 
            this.txtMaKho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKho.Location = new System.Drawing.Point(356, 50);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(70, 20);
            this.txtMaKho.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(463, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng Tiền:";
            // 
            // lblNoiNhap
            // 
            this.lblNoiNhap.AutoSize = true;
            this.lblNoiNhap.BackColor = System.Drawing.SystemColors.Control;
            this.lblNoiNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoiNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNoiNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNoiNhap.Location = new System.Drawing.Point(278, 24);
            this.lblNoiNhap.Name = "lblNoiNhap";
            this.lblNoiNhap.Size = new System.Drawing.Size(53, 15);
            this.lblNoiNhap.TabIndex = 2;
            this.lblNoiNhap.Text = "Nơi Xuất:";
            // 
            // txtNoiXuat
            // 
            this.txtNoiXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoiXuat.Location = new System.Drawing.Point(356, 19);
            this.txtNoiXuat.Name = "txtNoiXuat";
            this.txtNoiXuat.Size = new System.Drawing.Size(111, 20);
            this.txtNoiXuat.TabIndex = 8;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.BackColor = System.Drawing.SystemColors.Control;
            this.lblNgayNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNgayNhap.Location = new System.Drawing.Point(17, 55);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(62, 15);
            this.lblNgayNhap.TabIndex = 1;
            this.lblNgayNhap.Text = "Ngày Xuất:";
            // 
            // lblMaDon
            // 
            this.lblMaDon.AutoSize = true;
            this.lblMaDon.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaDon.Location = new System.Drawing.Point(17, 27);
            this.lblMaDon.Name = "lblMaDon";
            this.lblMaDon.Size = new System.Drawing.Size(50, 15);
            this.lblMaDon.TabIndex = 0;
            this.lblMaDon.Text = "Mã Đơn:";
            // 
            // txtMaDon
            // 
            this.txtMaDon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDon.Location = new System.Drawing.Point(101, 22);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(97, 20);
            this.txtMaDon.TabIndex = 6;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.SystemColors.Control;
            this.lblTongTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTongTien.Location = new System.Drawing.Point(533, 53);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(15, 15);
            this.lblTongTien.TabIndex = 12;
            this.lblTongTien.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(268, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Thông tin đơn hàng";
            // 
            // DonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 508);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dsDonXuat);
            this.Controls.Add(this.groupBox1);
            this.Name = "DonXuat";
            this.Text = "Đơn xuất hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DonXuat_FormClosing);
            this.Load += new System.EventHandler(this.DonXuat_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDonXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dsDonXuat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.DateTimePicker dtNgayXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoiNhap;
        private System.Windows.Forms.TextBox txtNoiXuat;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblMaDon;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label9;
    }
}