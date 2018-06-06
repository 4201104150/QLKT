﻿create database QuanLyNhieuDayTro
go
use QuanLyNhieuDayTro
go

CREATE TABLE CHUQUANLY
(	
	IDCHUQUANLY NVARCHAR(10) PRIMARY KEY,
	PASSBOSS NVARCHAR(16) NOT NULL,
	HOTEN NVARCHAR(200) NOT NULL,
	NGAYSINH DATE NOT NULL,
	CMND NVARCHAR(30) UNIQUE,
	DIACHI NVARCHAR(250) NOT NULL,
	SDT NVARCHAR(15) NOT NULL
)
GO

CREATE TABLE KHUTRO
(
	IDKHUTRO NVARCHAR(10) PRIMARY KEY,
	TENKHUTRO NVARCHAR(20) NOT NULL,
	DIACHI NVARCHAR(250) NOT NULL,
--	IDPHONGTRO NVARCHAR(10) FOREIGN KEY (IDPHONGTRO) REFERENCES PHONGTRO(IDPHONGTRO)
)
GO

CREATE TABLE PHONGTRO
(
	IDPHONGTRO NVARCHAR(10) PRIMARY KEY,
--	IDNGUOITHUE NVARCHAR(10) FOREIGN KEY(ÌNGUOITHUE) REFERENCES NGUOITHUE(IDNGUOITHUE),	
	CHATLUONGPHONG NVARCHAR(10) NOT NULL,
	GIATIEN int,
	DIENTICH INT NOT NULL,
	TINHTRANGPHONG int CHECK (TINHTRANGPHONG IN(0,1)),
	SONGUOITOIDA INT NOT NULL,
	IDKHUTRO NVARCHAR(10) FOREIGN KEY(IDKHUTRO) REFERENCES KHUTRO(IDKHUTRO)
)
GO


CREATE TABLE NGUOIQUANLY
(
	IDNGUOIQUANLY NVARCHAR(10) PRIMARY KEY,
	PASSNGQL NVARCHAR (16) NOT NULL,
	HOTEN NVARCHAR(200) NOT NULL,
	NGAYSINH DATE NOT NULL,
	CMND NVARCHAR(30) UNIQUE,
	DIACHI NVARCHAR(250) NOT NULL,
	SDT NVARCHAR(15) NOT NULL,
	IDKHUTRO NVARCHAR (10) FOREIGN KEY(IDKHUTRO) REFERENCES KHUTRO(IDKHUTRO) 
)
GO

CREATE TABLE NGUOITHUE
(
	IDNGUOITHUE NVARCHAR(10) PRIMARY KEY,
	HOTEN NVARCHAR(200) NOT NULL,
	NGAYSINH DATE NOT NULL,
	CMND NVARCHAR(30) UNIQUE,
	DIACHI NVARCHAR(250) NOT NULL,
	SDT NVARCHAR(15) NOT NULL,
	IDPHONG NVARCHAR (10) FOREIGN KEY(IDPHONG) REFERENCES PHONGTRO(IDPHONGTRO)
)
GO

INSERT INTO CHUQUANLY VALUES
('ADMIN','12345',N'Nguyễn Văn Tuấn','2/8/1998','231103411','Gia Lai','0963199444')
GO

INSERT INTO NGUOIQUANLY VALUES
('ID01','12345',N'Trần Yến Nhi','1/7/1968','12345678',N'Đà Nẵng','0982134121','KT1'),
('ID02','12345',N'Nguyễn Như Quỳnh','12/28/1968','12345677',N'TP.HCM','0922134121','KT2'),
('ID03','12345',N'Đỗ Thị Thanh Thi','5/10/1968','12345778',N'Đăk Lăk','01682124178','KT3'),
('ID04','12345',N'Nguyễn Văn D','2/9/1968','12347778',N'Tây Ninh','0982114123','KT1'),
('ID05','12345',N'Nguyễn Văn E','3/15/1968','12345679',N'Nghệ An','0982131127','KT3'),
('ID06','12345',N'Nguyễn Văn F','3/21/1968','12345672',N'Lâm Đồng','0922134122','KT1'),
('ID07','12345',N'Nguyễn Văn G','8/2/1968','12345676',N'Ninh Thuận','0942134121','KT2'),
('ID08','12345',N'Nguyễn Văn H','6/4/1958','12345674',N'Đồng Nai','09621341224','KT3'),
('ID09','12345',N'Nguyễn Văn K','2/11/1978','12345675',N'Phố Núi','0972134121','KT2')
GO

INSERT INTO NGUOITHUE VALUES
('ID001',N'Nguyễn Thị Q','3/10/1998','987654321',N'Cà Mau','01682141152','P03'),
('ID002',N'Trần Thị W','2/12/1999','987654322',N'Hà Nội','01684141152','P05'),
('ID003',N'Lê Thị E','4/29/1997','987654323',N'Khánh Hòa','01682041152','P06'),
('ID004',N'Nguyễn Thị R','3/6/1993','987654324','Vinh','01682141052','P05'),
('ID005',N'Lê Văn T','12/25/1991','987654325',N'Đà Nẵng','0982141152','P03'),
('ID006',N'Nguyễn Thị Thúy Y','11/10/1996','987654326',N'TP.HCM','01612141152','P06'),
------------
('ID007',N'Nguyễn Thị Utra','1/29/1999','987654327',N'Đà Nẵng','0982141152','P09'),
('ID008',N'Nguyễn Trần Từ','3/3/1998','982654328',N'Gia Lai','0984141152','P11'),
('ID009',N'Nguyễn Trần Ka','6/15/1998','927654328',N'Đồng Khởi','098124141152','P12'),
('ID010',N'Nguyễn Trần Nhân','9/3/1998','987254328',N'Đồng Tháp','0654141152','P15'),
('ID011',N'Nguyễn Từ Chức','1/17/1998','987650328',N'Tây Ninh','0912141152','P16'),
------------
('ID012',N'Phan Lang','1/2/1998','987654320',N'Kon Tum','0983151152','P18'),
('ID013',N'Lê Lúa','3/30/1998','987651328',N'IAKon','01684141152','P20'),
('ID014',N'Nguyễn Không Huệ','3/3/1998','987664328',N'Sao Hỏa','0164141152','P21'),
('ID015',N'Đinh Lê','9/15/1998','9876546328',N'Huế','0913251152','P21'),
('ID016',N'Hồ Mộc','10/10/1998','9875554328',N'Vũng Tàu','0984112152','P22')
GO

INSERT INTO PHONGTRO VALUES
('P01',N'Tốt','2400000','80','0','4','KT1'),
('P02',N'TB','1200000','40','0','3','KT1'),
('P03',N'Khá','1800000','60','1','3','KT1'),
('P04',N'Tốt','2400000','80','0','4','KT2'),
('P05',N'Tốt','1800000','70','1','4','KT3'),-------------
('P06',N'Khá','15000000','50','1','3','KT1'),
('P07',N'Tốt','2400000','80',N'0','4','KT2'),
------------------
('P08',N'Khá','1400000','60','0','4','KT2'),
('P09',N'TB','1000000','40','1','2','KT1'),
('P10',N'Tốt','2000000','75','0','4','KT3'),
('P11',N'TB','1200000','50','1','3','KT1'),
('P12',N'TB','1100000','50','1','2','KT2'),
('P13',N'Tốt','1700000','70','0','4','KT2'),
('P14',N'Tốt','2200000','75','0','4','KT2'),
('P15',N'Tốt','1900000','70','1','4','KT2'),
('P16',N'Tốt','1800000','65','1','4','KT2'),
-------------------
('P17',N'Tốt','2400000','80','0','4','KT3'),
('P18',N'Tốt','2000000','80','1','4','KT3'),
('P19',N'Tốt','1500000','60','0','4','KT3'),
('P20',N'Khá','1100000','60','1','3','KT3'),
('P21',N'Khá','1400000','65','1','3','KT3'),
('P22',N'TB','1300000','50','1','3','KT1'),
('P23',N'TB','1000000','50','0','2','KT3'),
('P24',N'TB','1000000','50','0','3','KT3')
GO

INSERT INTO KHUTRO VALUES
('KT1',N'Khu trọ A',N'Sư Vạn Hạnh, Phường 3, Quận 10'),
('KT2',N'Khu trọ B',N'285 An Dương Vương, Phường 4, Quận 5'),
('KT3',N'Khu trọ C',N'59 Điện Biên Phủ, Phường DaKao, Quận 3')
