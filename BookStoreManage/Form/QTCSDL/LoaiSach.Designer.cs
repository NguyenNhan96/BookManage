namespace QTCSDL
{
    partial class LoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiSach));
            this.dsLoai = new System.Windows.Forms.DataGridView();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsLoai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsLoai
            // 
            this.dsLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dsLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAI,
            this.TENLOAI,
            this.MOTA});
            this.dsLoai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dsLoai.Location = new System.Drawing.Point(2, 3);
            this.dsLoai.Name = "dsLoai";
            this.dsLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsLoai.Size = new System.Drawing.Size(588, 199);
            this.dsLoai.TabIndex = 7;
            this.dsLoai.SelectionChanged += new System.EventHandler(this.dsLoai_SelectionChanged);
            this.dsLoai.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dsLoai_UserDeletingRow);
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.HeaderText = "Mã Loại";
            this.MALOAI.Name = "MALOAI";
            // 
            // TENLOAI
            // 
            this.TENLOAI.DataPropertyName = "TENLOAI";
            this.TENLOAI.HeaderText = "Tên Loại";
            this.TENLOAI.Name = "TENLOAI";
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô Tả";
            this.MOTA.Name = "MOTA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(210, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(276, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 29);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(16, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 29);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(107, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 29);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(194, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 29);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // LoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dsLoai);
            this.Name = "LoaiSach";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoaiSach_FormClosing);
            this.Load += new System.EventHandler(this.LoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLoai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
    }
}