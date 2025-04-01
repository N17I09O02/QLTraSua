namespace QLTraSua.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mon")]
    public partial class Mon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mon()
        {
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        public int Ma { get; set; }

        public decimal Gia { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMon { get; set; }

        public int MaDanhMuc { get; set; }

        [StringLength(200)]
        public string HinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
