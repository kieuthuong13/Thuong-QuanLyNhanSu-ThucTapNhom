namespace Thuong_QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANCONG")]
    public partial class PHANCONG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNhanVien { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDuAn { get; set; }

        public int? SoGioThamGia { get; set; }

        public virtual DUAN DUAN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
