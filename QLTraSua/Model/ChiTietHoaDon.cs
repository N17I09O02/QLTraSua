namespace QLTraSua.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        public int Ma { get; set; }

        public int MaHoaDon { get; set; }

        public int MaMon { get; set; }

        public int SoLuong { get; set; }

        public decimal ThanhTien { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual Mon Mon { get; set; }
    }
}
