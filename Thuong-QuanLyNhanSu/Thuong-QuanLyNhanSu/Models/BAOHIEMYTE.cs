namespace Thuong_QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAOHIEMYTE")]
    public partial class BAOHIEMYTE
    {
        [Key]
        public int MaBHYT { get; set; }

        [StringLength(100)]
        public string NoiDangKyKCB { get; set; }

        public int? SoTien { get; set; }

        public DateTime? HieuLuc { get; set; }

        public int? MaNhanVien { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
