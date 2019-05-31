CREATE TABLE TAIKHOAN(
	TaiKhoan varchar(100) primary key,
	PassWord varchar(100),
	Access nvarchar(100))

CREATE TABLE PHONGBAN(
	MaPhongBan int identity primary key,
	TenPhongBan nvarchar(100),
	MaTruongPhong int,
	DiaDiem nvarchar(100),
	NgayNhanChuc datetime)

CREATE TABLE NHANVIEN(
	MaNhanVien int identity primary key,
	TenNhanVien nvarchar(100),
	NgaySinh datetime,
	GioiTinh nvarchar(100),
	DiaChi nvarchar(100),
	MaNguoiGiamSat int,
	MaPhongBan int references PHONGBAN(MaPhongBan),
	Luong int,
	)

CREATE TABLE DUAN(
	MaDuAn int identity primary key,
	TenDuAn nvarchar(100),
	DiaDiem nvarchar(100),
	MaPhongBan int references PHONGBAN(MaPhongBan),
	TongSoGio int)

CREATE TABLE PHANCONG(
	MaNhanVien int references NHANVIEN(MaNhanVien),
	MaDuAn int references DUAN(MaDuAn),
	SoGioThamGia int,
	primary key (MaNhanVien, MaDuAn))

CREATE TABLE THANNHAN (
	MaNhanVien int references NHANVIEN(MaNhanVien),
	TenThanNhan nvarchar(100),
	GioiTinh nvarchar(100),
	NgaySinh datetime,
	QuanHe nvarchar(100),
	primary key (MaNhanVien, TenThanNhan)
	)

CREATE TABLE BAOHIEMYTE(
	MaBHYT int identity primary key,
	NoiDangKyKCB nvarchar(100),
	SoTien int,
	HieuLuc datetime,
	MaNhanVien int references NHANVIEN(MaNhanVien))

CREATE TABLE BAOHIEMXAHOI(
	MaBHXH int identity primary key,
	TrangThai int,
	SoTien int,
	MaNhanVien int references NHANVIEN(MaNhanVien))
