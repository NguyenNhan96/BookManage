CREATE DATABASE QLKS
USE QLKS
/* Quản lí kho sách, ta có nhiều kho, mỗi kho chứa nhiều loại sách, mỗi loại chứa nhiều đầu sách.
- Khi nhập sách thì nhập vào kho nào, số lượng bao nhiêu...
- Xuất sách thì xuất từ kho nào, số lượng bao nhiêu...
*/
CREATE TABLE KHOSACH(
	MAKHO CHAR(3),
	TENKHO NVARCHAR(30),
	DIACHI NVARCHAR(50),
	PRIMARY KEY (MAKHO)
)
SELECT * FROM KHOSACH
INSERT KHOSACH VALUES ('K01',N'Kho Phương Nam', N'20- Nguyễn Ảnh Thủ-Quận 12')
INSERT KHOSACH VALUES ('K02',N'Kho Nguyễn Hữu Cầu', N'55-Nguyễn Ảnh Thủ-Quận 12')
INSERT KHOSACH VALUES ('K03',N'Kho Miền Đông', N'18-Tô ký- Quận 12')

DELETE KHOSACH

CREATE TABLE SACH(
	MASACH CHAR(3),
	TENSACH NVARCHAR(30),
	TACGIA NVARCHAR(30),
	NHAXB NVARCHAR(30),
	NAMXB INT,
	GIA INT,
	SOLUONG INT,
	MALOAI CHAR(3),
	PRIMARY KEY(MASACH)
)
DROP TABLE SACH
INSERT SACH VALUES ('S01',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01')
INSERT SACH VALUES ('S02',N'Hoàng tử bé', N'Antoine De Saint-Exupéry',N'Nhà xuất bản Kim Đồng',1990, 48000, 40, 'L02')
INSERT SACH VALUES ('S03',N'Never eat alone', N'Keith Ferrazzi',N'Nhà xuất bản trẻ',1990, 76000, 30, 'L01')
INSERT SACH VALUES ('S04',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01')
INSERT SACH VALUES ('S05',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01')
INSERT SACH VALUES ('S06',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01')
INSERT SACH VALUES ('S07',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01')
INSERT SACH VALUES ('S08',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01')
INSERT SACH VALUES ('S09',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01')
INSERT SACH VALUES ('S10',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01')
INSERT SACH VALUES ('S11',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01')
INSERT SACH VALUES ('S12',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01')
delete SACH
select * from SACH
drop table SACH
CREATE TABLE LOAI(
	MALOAI CHAR(3),
	TENLOAI NVARCHAR(20),
	MOTA NVARCHAR(100),
	MAKHO CHAR(3),
	PRIMARY KEY (MALOAI)
)
drop table LOAI
INSERT LOAI VALUES ('L01', N'Sách Kỹ Năng',N'Kỹ năng mềm dành cho mọi lứa tuổi','K01')
INSERT LOAI VALUES ('L02', N'Sách Thiếu Nhi',N'Nội dung dành cho thiếu nhi','K01')
INSERT LOAI VALUES ('L03', N'Sách Tâm Lý',N'Học cách nắm bắt tâm lí con người','K01')
INSERT LOAI VALUES ('L04', N'Sách Truyện',N'Các mẫu truyện hay','K02')

select * from LOAI

CREATE TABLE DONNHAP(
	MADN CHAR(3),
	NGAYNHAP DATETIME,
	NOINHAP NVARCHAR(30),
	TONGTIEN INT,
	MAKHO CHAR (3),
	PRIMARY KEY (MADN)
)

CREATE TABLE CTDN(
	MACTN CHAR(3),
	MADN CHAR(3),
	MASACH CHAR (3),
	SL INT,
	PRIMARY KEY (MACTN)
)

CREATE TABLE DONXUAT(
	MADX CHAR(3),
	NGAYXUAT DATETIME,
	NOIXUAT NVARCHAR(30),
	TONGTIEN INT,
	MAKHO CHAR(3),
	PRIMARY KEY (MADX)
)

CREATE TABLE CTDX(
	MACTX CHAR(3),
	MADX CHAR(3),
	MASACH CHAR(3),
	SL INT,
	PRIMARY KEY (MACTX)
)

