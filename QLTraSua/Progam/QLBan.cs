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

namespace QLTraSua.Danh_Mục
{
    public partial class QLBan : Form
    {
        public QLBan()
        {
            InitializeComponent();
            this.Load += QLBan_Load;

            cmbTang.DisplayMember = "TenTang";
            cmbTang.ValueMember = "Ma";
            cmbTang.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void QLBan_Load(object sender, EventArgs e)
        {
            LoadBan();
            LoadTang();
        }

        private void LoadTang()
        {
            using (var dbcontext = new Model1())
            {
                cmbTang.DataSource = dbcontext.Tang.Select(x => new { x.TenTang, x.Ma }).ToList();
            }
        }

        private void LoadBan()
        {
            dgvban.Rows.Clear();
            using (var dbContext = new Model1())
            {
                foreach (var item in dbContext.Ban.Select(x => new { x.Ma, x.TenBan, x.Tang.TenTang }))
                {
                    int dong = dgvban.Rows.Add();
                    dgvban.Rows[dong].Cells["colMa"].Value = item.Ma;
                    dgvban.Rows[dong].Cells["colTen"].Value = item.TenBan;
                    dgvban.Rows[dong].Cells["colTang"].Value = item.TenTang;
                }
            }
        }

        private DataGridViewCell clickedCell;

        private void dgvban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell newClickedCell = dgvban.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (clickedCell == newClickedCell)
            {
                txtTen.Text = null;
                txtMa.Text = null;
                dgvban.ClearSelection();
                clickedCell = null;
            }
            else
            {
                clickedCell = newClickedCell;
                int dong = e.RowIndex;
                if (dong >= 0)
                {
                    //maMon = int.Parse(dgvMon.Rows[dong].Cells["colMa"].Value.ToString());
                    txtTen.Text = dgvban.Rows[dong].Cells["colTen"].Value.ToString();
                    txtMa.Text = dgvban.Rows[dong].Cells["colMa"].Value.ToString();
                    cmbTang.Text = dgvban.Rows[dong].Cells["colTang"].Value.ToString();
                }
            }
        }
    }
}
