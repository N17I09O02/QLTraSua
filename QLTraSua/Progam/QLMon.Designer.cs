namespace QLTraSua.Danh_Mục
{
    partial class QLMon
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
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthemmonan = new System.Windows.Forms.Button();
            this.btnsuamonan = new System.Windows.Forms.Button();
            this.btnxoamonan = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDanhMuc = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMon
            // 
            this.dgvMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMon.BackgroundColor = System.Drawing.Color.White;
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colGia,
            this.colTenDanhMuc,
            this.colHinh});
            this.dgvMon.GridColor = System.Drawing.Color.Black;
            this.dgvMon.Location = new System.Drawing.Point(13, 284);
            this.dgvMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.RowHeadersWidth = 62;
            this.dgvMon.Size = new System.Drawing.Size(845, 331);
            this.dgvMon.TabIndex = 4;
            this.dgvMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMon_CellClick);
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã Món";
            this.colMa.MinimumWidth = 8;
            this.colMa.Name = "colMa";
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên Món";
            this.colTen.MinimumWidth = 8;
            this.colTen.Name = "colTen";
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Đơn Giá";
            this.colGia.MinimumWidth = 8;
            this.colGia.Name = "colGia";
            // 
            // colTenDanhMuc
            // 
            this.colTenDanhMuc.HeaderText = "Tên Danh Mục";
            this.colTenDanhMuc.MinimumWidth = 8;
            this.colTenDanhMuc.Name = "colTenDanhMuc";
            // 
            // colHinh
            // 
            this.colHinh.HeaderText = "Hình Ảnh";
            this.colHinh.MinimumWidth = 8;
            this.colHinh.Name = "colHinh";
            this.colHinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnthemmonan
            // 
            this.btnthemmonan.BackColor = System.Drawing.Color.White;
            this.btnthemmonan.Location = new System.Drawing.Point(710, 86);
            this.btnthemmonan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthemmonan.Name = "btnthemmonan";
            this.btnthemmonan.Size = new System.Drawing.Size(148, 35);
            this.btnthemmonan.TabIndex = 3;
            this.btnthemmonan.Text = "Thêm Món Ăn";
            this.btnthemmonan.UseVisualStyleBackColor = false;
            this.btnthemmonan.Click += new System.EventHandler(this.btnthemmonan_Click);
            // 
            // btnsuamonan
            // 
            this.btnsuamonan.BackColor = System.Drawing.Color.White;
            this.btnsuamonan.Location = new System.Drawing.Point(710, 135);
            this.btnsuamonan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsuamonan.Name = "btnsuamonan";
            this.btnsuamonan.Size = new System.Drawing.Size(148, 35);
            this.btnsuamonan.TabIndex = 2;
            this.btnsuamonan.Text = "Sửa Món Ăn";
            this.btnsuamonan.UseVisualStyleBackColor = false;
            this.btnsuamonan.Click += new System.EventHandler(this.btnsuamonan_Click);
            // 
            // btnxoamonan
            // 
            this.btnxoamonan.BackColor = System.Drawing.Color.White;
            this.btnxoamonan.Location = new System.Drawing.Point(708, 186);
            this.btnxoamonan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoamonan.Name = "btnxoamonan";
            this.btnxoamonan.Size = new System.Drawing.Size(150, 35);
            this.btnxoamonan.TabIndex = 1;
            this.btnxoamonan.Text = "Xóa Món Ăn";
            this.btnxoamonan.UseVisualStyleBackColor = false;
            this.btnxoamonan.Click += new System.EventHandler(this.btnxoamonan_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(139, 132);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(182, 26);
            this.txtTen.TabIndex = 5;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(139, 177);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(182, 26);
            this.txtGia.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Danh Mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(278, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quản Lý Món";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(708, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.FormattingEnabled = true;
            this.cmbDanhMuc.Location = new System.Drawing.Point(139, 214);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.Size = new System.Drawing.Size(121, 28);
            this.cmbDanhMuc.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(416, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(506, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "Open File";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // QLMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(881, 650);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbDanhMuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnthemmonan);
            this.Controls.Add(this.dgvMon);
            this.Controls.Add(this.btnsuamonan);
            this.Controls.Add(this.btnxoamonan);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QLMon";
            this.Text = "QLMenu";
            this.Load += new System.EventHandler(this.QLMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.Button btnthemmonan;
        private System.Windows.Forms.Button btnsuamonan;
        private System.Windows.Forms.Button btnxoamonan;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDanhMuc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHinh;
    }
}