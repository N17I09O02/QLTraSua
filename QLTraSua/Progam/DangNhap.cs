using QLTraSua.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTraSua.Progam
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            string taiKhoan = txtTK.Text.Trim();
            string matKhau = txtMK.Text.Trim();

            // Tìm tài khoản đăng nhập trong cơ sở dữ liệu
            var taiKhoanDangNhap = model.TKDangNhap.FirstOrDefault(item => item.TaiKhoan == taiKhoan && item.MatKhau == matKhau);

            if (taiKhoanDangNhap != null)
            {
                // Kiểm tra quyền hạn của tài khoản
                if (taiKhoanDangNhap.ChucVu == "GD") // Thay "GD" bằng quyền hạn tương ứng của tài khoản gia đình
                {
                    Form1 l = new Form1();
                    l.Show();
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công với quyền hạn Giám Đốc!", "Thông báo");
                }
                else
                {
                    Form1 l = new Form1();
                    l.Show();
                    l.AnDMToolStripMenuItem();
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
            }
        }

        private void cbxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxShow.Checked)
                txtMK.UseSystemPasswordChar = true;
            else
                txtMK.UseSystemPasswordChar = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
