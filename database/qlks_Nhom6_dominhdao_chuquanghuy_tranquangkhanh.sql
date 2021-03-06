USE [qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanh]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 06/15/2021 23:38:54 ******/
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
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'ad', N'123456', N'Đỗ Minh Đạo', N'minhdaodo2201@gamil.com', 1, 1)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'huy', N'123456', N'Chu Quang Huy', N'huy@gmail.com', 3, 1)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'khanh', N'123456', N'Trần Quang Khánh', N'huy@gmail.com', 1, 1)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'us', N'123456', N'Đỗ Minh Đạo', N'minhdaodo2201@gmail.com', 3, 1)
/****** Object:  Table [dbo].[phongban]    Script Date: 06/15/2021 23:38:54 ******/
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
INSERT [dbo].[phongban] ([mapb], [tenpb], [emailpb], [dienthoai]) VALUES (N'tg01           ', N'Kho', N'kho@gmail.com', N'0975352982')
INSERT [dbo].[phongban] ([mapb], [tenpb], [emailpb], [dienthoai]) VALUES (N'tg02           ', N'Massage', N'massage@gmail.com', N'0955555555')
INSERT [dbo].[phongban] ([mapb], [tenpb], [emailpb], [dienthoai]) VALUES (N'tg03           ', N'Xác thực', N'xacthuc@gmail.com', N'0987654321')
INSERT [dbo].[phongban] ([mapb], [tenpb], [emailpb], [dienthoai]) VALUES (N'tg04           ', N'Tiếp tân', N'tieptan@gmail.com', N'0988888888')
INSERT [dbo].[phongban] ([mapb], [tenpb], [emailpb], [dienthoai]) VALUES (N'tg05           ', N'Phục vụ', N'phucvu@gmail.com', N'0977777777')
/****** Object:  Table [dbo].[nhanvien]    Script Date: 06/15/2021 23:38:54 ******/
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
INSERT [dbo].[nhanvien] ([manhanvien], [hoten], [ngaysinh], [gioitinh], [quequan], [nambatdaulv], [luong], [mapb]) VALUES (N's01            ', N'Đỗ Minh Đạo', CAST(0x4A250B00 AS Date), N'Nam', N'Ninh Bình', CAST(0x7D410B00 AS Date), 88888, N'tg05           ')
INSERT [dbo].[nhanvien] ([manhanvien], [hoten], [ngaysinh], [gioitinh], [quequan], [nambatdaulv], [luong], [mapb]) VALUES (N's02            ', N'Chu Quang Huy', CAST(0xA2420B00 AS Date), N'Nam', N'Phú Thọ', CAST(0xA2420B00 AS Date), 30000, N'tg01           ')
INSERT [dbo].[nhanvien] ([manhanvien], [hoten], [ngaysinh], [gioitinh], [quequan], [nambatdaulv], [luong], [mapb]) VALUES (N's03            ', N'Trần Quang Khánh', CAST(0xA2420B00 AS Date), N'Nam', N'Nghệ An', CAST(0xA2420B00 AS Date), 30000, N'tg01           ')
INSERT [dbo].[nhanvien] ([manhanvien], [hoten], [ngaysinh], [gioitinh], [quequan], [nambatdaulv], [luong], [mapb]) VALUES (N's04            ', N'Nguyễn Bánh Bao', CAST(0xAC240B00 AS Date), N'Nữ', N'Hà Nam', CAST(0x95410B00 AS Date), 90000, N'tg03           ')
INSERT [dbo].[nhanvien] ([manhanvien], [hoten], [ngaysinh], [gioitinh], [quequan], [nambatdaulv], [luong], [mapb]) VALUES (N's05            ', N'Hồng Hi Đế', CAST(0xB0240B00 AS Date), N'Nam', N'Trung Quốc', CAST(0x883E0B00 AS Date), 11111, N'tg04           ')
/****** Object:  ForeignKey [FK__nhanvien__mapb__0519C6AF]    Script Date: 06/15/2021 23:38:54 ******/
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD FOREIGN KEY([mapb])
REFERENCES [dbo].[phongban] ([mapb])
GO
