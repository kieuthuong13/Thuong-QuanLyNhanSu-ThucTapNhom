namespace Thuong_QuanLyNhanSu.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyNhanVien : DbContext
    {
        public QuanLyNhanVien()
            : base("name=QuanLyNhanVien")
        {
        }

        public virtual DbSet<BAOHIEMXAHOI> BAOHIEMXAHOIs { get; set; }
        public virtual DbSet<BAOHIEMYTE> BAOHIEMYTEs { get; set; }
        public virtual DbSet<DUAN> DUANs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHANCONG> PHANCONGs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THANNHAN> THANNHANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DUAN>()
                .HasMany(e => e.PHANCONGs)
                .WithRequired(e => e.DUAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHANCONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.THANNHANs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.TaiKhoan1)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.PassWord)
                .IsUnicode(false);
        }
    }
}
