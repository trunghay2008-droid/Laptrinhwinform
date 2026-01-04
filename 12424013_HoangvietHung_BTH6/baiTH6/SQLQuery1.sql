CREATE DATABASE UTEHY;
GO
USE UTEHY;
GO

-- 1. Bảng Môn Học
CREATE TABLE MonHoc (
    MaMH VARCHAR(10) PRIMARY KEY,
    TenMH NVARCHAR(50)
);

-- 2. Bảng Lớp Học
CREATE TABLE LopHoc (
    MaLop VARCHAR(10) PRIMARY KEY,
    TenLop NVARCHAR(50)
);

-- 3. Bảng Sinh Viên (Tách Họ và Tên để dễ sắp xếp theo yêu cầu)
CREATE TABLE SV (
    MaSV VARCHAR(10) PRIMARY KEY,
    Ho NVARCHAR(50),
    Ten NVARCHAR(20),
    MaLop VARCHAR(10) REFERENCES LopHoc(MaLop),
    SoBienLai VARCHAR(20)
);

-- 4. Bảng Điểm
CREATE TABLE Diem (
    MaSV VARCHAR(10) REFERENCES SV(MaSV),
    MaMH VARCHAR(10) REFERENCES MonHoc(MaMH),
    DiemSo FLOAT,
    PRIMARY KEY (MaSV, MaMH)
);

-- Thêm dữ liệu mẫu
INSERT INTO MonHoc VALUES ('VB1', 'VB.Net Level 1'), ('CS1', 'Lập trình C#');
INSERT INTO LopHoc VALUES ('CD48', 'Cao đẳng 48'), ('DH10', 'Đại học 10');

INSERT INTO SV VALUES ('SV01', N'Nguyễn Thị', N'Đào', 'CD48', 'BL001');
INSERT INTO SV VALUES ('SV02', N'Lê', N'Đào', 'CD48', 'BL002');
INSERT INTO SV VALUES ('SV03', N'Đào Thị', N'Hoa', 'CD48', 'BL003');
INSERT INTO SV VALUES ('SV04', N'Nguyễn', N'Quân', 'CD48', 'BL004');
INSERT INTO SV VALUES ('SV05', N'Lý Văn', N'Sơn', 'DH10', 'BL005');