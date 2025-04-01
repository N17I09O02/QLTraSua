using QLTraSua.Danh_Mục;
using QLTraSua.Model;
using QLTraSua.Progam;
using QLTraSua.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace QLTraSua
{
    public partial class Form1 : Form
    {
        Button btndangchonban = null;
        Button btndangchonban2 = null;
        List<PhieuDatBan> DanhSachPhieuDatBan = new List<PhieuDatBan>();
        string SoMon = null;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            cmbKVban.DisplayMember = "TenTang";
            cmbKVban.ValueMember = "Ma";
            cmbKVban.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbdanhmucthucdon.DisplayMember = "TenDanhMuc";
            cmbdanhmucthucdon.ValueMember = "Ma";
            cmbdanhmucthucdon.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbdoiban.DisplayMember = "TenBan";
            cmbdoiban.ValueMember = "Ma";
            cmbdoiban.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbDTang.DisplayMember = "TenTang";
            cmbDTang.ValueMember = "Ma";
            cmbDTang.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvthucdondachon.DefaultCellStyle.BackColor = Color.White;
        }

        public void AnDMToolStripMenuItem()
        {
            DMToolStripMenuItem.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int selectedTangMa = Convert.ToInt32(cmbKVban.SelectedValue);
            KhoiTaoDanhSach(selectedTangMa);
            object selected = cmbdanhmucthucdon.SelectedValue;
            int selectedMaDanhMuc = Convert.ToInt32(selected);
            KhoiTaoDanhSachMon(selectedMaDanhMuc);
            using (var dbcontext = new Model1())
            {
                cmbKVban.DataSource = dbcontext.Tang.Select(x => new { x.TenTang, x.Ma }).ToList();
            }
            using (var dbcontext = new Model1())
            {
                cmbdanhmucthucdon.DataSource = dbcontext.DanhMuc.Select(x => new { x.TenDanhMuc, x.Ma }).ToList();
            }
            using (var dbcontext = new Model1())
            {
                cmbDTang.DataSource = dbcontext.Tang.Select(x => new { x.TenTang, x.Ma }).ToList();
            }
        }

        private void RoundButton(Button button, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            button.Region = new Region(path);
        }

        private void KhoiTaoDanhSach(int tangMa)
        {
            int x = 5, y = 3, i = 1;
            using (var dbcontext = new Model1())
            {
                foreach (var ban in dbcontext.Ban.Where(b => b.Tang.Ma == tangMa).ToList())
                {
                    TaoBan(ban.TenBan, ban.Ma, x, y);
                    if (i++ % 5 == 0)
                    {
                        y += 60;
                        x = 5;
                        continue;
                    }
                    x += 60;
                }
            }
        }

        private void TaoBan(string ten, int ma, int x, int y)
        {
            PhieuDatBan phieu = DanhSachPhieuDatBan.FirstOrDefault(z => z.MaBan == ma);
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(55, 55);
            btn.Text = ten;
            btn.Tag = ma;
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.ImageAlign = ContentAlignment.TopCenter;
            if (phieu == null)
            {
                btn.Image = Image.FromFile("../../Resources/outdoor-table.png");
            }
            else
            {
                btn.Image = Image.FromFile("../../Resources/ancestors (1).png");
            }
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            pnlban.Controls.Add(btn);
            RoundButton(btn, 20);
            btn.Click += btn_click;
        }

        private void KhoiTaoDanhSachMon(int madanhmuc)
        {
            int x = 5, y = 3, i = 1;
            using (var dbcontext = new Model1())
            {
                foreach (var mon in dbcontext.Mon.Where(b => b.MaDanhMuc == madanhmuc).ToList())
                {
                    //cmbDoiBan.Items.Add(ban);
                    TaoMon(mon.TenMon, mon.Ma, x, y);
                    if (i++ % 5 == 0)
                    {
                        y += 68;
                        x = 5;
                        continue;
                    }
                    x += 68;
                }
            }
        }

        private void TaoMon(string ten, int ma, int x, int y)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(64, 64);
            btn.Text = ten;
            btn.Tag = ma;
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.ImageAlign = ContentAlignment.TopCenter;
            using (var dbcontext = new Model1())
            {
                foreach (Mon mon in dbcontext.Mon.ToList())
                {
                    if(ten == mon.TenMon && mon.HinhAnh != null)
                    {
                        btn.Image = Image.FromFile(mon.HinhAnh);
                    }    
                }
            }
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            RoundButton(btn, 20);
            pnlmenu.Controls.Add(btn);
            btn.Click += btn2_click;
        }

        private void btn2_click(object sender, EventArgs e)
        {
            if (btndangchonban == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước!");
                return;
            }
            int maBan = int.Parse(btndangchonban.Tag.ToString());
            PhieuDatBan phieu = DanhSachPhieuDatBan.FirstOrDefault(x => x.MaBan == maBan);
            btndangchonban.Image = Image.FromFile("../../Resources/ancestors (1).png");
            if (btndangchonban != null)
            {
                Button btn = (Button)sender;
                if (btndangchonban2 == null){
                    btndangchonban2 = btn;
                }
                else if (btndangchonban2 != btn){
                    btndangchonban2 = btn;
                }
                else{
                    btndangchonban2 = btn;
                }
                if (phieu == null){
                    phieu = new PhieuDatBan();
                    phieu.MaBan = maBan;
                    DanhSachPhieuDatBan.Add(phieu);
                }    
                int maMon;
                if (btndangchonban2 != null && int.TryParse(btndangchonban2.Tag.ToString(), out maMon))
                {
                    using (var dbcontext = new Model1())
                    {
                        Mon thongTinMon = dbcontext.Mon.FirstOrDefault(x => x.Ma == maMon);
                        MonDat monDat = new MonDat()
                        {
                            MaMon = thongTinMon.Ma,
                            TenMon = thongTinMon.TenMon,
                            Gia = thongTinMon.Gia,
                            SoLuong = 1
                        };
                        phieu.GoiMon(monDat);
                        LoadDanhSachMon(phieu.DanhSachDatMon);
                    }
                }
            }
        }

        private void LoadDanhSachMon(List<MonDat> danhSachDatMon)
        {
            dgvthucdondachon.Rows.Clear();
            foreach (var item in danhSachDatMon)
            {
                int index = dgvthucdondachon.Rows.Add();
                dgvthucdondachon.Rows[index].Cells[0].Value = item.TenMon;
                dgvthucdondachon.Rows[index].Cells[1].Value = item.SoLuong;
                dgvthucdondachon.Rows[index].Cells[2].Value = item.Gia;
                dgvthucdondachon.Rows[index].Cells[3].Value = item.ThanhTien;
                txttong.Text = tien().ToString();
            }
            dgvthucdondachon.ClearSelection();
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btndangchonban == null)
            {
                btndangchonban = btn;
                btndangchonban.BackColor = Color.Pink;
            }
            else if (btndangchonban != btn)
            {
                btndangchonban.BackColor = Color.Transparent;
                btndangchonban.FlatAppearance.BorderSize = 0;
                btndangchonban = btn;
                btndangchonban.BackColor = Color.Pink;
            }
            else
            {
                btndangchonban.BackColor = Color.Transparent;
                btndangchonban.FlatAppearance.BorderSize = 0;
                btndangchonban = null;
            }
            if (btndangchonban != null)
            {
                int maBan = int.Parse(btndangchonban.Tag.ToString());
                PhieuDatBan phieu = DanhSachPhieuDatBan.FirstOrDefault(x => x.MaBan == maBan);
                if (phieu != null)
                {
                    LoadDanhSachMon(phieu.DanhSachDatMon);
                    txtkhachtra_TextChanged(sender, e);
                }
                else
                {
                    dgvthucdondachon.Rows.Clear();
                }
            }
        }

        private decimal tien()
        {
            int maBan = int.Parse(btndangchonban.Tag.ToString());
            PhieuDatBan phieu = DanhSachPhieuDatBan.FirstOrDefault(x => x.MaBan == maBan);
            return (phieu == null) ? 0 : phieu.DanhSachDatMon.Sum(x => x.ThanhTien);
        }

        private void cmbKVban_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTangMa = (int)cmbKVban.SelectedValue;
            pnlban.Controls.Clear();
            KhoiTaoDanhSach(selectedTangMa);

        }

        private void cmbdanhmucthucdon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMonMa = (int)cmbdanhmucthucdon.SelectedValue;
            pnlmenu.Controls.Clear();
            KhoiTaoDanhSachMon(selectedMonMa);
        }

        private void mónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLMon mMon = new QLMon();
            mMon.ShowDialog();
        }

        private void danhMụcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QLDanhMuc qLDanhMuc = new QLDanhMuc();
            qLDanhMuc.ShowDialog();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLBan qLBan = new QLBan();
            qLBan.ShowDialog();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            int x = 5, y = 3, i = 1;
            pnlmenu.Controls.Clear();

            using (var dbcontext = new Model1())
            {
                var keyword = RemoveDiacritics(txttimkiem.Text.ToLower());
                var allMon = dbcontext.Mon.ToList(); // Tải tất cả các mục từ cơ sở dữ liệu vào bộ nhớ

                var result = allMon.Where(b => RemoveDiacritics(b.TenMon.ToLower()).Contains(keyword)).ToList();

                foreach (var mon in result)
                {
                    TaoMon(mon.TenMon, mon.Ma, x, y);
                    if (i++ % 5 == 0)
                    {
                        y += 68;
                        x = 5;
                        continue;
                    }
                    x += 68;
                }
            }

            if (string.IsNullOrEmpty(txttimkiem.Text))
            {
                cmbdanhmucthucdon_SelectedIndexChanged(sender, e);
            }
        }

        private string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        private void cmbDTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTangMa = Convert.ToInt32(cmbDTang.SelectedValue);
            KhoiTaoDanhSach(selectedTangMa);
            cmbdoiban.Items.Clear();
            using (var dbcontext = new Model1())
            {
                foreach (var ban in dbcontext.Ban.Where(b => b.Tang.Ma == selectedTangMa).ToList())
                {
                    cmbdoiban.Items.Add(ban);
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap l = new DangNhap();
            l.Show();
            this.Hide();
        }
        
        private void dgvthucdondachon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    dgvthucdondachon.ClearSelection();
                    dgvthucdondachon.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    int x = dgvthucdondachon.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Left;
                    int y = dgvthucdondachon.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Bottom;
                    Point cellPosition = new Point(x, y);
                    Point menuPosition = dgvthucdondachon.PointToScreen(cellPosition);
                    CTTMenu.Show(menuPosition);
                }
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SoMon)){
                int maBan = int.Parse(btndangchonban.Tag.ToString());
                PhieuDatBan phieu = DanhSachPhieuDatBan.FirstOrDefault(x => x.MaBan == maBan);
                if (phieu != null){
                    MonDat monDat = phieu.DanhSachDatMon.FirstOrDefault(x => x.TenMon == SoMon);
                    if (monDat != null){
                        phieu.XoaMon(monDat);
                        if(phieu.DanhSachDatMon.Count < 1)
                        {
                            MessageBox.Show("da xoa");
                            DanhSachPhieuDatBan.Remove(phieu);
                            dgvthucdondachon.Rows.Clear();
                            btndangchonban.Image = Image.FromFile("../../Resources/outdoor-table.png");
                        }
                        else
                            LoadDanhSachMon(phieu.DanhSachDatMon);
                    }
                }
            }
            SoMon = null;
        }

        private void dgvthucdondachon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0){
                DataGridView dgv = (DataGridView)sender;
                DataGridViewCell cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if(dgvthucdondachon.Rows[dong].Cells["colTen"].Value != null && !string.IsNullOrEmpty(dgvthucdondachon.Rows[dong].Cells["colTen"].Value.ToString()))
                    SoMon = dgvthucdondachon.Rows[dong].Cells["colTen"].Value.ToString();
            }
        }

        private void dgvthucdondachon_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1){
                DataGridViewRow editedRow = dgvthucdondachon.Rows[e.RowIndex];
                if(int.Parse(editedRow.Cells[1].Value.ToString()) >= 1)
                {
                    int soLuong = int.Parse(editedRow.Cells[1].Value.ToString());
                    int maBan = int.Parse(btndangchonban.Tag.ToString());
                    PhieuDatBan phieu = DanhSachPhieuDatBan.FirstOrDefault(x => x.MaBan == maBan);
                    using (var dbcontext = new Model1())
                    {
                        Mon thongTinMon = dbcontext.Mon.FirstOrDefault(x => x.TenMon == SoMon);
                        MonDat monDat = new MonDat()
                        {
                            MaMon = thongTinMon.Ma,
                            TenMon = thongTinMon.TenMon,
                            Gia = thongTinMon.Gia,
                            SoLuong = soLuong
                        };
                        phieu.GoiMon(monDat);
                        LoadDanhSachMon(phieu.DanhSachDatMon);
                    }
                }
                else
                    xóaToolStripMenuItem_Click(sender, e);
            }
            SoMon = null;
        }

        private void txtkhachtra_TextChanged(object sender, EventArgs e)
        {
            if(txtkhachtra.Text != "")
            {
                decimal tong = tien();
                txttienthua.Text = (int.Parse(txtkhachtra.Text)-tong).ToString();
            }
            else
                txttienthua.Text = "";
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTaiKhoan taiKhoan = new QLTaiKhoan();
            taiKhoan.ShowDialog();
        }
    }
}
