-- Account
-- Thong tin sanh
-- Thuc don
-- Dich vu
-- thong tin khach hang
-- thong tin dat tiec
-- lap hoa don
-- nhan vien 
-- bao cao

USE Marriage_Hall
GO

--Tai Khoan
CREATE TABLE TaiKhoan
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	TenDangNhap NVARCHAR(100) NOT NULL,
	MatKhau NVARCHAR(1000) NOT NULL
)
GO
INSERT INTO TaiKhoan VALUES (N'ThaiDuong', N'1')
INSERT INTO TaiKhoan VALUES (N'HuyenThoai', N'2')
INSERT INTO TaiKhoan VALUES (N'ThuThien', N'3')
INSERT INTO TaiKhoan VALUES (N'DuyTan', N'4')
GO

-- ThongTinSanh
CREATE TABLE ThongTinSanh
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	LoaiSanh NVARCHAR(100),
	TenSanh NVARCHAR(100) NOT NULL DEFAULT N'Chưa Đặt Tên',
	SoLuongBanToiDa INT NOT NULL,
	DonGiaToiThieu MONEY NOT NULL,
	GhiChu NVARCHAR(100) DEFAULT N'Trống',
	TiSoPhat FLOAT DEFAULT 0.01
)
GO

INSERT INTO ThongTinSanh VALUES (N'Loai A', N'Kim Cương', 500, 50000000, N'Không', 0.01)
INSERT INTO ThongTinSanh VALUES (N'Loai B', N'Bạch Kim', 450, 45000000, N'Không', 0.01)
INSERT INTO ThongTinSanh VALUES (N'Loai C', N'Vàng', 400, 40000000, N'Không', 0.01)
INSERT INTO ThongTinSanh VALUES (N'Loai D', N'Bạc', 350, 35000000, N'Không', 0.01)
INSERT INTO ThongTinSanh VALUES (N'Loai E', N'Đồng', 300, 30000000, N'Không', 0.01)
GO

-- ThucDon
CREATE TABLE ThucDon
(
	id INT IDENTITY PRIMARY KEY,
	MaThucDon VARCHAR(100),
	MonKhaiVi NVARCHAR(100) NOT NULL,
	MonChinh1 NVARCHAR(100) NOT NULL,
	MonChinh2 NVARCHAR(100) NOT NULL,
	MonChinh3 NVARCHAR(100) NOT NULL,
	Lau NVARCHAR(100) NOT NULL,
	TrangMieng NVARCHAR(100) NOT NULL,
	Bia NVARCHAR(100) NOT NULL,
	NuocNgot NVARCHAR(100) NOT NULL,
	GiaThucDon MONEY NOT NULL
)
GO

INSERT INTO ThucDon VALUES (N'TĐ 1', N'Chả Giò Rế Hà Nội', N'Gà Ấp Chảo + Bánh Bao', N'Dê Hấp Lá Tía Tô', N'Tôm Sông Rang Muối', N'Lẩu Thái Hải Sản', N'Thanh Nhiệt Sâm Sâm', N'Heniken', N'Pepsi', 2000000)
INSERT INTO ThucDon VALUES (N'TĐ 2', N'Suop Cua Gà Xé', N'Gà Bó Xôi', N'Bò Nấu Đậu + Bánh Mì', N'Vịt Quay Bắc Kinh', N'Lẩu Nắm Hải Sản', N'Chè Hạt Sen', N'Tiger Bạc', N'Trà Xanh', 1800000)
INSERT INTO ThucDon VALUES (N'TĐ 3', N'Gỏi Gó Sen Tôm Thit', N'Gà Hấp Hành + Xôi', N'Cá Điêu Hồng Chưng Tương', N'Chim Cút Roti + Bánh Mì', N'Lẩu Thái Hải Sản', N'Chè Hạt Sen', N'Heniken', N'Cocacola', 2000000)
INSERT INTO ThucDon VALUES (N'TĐ 4', N'Suop Hải Sản Nấm Tuyết', N'Gà Nấu Lagu + Bánh Mì', N'Cá Điêu Hồng Hấp HongKong', N'Gà Bó Xôi', N'Lẩu Cua Đồng', N'Rau Câu Ngũ Sắc', N'Tiger', N'Pepsi', 1800000)
INSERT INTO ThucDon VALUES (N'TĐ 5', N'Chả Giò Venus', N'Chim Cút Roti + Bánh Mì', N'Tôm Sông Rang Muối', N'Cá Điêu Hồng Chưng Tương', N'Lẩu Cá Bớp', N'Chè Khúc Bạch', N'Heniken', N'Pepsi', 2000000)
GO

-- DichVu
CREATE TABLE DichVu
(
	id INT IDENTITY PRIMARY KEY,
	MaDichVu VARCHAR(100),
	Ruou NVARCHAR(100),
	BanhKem NVARCHAR(100),
	Mc NVARCHAR(100),
	BanNhac NVARCHAR(100),
	CaSi NVARCHAR(100),
	Dj NVARCHAR(100),
	GiaDichVu MONEY
)
GO

INSERT INTO DichVu VALUES (N'DV1', N'Rượu Vang', N'2 Tầng', N'Minh Anh', N'Band 1', N'NhưYến', N'Dan', 1000000)
INSERT INTO DichVu VALUES (N'DV2', N'Rượu Vang', N'3 Tầng', N'Ngọc Như', N'Band 2', N'NgọcBích', N'Black', 2000000)
INSERT INTO DichVu VALUES (N'DV3', N'Rượu Vang', N'4 Tầng', N'Anh Tuấn', N'Band 3', N'HoàngNgọc', N'DN', 3000000)
INSERT INTO DichVu VALUES (N'DV4', N'Rượu Vang', N'5 Tầng', N'Tuấn Khang', N'Band 4', N'NguyênKhang', N'Mie', 4000000)
GO

-- Tiec
CREATE TABLE Tiec
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	Ca NVARCHAR(20),
	TrangThai NVARCHAR(100) DEFAULT N'Chưa sẵn sàng'
)
GO

INSERT INTO Tiec VALUES (N'Trua', N'Chưa sẵn sàng')
INSERT INTO Tiec VALUES (N'Toi', N'Sẵn sàng')
GO

-- ThongTinKhachHang
CREATE TABLE ThongTinKhachHang
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	MaKhachHang AS RIGHT('KH' + CAST(id AS VARCHAR(7)), 7) PERSISTED,
	NgayLap DATE NOT NULL,
	TenKhachHang NVARCHAR(100) NOT NULL,
	TenChuRe NVARCHAR(100) NOT NULL,
	TenCoDau NVARCHAR(100) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	DienThoai NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	NgayToChuc DATE NOT NULL,
	TienCoc MONEY
)
GO

INSERT INTO ThongTinKhachHang VALUES ('2018-12-03', N'Nguyễn Thành Tài', N'Nguyễn Thành Tài', N'Hoàng Thị Bích Ngọc', N'Thị Trấn Bến Cầu, Huyện Bến Cầu, Tỉnh Tây Ninh', N'0169356263', N'nguyentai23998@gmail.com', '2018-12-12', 5000000)
INSERT INTO ThongTinKhachHang VALUES ('2018-10-04', N'Hà Như Ý', N'Hà Như Ý', N'Nguyễn Thị Tố Như', N'Phường Linh Trung, Quận Thủ Đức, Tp.Hồ Chí Minh', N'0162345347', N'nhuy1998@gmail.com', '2018-12-12', 4000000)
INSERT INTO ThongTinKhachHang VALUES ('2018-10-02', N'Hà Như', N'Hà Như', N'Nguyễn Thị Tố', N'Phường Linh Trung, Quận Thủ Đức, Tp.Hồ Chí Minh', N'01623453', N'nhu1998@gmail.com', '2018-12-01', 3000000)
GO

-- NhanVienTiepTan
CREATE TABLE NhanVienTiepTan
(
	id INT PRIMARY KEY,
	MaNhanVien VARCHAR(100),
	HoTen NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh BIT DEFAULT 1,
	DiaChi NVARCHAR(100),
	DienThoai NVARCHAR(100),
	Email NVARCHAR(100),
	TenDangNhap NVARCHAR(100),
	MatKhau NVARCHAR(100),
	NgayVaoLam DATE NOT NULL,
	CaLam NVARCHAR(20),
	Luong MONEY
)
GO

INSERT INTO NhanVienTiepTan VALUES (1, N'NV1', N'Nguyễn Nhật Quang', '1998-12-23', 1, N'Hoà Thành, Tây Ninh', N'0978421132', N'quangnguyen@gmail.com', N'quang123', N'123', '2018-10-09', N'Tối', 4000000)
INSERT INTO NhanVienTiepTan VALUES (2, N'NV2', N'Tran Thanh Tuyen', '1998-09-22', 0, N'Hoà Thành, Tây Ninh', N'0978421232', N'tuyennguyen@gmail.com', N'tuyen123', N'123', '2018-10-09', N'Trưa', 4000000)
INSERT INTO NhanVienTiepTan VALUES (3, N'NV3', N'Tran Thanh', '1998-02-23', 0, N'Hoà Thành, Tây Ninh', N'097842113', N'thanhnguyen@gmail.com', N'thanh123', N'123', '2018-10-09', N'Tối', 4000000)
GO

-- ThongTinDatTiec
CREATE TABLE ThongTinDatTiec
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	MaDatTiec AS RIGHT('MT' + CAST(id AS VARCHAR(7)), 7) PERSISTED,
	idTiec INT,
	idKhachHang INT,
	SoLuongBan INT,
	idThucDon INT,
	idDichVu INT,
	idNhanVien INT,
	CONSTRAINT FK_ThongTinDatTiec_Tiec FOREIGN KEY (idTiec) REFERENCES Tiec(id),
	CONSTRAINT FK_ThongTinDatTiec_ThongTinKhachHang FOREIGN KEY (idKhachHang) REFERENCES ThongTinKhachHang(id),
	CONSTRAINT FK_ThongTinDatTiec_ThucDon FOREIGN KEY (idThucDon) REFERENCES ThucDon(id),
	CONSTRAINT FK_ThongTinDatTiec_DichVu FOREIGN KEY (idDichVu) REFERENCES DichVu(id),
	CONSTRAINT FK_ThongTinDatTiec_NhanVienTiepTan FOREIGN KEY (idNhanVien) REFERENCES NhanVienTiepTan(id)
)
GO

INSERT INTO ThongTinDatTiec (idTiec, idKhachHang, SoLuongBan, idThucDon, idDichVu, idNhanVien) VALUES (2, 1, 60, 1, 1, 1)
INSERT INTO ThongTinDatTiec (idTiec, idKhachHang, SoLuongBan, idThucDon, idDichVu, idNhanVien) VALUES (2, 2, 50, 2, 2, 2)
INSERT INTO ThongTinDatTiec (idTiec, idKhachHang, SoLuongBan, idThucDon, idDichVu, idNhanVien) VALUES (1, 3, 40, 3, 3, 3)
GO

-- LapHoaDon
CREATE TABLE LapHoaDon
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	MaHoaDon AS RIGHT('HD' + CAST(id AS VARCHAR(7)), 7) PERSISTED,
	idDatTiec INT,
	NgayLap DATE NOT NULL,
	CONSTRAINT FK_LapHoaDon_ThongTinDatTiec FOREIGN KEY (idDatTiec) REFERENCES ThongTinDatTiec(id)
)
GO

INSERT INTO LapHoaDon (idDatTiec, NgayLap) VALUES (1, '2018-10-11')
INSERT INTO LapHoaDon (idDatTiec, NgayLap) VALUES (2, '2018-10-12')
INSERT INTO LapHoaDon (idDatTiec, NgayLap) VALUES (3, '2018-10-13')
GO

-- BaoCao
CREATE TABLE BaoCao
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	MaBaoCao AS RIGHT('BC' + CAST(id AS VARCHAR(7)), 7) PERSISTED,
	idHoaDon INT,
	CONSTRAINT FK_BaoCao_LapHoaDon FOREIGN KEY (idHoaDon) REFERENCES LapHoaDon(id)
)
GO

INSERT INTO BaoCao (idHoaDon) VALUES (1)
INSERT INTO BaoCao (idHoaDon) VALUES (2)
INSERT INTO BaoCao (idHoaDon) VALUES (3)
GO
