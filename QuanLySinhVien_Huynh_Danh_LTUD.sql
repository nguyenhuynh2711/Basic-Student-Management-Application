-- Tạo database cơ sở dữ liệu cho đồ án Quản Lý Sinh Viên

create database Huynh_Danh_QuanLySinhVien_LTUD

-- Tạo bảng Khoa
CREATE TABLE Khoa (
    MaKhoa CHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200),
    DienThoai VARCHAR(15)
);

-- Tạo bảng SinhVien
CREATE TABLE SinhVien (
    MaSV CHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')), -- Giới tính chỉ cho phép "Nam" hoặc "Nữ"
    DiaChi NVARCHAR(200),
    MaKhoa CHAR(10),
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- Tạo bảng MonHoc
CREATE TABLE MonHoc (
    MaMon CHAR(10) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,
    SoTinChi INT NOT NULL,
    MaKhoa CHAR(10),
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- Tạo bảng KetQua
CREATE TABLE KetQua (
    MaSV CHAR(10),
    MaMon CHAR(10),
    Diem DECIMAL(4, 2),
    HocKy NVARCHAR(20),
    PRIMARY KEY (MaSV, MaMon),
    FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
    FOREIGN KEY (MaMon) REFERENCES MonHoc(MaMon)
);

-- Tạo bảng GiaoVien
CREATE TABLE GiaoVien (
    MaGV CHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')), -- Giới tính chỉ cho phép "Nam" hoặc "Nữ"
    MaKhoa CHAR(10),
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- THÊM DỮ LIỆU VÀO CÁC BẢNG --
set dateformat dmy

-- Thêm dữ liệu vào bảng Khoa
INSERT INTO Khoa (MaKhoa, TenKhoa, DiaChi, DienThoai)
VALUES
('CNTT', N'Công Nghệ Thông Tin', N'123 Lê Lợi, TP.HCM', '0281234567'),
('QTKD', N'Quản Trị Kinh Doanh', N'456 Nguyễn Trãi, Hà Nội', '0247654321'),
('KT', N'Kế Toán', N'789 Trần Hưng Đạo, Đà Nẵng', '0511231234'),
('LUAT', N'Luật', N'111 Hùng Vương, Cần Thơ', '0291001234'),
('NH', N'Ngân Hàng', N'222 Lý Tự Trọng, Hà Nội', '0244567890'),
('XD', N'Xây Dựng', N'333 Lê Duẩn, TP.HCM', '0289998888'),
('DUOC', N'Dược Học', N'444 Tô Hiến Thành, Huế', '0545671234'),
('YH', N'Y Học', N'555 Quang Trung, Hà Nội', '0249876543'),
('MT', N'Môi Trường', N'666 Phạm Văn Đồng, Đà Nẵng', '0513456789'),
('DL', N'Du Lịch', N'777 Nguyễn Văn Linh, TP.HCM', '0281122334'),
('SP', N'Sư Phạm', N'888 Trần Cao Vân, Hà Nội', '0243344556'),
('KH', N'Khoa Học', N'999 Phan Đình Phùng, Đà Lạt', '0631234567'),
('TA', N'Tiếng Anh', N'123B Bạch Đằng, Hà Nội', '0245566778'),
('TC', N'Tài Chính', N'456B Láng Hạ, Hà Nội', '0242233445'),
('VT', N'Viễn Thông', N'789B Trường Sơn, TP.HCM', '0283344556');

-- Thêm dữ liệu vào bảng SinhVien
INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaKhoa)
VALUES
('SV001', N'Nguyễn Văn A', '2000-05-15', N'Nam', N'12 Lý Thái Tổ, TP.HCM', 'CNTT'),
('SV002', N'Lê Thị B', '2001-09-25', N'Nữ', N'34 Phan Chu Trinh, Hà Nội', 'QTKD'),
('SV003', N'Trần Văn C', '1999-12-30', N'Nam', N'56 Lê Lợi, Đà Nẵng', 'KT'),
('SV004', N'Phạm Thị D', '2002-03-12', N'Nữ', N'78 Trần Hưng Đạo, TP.HCM', 'LUAT'),
('SV005', N'Ngô Thanh E', '2001-11-20', N'Nữ', N'90 Lý Chính Thắng, Hà Nội', 'NH'),
('SV006', N'Bùi Văn F', '2000-07-25', N'Nam', N'45 Lê Văn Việt, Đà Nẵng', 'XD'),
('SV007', N'Hoàng Thị G', '1998-06-10', N'Nữ', N'23 Quang Trung, TP.HCM', 'DUOC'),
('SV008', N'Vũ Văn H', '1999-03-15', N'Nam', N'67 Nguyễn Huệ, Hà Nội', 'YH'),
('SV009', N'Đỗ Thị I', '2001-08-05', N'Nữ', N'88 Phan Văn Trị, Đà Nẵng', 'MT'),
('SV010', N'Phan Minh J', '2000-02-20', N'Nam', N'12 Nguyễn Thị Minh Khai, TP.HCM', 'DL'),
('SV011', N'Nguyễn Thị K', '2002-10-15', N'Nữ', N'56 Võ Văn Kiệt, Hà Nội', 'SP'),
('SV012', N'Trần Văn L', '2000-01-10', N'Nam', N'89 Lê Thánh Tôn, Đà Lạt', 'KH'),
('SV013', N'Phạm Thị M', '1998-09-30', N'Nữ', N'12A Hùng Vương, Hà Nội', 'TA'),
('SV014', N'Lê Văn N', '1999-04-25', N'Nam', N'33B Trần Phú, Hà Nội', 'TC'),
('SV015', N'Trần Thị O', '2001-12-10', N'Nữ', N'99A Nguyễn Văn Trỗi, TP.HCM', 'VT');

-- Thêm dữ liệu vào bảng MonHoc
INSERT INTO MonHoc (MaMon, TenMon, SoTinChi, MaKhoa)
VALUES
('MH001', N'Lập Trình Cơ Bản', 3, 'CNTT'),
('MH002', N'Trí Tuệ Nhân Tạo', 4, 'CNTT'),
('MH003', N'Cơ Sở Dữ Liệu', 3, 'CNTT'),
('MH004', N'Kế Toán Quản Trị', 2, 'KT'),
('MH005', N'Quản Lý Dự Án', 3, 'QTKD'),
('MH006', N'Nguyên Lý Kế Toán', 2, 'KT'),
('MH007', N'Luật Hình Sự', 3, 'LUAT'),
('MH008', N'Tiếng Anh Thương Mại', 3, 'TA'),
('MH009', N'Tiếng Anh Giao Tiếp', 2, 'TA'),
('MH010', N'Hóa Dược', 4, 'DUOC'),
('MH011', N'Tài Chính Quốc Tế', 3, 'TC'),
('MH012', N'Xây Dựng Cầu Đường', 4, 'XD'),
('MH013', N'Lý Thuyết Tài Chính', 3, 'TC'),
('MH014', N'Kinh Tế Vi Mô', 3, 'QTKD'),
('MH015', N'Hệ Thống Viễn Thông', 3, 'VT');

-- Thêm dữ liệu vào bảng KetQua
INSERT INTO KetQua (MaSV, MaMon, Diem, HocKy)
VALUES
('SV001', 'MH001', 8.5, N'Học Kỳ 1'),
('SV001', 'MH002', 9.0, N'Học Kỳ 2'),
('SV002', 'MH005', 7.5, N'Học Kỳ 1'),
('SV003', 'MH004', 6.0, N'Học Kỳ 1'),
('SV004', 'MH007', 7.5, N'Học Kỳ 1'),
('SV005', 'MH011', 8.0, N'Học Kỳ 1'),
('SV006', 'MH012', 7.0, N'Học Kỳ 1'),
('SV007', 'MH010', 8.5, N'Học Kỳ 1'),
('SV008', 'MH001', 6.5, N'Học Kỳ 2'),
('SV009', 'MH015', 7.5, N'Học Kỳ 1'),
('SV010', 'MH008', 9.0, N'Học Kỳ 1'),
('SV011', 'MH009', 8.0, N'Học Kỳ 1'),
('SV012', 'MH013', 7.0, N'Học Kỳ 1'),
('SV013', 'MH014', 7.5, N'Học Kỳ 2'),
('SV014', 'MH006', 8.0, N'Học Kỳ 1');

-- Thêm dữ liệu vào bảng GiaoVien
INSERT INTO GiaoVien (MaGV, HoTen, NgaySinh, GioiTinh, MaKhoa)
VALUES
('GV001', N'Nguyễn Thị Hồng', '1980-07-20', N'Nữ', 'CNTT'),
('GV002', N'Phạm Văn Minh', '1975-03-15', N'Nam', 'QTKD'),
('GV003', N'Lê Thị Hoa', '1982-11-05', N'Nữ', 'KT'),
('GV004', N'Trần Đình Phúc', '1985-01-25', N'Nam', 'LUAT'),
('GV005', N'Nguyễn Văn Quang', '1983-08-10', N'Nam', 'NH'),
('GV006', N'Trần Thị Vân', '1984-04-05', N'Nữ', 'XD'),
('GV007', N'Hoàng Minh Đức', '1980-10-22', N'Nam', 'DUOC'),
('GV008', N'Nguyễn Thị Mai', '1981-06-18', N'Nữ', 'YH'),
('GV009', N'Lê Văn Hải', '1982-09-01', N'Nam', 'MT'),
('GV010', N'Phạm Thị Lan', '1980-11-11', N'Nữ', 'DL'),
('GV011', N'Nguyễn Văn Nam', '1979-07-30', N'Nam', 'SP'),
('GV012', N'Trần Thị Ngọc', '1981-05-25', N'Nữ', 'KH'),
('GV013', N'Lê Văn An', '1983-01-20', N'Nam', 'TA'),
('GV014', N'Nguyễn Thị Duyên', '1980-12-10', N'Nữ', 'TC'),
('GV015', N'Hoàng Văn Bình', '1985-09-15', N'Nam', 'VT');

-- Display --
SELECT * FROM Khoa;
SELECT * FROM SinhVien;
SELECT * FROM MonHoc;
SELECT * FROM KetQua;
SELECT * FROM GiaoVien;

-- Tạo store cho các chức năng

--------- Các Store hiển thị danh sách ----------
-- Hiển thị danh sách Khoa
create proc sp_Khoa
as
SELECT * FROM Khoa
--- test
exec sp_Khoa

-- Hiển thị danh sách SinhVien
create proc sp_SinhVien
as
SELECT * FROM SinhVien
--- test
exec sp_SinhVien

-- Hiển thị danh sách MonHoc
create proc sp_MonHoc
as
SELECT * FROM MonHoc
--- test
exec sp_MonHoc

-- Hiển thị danh sách KetQua
create proc sp_KetQua
as
SELECT * FROM KetQua
--- test
exec sp_KetQua

-- Hiển thị danh sách GiaoVien
create proc sp_GiaoVien
as
SELECT * FROM GiaoVien
--- test
exec sp_GiaoVien
----------------------------------------------------------



--------- Các Store Thêm vào danh sách các bảng ----------
-- Thêm vào bảng Khoa
create proc sp_themKhoa(@maKhoa CHAR(6), @tenKhoa NVARCHAR(30), @diaChi NVARCHAR(100) = NULL, @dienThoai VARCHAR(15) = NULL, @trangThai BIT = 1) -- Tham số mặc định Null có thể bỏ qua nếu không truyền giá trị
as
    INSERT INTO Khoa VALUES (@maKhoa, @tenKhoa, @diaChi, @dienThoai,@trangThai);
-- Test
exec sp_themKhoa 'DH', N'Đồ Họa', N'123 Đường ABC', '0123456789';
select * from Khoa

-- Thêm vào bảng SinhVien
create proc sp_themSinhVien( @maSV CHAR(6), @hoTen NVARCHAR(50), @ngaySinh DATE, @gioiTinh NVARCHAR(10), @diaChi NVARCHAR(100) = NULL, @maKhoa CHAR(6),@trangThai BIT = 1) -- Tham số mặc định Null có thể bỏ qua nếu không truyền giá trị
as
    INSERT INTO SinhVien VALUES (@maSV, @hoTen, @ngaySinh, @gioiTinh, @diaChi, @maKhoa,@trangThai);
-- Test
exec sp_themSinhVien 'SV016', N'Nguyễn Văn B', '2001-01-01', N'Nam', N'456 Đường XYZ', 'CNTT';
select * from SinhVien


-- Thêm vào bảng MonHoc
create proc sp_themMonHoc (@maMon CHAR(6), @tenMon NVARCHAR(50), @soTinChi INT, @maKhoa CHAR(6), @trangThai BIT = 1)
as
	INSERT INTO MonHoc VALUES (@maMon, @tenMon, @soTinChi, @maKhoa,@trangThai);
-- Test
exec sp_themMonHoc 'MH017', N'Lập Trình Ứng Dụng', 3, 'CNTT';
select * from MonHoc

-- Thêm vào bảng KetQua
create proc sp_themKetQua (@maSV CHAR(6), @maMon CHAR(6), @diem DECIMAL(4, 2), @hocKy NVARCHAR(20), @trangThai BIT = 1)
as
    INSERT INTO KetQua VALUES (@maSV, @maMon, @diem, @hocKy,@trangThai);
-- Test
exec sp_themKetQua 'SV015', 'MH001', 8.5, N'Học Kỳ 1';
select * from KetQua

-- Thêm vào bảng GiaoVien
create proc sp_themGiaoVien (@maGV CHAR(6), @hoTen NVARCHAR(50), @ngaySinh DATE, @gioiTinh NVARCHAR(10), @maKhoa CHAR(6), @trangThai BIT = 1)
as
    INSERT INTO GiaoVien VALUES (@maGV, @hoTen, @ngaySinh, @gioiTinh, @maKhoa,@trangThai);
-- Test
exec sp_themGiaoVien 'GV016', N'Phạm Văn C', '1980-05-05', N'Nam', 'QTKD';
select * from GiaoVien
----------------------------------------------------------



--------- Các Store Xóa cho danh sách các bảng -----------

-- Xóa trong bảng Khoa
-- Sau khi xóa khoa thì sẽ xóa hết các SinhVien,MonHoc,GiaoVien của Khoa đó và xóa các kết quả học tập như KetQua theo SinhVien thuộc Khoa đã xóa , KetQua theo MonHoc thuộc Khoa đã xóa 
create proc sp_xoaKhoa (@maKhoa CHAR(6))
as
		-- Xóa các giáo viên thuộc Khoa
        DELETE FROM GiaoVien
        WHERE MaKhoa = @maKhoa;

		-- Xóa kết quả học tập liên quan đến các MÔN HỌC của Khoa
        DELETE FROM KetQua
        WHERE MaMon IN (SELECT MaMon FROM MonHoc WHERE MaKhoa = @maKhoa);

        -- Xóa các môn học thuộc Khoa
        DELETE FROM MonHoc
        WHERE MaKhoa = @maKhoa;

        -- Xóa các kết quả học tập liên quan đến SINH VIÊN của Khoa
        DELETE FROM KetQua
        WHERE MaSV IN (SELECT MaSV FROM SinhVien WHERE MaKhoa = @maKhoa);

        -- Xóa sinh viên thuộc Khoa
        DELETE FROM SinhVien
        WHERE MaKhoa = @maKhoa;

		-- Xóa Khoa
		DELETE FROM Khoa 
		WHERE MaKhoa = @maKhoa;
-- Test
EXEC sp_xoaKhoa 'TC';
-- Display --
SELECT * FROM Khoa;
SELECT * FROM SinhVien;
SELECT * FROM MonHoc;
SELECT * FROM KetQua;
SELECT * FROM GiaoVien;

-----------------------------------------------------------------------
-- Thêm trạng thái cho bảng Khoa
alter table Khoa add TrangThai bit default 1;

UPDATE Khoa
SET TrangThai = 1;
drop proc sp_khoiPhucKhoa
--- Xóa này là ẩn khoa đi chứ khoa sẽ không bị xóa
create proc sp_anKhoa (@maKhoa CHAR(6))
AS
BEGIN
	-- Ẩn đi giáo viên thuộc khoa bị xóa
	Update GiaoVien set TrangThai = 0 where MaKhoa = @maKhoa

	-- Ẩn đi kết quả học tập liên quan đến môn học thuộc khoa bị xóa
	Update KetQua set TrangThai = 0 where MaMon in (Select MaMon From MonHoc where MaKhoa = @maKhoa)

	-- Ẩn đi Môn Học thuộc Khoa bị xóa
	Update MonHoc set TrangThai = 0 where MaKhoa = @maKhoa

	-- Ẩn đi Kết quả liên quan đến sinh viên thuộc Khoa bị xóa
	Update KetQua set TrangThai = 0 where MaSV in (Select MaSV from SinhVien where MaKhoa = @maKhoa)

	-- ẩn đi Sinh Viên thuộc Khoa bị xóa
	Update SinhVien Set TrangThai = 0 where MaKhoa = @maKhoa

    -- Đánh dấu khoa là "ẩn" (TrangThai = 0)
    UPDATE Khoa
    SET TrangThai = 0
    WHERE MaKhoa = @maKhoa;
END;

--- Khôi phục lại khoa bị xóa ( bị ẩn )
create proc sp_khoiPhucKhoa (@maKhoa CHAR(6))
AS
BEGIN
	-- Khôi phục đi giáo viên thuộc khoa bị xóa
	Update GiaoVien set TrangThai = 1 where MaKhoa = @maKhoa

	-- Khôi phục đi kết quả học tập liên quan đến môn học thuộc khoa bị xóa
	Update KetQua set TrangThai = 1 where MaMon in (Select MaMon From MonHoc where MaKhoa = @maKhoa)

	-- Khôi phục đi Môn Học thuộc Khoa bị xóa
	Update MonHoc set TrangThai = 1 where MaKhoa = @maKhoa

	-- Khôi phục đi Kết quả liên quan đến sinh viên thuộc Khoa bị xóa
	Update KetQua set TrangThai = 1 where MaSV in (Select MaSV from SinhVien where MaKhoa = @maKhoa)

	-- Khôi phục đi Sinh Viên thuộc Khoa bị xóa
	Update SinhVien Set TrangThai = 1 where MaKhoa = @maKhoa

    -- Khôi phục khoa (TrangThai = 1)
    UPDATE Khoa
    SET TrangThai = 1
    WHERE MaKhoa = @maKhoa;
END;
drop proc sp_Khoa
--- Lấy các khoa có TrangThai = 1 là không bị ẩn
create proc sp_Khoa
AS
BEGIN
    SELECT MaKhoa, TenKhoa, DiaChi, DienThoai
    FROM Khoa
    WHERE TrangThai = 1;
END;
--- Lấy các khoa bị ẩn
create proc sp_layKhoaAn
AS
BEGIN
    SELECT MaKhoa, TenKhoa, DiaChi, DienThoai
    FROM Khoa
    WHERE TrangThai = 0;
END;


-- Thêm cột TrangThai vào bảng SinhVien
ALTER TABLE SinhVien
ADD TrangThai BIT DEFAULT 1;

-- Cập nhật trạng thái mặc định là hiển thị (1) cho các bản ghi hiện có
UPDATE SinhVien
SET TrangThai = 1;

drop proc sp_khoiPhucSinhVien
-- Ẩn Sinh Viên
create proc sp_anSinhVien (@maSV CHAR(10))
AS
BEGIN
	-- Ẩn đi kết quả của Sinh Viên bị xóa
	Update KetQua set TrangThai = 0 where MaSV in (Select MaSV from SinhVien where MaSV = @maSV)

    -- Đánh dấu sinh viên là "ẩn" (TrangThai = 0)
    UPDATE SinhVien
    SET TrangThai = 0
    WHERE MaSV = @maSV;
END;

--- Khôi phục Sinh Viên 
create proc sp_khoiPhucSinhVien (@maSV CHAR(10))
AS
BEGIN
	-- Khôi phục đi kết quả của Sinh Viên bị xóa
	Update KetQua set TrangThai = 1 where MaSV in (Select MaSV from SinhVien where MaSV = @maSV)

    -- Khôi phục sinh viên (TrangThai = 1)
    UPDATE SinhVien
    SET TrangThai = 1
    WHERE MaSV = @maSV;
END;

--- Lấy Danh Sách Sinh Viên
create proc sp_laySinhVien
AS
BEGIN
    -- Lấy danh sách sinh viên với trạng thái hiển thị (TrangThai = 1)
    SELECT MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaKhoa
    FROM SinhVien
    WHERE TrangThai = 1;
END;

--- Lấy Danh Sách Sinh Viên bị ẩn
CREATE PROCEDURE sp_laySinhVienAn
AS
BEGIN
    -- Lấy danh sách sinh viên với trạng thái bị ẩn (TrangThai = 0)
    SELECT MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaKhoa
    FROM SinhVien
    WHERE TrangThai = 0;
END;

-- Thêm trạng thái cho bảng Mon Hoc
alter table MonHoc add TrangThai bit default 1;

UPDATE MonHoc
SET TrangThai = 1;

--- Xóa này là ẩn khoa đi chứ khoa sẽ không bị xóa
create proc sp_anMonHoc (@maMon CHAR(6))
AS
BEGIN
    -- Đánh dấu khoa là "ẩn" (TrangThai = 0)
    UPDATE MonHoc
    SET TrangThai = 0
    WHERE MaMon = @maMon;
END;

--- Khôi phục lại khoa bị xóa ( bị ẩn )
create proc sp_khoiPhucMonHoc (@maMon CHAR(6))
AS
BEGIN
    -- Khôi phục khoa (TrangThai = 1)
    UPDATE MonHoc
    SET TrangThai = 1
    WHERE MaMon = @maMon;
END;

--- Lấy các khoa có TrangThai = 1 là không bị ẩn
create proc sp_MonHoc
AS
BEGIN
    SELECT MaMon, TenMon, SoTinChi, MaKhoa
    FROM MonHoc
    WHERE TrangThai = 1;
END;
--- Lấy các khoa bị ẩn
create proc sp_layMonHocAn
AS
BEGIN
    SELECT MaMon, TenMon, SoTinChi, MaKhoa
    FROM MonHoc
    WHERE TrangThai = 0;
END;



-- Thêm trạng thái cho bảng KetQua
alter table KetQua add TrangThai bit default 1;

UPDATE KetQua
SET TrangThai = 1;

--- Xóa này là ẩn KetQua đi chứ KetQua sẽ không bị xóa
create proc sp_anKetQua (@maSV CHAR(6),@maMon CHAR(6))
AS
BEGIN
    -- Đánh dấu KetQua là "ẩn" (TrangThai = 0)
    UPDATE KetQua
    SET TrangThai = 0
    WHERE MaMon = @maMon and MaSV = @maSV;
END;

--- Khôi phục lại KetQua bị xóa ( bị ẩn )
create proc sp_khoiPhucKetQua (@maSV CHAR(6),@maMon CHAR(6))
AS
BEGIN
    -- Khôi phục KetQua (TrangThai = 1)
    UPDATE KetQua
    SET TrangThai = 1
    WHERE MaMon = @maMon and MaSV = @maSV;
END;

--- Lấy các KetQua có TrangThai = 1 là không bị ẩn
create proc sp_KetQua
AS
BEGIN
    SELECT MaSV, MaMon, Diem, HocKy
    FROM KetQua
    WHERE TrangThai = 1;
END;
--- Lấy các KetQua bị ẩn
create proc sp_layKetQuaAn
AS
BEGIN
    SELECT MaSV, MaMon, Diem, HocKy
    FROM KetQua
    WHERE TrangThai = 0;
END;



-- Thêm cột TrangThai vào bảng GiaoVien
ALTER TABLE GiaoVien
ADD TrangThai BIT DEFAULT 1;

-- Cập nhật trạng thái mặc định là hiển thị (1) cho các bản ghi hiện có
UPDATE GiaoVien
SET TrangThai = 1;

-- Ẩn GiaoVien
create proc sp_anGiaoVien (@maGV CHAR(10))
AS
BEGIN
    -- Đánh dấu GiaoVien là "ẩn" (TrangThai = 0)
    UPDATE GiaoVien
    SET TrangThai = 0
    WHERE MaGV = @maGV;
END;

--- Khôi phục GiaoVien 
create proc sp_khoiPhucGiaoVien (@maGV CHAR(10))
AS
BEGIN
    -- Khôi phục GiaoVien (TrangThai = 1)
    UPDATE GiaoVien
    SET TrangThai = 1
    WHERE MaGV = @maGV;
END;

--- Lấy Danh Sách GiaoVien
create proc sp_layGiaoVien
AS
BEGIN
    -- Lấy danh sách GiaoVien với trạng thái hiển thị (TrangThai = 1)
    SELECT MaGV, HoTen, NgaySinh, GioiTinh, MaKhoa
    FROM GiaoVien
    WHERE TrangThai = 1;
END;

--- Lấy Danh Sách GiaoVien bị ẩn
CREATE PROCEDURE sp_layGiaoVienAn
AS
BEGIN
    -- Lấy danh sách GiaoVien với trạng thái bị ẩn (TrangThai = 0)
    SELECT MaGV, HoTen, NgaySinh, GioiTinh, MaKhoa
    FROM GiaoVien
    WHERE TrangThai = 0;
END;


-------------------------------------------------------------------


-- Xóa trong bảng SinhVien
create proc sp_xoaSinhVien (@maSV CHAR(6))
as
        -- Xóa các kết quả học tập của sinh viên
        DELETE FROM KetQua
        WHERE MaSV = @maSV;

        -- Xóa sinh viên
        DELETE FROM SinhVien
        WHERE MaSV = @maSV;
   
-- Test
EXEC sp_xoaSinhVien 'SV001';
SELECT * FROM SinhVien;
SELECT * FROM KetQua;


-- Xóa trong bảng MonHoc
create proc sp_xoaMonHoc (@maMon CHAR(6))
as
        -- Xóa các kết quả học tập liên quan đến môn học
        DELETE FROM KetQua
        WHERE MaMon = @maMon;

        -- Xóa môn học
        DELETE FROM MonHoc
        WHERE MaMon = @maMon;

-- Test
EXEC sp_xoaMonHoc 'MH012';
SELECT * FROM MonHoc;
SELECT * FROM KetQua;


-- Xóa trong bảng KetQua
create proc sp_xoaKetQua (@maSV CHAR(6),@maMon CHAR(6))
as
        -- Xóa kết quả học tập của sinh viên cho môn học
        DELETE FROM KetQua
        WHERE MaSV = @maSV AND MaMon = @maMon;
-- Test
EXEC sp_xoaKetQua 'SV001', 'MH001';
SELECT * FROM SinhVien;
SELECT * FROM KetQua;


-- Xóa trong bảng GiaoVien
create proc sp_xoaGiaoVien (@maGV CHAR(6))
AS
        -- Xóa giáo viên
        DELETE FROM GiaoVien
        WHERE MaGV = @maGV;
-- Test
EXEC sp_xoaGiaoVien 'GV016';
SELECT * FROM GiaoVien;

----------------------------------------------------------



--------- Các Store Sửa cho danh sách các bảng -----------

-- Sửa thông tin trong bảng Khoa
create proc sp_suaKhoa (@maKhoa CHAR(6),@tenKhoa NVARCHAR(100),@diaChi NVARCHAR(200) = NULL,@dienThoai VARCHAR(15) = NULL,@trangThai BIT = 1)
AS
        -- Cập nhật thông tin khoa
        UPDATE Khoa
        SET TenKhoa = @tenKhoa, DiaChi = COALESCE(@diaChi, DiaChi), DienThoai = COALESCE(@dienThoai, DienThoai) , TrangThai = @trangThai -- Nếu không truyền DiaChi và DienThoai thì giữ nguyên
        WHERE MaKhoa = @maKhoa;

-- Test
EXEC sp_suaKhoa 'YH', N'Y Học', N'1234 Láng Hạ', '0245566779';
SELECT * FROM Khoa;


-- Sửa thông tin SinhVien
create proc sp_suaSinhVien (@maSV CHAR(6),@hoTen NVARCHAR(50) = NULL,@ngaySinh DATE = NULL,@gioiTinh NVARCHAR(10) = NULL,@diaChi NVARCHAR(100) = NULL,@maKhoa CHAR(6) = NULL,@trangThai BIT = 1)
as
        -- Cập nhật thông tin sinh viên
        UPDATE SinhVien
        SET HoTen = COALESCE(@hoTen, HoTen), NgaySinh = COALESCE(@ngaySinh, NgaySinh), GioiTinh = COALESCE(@gioiTinh, GioiTinh), DiaChi = COALESCE(@diaChi, DiaChi), MaKhoa = COALESCE(@maKhoa, MaKhoa), TrangThai = @trangThai
        WHERE MaSV = @maSV; 
-- Test
EXEC sp_suaSinhVien 'SV016', N'Nguyễn Huỳnh', '2000-06-15', N'Nam', N'123 Nguyễn Lương Bằng, TP.HCM', 'QTKD';
SELECT * FROM SinhVien;


-- Sửa thông tin MonHoc
create proc sp_suaMonHoc (@maMon CHAR(6),@tenMon NVARCHAR(100),@soTinChi INT,@maKhoa CHAR(6) = NULL,@trangThai BIT = 1)
as
        -- Cập nhật thông tin môn học
        UPDATE MonHoc
        SET TenMon = @tenMon, SoTinChi = @soTinChi, MaKhoa = COALESCE(@maKhoa, MaKhoa), TrangThai = @trangThai
        WHERE MaMon = @maMon;
-- Test
EXEC sp_suaMonHoc 'MH017', N'Lập Trình Ứng Dụng', 4, 'CNTT';
SELECT * FROM MonHoc;


-- Sửa thông tin KetQua
CREATE PROC sp_suaKetQua (@maSV CHAR(6), @maMon CHAR(6), @diem DECIMAL(4, 2) = NULL, @hocKy NVARCHAR(20) = NULL,@trangThai BIT = 1)
as
        -- Cập nhật kết quả học tập
        UPDATE KetQua
        SET Diem = COALESCE(@diem, Diem),
            HocKy = COALESCE(@hocKy, HocKy), TrangThai = @trangThai
        WHERE MaSV = @maSV AND MaMon = @maMon;
-- Test
EXEC sp_suaKetQua 'SV00113', 'MH014', 9.5, N'Học Kỳ 2';
SELECT * FROM KetQua;


-- Sửa thông tin GiaoVien
CREATE PROC sp_suaGiaoVien (@maGV CHAR(6), @hoTen NVARCHAR(50) = NULL, @ngaySinh DATE = NULL, @gioiTinh NVARCHAR(10) = NULL, @maKhoa CHAR(6) = NULL,@trangThai BIT = 1)
AS
        -- Cập nhật thông tin giáo viên
        UPDATE GiaoVien
        SET HoTen = COALESCE(@hoTen, HoTen),
            NgaySinh = COALESCE(@ngaySinh, NgaySinh),
            GioiTinh = COALESCE(@gioiTinh, GioiTinh),
            MaKhoa = COALESCE(@maKhoa, MaKhoa), TrangThai = @trangThai
        WHERE MaGV = @maGV;
-- Test
EXEC sp_suaGiaoVien 'GV001', N'Nguyễn Hồng', '1980-07-20', N'Nữ', 'KT';
SELECT * FROM GiaoVien;

---------------------------------------------------------------


--------- Các Store Tìm Kiếm cho danh sách các bảng -----------

-- Tìm kiếm Khoa theo Mã hoặc Tên
create proc sp_timKiemKhoa (@keyword NVARCHAR(100))
as
begin
    SELECT * FROM Khoa WHERE MaKhoa LIKE '%' + @keyword + '%' OR TenKhoa LIKE '%' + @keyword + '%'
end;
-- Test
select * from Khoa
exec sp_timKiemKhoa @keyword = 'CNTT';
exec sp_timKiemKhoa @keyword = N'Kinh Doanh';



-- Tìm kiếm Sinh viên theo Mã hoặc Tên
create proc sp_timKiemSinhVien ( @keyword NVARCHAR(100))
AS
BEGIN
    SELECT * FROM SinhVien
    WHERE HoTen LIKE '%' + @keyword + '%'
    OR MaSV LIKE '%' + @keyword + '%'
END
-- Test
select * from SinhVien
exec sp_timKiemSinhVien @keyword = 'SV002';
exec sp_timKiemSinhVien @keyword = N'Nguyễn Huỳnh';

-- Tìm kiếm Môn học theo Mã hoặc Tên
create proc sp_timMonHoc (@keyword NVARCHAR(100))
as
begin
    SELECT * 
    FROM MonHoc
     WHERE TenMon LIKE '%' + @keyword + '%'
    OR MaMon LIKE '%' + @keyword + '%'
end;
-- Test
select * from MonHoc
exec sp_timMonHoc @keyword = 'MH002';
exec sp_timMonHoc @keyword = N'Tiếng Anh';

drop proc sp_timKetQua
-- Tìm kiếm kết quả học tập theo Mã Sinh Viên hoặc Mã Môn
create proc sp_timKetQua (@keyword NVARCHAR(100))
as
begin
    SELECT * 
    FROM KetQua k,MonHoc m,SinhVien s
     WHERE k.MaMon LIKE '%' + @keyword + '%'or m.TenMon LIKE '%' + @keyword + '%'
    OR k.MaSV LIKE '%' + @keyword + '%' or s.HoTen LIKE '%' + @keyword + '%'
end;
-- Test
select * from KetQua
exec sp_timKetQua @keyword = 'SV002';
exec sp_timKetQua @keyword = 'MH010';

-- Tìm kiếm Giáo viên theo Mã hoặc Tên
create proc sp_timGiaoVien (@keyword NVARCHAR(100))
as
begin
    SELECT * 
    FROM GiaoVien
    WHERE HoTen LIKE '%' + @keyword + '%'
    OR MaGV LIKE '%' + @keyword + '%'
end;
-- Test
exec sp_timGiaoVien @keyword = 'GV001';
exec sp_timGiaoVien @keyword = N'Lê Thị Hoa';

--In danh sách điểm cho 1 sinh viên
create proc laybangdiem1sv(@masv char(6))
as
select sv.MaSV , sv.HoTen , mh.TenMon,mh.SoTinChi,kq.Diem,k.MaKhoa,k.TenKhoa,kq.HocKy
from SinhVien sv,Khoa k,MonHoc mh ,KetQua kq
where sv.MaSV = kq.MaSV and kq.MaMon = mh.MaMon and sv.MaKhoa = k.MaKhoa and sv.MaSV = @masv

exec laybangdiem1sv 'SV001'

--In danh sách môn học cho 1 sinh viên
create proc laybangmonhoc1sv(@masv char(6))
as
select sv.MaSV , sv.HoTen ,mh.MaMon, mh.TenMon,mh.SoTinChi,k.MaKhoa,k.TenKhoa
from SinhVien sv,Khoa k,MonHoc mh 
where sv.MaKhoa = mh.MaKhoa and k.MaKhoa = mh.MaKhoa and sv.MaKhoa = k.MaKhoa and sv.MaSV = @masv

exec laybangmonhoc1sv 'SV002'

drop proc layDSSinhVienThuocKhoa
-- In danh sách các Sinh Viên thuộc Khoa
create proc layDSSinhVienThuocKhoa(@maKhoa CHAR(10))
as
select sv.MaSV , sv.HoTen , sv.GioiTinh , sv.NgaySinh , sv.DiaChi , k.TenKhoa as ThuộcKhoa
from Khoa k , SinhVien sv
where sv.MaKhoa = k.MaKhoa and k.MaKhoa = @maKhoa and sv.TrangThai = 1

exec layDSSinhVienThuocKhoa 'CNTT'