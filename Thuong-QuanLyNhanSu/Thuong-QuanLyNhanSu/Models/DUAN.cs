namespace Thuong_QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DUAN")]
    public partial class DUAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DUAN()
        {
            PHANCONGs = new HashSet<PHANCONG>();
        }

        [Key]
        public int MaDuAn { get; set; }

        [StringLength(100)]
        public string TenDuAn { get; set; }

        [StringLength(100)]
        public string DiaDiem { get; set; }

        public int? MaPhongBan { get; set; }

        public int? TongSoGio { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONG> PHANCONGs { get; set; }
    }
}
