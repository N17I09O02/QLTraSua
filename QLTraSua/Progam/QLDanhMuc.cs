using QLTraSua.Model;
using QLTraSua.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTraSua.Progam
{
    public partial class QLDanhMuc : Form
    {
        int maDanhMuc = -1;
        public QLDanhMuc()
        {
            InitializeComponent();
            this.Load += QLDanhMuc_Load;
        }

        private void QLDanhMuc_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }

        private void ResetThongTinNhap()
        {
            txtTen.Text = txtMa.Text = string.Empty;
        }

        private void LoadDanhMuc()
        {
            dgvDanhMuc.Rows.Clear();
            using (var dbContext = new Model1())
            {
                foreach (var item in dbContext.DanhMuc.Select(x => new { x.Ma, x.TenDanhMuc }))
                {
                    int dong = dgvDanhMuc.Rows.Add();
                    dgvDanhMuc.Rows[dong].Cells["colMa"].Value = item.Ma;
                    dgvDanhMuc.Rows[dong].Cells["colTen"].Value = item.TenDanhMuc;
                }
            }
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                maDanhMuc = int.Parse(dgvDanhMuc.Rows[dong].Cells["colMa"].Value.ToString());
                txtMa.Text = dgvDanhMuc.Rows[dong].Cells["colMa"].Value.ToString();
                txtTen.Text = dgvDanhMuc.Rows[dong].Cells["colTen"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string userInput = txtMa.Text;
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show(" vui long nhap ten danh muc ");
                return;
            }
            using (var dbContext = new Model1())
            {
                if (int.TryParse(userInput, out int userValue))
                {
                    // Kiểm tra sự trùng khớp với giá trị trong cơ sở dữ liệu
                    bool isDuplicate = dbContext.DanhMuc.Any(d => d.Ma == userValue);
                    if (isDuplicate)
                    {
                        MessageBox.Show("Loi mã đã tồn tại");
                        return;
                    }
                    try
                    {
                        DanhMuc danhMuc = new DanhMuc()
                        {
                            TenDanhMuc = txtTen.Text,
                        };
                        using (var dbConText = new Model1())
                        {
                            dbConText.DanhMuc.Add(danhMuc);
                            dbConText.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Loi" + ex.Message);
                    }
                    LoadDanhMuc();
                    ResetThongTinNhap();
                }
                else
                {
                    MessageBox.Show(" Loi ");
                    return;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDanhMuc != -1)
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show(" vui long nhap ten danh muc ");
                    return;
                }
                try
                {
                    using (var dbConText = new Model1())
                    {
                        DanhMuc danhmuc = dbConText.DanhMuc.FirstOrDefault(m => m.Ma == maDanhMuc);
                        if (danhmuc != null)
                        {
                            danhmuc.TenDanhMuc = txtTen.Text;
                            dbConText.SaveChanges();
                            maDanhMuc = -1;
                        }
                    }
                    LoadDanhMuc();
                    ResetThongTinNhap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi" + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDanhMuc != -1)
            {
                try
                {
                    using (var dbConText = new Model1())
                    {
                        DanhMuc danhMuc = dbConText.DanhMuc.FirstOrDefault(m => m.Ma == maDanhMuc);
                        if (danhMuc != null)
                        {
                            dbConText.DanhMuc.Remove(danhMuc);
                            dbConText.SaveChanges();
                            maDanhMuc = -1;
                        }
                    }
                    LoadDanhMuc();
                    ResetThongTinNhap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi" + ex.Message);
                }
            }
        }
    }
}
