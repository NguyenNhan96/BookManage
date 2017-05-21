CREATE DATABASE QLKS
USE QLKS
/* Quản lí kho sách, ta có nhiều kho, chứa nhiều đầu sách, được phân theo loại. Tức là KHÔNG PHẢI KHO CỦA MÌNH CHỨA TÙM LUM SÁCH
- Khi nhập sách thì nhập vào kho nào, số lượng bao nhiêu...
- Xuất sách thì xuất từ kho nào, số lượng bao nhiêu...
- Sách của mình sẽ có thông tin loại sách.
- Mỗi kho lưu tất cả các đầu sách, sách được phân theo loại -> trong table LOAISACH không cần MAKHO -> bỏ.
	Trong SACH thì thêm MAKHO để biết sách này bỏ vào kho nào khi nhập đơn sách.
- Trong CTDN, CTDX bổ sung thêm giá của sách đó và số lượng, Mình sẽ hiển thị tổng giá tiền của mỗi chi tiết đơn sách.
	Tổng hợp tất cả các giá tiền của các chi tiết đơn, mình có được tổng giá tiền của đơn sách.
	+ sau khi chỉnh sửa các chi tiết đơn sách, mình phải thay đổi tổng giá tiền ở bên form DONNHAP hoặc DONXUAT.
	( làm sao để nó thay đổi bên kia ? )
	+ Bổ sung thêm đơn nhập, tất nhiên bảng SACH cũng bị ảnh hưởng rồi. Trời, rắc rối vãi. 
		Ta lại phải truy vẫn câu lệnh để thêm sách hoặc chỉnh sửa sách ở trong bảng SACH. đù..ù.....ù..........

*/
drop database QLKS
CREATE TABLE TAIKHOAN(
	USERNAME CHAR(30),
	PASS CHAR(30),
	HOTEN NVARCHAR(30),
	PRIMARY KEY(USERNAME) 
)
drop table TAIKHOAN
INSERT TAIKHOAN VALUES ('admin','admin',N'Nguyễn Văn Nhàn')
select * from TAIKHOAN
 
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

CREATE TABLE LOAI(
	MALOAI CHAR(3),
	TENLOAI NVARCHAR(20),
	MOTA NVARCHAR(100),
	PRIMARY KEY (MALOAI)
)
drop table LOAI
INSERT LOAI VALUES ('L01', N'Sách Kỹ Năng',N'Kỹ năng mềm dành cho mọi lứa tuổi')
INSERT LOAI VALUES ('L02', N'Sách Thiếu Nhi',N'Nội dung dành cho thiếu nhi')
INSERT LOAI VALUES ('L03', N'Sách Tâm Lý',N'Học cách nắm bắt tâm lí con người')
INSERT LOAI VALUES ('L04', N'Sách Truyện',N'Các mẫu truyện hay')

select * from LOAI
CREATE TABLE SACH(
	MASACH CHAR(3),
	TENSACH NVARCHAR(30),
	TACGIA NVARCHAR(30),
	NHAXB NVARCHAR(30),
	NAMXB INT,
	GIA INT,
	SOLUONG INT,
	MALOAI CHAR(3),
	MAKHO CHAR(3),
	PRIMARY KEY(MASACH, MAKHO)
)
DROP TABLE SACH
INSERT SACH VALUES ('S01',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01','K01')
INSERT SACH VALUES ('S02',N'Hoàng tử bé', N'Antoine De Saint-Exupéry',N'Nhà xuất bản Kim Đồng',1990, 48000, 40, 'L02','K01')
INSERT SACH VALUES ('S03',N'Never eat alone', N'Keith Ferrazzi',N'Nhà xuất bản trẻ',1990, 76000, 30, 'L01','K01')
INSERT SACH VALUES ('S04',N'Nobita và Mê cung thiếc', N'Fujiko F Fujio',N'Nhà xuất bản Kim Đồng',2005, 27000, 50, 'L04','K02')
INSERT SACH VALUES ('S05',N'Connan Tập 01', N'Aoyam',N'Nhà xuất bản trẻ',1990, 28000, 40, 'L04','K02')
INSERT SACH VALUES ('S06',N'Code dạo kí sự', N'Phạm Huy Hoàng',N'Nhà xuất bản trẻ',2016, 127000, 70, 'L01','K03')
INSERT SACH VALUES ('S07',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01','K04')
INSERT SACH VALUES ('S08',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01','K04')
INSERT SACH VALUES ('S09',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01','K04')
INSERT SACH VALUES ('S10',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01','K01')
INSERT SACH VALUES ('S11',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01','K02')
INSERT SACH VALUES ('S12',N'Đắc Nhân Tâm', N'Dale Carnegie',N'Nhà xuất bản trẻ',1951, 56000, 50, 'L01','K01')
delete SACH
select * from SACH
drop table SACH


CREATE TABLE DONNHAP(
	MADN CHAR(3),
	NGAYNHAP DATETIME,
	NOINHAP NVARCHAR(30),
	TONGTIEN INT,
	MAKHO CHAR (3),
	PRIMARY KEY (MADN)
)
INSERT DONNHAP VALUES ('N01','03/20/2017',N'Ba Đình - Hà Nội', 2500000, 'K01')
INSERT DONNHAP VALUES ('N02','03/25/2017',N'Thanh khê - Đà Nẵng', 1500000, 'K01')
INSERT DONNHAP VALUES ('N03','02/10/2017',N'Linh Chiểu - Đà Nẵng', 3000000, 'K02')
INSERT DONNHAP VALUES ('N04','02/10/2017',N'Quận 1 - Tp HCM', 2560000, 'K03')


CREATE TABLE CTDN(
	MACTN CHAR(3),
	MADN CHAR(3),
	MASACH CHAR (3),
	GIA INT,
	SL INT,
	PRIMARY KEY (MACTN)
)
drop table CTDN

INSERT CTDN VALUES ('C01','N01','S01',27000,25)
INSERT CTDN VALUES ('C02','N01','S02',28000,30)
INSERT CTDN VALUES ('C03','N01','S03',35000,40)
INSERT CTDN VALUES ('C04','N02','S01',40000,10)
INSERT CTDN VALUES ('C05','N03','S05',55000,25)
INSERT CTDN VALUES ('C06','N03','S02',127000,25)

CREATE TABLE DONXUAT(
	MADX CHAR(3),
	NGAYXUAT DATETIME,
	NOIXUAT NVARCHAR(30),
	TONGTIEN INT,
	MAKHO CHAR(3),
	PRIMARY KEY (MADX)
)

INSERT DONXUAT VALUES ('X01','01/20/2017',N'Nhà sách Nguyễn Hữu Cầu', 1500000, 'K01')
INSERT DONXUAT VALUES ('X02','01/29/2017',N'Nhà sách Phương Nam', 1500000, 'K02')
INSERT DONXUAT VALUES ('X03','02/10/2017',N'Nhà sách Kim Đồng', 1000000, 'K02')
INSERT DONXUAT VALUES ('X04','02/15/2017',N'Nhà sách Nguyễn Hữu Cầu', 1100000, 'K01')
INSERT DONXUAT VALUES ('X05','02/20/2017',N'Nhà sách Phan Văn Trị', 800000, 'K03')
INSERT DONXUAT VALUES ('X06','03/20/2017',N'Nhà sách Nguyễn Hữu Cầu', 900000, 'K01')


CREATE TABLE CTDX(
	MACTX CHAR(3),
	MADX CHAR(3),
	MASACH CHAR(3),
	GIA int,
	SL INT,
	PRIMARY KEY (MACTX,MADX)
)
drop table CTDX

INSERT CTDX VALUES ('C01','X01','S01',19000,10)
INSERT CTDX VALUES ('C02','X01','S02',109000,15)
INSERT CTDX VALUES ('C03','X01','S03',157000,15)
INSERT CTDX VALUES ('C04','X01','S10',28000,5)
INSERT CTDX VALUES ('C05','X02','S01',56000,10)
INSERT CTDX VALUES ('C06','X02','S05',65000,50)
INSERT CTDX VALUES ('C07','X02','S06',39000,20)
INSERT CTDX VALUES ('C08','X02','S07',75000,35)
INSERT CTDX VALUES ('C09','X03','S08',40000,60)
INSERT CTDX VALUES ('C10','X03','S09',29000,35)
INSERT CTDX VALUES ('C11','X03','S01',15000,40)
INSERT CTDX VALUES ('C12','X04','S02',25000,50)
INSERT CTDX VALUES ('C13','X04','S05',30000,100)
INSERT CTDX VALUES ('C14','X04','S06',54000,60)
INSERT CTDX VALUES ('C15','X04','S10',76000,25)

