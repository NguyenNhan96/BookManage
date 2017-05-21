namespace QTCSDL
{
    partial class Sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sach));
            this.dsSach = new System.Windows.Forms.DataGridView();
            this.MASACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHAXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.btnSua2 = new System.Windows.Forms.Button();
            this.btnXoa2 = new System.Windows.Forms.Button();
            this.btnThem2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.txtTimMa = new System.Windows.Forms.TextBox();
            this.picTim = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTim)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSach
            // 
            this.dsSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dsSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASACH,
            this.TENSACH,
            this.TACGIA,
            this.NHAXB,
            this.NAMXB,
            this.GIA,
            this.SOLUONG,
            this.MALOAI,
            this.MAKHO});
            this.dsSach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dsSach.Location = new System.Drawing.Point(2, 61);
            this.dsSach.Name = "dsSach";
            this.dsSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsSach.Size = new System.Drawing.Size(816, 328);
            this.dsSach.TabIndex = 0;
            this.dsSach.SelectionChanged += new System.EventHandler(this.dsSach_SelectionChanged_1);
            this.dsSach.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dsSach_UserDeletingRow);
            // 
            // MASACH
            // 
            this.MASACH.DataPropertyName = "MASACH";
            this.MASACH.FillWeight = 14.5784F;
            this.MASACH.HeaderText = "Mã Sách";
            this.MASACH.Name = "MASACH";
            // 
            // TENSACH
            // 
            this.TENSACH.DataPropertyName = "TENSACH";
            this.TENSACH.FillWeight = 41.45074F;
            this.TENSACH.HeaderText = "Tên Sách";
            this.TENSACH.Name = "TENSACH";
            // 
            // TACGIA
            // 
            this.TACGIA.DataPropertyName = "TACGIA";
            this.TACGIA.FillWeight = 49.56398F;
            this.TACGIA.HeaderText = "Tác Giả";
            this.TACGIA.Name = "TACGIA";
            // 
            // NHAXB
            // 
            this.NHAXB.DataPropertyName = "NHAXB";
            this.NHAXB.FillWeight = 50.72882F;
            this.NHAXB.HeaderText = "Nhà Xuất Bản";
            this.NHAXB.Name = "NHAXB";
            // 
            // NAMXB
            // 
            this.NAMXB.DataPropertyName = "NAMXB";
            this.NAMXB.FillWeight = 16.19823F;
            this.NAMXB.HeaderText = "Năm Xuất Bản";
            this.NAMXB.Name = "NAMXB";
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.FillWeight = 16.19823F;
            this.GIA.HeaderText = "Giá";
            this.GIA.Name = "GIA";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.FillWeight = 15.26004F;
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.FillWeight = 20.44196F;
            this.MALOAI.HeaderText = "Mã Loại";
            this.MALOAI.Name = "MALOAI";
            // 
            // MAKHO
            // 
            this.MAKHO.DataPropertyName = "MAKHO";
            this.MAKHO.FillWeight = 19.68222F;
            this.MAKHO.HeaderText = "Mã Kho";
            this.MAKHO.Name = "MAKHO";
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh2.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh2.Image")));
            this.btnRefresh2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh2.Location = new System.Drawing.Point(720, 395);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(86, 29);
            this.btnRefresh2.TabIndex = 27;
            this.btnRefresh2.Text = "Refresh";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // btnSua2
            // 
            this.btnSua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSua2.Image = ((System.Drawing.Image)(resources.GetObject("btnSua2.Image")));
            this.btnSua2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua2.Location = new System.Drawing.Point(503, 395);
            this.btnSua2.Name = "btnSua2";
            this.btnSua2.Size = new System.Drawing.Size(77, 29);
            this.btnSua2.TabIndex = 25;
            this.btnSua2.Text = "Sửa";
            this.btnSua2.UseVisualStyleBackColor = true;
            this.btnSua2.Click += new System.EventHandler(this.btnSua2_Click);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnXoa2.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa2.Image")));
            this.btnXoa2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa2.Location = new System.Drawing.Point(610, 395);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(77, 29);
            this.btnXoa2.TabIndex = 26;
            this.btnXoa2.Text = "Xóa";
            this.btnXoa2.UseVisualStyleBackColor = true;
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // btnThem2
            // 
            this.btnThem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThem2.Image = ((System.Drawing.Image)(resources.GetObject("btnThem2.Image")));
            this.btnThem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem2.Location = new System.Drawing.Point(398, 395);
            this.btnThem2.Name = "btnThem2";
            this.btnThem2.Size = new System.Drawing.Size(77, 29);
            this.btnThem2.TabIndex = 24;
            this.btnThem2.Text = "Thêm";
            this.btnThem2.UseVisualStyleBackColor = true;
            this.btnThem2.Click += new System.EventHandler(this.btnThem2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "- Nhấn vào nút \" Thêm \" để thêm sách mới.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(657, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "- Chọn sách trong danh sách hiển thị sau đó nhấn \" Sửa \" để chỉnh sửa thông tin s" +
    "ách, hoặc nhấn \"Xóa \"để  loại bỏ sách.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(2, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(816, 88);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hướng dẫn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "- Nhấn \" Refresh\" sau khi sửa để load lại dữ liệu.";
            // 
            // txtTimTen
            // 
            this.txtTimTen.ForeColor = System.Drawing.Color.Silver;
            this.txtTimTen.Location = new System.Drawing.Point(192, 35);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(146, 20);
            this.txtTimTen.TabIndex = 28;
            this.txtTimTen.Tag = "Tên sách";
            this.txtTimTen.Text = "Tên sách";
            this.txtTimTen.TextChanged += new System.EventHandler(this.txtTimten_TextChanged);
            this.txtTimTen.Enter += new System.EventHandler(this.txtTimten_Enter);
            this.txtTimTen.Leave += new System.EventHandler(this.txtTimten_Leave);
            // 
            // txtTimMa
            // 
            this.txtTimMa.ForeColor = System.Drawing.Color.Silver;
            this.txtTimMa.Location = new System.Drawing.Point(107, 35);
            this.txtTimMa.Name = "txtTimMa";
            this.txtTimMa.Size = new System.Drawing.Size(79, 20);
            this.txtTimMa.TabIndex = 29;
            this.txtTimMa.Tag = "Mã sách";
            this.txtTimMa.Text = "Mã sách";
            this.txtTimMa.TextChanged += new System.EventHandler(this.txtTimMa_TextChanged);
            this.txtTimMa.Enter += new System.EventHandler(this.txtTimMa_Enter);
            this.txtTimMa.Leave += new System.EventHandler(this.txtTimMa_Leave);
            // 
            // picTim
            // 
            this.picTim.BackColor = System.Drawing.Color.White;
            this.picTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTim.BackgroundImage")));
            this.picTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picTim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picTim.Location = new System.Drawing.Point(344, 35);
            this.picTim.Name = "picTim";
            this.picTim.Size = new System.Drawing.Size(34, 20);
            this.picTim.TabIndex = 30;
            this.picTim.TabStop = false;
            this.picTim.Click += new System.EventHandler(this.picTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(40, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tìm kiếm";
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(818, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picTim);
            this.Controls.Add(this.txtTimMa);
            this.Controls.Add(this.txtTimTen);
            this.Controls.Add(this.btnRefresh2);
            this.Controls.Add(this.btnSua2);
            this.Controls.Add(this.btnXoa2);
            this.Controls.Add(this.btnThem2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dsSach);
            this.Name = "Sach";
            this.Text = "Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sach_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHAXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.Button btnSua2;
        private System.Windows.Forms.Button btnXoa2;
        private System.Windows.Forms.Button btnThem2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.TextBox txtTimMa;
        private System.Windows.Forms.PictureBox picTim;
        private System.Windows.Forms.Label label2;
    }
}