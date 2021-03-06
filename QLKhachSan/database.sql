USE [qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanh]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 06/14/2021 20:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DangNhap](
	[Taikhoan] [varchar](20) NOT NULL,
	[Matkhau] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[phanquyen] [int] NULL,
	[trangthai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Taikhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'admin', N'123456', N'Đỗ Minh Đạo', N'minhdaodo2201@gmail.com', 1, 1)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'admin1', N'123456', N'Ð? Minh Ð?o', N'dao@gmail.com', 1, 1)
/****** Object:  Table [dbo].[phongban]    Script Date: 06/14/2021 20:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phongban](
	[mapb] [char](15) NOT NULL,
	[tenpb] [nvarchar](50) NULL,
	[emailpb] [varchar](50) NULL,
	[dienthoai] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[mapb] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[phongban] ([mapb], [tenpb], [emailpb], [dienthoai]) VALUES (N'tg01           ', N'Trần Văn Nam', N'namtv.sach@gmail.com', N'038612312')
INSERT [dbo].[phongban] ([mapb], [tenpb], [emailpb], [dienthoai]) VALUES (N'tg03           ', N'Lai Văn Xâm', N'namtv.sach@gmail.com', N'038612312')
INSERT [dbo].[phongban] ([mapb], [tenpb], [emailpb], [dienthoai]) VALUES (N'tg04           ', N'Mai Tài Hoa', N'namtv.sach@gmail.com', N'038612312')
INSERT [dbo].[phongban] ([mapb], [tenpb], [emailpb], [dienthoai]) VALUES (N'tg05           ', N'Ngô Bình Nam', N'namtv.sach@gmail.com', N'038612312')
/****** Object:  Table [dbo].[nhanvien]    Script Date: 06/14/2021 20:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manhanvien] [char](15) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](50) NULL,
	[quequan] [nvarchar](50) NULL,
	[nambatdaulv] [date] NULL,
	[luong] [int] NULL,
	[mapb] [char](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[nhanvien] ([manhanvien], [hoten], [ngaysinh], [gioitinh], [quequan], [nambatdaulv], [luong], [mapb]) VALUES (N's01            ', N'Đỗ Minh Đạo', CAST(0x4A250B00 AS Date), N'Nam', N'Ninh Bình', CAST(0x7D410B00 AS Date), 30000, N'tg05           ')
INSERT [dbo].[nhanvien] ([manhanvien], [hoten], [ngaysinh], [gioitinh], [quequan], [nambatdaulv], [luong], [mapb]) VALUES (N's02            ', N'ádsad', CAST(0xA2420B00 AS Date), N'Nam', N'sd', CAST(0xA2420B00 AS Date), 123, N'tg01           ')
INSERT [dbo].[nhanvien] ([manhanvien], [hoten], [ngaysinh], [gioitinh], [quequan], [nambatdaulv], [luong], [mapb]) VALUES (N's03            ', N'sadasd', CAST(0xA2420B00 AS Date), N'Nữ', N'sad', CAST(0xA2420B00 AS Date), 2435, N'tg01           ')
/****** Object:  ForeignKey [FK__nhanvien__mapb__0519C6AF]    Script Date: 06/14/2021 20:26:12 ******/
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD FOREIGN KEY([mapb])
REFERENCES [dbo].[phongban] ([mapb])
GO
