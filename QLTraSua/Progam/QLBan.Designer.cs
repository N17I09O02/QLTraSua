namespace QLTraSua.Danh_Mục
{
    partial class QLBan
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
            this.dgvban = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthemban = new System.Windows.Forms.Button();
            this.btnsuaban = new System.Windows.Forms.Button();
            this.btnxoaban = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvban
            // 
            this.dgvban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvban.BackgroundColor = System.Drawing.Color.White;
            this.dgvban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colTang});
            this.dgvban.GridColor = System.Drawing.Color.Black;
            this.dgvban.Location = new System.Drawing.Point(41, 240);
            this.dgvban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvban.Name = "dgvban";
            this.dgvban.RowHeadersWidth = 62;
            this.dgvban.Size = new System.Drawing.Size(603, 325);
            this.dgvban.TabIndex = 4;
            this.dgvban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvban_CellClick);
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã Bàn";
            this.colMa.MinimumWidth = 8;
            this.colMa.Name = "colMa";
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên Bàn";
            this.colTen.MinimumWidth = 8;
            this.colTen.Name = "colTen";
            // 
            // colTang
            // 
            this.colTang.HeaderText = "Tầng";
            this.colTang.MinimumWidth = 8;
            this.colTang.Name = "colTang";
            // 
            // btnthemban
            // 
            this.btnthemban.BackColor = System.Drawing.Color.White;
            this.btnthemban.Location = new System.Drawing.Point(532, 101);
            this.btnthemban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthemban.Name = "btnthemban";
            this.btnthemban.Size = new System.Drawing.Size(112, 35);
            this.btnthemban.TabIndex = 3;
            this.btnthemban.Text = "Thêm Bàn";
            this.btnthemban.UseVisualStyleBackColor = false;
            // 
            // btnsuaban
            // 
            this.btnsuaban.BackColor = System.Drawing.Color.White;
            this.btnsuaban.Location = new System.Drawing.Point(532, 145);
            this.btnsuaban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsuaban.Name = "btnsuaban";
            this.btnsuaban.Size = new System.Drawing.Size(112, 35);
            this.btnsuaban.TabIndex = 2;
            this.btnsuaban.Text = "Sửa Bàn";
            this.btnsuaban.UseVisualStyleBackColor = false;
            // 
            // btnxoaban
            // 
            this.btnxoaban.BackColor = System.Drawing.Color.White;
            this.btnxoaban.Location = new System.Drawing.Point(532, 188);
            this.btnxoaban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoaban.Name = "btnxoaban";
            this.btnxoaban.Size = new System.Drawing.Size(112, 35);
            this.btnxoaban.TabIndex = 1;
            this.btnxoaban.Text = "Xóa Bàn";
            this.btnxoaban.UseVisualStyleBackColor = false;
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(130, 105);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(121, 26);
            this.txtMa.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(130, 149);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(121, 26);
            this.txtTen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tầng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quản Lý Bàn";
            // 
            // cmbTang
            // 
            this.cmbTang.FormattingEnabled = true;
            this.cmbTang.Location = new System.Drawing.Point(130, 189);
            this.cmbTang.Name = "cmbTang";
            this.cmbTang.Size = new System.Drawing.Size(121, 28);
            this.cmbTang.TabIndex = 11;
            // 
            // QLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(665, 583);
            this.Controls.Add(this.cmbTang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnthemban);
            this.Controls.Add(this.dgvban);
            this.Controls.Add(this.btnsuaban);
            this.Controls.Add(this.btnxoaban);
            this.Controls.Add(this.txtMa);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QLBan";
            this.Text = "Quản Lý Bàn";
            this.Load += new System.EventHandler(this.QLBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvban;
        private System.Windows.Forms.Button btnthemban;
        private System.Windows.Forms.Button btnsuaban;
        private System.Windows.Forms.Button btnxoaban;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTang;
    }
}