USE [master]

CREATE DATABASE [QLKho]
go

use [QLKho]

CREATE TABLE [dbo].[HANG](
	[MaHang] [char](10) NOT NULL primary key,
	[TenHang] [nvarchar](50) NULL,
	[KhoiLuong] [float] NULL,
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

