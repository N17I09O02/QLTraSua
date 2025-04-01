using QLTraSua.Model;
using QLTraSua.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTraSua.Danh_Mục
{
    public partial class QLMon : Form
    {
        int maMon = -1;
        public QLMon()
        {
            InitializeComponent();
            this.Load += QLMon_Load;

        }

        private void DieuKien()
        {
            cmbDanhMuc.DisplayMember = "TenDanhMuc";
            cmbDanhMuc.ValueMember = "Ma";
            cmbDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void QLMon_Load(object sender, EventArgs e)
        {
            LoadMon();
            LoadDanhMuc();
            DieuKien();
        }

        private void LoadDanhMuc()
        {
            using (var dbcontext = new Model1())
            {
                cmbDanhMuc.DataSource = dbcontext.DanhMuc.Select(x => new { x.TenDanhMuc, x.Ma }).ToList();
            }
        }

        private void LoadMon()
        {
            dgvMon.Rows.Clear();
            using (var dbContext = new Model1())
            {
                foreach (var item in dbContext.Mon.Select(x => new MonDat { MaMon = x.Ma, TenMon = x.TenMon, Gia = x.Gia, TenDanhMuc = x.DanhMuc.TenDanhMuc, HinhAnh = x.HinhAnh }))
                {
                    int dong = dgvMon.Rows.Add();
                    dgvMon.Rows[dong].Cells["colMa"].Value = item.MaMon;
                    dgvMon.Rows[dong].Cells["colTen"].Value = item.TenMon;
                    dgvMon.Rows[dong].Cells["colGia"].Value = item.Gia;
                    dgvMon.Rows[dong].Cells["colTenDanhMuc"].Value = item.TenDanhMuc;
                    dgvMon.Rows[dong].Cells["colHinh"].Value = item.HinhAnh;
                }
            }
            dgvMon.ClearSelection();
        }

        private DataGridViewCell clickedCell;

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewCell newClickedCell = dgvMon.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (clickedCell == newClickedCell)
                {
                    txtTen.Text = null;
                    txtGia.Text = null;
                    pictureBox1.Image = null;
                    dgvMon.ClearSelection();
                    clickedCell = null;
                }
                else
                {
                    clickedCell = newClickedCell;
                    int dong = e.RowIndex;
                    if (dong >= 0)
                    {
                        maMon = int.Parse(dgvMon.Rows[dong].Cells["colMa"].Value.ToString());
                        txtTen.Text = dgvMon.Rows[dong].Cells["colTen"].Value.ToString();
                        txtGia.Text = dgvMon.Rows[dong].Cells["colGia"].Value.ToString();
                        cmbDanhMuc.Text = dgvMon.Rows[dong].Cells["colTenDanhMuc"].Value.ToString();
                        //pictureBox1.Image = Image.FromFile(dgvMon.Rows[dong].Cells["colHinh"].Value.ToString());
                        Image im = GetCopyImage(dgvMon.Rows[dong].Cells["colHinh"].Value.ToString());
                        pictureBox1.Image = im;
                        pictureBox1.Refresh();
                    }
                }
            }
        }

        private void ResetThongTinNhap()
        {
            txtTen.Text = txtGia.Text = string.Empty;
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemmonan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show(" vui long nhap ten mon ");
                return;
            }
            decimal gia;
            if (decimal.TryParse(txtGia.Text, out gia) == false)
            {
                MessageBox.Show(" GIA K HOP LE");
                return;
            }
            try
            {
                Mon mon = new Mon()
                {
                    TenMon = txtTen.Text,
                    Gia = gia,
                    MaDanhMuc = int.Parse(cmbDanhMuc.SelectedValue.ToString()),
                };
                if (pictureBox1 != null)
                {
                    string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string imagePath = Path.Combine(parentDirectory, "Resources", mon.TenMon + ".png");
                    mon.HinhAnh = imagePath;
                    pictureBox1.Image.Save(imagePath);
                }
                using (var dbConText = new Model1())
                {
                    dbConText.Mon.Add(mon);
                    dbConText.SaveChanges();
                }
                LoadMon();
                ResetThongTinNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex.Message);
            }
        }

        private void btnsuamonan_Click(object sender, EventArgs e)
        {
            if (maMon != -1)
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show(" vui long nhap ten mon ");
                    return;
                }
                decimal gia;
                if (decimal.TryParse(txtGia.Text, out gia) == false)
                {
                    MessageBox.Show(" GIA K HOP LE");
                    return;
                }
                try
                {
                    using (var dbConText = new Model1())
                    {
                        Mon mon = dbConText.Mon.FirstOrDefault(m => m.Ma == maMon);
                        if (mon != null)
                        {
                            mon.MaDanhMuc = int.Parse(cmbDanhMuc.SelectedValue.ToString());
                            mon.TenMon = txtTen.Text;
                            mon.Gia = decimal.Parse(txtGia.Text);
                            if (pictureBox1 != null)
                            {
                                if (File.Exists(mon.HinhAnh) && mon.HinhAnh != null)
                                {
                                    File.Delete(mon.HinhAnh);
                                }
                                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                                string imagePath = Path.Combine(parentDirectory, "Resources", mon.TenMon + ".png");
                                mon.HinhAnh = imagePath;
                                pictureBox1.Image.Save(imagePath);
                            }
                            dbConText.SaveChanges();
                            maMon = -1;
                        }
                    }
                    LoadMon();
                    ResetThongTinNhap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi" + ex.Message);
                }
            }
        }

        private void btnxoamonan_Click(object sender, EventArgs e)
        {
            if (maMon != -1)
            {
                try
                {
                    using (var dbConText = new Model1())
                    {
                        Mon mon = dbConText.Mon.FirstOrDefault(m => m.Ma == maMon);
                        if (mon != null)
                        {
                            dbConText.Mon.Remove(mon);
                            dbConText.SaveChanges();
                            maMon = -1;
                        }
                    }
                    LoadMon();
                    ResetThongTinNhap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi" + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFile.Title = "Chọn hình ảnh nước uống";
            openFile.Filter = "Hình ảnh (.jpg;.jpeg;.png)|*.jpg;*.jpeg;*.png|All files (*,*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string name = openFile.FileName;
                pictureBox1.Image = System.Drawing.Image.FromFile(name);
                pictureBox1.Refresh();
            }
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }
    }
}