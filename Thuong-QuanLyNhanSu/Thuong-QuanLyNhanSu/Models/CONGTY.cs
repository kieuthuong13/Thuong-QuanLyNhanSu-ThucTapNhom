namespace Thuong_QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONGTY")]
    public partial class CONGTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONGTY()
        {
            NHANVIEN_CONGTY = new HashSet<NHANVIEN_CONGTY>();
        }

        [Key]
        public int MaCongTy { get; set; }

        [StringLength(100)]
        public string TenCongTy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_CONGTY> NHANVIEN_CONGTY { get; set; }
    }
}
