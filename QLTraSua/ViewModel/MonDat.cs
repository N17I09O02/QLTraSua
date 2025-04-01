using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTraSua.ViewModel
{
    internal class MonDat
    {
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
        public decimal ThanhTien { get { return SoLuong * Gia; } }
        public string HinhAnh { get; set; } 
        public string TenDanhMuc { get; set; }
    }
}
