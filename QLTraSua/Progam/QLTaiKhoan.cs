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
    public partial class QLTaiKhoan : Form
    {
        public QLTaiKhoan()
        {
            InitializeComponent();
        }
        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTK();
        }

        private void LoadTK()
        {
            dgvNV.Rows.Clear();
            using (var dbContext = new Model1())
            {
                foreach (var item in dbContext.TKDangNhap.Select(x => new { x.TenNV, x.TaiKhoan, x.MatKhau, x.ChucVu }))
                {
                    int dong = dgvNV.Rows.Add();
                    dgvNV.Rows[dong].Cells["colTen"].Value = item.TenNV;
                    dgvNV.Rows[dong].Cells["colCV"].Value = item.ChucVu;
                    dgvNV.Rows[dong].Cells["colTK"].Value = item.TaiKhoan;
                    dgvNV.Rows[dong].Cells["colMK"].Value = item.MatKhau;
                }
            }
            dgvNV.ClearSelection();
        }

    }
}
