namespace Thuong_QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAOHIEMXAHOI")]
    public partial class BAOHIEMXAHOI
    {
        [Key]
        public int MaBHXH { get; set; }

        public int? TrangThai { get; set; }

        public int? SoTien { get; set; }

        public int? MaNhanVien { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
