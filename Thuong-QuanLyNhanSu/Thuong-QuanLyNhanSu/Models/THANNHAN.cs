namespace Thuong_QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THANNHAN")]
    public partial class THANNHAN
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNhanVien { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string TenThanNhan { get; set; }

        [StringLength(100)]
        public string GioiTinh { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(100)]
        public string QuanHe { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
