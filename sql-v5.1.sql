USE [master]
GO
/****** Object:  Database [QLKS]    Script Date: 21/01/2021 8:08:52 SA ******/
CREATE DATABASE [QLKS]
GO
ALTER DATABASE [QLKS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLKS]
GO
/****** Object:  Table [dbo].[CHI_TIET_HOA_DON]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHI_TIET_HOA_DON](
	[MaHoaDon] [varchar](5) NOT NULL,
	[MaThuePhong] [varchar](5) NOT NULL,
	[TienPhong] [bigint] NULL,
	[TienDichVu] [bigint] NULL,
	[SoNgay] [int] NULL,
	[ThanhTien] [bigint] NULL,
 CONSTRAINT [PK_CHI_TIET_HOA_DON_1] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHI_TIET_PHIEU_SUA_CHUA]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHI_TIET_PHIEU_SUA_CHUA](
	[MaPhieuSua] [varchar](5) NOT NULL,
	[MaThietBi] [varchar](5) NOT NULL,
	[PhiSuaChua] [bigint] NULL,
 CONSTRAINT [PK__CHI_TIET__BF47AD319FA6A88B] PRIMARY KEY CLUSTERED 
(
	[MaPhieuSua] ASC,
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHI_TIET_PHIEU_THUE_PHONG]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHI_TIET_PHIEU_THUE_PHONG](
	[MaThuePhong] [varchar](5) NOT NULL,
	[MaPhong] [varchar](5) NOT NULL,
	[MaKhachHang] [varchar](5) NOT NULL,
	[HoTenKhachHang] [nvarchar](50) NOT NULL,
	[CMND] [varchar](10) NULL,
	[NgayNhan] [datetime] NULL,
	[NgayTraDuKien] [datetime] NULL,
	[NgayTra] [datetime] NULL,
 CONSTRAINT [PK_CHI_TIET_PHIEU_NHAN_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaThuePhong] ASC,
	[MaPhong] ASC,
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUC_VU]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUC_VU](
	[MaChucVu] [varchar](5) NOT NULL,
	[TenChucVu] [nvarchar](30) NULL,
	[HeSoLuong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANH_SACH_SU_DUNG_DICH_VU]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANH_SACH_SU_DUNG_DICH_VU](
	[MaThuePhong] [varchar](5) NOT NULL,
	[MaDichVu] [varchar](5) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_DANH_SACH_SU_DUNG_DICH_VU] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC,
	[MaThuePhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DICH_VU]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DICH_VU](
	[MaDichVu] [varchar](5) NOT NULL,
	[TenDichVu] [nvarchar](50) NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK__DICH_VU__C0E6DE8F4165291B] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOA_DON]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOA_DON](
	[MaHoaDon] [varchar](5) NOT NULL,
	[MaThuePhong] [varchar](5) NOT NULL,
	[MaNhanVien] [varchar](5) NULL,
	[TongTien] [bigint] NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_HOA_DON_1] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[MaKhachHang] [varchar](5) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[CMND] [varchar](10) NOT NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [varchar](10) NULL,
 CONSTRAINT [PK__KHACH_HA__88D2F0E517F418FD] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAI_PHONG]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAI_PHONG](
	[MaLoaiPhong] [varchar](5) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
	[SoNguoiLonToiDa] [int] NULL,
	[SoTreEmToiDa] [int] NULL,
	[SoNguoiToiDa] [int] NULL,
	[TongSoPhong] [int] NULL,
	[MoTa] [nvarchar](max) NULL,
	[DonGia] [float] NULL,
	[Tang] [int] NULL,
 CONSTRAINT [PK__LOAI_PHO__23021217F04574EA] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAI_TINH_TRANG]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAI_TINH_TRANG](
	[MaLoaiTinhTrangPhong] [varchar](5) NOT NULL,
	[TenLoaiTinhTrangPhong] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiTinhTrangPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOI_DUNG]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOI_DUNG](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[MaChucVu] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[MaNhanVien] [varchar](5) NOT NULL,
	[MaChucVu] [varchar](5) NULL,
	[HoTen] [nvarchar](30) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[ChucVu] [nvarchar](30) NULL,
 CONSTRAINT [PK__NHAN_VIE__77B2CA4797A06D72] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEU_SUA_CHUA]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEU_SUA_CHUA](
	[MaPhieuSua] [varchar](5) NOT NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[MaNhanVien] [varchar](5) NULL,
	[MaPhong] [varchar](5) NULL,
	[NguyenNhan] [nvarchar](max) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK__PHIEU_SU__1D4C78D426873A9C] PRIMARY KEY CLUSTERED 
(
	[MaPhieuSua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEU_THUE_PHONG]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEU_THUE_PHONG](
	[MaThuePhong] [varchar](5) NOT NULL,
	[MaNhanVien] [varchar](5) NULL,
	[MaKhachHang] [varchar](5) NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK__PHIEU_TH__4859A878FB9FB3D0] PRIMARY KEY CLUSTERED 
(
	[MaThuePhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [varchar](5) NOT NULL,
	[MaLoaiPhong] [varchar](5) NULL,
	[MaLoaiTinhTrangPhong] [varchar](5) NULL,
	[GhiChu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SO_HUU_THIET_BI]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SO_HUU_THIET_BI](
	[MaPhong] [varchar](5) NOT NULL,
	[MaThietBi] [varchar](5) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_SO_HUU_THIET_BI] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC,
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THIET_BI]    Script Date: 21/01/2021 8:08:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THIET_BI](
	[MaThietBi] [varchar](5) NOT NULL,
	[TenThietBi] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaHoaDon], [MaThuePhong], [TienPhong], [TienDichVu], [SoNgay], [ThanhTien]) VALUES (N'HD001', N'TP001', 5700000, 1800000, 19, 7500000)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaHoaDon], [MaThuePhong], [TienPhong], [TienDichVu], [SoNgay], [ThanhTien]) VALUES (N'HD002', N'TP014', 1000000, 0, 1, 1000000)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaHoaDon], [MaThuePhong], [TienPhong], [TienDichVu], [SoNgay], [ThanhTien]) VALUES (N'HD003', N'TP013', 3000000, 1518000000, 2, 1521000000)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaHoaDon], [MaThuePhong], [TienPhong], [TienDichVu], [SoNgay], [ThanhTien]) VALUES (N'HD004', N'TP012', 1200000, 15000000, 4, 16200000)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaHoaDon], [MaThuePhong], [TienPhong], [TienDichVu], [SoNgay], [ThanhTien]) VALUES (N'HD005', N'TP010', 6000000, 50000000, 12, 56000000)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaHoaDon], [MaThuePhong], [TienPhong], [TienDichVu], [SoNgay], [ThanhTien]) VALUES (N'HD007', N'TP002', 9500000, 2500000, 19, 12000000)
INSERT [dbo].[CHI_TIET_HOA_DON] ([MaHoaDon], [MaThuePhong], [TienPhong], [TienDichVu], [SoNgay], [ThanhTien]) VALUES (N'HD008', N'TP015', 2000000, 20000000000, 1, 20002000000)
INSERT [dbo].[CHI_TIET_PHIEU_SUA_CHUA] ([MaPhieuSua], [MaThietBi], [PhiSuaChua]) VALUES (N'PS001', N'TB01', 900000)
INSERT [dbo].[CHI_TIET_PHIEU_SUA_CHUA] ([MaPhieuSua], [MaThietBi], [PhiSuaChua]) VALUES (N'PS002', N'TB01', 10000000)
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP001', N'1501', N'KH001', N'Trần Văn Lâm', N'261590453', CAST(N'2020-01-01 00:00:00.000' AS DateTime), CAST(N'2020-01-03 00:00:00.000' AS DateTime), CAST(N'2021-01-19 15:23:24.683' AS DateTime))
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP002', N'1505', N'KH003', N'Lại Thị Tiên', N'261879009', CAST(N'2020-02-02 00:00:00.000' AS DateTime), CAST(N'2020-02-03 00:00:00.000' AS DateTime), CAST(N'2021-01-20 09:33:25.373' AS DateTime))
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP004', N'1502', N'KH002', N'Lê Thị Lợi', N'13487901', CAST(N'2020-10-04 00:00:00.000' AS DateTime), CAST(N'2020-10-06 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP005', N'1503', N'KH010', N'EVA', N'32139221', CAST(N'2020-11-05 00:00:00.000' AS DateTime), CAST(N'2020-11-09 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP006', N'1508', N'KH006', N'Nguyễn Tấn Quyền', N'11198788', CAST(N'2020-06-06 00:00:00.000' AS DateTime), CAST(N'2020-06-07 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP007', N'1509', N'KH008', N'Nguyễn Thị Nhi', N'340091177', CAST(N'2020-04-06 00:00:00.000' AS DateTime), CAST(N'2020-04-08 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP008', N'1504', N'KH009', N'Steve job', N'43620916', CAST(N'2020-08-08 00:00:00.000' AS DateTime), CAST(N'2020-08-10 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP010', N'1510', N'KH005', N'Nguyễn Quang Huy', N'21199234', CAST(N'2020-09-09 00:00:00.000' AS DateTime), CAST(N'2020-09-15 00:00:00.000' AS DateTime), CAST(N'2021-01-20 09:14:26.373' AS DateTime))
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP012', N'1501', N'KH001', N'Trần Văn Lâm', N'261590453', CAST(N'2021-01-17 00:00:00.000' AS DateTime), CAST(N'2021-01-26 00:00:00.000' AS DateTime), CAST(N'2021-01-20 09:11:28.990' AS DateTime))
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP013', N'1521', N'KH001', N'Trần Văn Lâm', N'261590453', CAST(N'2021-01-19 00:00:00.000' AS DateTime), CAST(N'2021-01-21 00:00:00.000' AS DateTime), CAST(N'2021-01-20 09:11:08.713' AS DateTime))
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP014', N'1506', N'KH001', N'Trần Văn Lâm', N'261590453', CAST(N'2021-01-19 00:00:00.000' AS DateTime), CAST(N'2021-01-22 00:00:00.000' AS DateTime), CAST(N'2021-01-19 16:03:19.057' AS DateTime))
INSERT [dbo].[CHI_TIET_PHIEU_THUE_PHONG] ([MaThuePhong], [MaPhong], [MaKhachHang], [HoTenKhachHang], [CMND], [NgayNhan], [NgayTraDuKien], [NgayTra]) VALUES (N'TP015', N'1514', N'KH001', N'Trần Văn Lâm', N'261590453', CAST(N'2021-01-20 00:00:00.000' AS DateTime), CAST(N'2021-01-20 00:00:00.000' AS DateTime), CAST(N'2021-01-20 22:09:17.257' AS DateTime))
INSERT [dbo].[CHUC_VU] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'CV001', N'Lễ Tân', 2.3)
INSERT [dbo].[CHUC_VU] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'CV002', N'Giám sát lễ tân', 2.5)
INSERT [dbo].[CHUC_VU] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'CV004', N'IT HelpDesk', 3.2)
INSERT [dbo].[CHUC_VU] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'CV005', N'Nhân viên bảo vệ', 2.5)
INSERT [dbo].[CHUC_VU] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'CV006', N'Nhân viên kỹ thuật', 3)
INSERT [dbo].[CHUC_VU] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'CV007', N'Trưởng phòng nhân sự', 4)
INSERT [dbo].[CHUC_VU] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'CV008', N'Nhân viên kế toán', 3)
INSERT [dbo].[CHUC_VU] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'CV010', N'Nhân viên vệ sinh', 2)
INSERT [dbo].[CHUC_VU] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'CV011', N'Nhân viên buồng phòng', 2.2)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP006', N'BAR', 1)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP007', N'BAR', 2)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP013', N'BAR', 2)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP001', N'BIA01', 5)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP001', N'BIA02', 1)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP006', N'BIA03', 10)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP006', N'BIA04', 1)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP006', N'BIA07', 1)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP004', N'BIA10', 24)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP007', N'BIA10', 20)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP002', N'GK01', 2)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP002', N'GK03', 1)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP005', N'GK05', 3)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP012', N'GK06', 50)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP006', N'GK07', 2)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP004', N'GK09', 4)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP013', N'GK09', 1000)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP010', N'GK11', 100)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP005', N'GK12', 1)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP015', N'GK13', 10000)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP002', N'GYM', 2)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP013', N'GYM', 10)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP005', N'MOV', 2)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP006', N'MOV', 2)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP007', N'MOV', 2)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP005', N'NET', 1)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP004', N'PA03', 3)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP005', N'POL', 7)
INSERT [dbo].[DANH_SACH_SU_DUNG_DICH_VU] ([MaThuePhong], [MaDichVu], [SoLuong]) VALUES (N'TP006', N'TEN', 2)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BAR', N'Bar', N'Vé', 1200000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BIA01', N'Bia Tiger Lon', N'Lon', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BIA02', N'Bia Sài gòn Lon', N'Lon', 13000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BIA03', N'Bia 333 Lon', N'Lon', 11000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BIA04', N'Bia Heniken Lon', N'Lon', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BIA05', N'Bia Corona Lon', N'Lon', 40000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BIA06', N'Bia Tiger Chai', N'Chai', 25000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BIA07', N'Bia Heniken Chai', N'Chai', 25000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BIA08', N'Bia Corona Chai', N'Chai', 50000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BIA09', N'Bia 333 Chai', N'Chai', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BIA10', N'Bia Sài gòn Chai', N'Chai', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'BIDA', N'Chơi Bida', N'Vé', 200000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK01', N'Nước khoáng', N'Chai', 10000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK02', N'Sting', N'Chai', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK03', N'Coca-Cola', N'Chai', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK04', N'Pepsi', N'Chai', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK05', N'Number One', N'Chai', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK06', N'Trà xanh 0 độ', N'Chai', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK07', N'Trà xanh C2', N'Chai', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK08', N'7Up', N'Chai', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK09', N'Cam ép Twister', N'Chai', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK10', N'Sting', N'Lon', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK11', N'Coca-Cola', N'Lon', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK12', N'Pepsi', N'Lon', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GK13', N'Bò húc', N'Lon', 30000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'GYM', N'Gym', N'Vé', 300000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'MOV', N'Xem phim', N'Vé', 250000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'MS', N'Massage
', N'Vé', 1000000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'NET', N'Chơi net', N'Giờ', 20000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'PA01', N'Phần ăn sáng', N'Phần', 300000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'PA02', N'Phần ăn trưa', N'Phần', 400000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'PA03', N'Phần ăn tối', N'Phần', 400000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'POL', N'Bơi lội', N'Vé', 500000)
INSERT [dbo].[DICH_VU] ([MaDichVu], [TenDichVu], [DonViTinh], [DonGia]) VALUES (N'TEN', N'Chơi tenis', N'Vé', 600000)
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD001', N'TP001', N'NV002', 7500000, CAST(N'2021-01-19 15:23:24.897' AS DateTime))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD002', N'TP014', N'NV002', 1000000, CAST(N'2021-01-19 16:03:19.087' AS DateTime))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD003', N'TP013', N'NV002', 1521000000, CAST(N'2021-01-20 09:11:08.840' AS DateTime))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD004', N'TP012', N'NV002', 16200000, CAST(N'2021-01-20 09:11:29.027' AS DateTime))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD005', N'TP010', N'NV001', 56000000, CAST(N'2021-01-20 09:14:26.473' AS DateTime))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD007', N'TP002', N'NV001', 12000000, CAST(N'2021-01-20 09:33:25.597' AS DateTime))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [MaNhanVien], [TongTien], [NgayLap]) VALUES (N'HD008', N'TP015', N'NV002', 20002000000, CAST(N'2021-01-20 22:09:17.587' AS DateTime))
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH001', N'Trần Văn Lâm', N'Nam', N'261590453', CAST(N'1987-02-22 00:00:00.000' AS DateTime), N'132/8A Âu Cơ', N'0917565841')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH002', N'Lê Thị Lợi', N'Nữ', N'013487901', CAST(N'1988-04-26 00:00:00.000' AS DateTime), N'267/3D Hồng Bàng', N'0978324153')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH003', N'Lại Thị Tiên', N'Nữ', N'261879009', CAST(N'1997-04-02 00:00:00.000' AS DateTime), N'Số 1,Trần Hưng Đạo, Phan Thiết', N'0127893242')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH005', N'Nguyễn Quang Huy', N'Nam', N'021199234', CAST(N'1976-11-18 00:00:00.000' AS DateTime), N'475A Điện Biên Phủ, Bình Thạnh', N'0918063669')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH006', N'Nguyễn Tấn Quyền', N'Nam', N'011198788', CAST(N'2000-07-21 00:00:00.000' AS DateTime), N'18 Hoàng Diệu', N'0121777102')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH008', N'Nguyễn Thị Nhi', N'Nữ', N'340091177', CAST(N'1996-01-31 00:00:00.000' AS DateTime), N' 168/5F, Mỹ Quí, Đồng Tháp', N'0273824128')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH009', N'Steve job', N'Nam', N'043620916', CAST(N'1955-02-24 00:00:00.000' AS DateTime), N'1010 Pennsylvania Ave S. E., Southeast', N'3246591729')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH010', N'Mariaodawa', N'Nữ', N'032139221', CAST(N'1974-06-26 00:00:00.000' AS DateTime), N'25 Laycock Street, Surfers Paradise', N'2134237561')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH011', N'LisaBrennan', N'Nữ', N'212139221', CAST(N'1983-07-26 00:00:00.000' AS DateTime), N' 7 East 27th Street, NoMad,', N'4634532561')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH012', N'TimCook', N'Nam', N'477936947', CAST(N'1960-11-01 00:00:00.000' AS DateTime), N'234 Holywood, Mobile', N'2362646284')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH013', N'Ma Yun', N'Nam', N'327936653', CAST(N'1964-09-10 00:00:00.000' AS DateTime), N'146 Tây Cửu Long', N'0352446233')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH014', N'Stephen Hawking', N'Nam', N'645424341', CAST(N'1987-01-08 00:00:00.000' AS DateTime), N'Bolsover Street', N'8290381802')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH015', N'Priscilla Chan', N'Nữ', N'423123255', CAST(N'1985-02-24 00:00:00.000' AS DateTime), N'152/4G BrainTree', N'2137198724')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH016', N'Kim Ji-soo', N'Nữ', N'092317276', CAST(N'1995-01-03 00:00:00.000' AS DateTime), N'Gunpo,Gyeonggi-do', N'3213957322')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH017', N'Lisa', N'Nữ', N'461876294', CAST(N'1997-03-27 00:00:00.000' AS DateTime), N'123/3D Burriam', N'0912317822')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH018', N'Trần Hoài An', N'Nam', N'218736127', CAST(N'2000-08-21 00:00:00.000' AS DateTime), N'315 Nguyễn Thị Định, Phú Hưng', N'0842838490')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH019', N'Dương Quốc Việt', N'Nam', N'923241241', CAST(N'1974-03-12 00:00:00.000' AS DateTime), N'247A Lý Thường Kiệt', N'0918236812')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH020', N'Mikami Yua', N'Nữ', N'092367123', CAST(N'1993-08-16 00:00:00.000' AS DateTime), N'743A/3F Aichi', N'0923712642')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH021', N'Abe', N'Nam', N'231321321', CAST(N'2021-01-15 00:00:00.000' AS DateTime), N'Binh phuoc', N'0131232131')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhachHang], [GioiTinh], [CMND], [NgaySinh], [DiaChi], [DienThoai]) VALUES (N'KH022', N'Dương Quốc Nam', N'Nam', N'123213213', CAST(N'2021-01-20 00:00:00.000' AS DateTime), N'ádqưeqưe', N'0131231231')
INSERT [dbo].[LOAI_PHONG] ([MaLoaiPhong], [TenLoaiPhong], [SoNguoiLonToiDa], [SoTreEmToiDa], [SoNguoiToiDa], [TongSoPhong], [MoTa], [DonGia], [Tang]) VALUES (N'BR', N'Phòng Hướng biển', 2, 1, 3, 10, NULL, 1500000, 4)
INSERT [dbo].[LOAI_PHONG] ([MaLoaiPhong], [TenLoaiPhong], [SoNguoiLonToiDa], [SoTreEmToiDa], [SoNguoiToiDa], [TongSoPhong], [MoTa], [DonGia], [Tang]) VALUES (N'DLX', N'Phòng VIP 2', 2, 1, 3, 10, NULL, 1000000, 3)
INSERT [dbo].[LOAI_PHONG] ([MaLoaiPhong], [TenLoaiPhong], [SoNguoiLonToiDa], [SoTreEmToiDa], [SoNguoiToiDa], [TongSoPhong], [MoTa], [DonGia], [Tang]) VALUES (N'FR', N'Phòng Gia đình', 4, 2, 6, 8, NULL, 1200000, 2)
INSERT [dbo].[LOAI_PHONG] ([MaLoaiPhong], [TenLoaiPhong], [SoNguoiLonToiDa], [SoTreEmToiDa], [SoNguoiToiDa], [TongSoPhong], [MoTa], [DonGia], [Tang]) VALUES (N'STD', N'Phòng Tiêu chuẩn', 2, 2, 4, 15, NULL, 300000, 1)
INSERT [dbo].[LOAI_PHONG] ([MaLoaiPhong], [TenLoaiPhong], [SoNguoiLonToiDa], [SoTreEmToiDa], [SoNguoiToiDa], [TongSoPhong], [MoTa], [DonGia], [Tang]) VALUES (N'SUP', N'Phòng VIP 1', 2, 1, 3, 10, NULL, 500000, 3)
INSERT [dbo].[LOAI_PHONG] ([MaLoaiPhong], [TenLoaiPhong], [SoNguoiLonToiDa], [SoTreEmToiDa], [SoNguoiToiDa], [TongSoPhong], [MoTa], [DonGia], [Tang]) VALUES (N'SUT', N'Phòng Hoàng gia', 2, 1, 3, 5, NULL, 2000000, 5)
INSERT [dbo].[LOAI_TINH_TRANG] ([MaLoaiTinhTrangPhong], [TenLoaiTinhTrangPhong]) VALUES (N'TP001', N'Phòng trống')
INSERT [dbo].[LOAI_TINH_TRANG] ([MaLoaiTinhTrangPhong], [TenLoaiTinhTrangPhong]) VALUES (N'TP002', N'Phòng đang sửa chửa')
INSERT [dbo].[LOAI_TINH_TRANG] ([MaLoaiTinhTrangPhong], [TenLoaiTinhTrangPhong]) VALUES (N'TP003', N'Phòng đang thuê')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'1', N'1', N'CV001')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'2', N'2', N'CV002')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'4', N'4', N'CV004')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'6', N'6', N'CV006')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'7', N'7', N'CV007')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'8', N'8', N'CV008')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'buithanhhang', N'hang123', N'CV001')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'caovantrien', N'trien123', N'CV011')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'dangthilehang', N'lehang123', N'CV008')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'dangthileroi', N'leroi123', N'CV011')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'duongquocnam', N'nam123', N'CV002')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'duongtrieuvu', N'vu123', N'CV001')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'hoanglan', N'lan123', N'CV001')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'hoangnhungoc', N'ngoc123', N'CV002')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'lehuunghia', N'nghia123', N'CV006')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'mauthithanhthuy', N'thanhthuy123', N'CV007')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'nguyenminhquang', N'quang123', N'CV005')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'nguyenngocthuong', N'thuong123', N'CV006')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'nguyenphuockhoi', N'khoi123', N'CV005')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'nguyenquocbao', N'bao123', N'CV008')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'nguyenthikimdung', N'kimdung123', N'CV011')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'nguyenthingocnu', N'nu123', N'CV008')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'phammyhanh', N'hanh123', N'CV010')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'phamthimytien', N'tien123', N'CV010')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'phamvantruong', N'truong123', N'CV010')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'phanhuynhnguyenvu', N'nguyenvu123', N'CV005')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'tranhoaian', N'an123', N'CV005')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'trannhattan', N'tan123', N'CV004')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'truongtuantu', N'tu123', N'CV011')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'voductinh', N'tinh123', N'CV006')
INSERT [dbo].[NGUOI_DUNG] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'vuvanhung', N'hung123', N'CV010')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV001', N'CV001', N'Bùi Thanh Hằng', CAST(N'1998-01-01 00:00:00.000' AS DateTime), N'Nữ', N'Cầu giấy, Hà Nội', N'0917686873', N'Lễ Tân')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV002', N'CV001', N'Hoàng Lan', CAST(N'1997-02-01 00:00:00.000' AS DateTime), N'Nữ', N'Bình Thạnh, TP.HCM', N'0917686970', N'Lễ Tân')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV004', N'CV002', N'Hoàng Như Ngọc', CAST(N'1990-02-22 00:00:00.000' AS DateTime), N'Nữ', N'Ninh Kiều, Cần Thơ', N'0375658412', N'Giám sát lễ tân')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV005', N'CV002', N'Dương Quốc Nam', CAST(N'1995-02-22 00:00:00.000' AS DateTime), N'Nam', N'Cái Bè, Tiền Giang', N'0978925541', N'Giám sát lễ tân')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV009', N'CV004', N'Trần Nhựt Tân', CAST(N'2000-12-04 00:00:00.000' AS DateTime), N'Nam', N'Cai Lậy, Tiền Giang', N'0392690012', N'Nhân viên IT')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV011', N'CV005', N'Trần Hoài An', CAST(N'1980-05-05 00:00:00.000' AS DateTime), N'Nam', N'Mỏ Cày Nam, Bến Tre', N'0931218642', N'Nhân viên bảo vệ')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV012', N'CV005', N'Phan Huỳnh Nguyên Vũ', CAST(N'1975-05-09 00:00:00.000' AS DateTime), N'Nam', N'Nhà Bè, TP.HCM', N'0163853864', N'Nhân viên bảo vệ')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV013', N'CV005', N'Nguyễn Phước Khôi', CAST(N'1979-01-11 00:00:00.000' AS DateTime), N'Nam', N'Châu Đốc, An Giang', N'0169363866', N'Nhân viên bảo vệ')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV014', N'CV005', N'Nguyễn Minh Quang', CAST(N'1981-02-21 00:00:00.000' AS DateTime), N'Nam', N'Biên Hòa, Đồng Nai', N'0169366469', N'Nhân viên bảo vệ')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV015', N'CV006', N'Lê Hữu Nghĩa', CAST(N'2000-01-09 00:00:00.000' AS DateTime), N'Nam', N'Tây Ninh', N'0163694728', N'Nhân viên kỹ thuật')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV016', N'CV006', N'Võ Đức Tính', CAST(N'2000-02-15 00:00:00.000' AS DateTime), N'Nam', N'Bình Tân, TP.HCM', N'0193612762', N'Nhân viên kỹ thuật')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV017', N'CV006', N'Nguyễn Ngọc Thương', CAST(N'2000-09-09 00:00:00.000' AS DateTime), N'Nam', N'Phú Nhuận, TP.HCM', N'0681198412', N'Nhân viên kỹ thuật')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV018', N'CV007', N'Mâu Thị Thanh Thủy', CAST(N'1997-12-23 00:00:00.000' AS DateTime), N'Nữ', N'Tân Bình, TP.HCM', N'0918063669', N'Trưởng phòng nhân sự')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV019', N'CV008', N'Nguyễn Thị Ngọc Nữ', CAST(N'1994-10-23 00:00:00.000' AS DateTime), N'Nữ', N'Quận 3, TP.HCM', N'0919043275', N'Nhân viên kế toán')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV020', N'CV008', N'Đặng Thị Lệ Hằng', CAST(N'2000-01-23 00:00:00.000' AS DateTime), N'Nữ', N'Quận 3, TP.HCM', N'0517898952', N'Nhân viên kế toán')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV021', N'CV008', N'Nguyễn Quốc Bảo', CAST(N'2001-02-28 00:00:00.000' AS DateTime), N'Nam', N'Quận 10,TP.HCM', N'0978925531', N'Nhân viên kế toán')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV023', N'CV010', N'Phạm Thị Mỹ Tiên', CAST(N'1985-05-05 00:00:00.000' AS DateTime), N'Nữ', N'Chợ Gạo, Tiền Giang', N'0372427531', N'Nhân viên vệ sinh')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV024', N'CV010', N'Phạm Văn Trường', CAST(N'1995-01-15 00:00:00.000' AS DateTime), N'Nam', N'Hòa Hưng, Vĩnh Long', N'0217972000', N'Nhân viên vệ sinh')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV025', N'CV010', N'Vũ Văn Hưng', CAST(N'1991-06-25 00:00:00.000' AS DateTime), N'Nam', N'Bình Thạnh, TP.HCM', N'0417972022', N'Nhân viên vệ sinh')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV026', N'CV010', N'Phạm Mỹ Hạnh', CAST(N'1989-09-21 00:00:00.000' AS DateTime), N'Nữ', N'Long Hồ, Vĩnh Long', N'0917932095', N'Nhân viên vệ sinh')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV027', N'CV011', N'Trương Tuấn Tú', CAST(N'1989-03-22 00:00:00.000' AS DateTime), N'Nam', N'Mỏ Cày Bắc, Bến Tre', N'0917432320', N'Nhân viên buồng phòng')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV028', N'CV011', N'Cao Văn Triển', CAST(N'1987-06-22 00:00:00.000' AS DateTime), N'Nam', N'Mỏ Cày Nam, Bến Tre', N'0877843248', N'Nhân viên buồng phòng')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [MaChucVu], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV029', N'CV011', N'Nguyễn Huỳnh Kim Duyên', CAST(N'2000-05-12 00:00:00.000' AS DateTime), N'Nữ', N'Hàm Thuận Nam, Bình Thuận', N'0917683214', N'Nhân viên buồng phòng')
INSERT [dbo].[PHIEU_SUA_CHUA] ([MaPhieuSua], [NgayBatDau], [NgayKetThuc], [MaNhanVien], [MaPhong], [NguyenNhan], [GhiChu]) VALUES (N'PS001', CAST(N'2021-01-20 00:00:00.000' AS DateTime), CAST(N'2021-01-21 00:00:00.000' AS DateTime), N'NV001', N'1502', N'Gãy chân bàn', N'Sửa gấp')
INSERT [dbo].[PHIEU_SUA_CHUA] ([MaPhieuSua], [NgayBatDau], [NgayKetThuc], [MaNhanVien], [MaPhong], [NguyenNhan], [GhiChu]) VALUES (N'PS002', CAST(N'2021-01-20 00:00:00.000' AS DateTime), CAST(N'2021-01-23 00:00:00.000' AS DateTime), N'NV001', N'1501', N'Dột mưa', N'Không')
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP001', N'NV002', N'KH001', CAST(N'2020-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP002', N'NV001', N'KH003', CAST(N'2020-02-02 00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP004', N'NV001', N'KH002', CAST(N'2020-10-04 00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP005', N'NV002', N'KH010', CAST(N'2020-11-05 00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP006', N'NV001', N'KH006', CAST(N'2020-06-06 00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP007', N'NV001', N'KH008', CAST(N'2020-04-06 00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP008', N'NV001', N'KH009', CAST(N'2020-08-08 00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP010', N'NV001', N'KH005', CAST(N'2020-09-09 00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP011', N'NV001', N'KH001', CAST(N'2020-09-09 00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP012', N'NV002', N'KH001', CAST(N'2021-01-17 21:24:37.007' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP013', N'NV002', N'KH001', CAST(N'2021-01-19 13:11:31.440' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP014', N'NV002', N'KH001', CAST(N'2021-01-19 16:02:41.253' AS DateTime))
INSERT [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong], [MaNhanVien], [MaKhachHang], [NgayLap]) VALUES (N'TP015', N'NV002', N'KH001', CAST(N'2021-01-20 17:35:16.553' AS DateTime))
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1501', N'STD', N'TP002', N'')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1502', N'STD', N'TP001', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1503', N'STD', N'TP003', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1504', N'SUP', N'TP002', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1505', N'SUP', N'TP001', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1506', N'DLX', N'TP001', N'')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1507', N'DLX', N'TP003', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1508', N'DLX', N'TP003', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1509', N'DLX', N'TP001', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1510', N'SUP', N'TP002', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1511', N'SUP', N'TP003', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1512', N'SUT', N'TP003', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1513', N'SUT', N'TP003', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1514', N'SUT', N'TP001', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1515', N'SUT', N'TP003', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1516', N'FR', N'TP003', N'')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1517', N'FR', N'TP001', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1518', N'SUT', N'TP001', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1519', N'FR', N'TP002', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1520', N'SUT', N'TP003', NULL)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoaiPhong], [MaLoaiTinhTrangPhong], [GhiChu]) VALUES (N'1521', N'BR', N'TP001', N'')
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1501', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1502', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1503', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1504', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1505', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1506', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB10', 1)
GO
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1507', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1508', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1509', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1510', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1511', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1512', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1513', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB06', 1)
GO
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1514', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1515', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB02', 4)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB09', 4)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1516', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB02', 4)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB09', 4)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1517', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1518', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB02', 4)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB09', 4)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1519', N'TB15', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB01', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB02', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB03', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB04', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB05', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB06', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB07', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB08', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB09', 2)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB10', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB11', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB12', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB13', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB14', 1)
INSERT [dbo].[SO_HUU_THIET_BI] ([MaPhong], [MaThietBi], [SoLuong]) VALUES (N'1520', N'TB15', 1)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB01', N'Bàn làm việc', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB02', N'Dép đi trong nhà', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB03', N'Điện thoại', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB04', N'Điều hòa', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB05', N'Két sắt trong phòng', 19)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB06', N'Khu vực tiếp khách', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB07', N'Máy pha trà/cà phê', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB08', N'Máy sấy tóc', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB09', N'Nước đóng chai miễn phí', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB10', N'Truyền hình cáp/vệ tinh', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB11', N'Tủ lạnh nhỏ trong phòng', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB12', N'Vật dụng tắm rửa', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB13', N'Vòi sen', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB14', N'Wi-Fi', 20)
INSERT [dbo].[THIET_BI] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB15', N'Máy giặt', 20)
ALTER TABLE [dbo].[CHI_TIET_HOA_DON]  WITH CHECK ADD  CONSTRAINT [FK_CHI_TIET_HOA_DON_HOA_DON] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOA_DON] ([MaHoaDon])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CHI_TIET_HOA_DON] CHECK CONSTRAINT [FK_CHI_TIET_HOA_DON_HOA_DON]
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_SUA_CHUA]  WITH CHECK ADD  CONSTRAINT [FK_CHI_TIET_PHIEU_SUA_CHUA_THIET_BI] FOREIGN KEY([MaThietBi])
REFERENCES [dbo].[THIET_BI] ([MaThietBi])
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_SUA_CHUA] CHECK CONSTRAINT [FK_CHI_TIET_PHIEU_SUA_CHUA_THIET_BI]
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_SUA_CHUA]  WITH CHECK ADD  CONSTRAINT [R26] FOREIGN KEY([MaPhieuSua])
REFERENCES [dbo].[PHIEU_SUA_CHUA] ([MaPhieuSua])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_SUA_CHUA] CHECK CONSTRAINT [R26]
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE_PHONG]  WITH CHECK ADD  CONSTRAINT [R18] FOREIGN KEY([MaThuePhong])
REFERENCES [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE_PHONG] CHECK CONSTRAINT [R18]
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE_PHONG]  WITH CHECK ADD  CONSTRAINT [R19] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE_PHONG] CHECK CONSTRAINT [R19]
GO
ALTER TABLE [dbo].[DANH_SACH_SU_DUNG_DICH_VU]  WITH CHECK ADD  CONSTRAINT [R14] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DICH_VU] ([MaDichVu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DANH_SACH_SU_DUNG_DICH_VU] CHECK CONSTRAINT [R14]
GO
ALTER TABLE [dbo].[DANH_SACH_SU_DUNG_DICH_VU]  WITH CHECK ADD  CONSTRAINT [R15] FOREIGN KEY([MaThuePhong])
REFERENCES [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DANH_SACH_SU_DUNG_DICH_VU] CHECK CONSTRAINT [R15]
GO
ALTER TABLE [dbo].[HOA_DON]  WITH CHECK ADD  CONSTRAINT [FK_HOA_DON_NHAN_VIEN] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHAN_VIEN] ([MaNhanVien])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOA_DON] CHECK CONSTRAINT [FK_HOA_DON_NHAN_VIEN]
GO
ALTER TABLE [dbo].[HOA_DON]  WITH CHECK ADD  CONSTRAINT [FK_HOA_DON_PHIEU_THUE_PHONG] FOREIGN KEY([MaThuePhong])
REFERENCES [dbo].[PHIEU_THUE_PHONG] ([MaThuePhong])
GO
ALTER TABLE [dbo].[HOA_DON] CHECK CONSTRAINT [FK_HOA_DON_PHIEU_THUE_PHONG]
GO
ALTER TABLE [dbo].[NGUOI_DUNG]  WITH CHECK ADD  CONSTRAINT [R10] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUC_VU] ([MaChucVu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NGUOI_DUNG] CHECK CONSTRAINT [R10]
GO
ALTER TABLE [dbo].[NHAN_VIEN]  WITH CHECK ADD  CONSTRAINT [R9] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUC_VU] ([MaChucVu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NHAN_VIEN] CHECK CONSTRAINT [R9]
GO
ALTER TABLE [dbo].[PHIEU_SUA_CHUA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEU_SUA_CHUA_PHONG] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[PHIEU_SUA_CHUA] CHECK CONSTRAINT [FK_PHIEU_SUA_CHUA_PHONG]
GO
ALTER TABLE [dbo].[PHIEU_SUA_CHUA]  WITH CHECK ADD  CONSTRAINT [R24] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHAN_VIEN] ([MaNhanVien])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEU_SUA_CHUA] CHECK CONSTRAINT [R24]
GO
ALTER TABLE [dbo].[PHIEU_THUE_PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEU_THUE_PHONG_NHAN_VIEN] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHAN_VIEN] ([MaNhanVien])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEU_THUE_PHONG] CHECK CONSTRAINT [FK_PHIEU_THUE_PHONG_NHAN_VIEN]
GO
ALTER TABLE [dbo].[PHIEU_THUE_PHONG]  WITH CHECK ADD  CONSTRAINT [R6] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACH_HANG] ([MaKhachHang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEU_THUE_PHONG] CHECK CONSTRAINT [R6]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [R7] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LOAI_PHONG] ([MaLoaiPhong])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [R7]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [R8] FOREIGN KEY([MaLoaiTinhTrangPhong])
REFERENCES [dbo].[LOAI_TINH_TRANG] ([MaLoaiTinhTrangPhong])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [R8]
GO
ALTER TABLE [dbo].[SO_HUU_THIET_BI]  WITH CHECK ADD  CONSTRAINT [FK_SO_HUU_THIET_BI_PHONG] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SO_HUU_THIET_BI] CHECK CONSTRAINT [FK_SO_HUU_THIET_BI_PHONG]
GO
ALTER TABLE [dbo].[SO_HUU_THIET_BI]  WITH CHECK ADD  CONSTRAINT [FK_SO_HUU_THIET_BI_THIET_BI] FOREIGN KEY([MaThietBi])
REFERENCES [dbo].[THIET_BI] ([MaThietBi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SO_HUU_THIET_BI] CHECK CONSTRAINT [FK_SO_HUU_THIET_BI_THIET_BI]
GO
USE [master]
GO
ALTER DATABASE [QLKS] SET  READ_WRITE 
GO
