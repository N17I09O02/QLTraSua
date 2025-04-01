namespace QLTraSua.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TKDangNhap")]
    public partial class TKDangNhap
    {
        [Key]
        public int Ma { get; set; }

        [Required]
        [StringLength(100)]
        public string TaiKhoan { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(100)]
        public string ChucVu { get; set; }

        [Required]
        [StringLength(100)]
        public string TenNV { get; set; }
    }
}
