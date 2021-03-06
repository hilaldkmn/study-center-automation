/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2014 (12.0.2000)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [proje]
GO
/****** Object:  Table [dbo].[adminn]    Script Date: 27.12.2018 23:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adminn](
	[kullanıcı] [varchar](50) NULL,
	[sifre] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogrenci]    Script Date: 27.12.2018 23:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrenci](
	[numara] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[ders] [nvarchar](50) NULL,
	[ücreti] [nvarchar](50) NULL,
	[ögretmen] [nvarchar](50) NULL,
	[töplam_devamsizlik] [nvarchar](50) NULL,
	[yorum] [nvarchar](max) NULL,
	[gün] [nvarchar](50) NULL,
	[saat] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ögretmen]    Script Date: 27.12.2018 23:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ögretmen](
	[isim] [nvarchar](50) NULL,
	[soyisim] [nvarchar](50) NULL,
	[ders] [nvarchar](50) NULL,
	[kullanıcı_ismi] [nvarchar](50) NULL,
	[sifre] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[adminn] ([kullanıcı], [sifre]) VALUES (N'admin', N'123456')
SET IDENTITY_INSERT [dbo].[ogrenci] ON 

INSERT [dbo].[ogrenci] ([numara], [ad], [soyad], [ders], [ücreti], [ögretmen], [töplam_devamsizlik], [yorum], [gün], [saat]) VALUES (2, N'elif', N'sahin', N'fen', N'2000', N'ayse ay', N'1', N'Başarılı ama dersi dinlemiyor', N'cuma', N'14:00')
INSERT [dbo].[ogrenci] ([numara], [ad], [soyad], [ders], [ücreti], [ögretmen], [töplam_devamsizlik], [yorum], [gün], [saat]) VALUES (3, N'nazli', N'altin', N'türkce', N'2000', N'selami kanar', N'0', N'Başarılı ve ödevlerini yapıyor', N'cumartesi', N'14:00')
INSERT [dbo].[ogrenci] ([numara], [ad], [soyad], [ders], [ücreti], [ögretmen], [töplam_devamsizlik], [yorum], [gün], [saat]) VALUES (4, N'nilüfer', N'silemek', N'sosyal', N'2000', N'hava kaf', N'3', N'Başarılı ve ödevlerini yapıyor', N'pazar', N'14:00')
INSERT [dbo].[ogrenci] ([numara], [ad], [soyad], [ders], [ücreti], [ögretmen], [töplam_devamsizlik], [yorum], [gün], [saat]) VALUES (5, N'selin', N'dursun', N'fen', N'2000', N'ayse ay', N'2', N'Başarılı ama derse kendini vermiyor', N'cuma', N'16:00')
INSERT [dbo].[ogrenci] ([numara], [ad], [soyad], [ders], [ücreti], [ögretmen], [töplam_devamsizlik], [yorum], [gün], [saat]) VALUES (6, N'sevde', N'kilic', N'matematik', N'2000', N'selda yildiz', N'0', N'Başarılı', N'salı', N'16:00')
INSERT [dbo].[ogrenci] ([numara], [ad], [soyad], [ders], [ücreti], [ögretmen], [töplam_devamsizlik], [yorum], [gün], [saat]) VALUES (20, N'Hilal', N'Dikman', N'Sosyal', N'1000', N'Hava Kaf', NULL, NULL, N'Pazar', N'20:00')
SET IDENTITY_INSERT [dbo].[ogrenci] OFF
INSERT [dbo].[ögretmen] ([isim], [soyisim], [ders], [kullanıcı_ismi], [sifre]) VALUES (N'selda', N'yildiz', N'matematik', N'selday', 123456)
INSERT [dbo].[ögretmen] ([isim], [soyisim], [ders], [kullanıcı_ismi], [sifre]) VALUES (N'ayse', N'ay', N'fen', N'aysea', 123456)
INSERT [dbo].[ögretmen] ([isim], [soyisim], [ders], [kullanıcı_ismi], [sifre]) VALUES (N'selami', N'kanar', N'türkçe', N'selamik', 123456)
INSERT [dbo].[ögretmen] ([isim], [soyisim], [ders], [kullanıcı_ismi], [sifre]) VALUES (N'hava', N'kaf', N'sosyal', N'havak', 123456)
