namespace Thuong_QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            BAOHIEMXAHOIs = new HashSet<BAOHIEMXAHOI>();
            BAOHIEMYTEs = new HashSet<BAOHIEMYTE>();
            PHANCONGs = new HashSet<PHANCONG>();
            THANNHANs = new HashSet<THANNHAN>();
        }

        [Key]
        public int MaNhanVien { get; set; }

        [StringLength(100)]
        public string TenNhanVien { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(100)]
        public string GioiTinh { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        public int? MaNguoiGiamSat { get; set; }

        public int? MaPhongBan { get; set; }

        public int? Luong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOHIEMXAHOI> BAOHIEMXAHOIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOHIEMYTE> BAOHIEMYTEs { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONG> PHANCONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANNHAN> THANNHANs { get; set; }
    }
}
