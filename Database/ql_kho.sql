USE [master]

CREATE DATABASE [QLKho]
go

use [QLKho]

CREATE TABLE [dbo].[HANG](
	[MaHang] [char](10) NOT NULL primary key,
	[TenHang] [nvarchar](50) NULL,
	[KhoiLuong] [float] NULL,
	[GiaTri] [int] NULL,
	[DaXuat] [bit] NULL,
)
GO

CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieu] [char](10) NOT NULL primary key,
	[MaHang] [char](10) NULL,
	[TGNhap] [datetime] NULL,
	[NhaSanXuat] [nvarchar](50) NULL,
)
GO

CREATE TABLE [dbo].[PHIEUXUAT](
	[MaPhieu] [char](10) NOT NULL primary key,
	[MaHang] [char](10) NULL,
	[NgayXuat] [datetime] NULL,
	[NoiNhap] [nvarchar](50) NULL,
)
ALTER TABLE [dbo].[PHIEUNHAP] ADD  CONSTRAINT [FK_PHIEUNHAP_HANG] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANG] ([MaHang])
GO

ALTER TABLE [dbo].[PHIEUXUAT]   ADD  CONSTRAINT [FK_PHIEUXUAT_HANG] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANG] ([MaHang])

INSERT INTO HANG VALUES
	('MH0001', 'CPU', 2, 900000, 0),
	('MH0002', 'RAM', 20, 6900000, 0),
	('MH0003', 'Tản nhiệt', 5, 1800000, 1),
	('MH0004', 'Màn hình', 10, 26000000, 0),
	('MH0005', 'Nguồn', 6, 3900000, 1)

INSERT INTO PHIEUNHAP VALUES
	('PN0001', 'MH0001', '20210220', N'In theo'),
	('PN0002', 'MH0002', '20210223', N'Coọc se'),
	('PN0003', 'MH0003', '20210120', N'Cun lờ mát tơ'),
	('PN0004', 'MH0004', '20210303', N'Đeo'),
	('PN0005', 'MH0005', '20210131', N'Ây sớt')

INSERT INTO PHIEUXUAT VALUES
	('PX0001', 'MH0001', '20210221', 'AnhTu.VN'),
	('PX0002', 'MH0002', '20210224', 'ThanhTungMobile'),
	('PX0003', 'MH0003', '20210124', 'DienMayHieuNguyen'),
	('PX0004', 'MH0004', '20210306', 'DoanHungComputer'),
	('PX0005', 'MH0005', '20210212', 'KienMacPC')

GO
create procedure [dbo].[selectAllPhieuNhap]
as
	select MaPhieu, MaHang, convert(varchar(10),TGNhap,103) as TGNhap, NhaSanXuat
	from PHIEUNHAP

go
CREATE procedure [dbo].[ThemMoiPhieuNhap] 
	@MaPhieu nvarchar(50),
	@TGNhap datetime,
	@NhaSanXuat nvarchar(100),
	@MaHang char(10)
as
begin
insert into PhieuNhap
	(
		MaPhieu,TGNhap,NhaSanXuat,MaHang
	)values(
		@MaPhieu,
		@TGNhap,
		@NhaSanXuat,
		@MaHang
		);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end

GO
CREATE PROCEDURE SelectAllPhieuXuat
AS
	SELECT MaPhieu, MaHang, NgayXuat, NoiNhap
	FROM PHIEUXUAT

GO
CREATE PROCEDURE [dbo].[ThemMoiPhieuXuat]
	@MaPhieu CHAR(10),
	@MaHang CHAR(10),
	@NgayXuat DATETIME,
	@NoiNhap NVARCHAR(50)
as
begin
insert into PHIEUXUAT
	(
		MaPhieu, MaHang, NgayXuat, NoiNhap
	)values(
		@MaPhieu,
		@MaHang,
		@NgayXuat,
		@NoiNhap
		);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end