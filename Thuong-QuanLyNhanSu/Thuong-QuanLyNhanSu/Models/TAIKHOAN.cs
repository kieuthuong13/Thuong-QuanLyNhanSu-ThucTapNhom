namespace Thuong_QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [Column("TaiKhoan")]
        [StringLength(100)]
        public string TaiKhoan1 { get; set; }

        [StringLength(100)]
        public string PassWord { get; set; }

        [StringLength(100)]
        public string Access { get; set; }
    }
}
