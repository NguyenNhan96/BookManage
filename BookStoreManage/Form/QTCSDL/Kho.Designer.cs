namespace QTCSDL
{
    partial class Kho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kho));
            this.dsKho = new System.Windows.Forms.DataGridView();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsKho
            // 
            this.dsKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKHO,
            this.TENKHO,
            this.DIACHI});
            this.dsKho.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dsKho.Location = new System.Drawing.Point(0, 51);
            this.dsKho.Name = "dsKho";
            this.dsKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsKho.Size = new System.Drawing.Size(643, 228);
            this.dsKho.TabIndex = 0;
            this.dsKho.SelectionChanged += new System.EventHandler(this.dsKho_SelectionChanged);
            this.dsKho.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dsKho_UserDeletingRow);
            // 
            // MAKHO
            // 
            this.MAKHO.DataPropertyName = "MAKHO";
            this.MAKHO.HeaderText = "Mã Kho";
            this.MAKHO.Name = "MAKHO";
            // 
            // TENKHO
            // 
            this.TENKHO.DataPropertyName = "TENKHO";
            this.TENKHO.HeaderText = "Tên Kho";
            this.TENKHO.Name = "TENKHO";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(262, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 56);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(274, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 29);
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
            this.btnThem.Location = new System.Drawing.Point(20, 15);
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
            this.btnSua.Location = new System.Drawing.Point(107, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 29);
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
            this.btnXoa.Location = new System.Drawing.Point(195, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 29);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(245, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thông tin kho sách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(2, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 90);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hướng dẫn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "- Nhấn \" Refresh\" sau khi sửa để load lại dữ liệu.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(567, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "- Click trong danh sách hiển thị sau đó nhấn \" Sửa \" để chỉnh sửa thông tin, hoặc" +
    " nhấn \"Xóa \"để  loại bỏ.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "- Nhấn vào nút \" Thêm \" để thêm kho mới.";
            // 
            // Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(644, 439);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dsKho);
            this.Name = "Kho";
            this.Text = " Kho Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kho_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}

