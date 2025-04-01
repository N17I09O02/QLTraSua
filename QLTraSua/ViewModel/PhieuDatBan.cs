using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTraSua.ViewModel
{
    internal class PhieuDatBan
    {
        public int MaBan { get; set; }

        public int PhanTramGiamGia { get; set; }

        public List<MonDat> DanhSachDatMon { get; set; }

        public PhieuDatBan()
        {
            DanhSachDatMon = new List<MonDat>();
            PhanTramGiamGia = 0;
        }

        //Phuong Thuc Goi Mon
        public void GoiMon(MonDat mon)
        {
            //Kiem tra mon co ton tai trong danh sach goi mon hay khong?
            MonDat m = DanhSachDatMon.FirstOrDefault(x => x.MaMon == mon.MaMon);
            if (m != null)
            {
                m.SoLuong += mon.SoLuong;
            }
            else
                DanhSachDatMon.Add(mon);
        }

        public void XoaMon(MonDat mondat)
        {
            MonDat m = DanhSachDatMon.FirstOrDefault(x => x.MaMon == mondat.MaMon);
            if (m != null)
            {
                DanhSachDatMon.Remove(mondat);
            }
        }
    }
}
