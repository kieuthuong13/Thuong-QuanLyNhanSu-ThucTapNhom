namespace Thuong_QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHANVIEN_CONGTY
    {
        public int? MaCongTy { get; set; }

        public int? MaNhanVien { get; set; }

        [Key]
        public DateTime NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        [StringLength(100)]
        public string ChucVu { get; set; }

        public int? Luong { get; set; }

        public virtual CONGTY CONGTY { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
