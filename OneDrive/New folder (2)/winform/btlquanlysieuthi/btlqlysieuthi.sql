CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    TenNV NVARCHAR(100) ,
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    DienThoai NVARCHAR(11),
    Quyen NVARCHAR(20),     -- admin / quanly / nhanvien
    NgayVaoLam DATE,
    Luong DECIMAL(18,2)
);

CREATE TABLE TaiKhoan (
    MaTK INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) UNIQUE,
    MatKhau NVARCHAR(50),
    Quyen NVARCHAR(20),
    MaNV INT,
        FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
CREATE  TABLE ChamCong (
    MaCC INT IDENTITY(1,1) PRIMARY KEY,
    MaNV INT ,
    Ngay DATE ,
    GioVao TIME,
    GioRa TIME,
    SoCong FLOAT DEFAULT 0,
    TrangThai NVARCHAR(50), -- Đi muộn / Đúng giờ
        FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
);

CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100) ,
    DienThoai NVARCHAR(15),
    DiaChi NVARCHAR(200)
);

CREATE TABLE Category (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(100) 
);
CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100) ,
    Price DECIMAL(18,2) ,
    Quantity INT ,
    CategoryID INT,
    ImagePath NVARCHAR(MAX),
    Status NVARCHAR(20) DEFAULT N'Còn hàng',

    CONSTRAINT FK_Product_Category
        FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate DATETIME DEFAULT GETDATE(),
    MaNV INT,
    MaKH INT,
    TotalAmount DECIMAL(18,2),
    AmountReceived DECIMAL(18,2),
    ChangeAmount DECIMAL(18,2),

    CONSTRAINT FK_Orders_NhanVien
        FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),

    CONSTRAINT FK_Orders_KhachHang
        FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);
CREATE TABLE OrderDetails (
    DetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT ,
    ProductID INT ,
    Quantity INT ,
    UnitPrice DECIMAL(18,2) ,

    CONSTRAINT FK_OrderDetails_Orders
        FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),

    CONSTRAINT FK_OrderDetails_Product
        FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

CREATE TABLE NhaCungCap (
    MaNCC INT IDENTITY(1,1) PRIMARY KEY,
    TenNCC NVARCHAR(200) NOT NULL,
    DienThoai NVARCHAR(15),
    DiaChi NVARCHAR(MAX)
);

CREATE TABLE PhieuNhap (
    MaPN INT IDENTITY(1,1) PRIMARY KEY,
    MaNCC INT,
    ProductID INT,
    NgayNhap DATETIME DEFAULT GETDATE(),
    SoLuongNhap INT,
    GiaNhap DECIMAL(18,2),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

INSERT INTO NhanVien VALUES
(1, N'Nguyễn Văn Admin', N'Nam', '1990-01-01', '0901111111', 'admin', '2020-01-01', 300000),
(2, N'Trần Thị Quản Lý', N'Nữ', '1995-05-10', '0902222222', 'quanly', '2021-03-01', 200000),
(3, N'Lê Văn Nhân Viên', N'Nam', '2000-09-20', '0903333333', 'nhanvien', '2023-06-01', 150000);


INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Quyen, MaNV) VALUES
('admin', '123', 'admin', 1),
('ql01', '123', 'quanly', 2),
('nv01', '123', 'nhanvien', 3);

INSERT INTO KhachHang (TenKH, DienThoai, DiaChi) VALUES
(N'Khách Lẻ', '0000000000', N'Không xác định'),
(N'Nguyễn Văn A', '0988888888', N'Hà Nội'),
(N'Trần Thị B', '0977777777', N'Hải Phòng');

INSERT INTO Category VALUES
(1, N'Đồ ăn'),
(2, N'Nước uống');

INSERT INTO Product VALUES
(1, N'Spaghetti', 10000, 100, 1, NULL, N'Còn hàng');


ALTER PROCEDURE sp_ChamCong
    @MaNV INT,
    @Ngay DATE,
    @Gio TIME, -- Thêm tham số @Gio vào đây
    @Loai NVARCHAR(10) -- VAO / RA
AS
BEGIN
    SET NOCOUNT ON;

    IF @Loai = 'VAO'
    BEGIN
        IF EXISTS (SELECT 1 FROM ChamCong WHERE MaNV=@MaNV AND Ngay=@Ngay)
        BEGIN
            RAISERROR (N'Đã chấm vào rồi!', 16, 1);
            RETURN;
        END

        INSERT INTO ChamCong (MaNV, Ngay, GioVao, TrangThai)
        VALUES (
            @MaNV,
            @Ngay,
            @Gio, 
            CASE 
                WHEN @Gio > '08:00' THEN N'Đi muộn'
                ELSE N'Đúng giờ'
            END
        );
    END

    IF @Loai = 'RA'
    BEGIN
        -- Kiểm tra xem đã chấm giờ vào chưa
        IF NOT EXISTS (SELECT 1 FROM ChamCong WHERE MaNV=@MaNV AND Ngay=@Ngay AND GioVao IS NOT NULL)
        BEGIN
            RAISERROR (N'Chưa chấm giờ vào!', 16, 1);
            RETURN;
        END

        -- Kiểm tra xem đã chấm giờ ra rồi chưa
        IF EXISTS (SELECT 1 FROM ChamCong WHERE MaNV=@MaNV AND Ngay=@Ngay AND GioRa IS NOT NULL)
        BEGIN
            RAISERROR (N'Đã chấm giờ ra rồi!', 16, 1);
            RETURN;
        END

        UPDATE ChamCong
        SET GioRa = @Gio, 
            SoCong =
                CASE
                    WHEN GioVao <= '08:00' AND @Gio >= '17:30' THEN 1 -- Đúng giờ cả vào và ra: 1 công
                    ELSE 0.5
                END
        WHERE MaNV=@MaNV AND Ngay=@Ngay AND GioRa IS NULL;
    END
END;



-- sửa lại ràng buộc với tính năng ON DELETE CASCADE

ALTER TABLE dbo.ChamCong
ADD CONSTRAINT FK_ChamCong_MaNV_3E52440B FOREIGN KEY (MaNV)
REFERENCES dbo.NhanVien(MaNV)
ON DELETE CASCADE;


ALTER TABLE PhieuNhap DROP CONSTRAINT FK__PhieuNhap__Produ__71D1E811;
ALTER TABLE PhieuNhap 
ADD CONSTRAINT FK_PhieuNhap_Product 
FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE CASCADE;


ALTER TABLE OrderDetails DROP CONSTRAINT FK_OrderDetails_Orders;

ALTER TABLE OrderDetails 
ADD CONSTRAINT FK_OrderDetails_Orders_New 
FOREIGN KEY (OrderID) REFERENCES Orders(OrderID) ON DELETE CASCADE;



-- Tạo View để lấy dữ liệu in hóa đơn dễ dàng hơn
CREATE VIEW v_ChiTietHoaDon AS
SELECT 
    o.OrderID, 
    o.OrderDate, 
    nv.TenNV, 
    kh.TenKH, 
    p.ProductName, 
    od.Quantity, 
    od.UnitPrice, 
    (od.Quantity * od.UnitPrice) AS ThanhTien, 
    o.TotalAmount
FROM Orders o
JOIN NhanVien nv ON o.MaNV = nv.MaNV
JOIN KhachHang kh ON o.MaKH = kh.MaKH
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Product p ON od.ProductID = p.ProductID;



ALTER TABLE Product 
ADD CostPrice DECIMAL(18,2) DEFAULT 0;



ALTER PROCEDURE sp_Product_CRUD
    @Action NVARCHAR(10),
    @ProductID INT,
    @ProductName NVARCHAR(200),
    @Price DECIMAL(18,2),
    @Quantity INT,
    @CategoryID INT,
    @ImagePath NVARCHAR(255),
    @Status NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF @Action = 'INSERT'
    BEGIN
        INSERT INTO Product
        (ProductID, ProductName, Price, Quantity, CategoryID, ImagePath, Status)
        VALUES
        (@ProductID, @ProductName, @Price, @Quantity, @CategoryID, @ImagePath, @Status)
    END

    ELSE IF @Action = 'UPDATE'
    BEGIN
        UPDATE Product
        SET ProductName = @ProductName,
            Price       = @Price,
            Quantity    = @Quantity,
            CategoryID  = @CategoryID,
            ImagePath   = @ImagePath,
            Status      = @Status
        WHERE ProductID = @ProductID
    END
END

CREATE VIEW vw_DangNhap
AS
SELECT 
    tk.TenDangNhap, 
    tk.MatKhau, 
    tk.Quyen, 
    nv.MaNV, 
    nv.TenNV
FROM TaiKhoan tk
JOIN NhanVien nv ON tk.MaNV = nv.MaNV;

select*from vw_DangNhap;


CREATE VIEW v_ChiTietHoaDonst AS
SELECT 
    o.OrderID, 
    o.OrderDate, 
    nv.TenNV AS [Nhân Viên], 
    kh.TenKH AS [Khách Hàng], 
    p.ProductName AS [Sản Phẩm], 
    ncc.TenNCC AS [Nhà Cung Cấp], -- Lấy từ bảng NhaCungCap
    od.Quantity AS [Số Lượng], 
    pn.GiaNhap AS [Giá Vốn],       -- Lấy từ bảng PhieuNhap
    od.UnitPrice AS [Giá Bán],    -- Lấy từ bảng OrderDetails
    (od.Quantity * od.UnitPrice) AS [Thành Tiền],
    (od.Quantity * (od.UnitPrice - pn.GiaNhap)) AS [Lợi Nhuận] -- Tính nhanh tiền lãi
FROM Orders o
JOIN NhanVien nv ON o.MaNV = nv.MaNV
JOIN KhachHang kh ON o.MaKH = kh.MaKH
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Product p ON od.ProductID = p.ProductID
-- Nối với phiếu nhập gần nhất của sản phẩm đó để lấy giá vốn
JOIN PhieuNhap pn ON pn.ProductID = p.ProductID 
JOIN NhaCungCap ncc ON pn.MaNCC = ncc.MaNCC
WHERE pn.MaPN = (SELECT MAX(MaPN) FROM PhieuNhap WHERE ProductID = p.ProductID);

select*from v_ChiTietHoaDonst;

CREATE VIEW  v_LoiNhuanHoaDonst AS
SELECT 
    o.OrderID, 
    o.OrderDate, 
    nv.TenNV, 
    kh.TenKH, 
    p.ProductName, 
    od.Quantity AS SoLuongBan, 
    od.UnitPrice AS GiaBan, 
    pn.GiaNhap, 
    (od.Quantity * od.UnitPrice) AS ThanhTien, 
    -- Tính lợi nhuận thực tế dựa trên giá nhập cuối cùng của sản phẩm
    (od.Quantity * (od.UnitPrice - pn.GiaNhap)) AS TienLai
FROM Orders o
JOIN NhanVien nv ON o.MaNV = nv.MaNV
JOIN KhachHang kh ON o.MaKH = kh.MaKH
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Product p ON od.ProductID = p.ProductID
-- Lấy giá nhập từ phiếu nhập gần nhất của mỗi sản phẩm
JOIN PhieuNhap pn ON pn.ProductID = p.ProductID 
WHERE pn.MaPN = (
    SELECT MAX(MaPN) 
    FROM PhieuNhap 
    WHERE ProductID = p.ProductID
);
select*from v_LoiNhuanHoaDonst;


CREATE VIEW v_ThongTinKho AS
SELECT 
    p.ProductID, 
    p.ProductName, 
    p.Price AS GiaBan, 
    p.Quantity AS TonKho, 
    pn.GiaNhap, 
    ncc.TenNCC
FROM Product p
LEFT JOIN PhieuNhap pn ON pn.ProductID = p.ProductID
LEFT JOIN NhaCungCap ncc ON pn.MaNCC = ncc.MaNCC
WHERE pn.MaPN = (SELECT MAX(MaPN) FROM PhieuNhap WHERE ProductID = p.ProductID)
   OR pn.MaPN IS NULL;
   --lấy từ bảng  phiếu nhập và nhà cung cấp

  SELECT*FROM v_ThongTinKho;


  CREATE PROCEDURE sp_NhapHang
    @tenNCC NVARCHAR(200),
    @maSP VARCHAR(50),
    @tenSP NVARCHAR(200),
    @sl INT,
    @giaN DECIMAL(18,2),
    @maLoai INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Nhà cung cấp (Chỉ thêm nếu chưa có)
        DECLARE @maNCC INT;
        SELECT @maNCC = MaNCC FROM NhaCungCap WHERE TenNCC = @tenNCC;
        
        IF @maNCC IS NULL
        BEGIN
            INSERT INTO NhaCungCap (TenNCC) VALUES (@tenNCC);
            SET @maNCC = SCOPE_IDENTITY();
        END

        --  Sản phẩm (Cập nhật hoặc Thêm mới)
        IF EXISTS (SELECT 1 FROM Product WHERE ProductID = @maSP)
        BEGIN
            UPDATE Product SET Quantity = Quantity + @sl WHERE ProductID = @maSP;
        END
        ELSE
        BEGIN
            INSERT INTO Product (ProductID, ProductName, Price, Quantity, CategoryID)
            VALUES (@maSP, @tenSP, 0, @sl, @maLoai);
        END

        -- Thêm Phiếu Nhập
        INSERT INTO PhieuNhap (MaNCC, ProductID, SoLuongNhap, GiaNhap)
        VALUES (@maNCC, @maSP, @sl, @giaN);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END