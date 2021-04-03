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
GO


create procedure [dbo].[selectAllPhieuNhap]
as
	select MaPhieu, MaHang, convert(varchar(10),TGNhap,103) as TGNhap, NhaSanXuat
	from PHIEUNHAP
go

	alter procedure [dbo].[ThemMoiPhieuNhap] 
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
