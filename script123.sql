USE [quanlyxuatnhapkho]
GO
/****** Object:  Table [dbo].[dangnhap]    Script Date: 11/10/2021 1:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangnhap](
	[stendangnhap] [varchar](10) NOT NULL,
	[smatkhau] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[username] [nvarchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[code] [varchar](10) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[dob] [datetime] NULL,
	[gender] [bit] NULL,
	[phoneNumber] [varchar](11) NULL,
	[dayOne] [datetime] NULL,
	[identify] [varchar](15) NOT NULL,
	[flag] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietDatHang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietDatHang](
	[sSohoadon] [varchar](10) NOT NULL,
	[sMaloairem] [varchar](10) NOT NULL,
	[fGiaban] [float] NOT NULL,
	[fSoluongmua] [float] NOT NULL,
 CONSTRAINT [pk_chitietdathang] PRIMARY KEY CLUSTERED 
(
	[sSohoadon] ASC,
	[sMaloairem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChitietnhaphang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChitietnhaphang](
	[sSohoadon] [varchar](10) NOT NULL,
	[sMaloairem] [varchar](10) NOT NULL,
	[fGianhap] [float] NULL,
	[fSoluongnhap] [float] NULL,
 CONSTRAINT [pk_sohd_maloairem] PRIMARY KEY CLUSTERED 
(
	[sSohoadon] ASC,
	[sMaloairem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDonDatHang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDonDatHang](
	[sSohoadon] [varchar](10) NOT NULL,
	[sMaNv] [varchar](10) NOT NULL,
	[sMaKH] [varchar](10) NOT NULL,
	[dNgaydathang] [datetime] NULL,
	[dNgaygiaohang] [datetime] NULL,
	[sDiachigiaohang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_sohd] PRIMARY KEY CLUSTERED 
(
	[sSohoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDonnhaphang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDonnhaphang](
	[sSohoadon] [varchar](10) NOT NULL,
	[sMaNv] [varchar](10) NOT NULL,
	[dNgaynhaphang] [datetime] NULL,
 CONSTRAINT [pk_isohd] PRIMARY KEY CLUSTERED 
(
	[sSohoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachhang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachhang](
	[sMaKH] [varchar](10) NOT NULL,
	[sTenKH] [nvarchar](30) NOT NULL,
	[sGioitinhKH] [nvarchar](3) NOT NULL,
	[sDiachi] [nvarchar](50) NOT NULL,
	[sDienthoai] [varchar](10) NOT NULL,
 CONSTRAINT [pk_smakh] PRIMARY KEY CLUSTERED 
(
	[sMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoairem]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoairem](
	[sMaloairem] [varchar](10) NOT NULL,
	[sTenloairem] [nvarchar](30) NOT NULL,
	[sMaNcc] [varchar](10) NULL,
	[fSoluong] [float] NULL,
	[fDongia] [float] NULL,
 CONSTRAINT [pk_smaloairem] PRIMARY KEY CLUSTERED 
(
	[sMaloairem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhacungcap]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhacungcap](
	[sMaNcc] [varchar](10) NOT NULL,
	[sTenNcc] [nvarchar](30) NOT NULL,
	[sTengiaodich] [nvarchar](50) NULL,
	[sDiachi] [nvarchar](30) NULL,
	[sDienthoai] [varchar](10) NULL,
 CONSTRAINT [pk_mancc] PRIMARY KEY CLUSTERED 
(
	[sMaNcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanvien]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanvien](
	[sMaNV] [varchar](10) NOT NULL,
	[sTenNV] [nvarchar](30) NOT NULL,
	[dNgaysinh] [datetime] NULL,
	[sGioitinh] [nvarchar](5) NULL,
	[sDiachi] [nvarchar](30) NULL,
	[sDienthoai] [varchar](10) NOT NULL,
	[dNgayvaolam] [datetime] NULL,
	[fLuongcoban] [float] NOT NULL,
 CONSTRAINT [pk_sma] PRIMARY KEY CLUSTERED 
(
	[sMaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblDonDatHang] ADD  DEFAULT (getdate()) FOR [dNgaydathang]
GO
ALTER TABLE [dbo].[tblChiTietDatHang]  WITH CHECK ADD  CONSTRAINT [fk_chitietdathang] FOREIGN KEY([sMaloairem])
REFERENCES [dbo].[tblLoairem] ([sMaloairem])
GO
ALTER TABLE [dbo].[tblChiTietDatHang] CHECK CONSTRAINT [fk_chitietdathang]
GO
ALTER TABLE [dbo].[tblChiTietDatHang]  WITH CHECK ADD  CONSTRAINT [fk_isohd_chitietdathang] FOREIGN KEY([sSohoadon])
REFERENCES [dbo].[tblDonDatHang] ([sSohoadon])
GO
ALTER TABLE [dbo].[tblChiTietDatHang] CHECK CONSTRAINT [fk_isohd_chitietdathang]
GO
ALTER TABLE [dbo].[tblChitietnhaphang]  WITH CHECK ADD  CONSTRAINT [fk_ctn_dn] FOREIGN KEY([sSohoadon])
REFERENCES [dbo].[tblDonnhaphang] ([sSohoadon])
GO
ALTER TABLE [dbo].[tblChitietnhaphang] CHECK CONSTRAINT [fk_ctn_dn]
GO
ALTER TABLE [dbo].[tblChitietnhaphang]  WITH CHECK ADD  CONSTRAINT [fk_ctn_mlr] FOREIGN KEY([sMaloairem])
REFERENCES [dbo].[tblLoairem] ([sMaloairem])
GO
ALTER TABLE [dbo].[tblChitietnhaphang] CHECK CONSTRAINT [fk_ctn_mlr]
GO
ALTER TABLE [dbo].[tblDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_makh] FOREIGN KEY([sMaKH])
REFERENCES [dbo].[tblKhachhang] ([sMaKH])
GO
ALTER TABLE [dbo].[tblDonDatHang] CHECK CONSTRAINT [FK_makh]
GO
ALTER TABLE [dbo].[tblDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_manv] FOREIGN KEY([sMaNv])
REFERENCES [dbo].[tblNhanvien] ([sMaNV])
GO
ALTER TABLE [dbo].[tblDonDatHang] CHECK CONSTRAINT [FK_manv]
GO
ALTER TABLE [dbo].[tblDonnhaphang]  WITH CHECK ADD  CONSTRAINT [fk_dn_nv] FOREIGN KEY([sMaNv])
REFERENCES [dbo].[tblNhanvien] ([sMaNV])
GO
ALTER TABLE [dbo].[tblDonnhaphang] CHECK CONSTRAINT [fk_dn_nv]
GO
ALTER TABLE [dbo].[tblLoairem]  WITH CHECK ADD  CONSTRAINT [fk_ncc_mh] FOREIGN KEY([sMaNcc])
REFERENCES [dbo].[tblNhacungcap] ([sMaNcc])
GO
ALTER TABLE [dbo].[tblLoairem] CHECK CONSTRAINT [fk_ncc_mh]
GO
/****** Object:  StoredProcedure [dbo].[addUser]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[addUser]
@username nvarchar(20),
	@password varchar(20) ,
	@code varchar(10) ,
	@name varchar(50) ,
	@dob datetime,
	@gender bit ,
	@phoneNumber varchar(11) ,
	@dayOne datetime ,
	@identify varchar(15) ,
	@flag bit
as 
begin	
INSERT INTO employee(username,password,code,name,dob,gender,phoneNumber,dayOne,identify,flag)
	Values(@username,@password,@code,@name,@dob,@gender,@phoneNumber,@dayOne,@identify,@flag)
end
GO
/****** Object:  StoredProcedure [dbo].[checkmarem]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[checkmarem]
@maloai  varchar(10)
as
select *from tblLoairem where sMaloairem =@maloai
GO
/****** Object:  StoredProcedure [dbo].[flagging]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[flagging]
@username nvarchar(10)
AS
BEGIN
	 update employee
	 set flag =0 
	 where username = @username
END
GO
/****** Object:  StoredProcedure [dbo].[pr_kiemtradangnhap]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[pr_kiemtradangnhap]
@stendangnhap varchar(10),@smatkhau varchar(10)
as
select count(*) from dangnhap where stendangnhap = @Stendangnhap and smatkhau=@smatkhau
GO
/****** Object:  StoredProcedure [dbo].[selectUserNotFlag]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectUserNotFlag]
as
begin
select username from dbo.employee where flag = 1 and username != 'admin'
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CapNhatMK]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SP_CapNhatMK]
@username nvarchar(20), @password nvarchar(20), @newPass nvarchar(20)
AS
BEGIN
	update employee set password = @newPass
	 WHERE username = @username AND password = @password
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Indondathang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Indondathang]
@sohd varchar (10)
as
begin
	select tblDonDatHang.sSohoadon,tblDonDatHang.dNgaydathang,
	tblDonDatHang.dNgaygiaohang, tblDonDatHang.sDiachigiaohang,
	tblDonDatHang.sMaKH, tblDonDatHang.sMaNv,convert(float,tblChiTietDatHang.fSoluongmua,2) as fSoluongmua, 
	convert(float, tblChiTietDatHang.fGiaban,2) as fGiaban ,
	convert(float, tblChiTietDatHang.fSoluongmua* tblChiTietDatHang.fGiaban,2) as tongtien,
	(select convert(float,sum (tblChiTietDatHang.fSoluongmua* tblChiTietDatHang.fGiaban),2)
	from tblChiTietDatHang where sSohoadon= @sohd)as thanhtien
	from (tblDonDatHang join tblChiTietDatHang on tblChiTietDatHang.sSohoadon= tblDonDatHang.sSohoadon)
	where tblDonDatHang.sSohoadon= @sohd
	group by tblDonDatHang.sSohoadon, tblDonDatHang.dNgaydathang,
	tblDonDatHang.dNgaygiaohang, tblDonDatHang.sDiachigiaohang,
	tblDonDatHang.sMaKH, tblDonDatHang.sMaNv,tblChiTietDatHang.fSoluongmua,
	tblChiTietDatHang.fGiaban
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Indonnhaphang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Indonnhaphang]
@sohd varchar (10)
as
begin
	select tblDonNhapHang.sSohoadon,
	tblDonNhapHang.dNgaynhaphang, tblDonNhapHang.sMaNv,convert(float,tblChiTietNhapHang.fSoluongnhap,2) as fSoluongnhap, 
	convert(float, tblChiTietNhapHang.fGianhap,2) as fGianhap ,
	convert(float, tblChiTietNhapHang.fSoluongnhap* tblChiTietNhapHang.fGianhap,2) as tongtien,
	(select convert(float,sum (tblChiTietNhapHang.fSoluongnhap* tblChiTietNhapHang.fGianhap),2)
	from tblChiTietNhapHang where sSohoadon= @sohd)as thanhtien
	from (tblDonNhapHang join tblChiTietNhapHang on tblChiTietNhapHang.sSohoadon= tblDonNhapHang.sSohoadon)
	where tblDonNhapHang.sSohoadon= @sohd
	group by tblDonNhapHang.sSohoadon, tblDonNhapHang.dNgaynhaphang,
	tblDonNhapHang.dNgaynhaphang, tblDonNhapHang.sMaNv,tblChiTietNhapHang.fSoluongnhap,
	tblChiTietNhapHang.fGianhap
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Suachitietdondathang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Suachitietdondathang]
@sohd varchar(10),
@loairem varchar (10),
@soluong float,
@giaban float
as
begin
	update tblChiTietDatHang 
	set fGiaban= @giaban, fSoluongmua= @soluong
	where sSohoadon= @sohd and sMaloairem =@loairem
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Suachitietdonnhaphang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Suachitietdonnhaphang]
@sohd varchar(10),
@loairem varchar (10),
@soluong float,
@gianhap float
as
begin
	update tblChiTietNhapHang 
	set fGianhap= @gianhap, fSoluongnhap= @soluong
	where sSohoadon= @sohd and sMaloairem =@loairem
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Suadondathang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Suadondathang]
@sSohoadonmoi varchar(10), @sSohoadoncu varchar(10), @sMaNV varchar(10), @sMaKH varchar(10), @dNgaydathang datetime, @dNgaygiaohang datetime, @sDiachigiaohang nvarchar(50)
as
	update tblDondathang
	set sSohoadon = @sSohoadonmoi, sMaNV = @sMaNV, sMaKH = @sMaKH,  dNgaydathang = @dNgaydathang, dNgaygiaohang = @dNgaygiaohang, sDiachigiaohang = @sDiachigiaohang
	from tblDondathang
	where sSohoadon = @sSohoadoncu
GO
/****** Object:  StoredProcedure [dbo].[sp_Suadonnhaphang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Suadonnhaphang]
@sSohoadonmoi varchar(10), @sSohoadoncu varchar(10),@sMaNV varchar(10), @dNgaynhaphang datetime
as
	update tblDonnhaphang
	set sSohoadon = @sSohoadonmoi, sMaNV = @sMaNV, dNgaynhaphang = @dNgaynhaphang
	from tblDonnhaphang
	where sSohoadon = @sSohoadoncu
GO
/****** Object:  StoredProcedure [dbo].[sp_Suakhachhang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[sp_Suakhachhang]
@sMaKHmoi varchar(10), @sMaKHcu varchar(10),@sTenKH nvarchar(30), @sGioitinh nvarchar(5), @sDiachi nvarchar(30), @sDienthoai varchar(10)
as
	update tblKhachhang
	set sMaKH = @sMaKHmoi, sTenKH = @sTenKH, sGioitinhKH = @sGioitinh, sDiachi = @sDiachi, sDienthoai = @sDienthoai
	from tblKhachhang
	where sMaKH = @sMaKHcu
GO
/****** Object:  StoredProcedure [dbo].[sp_Sualoairem]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Sualoairem]
@sMaloairemmoi varchar(10), @sMaloairemcu varchar(10), @sTenloairem nvarchar(30), @sMaNcc varchar(10), @fSoluong float, @fDongia float
as
	update tblLoairem
	set sMaloairem = @sMaloairemmoi, sTenloairem = @sTenloairem, sMaNcc = @sMaNcc, fSoluong = @fSoluong, fDongia = @fDongia
	from tblLoairem
	where sMaloairem = @sMaloairemcu
GO
/****** Object:  StoredProcedure [dbo].[sp_Suanhacungcap]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Suanhacungcap]
@sMaNCCmoi varchar(10), @sMaNCCcu varchar(10), @sTenNCC nvarchar(30), @sTengiaodich nvarchar(50), @sDiachi nvarchar(30), @sDienthoai varchar(10)
as
	update tblNhacungcap
	set sMaNcc = @sMaNCCmoi, sTenNcc = @sTenNCC, sTengiaodich = @sTengiaodich, sDiachi = @sDiachi, sDienthoai = @sDienthoai
	from tblNhacungcap
	where sMaNcc = @sMaNCCcu
GO
/****** Object:  StoredProcedure [dbo].[sp_Suanhanvien]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Suanhanvien]
@sMaNVcu varchar(10), @sMaNVmoi varchar(10), @sTenNV nvarchar(30), @dNgaysinh datetime, @sGioitinh nvarchar(5), @sDiachi nvarchar(30), @sDienthoai varchar(10), @dNgayvaolam datetime, @fLuongcoban float
as
	update tblNhanvien
	set sMaNV=@sMaNVmoi, sTenNV = @sTenNV, dNgaysinh = @dNgaysinh, sGioitinh = @sGioitinh, sDiachi = @sDiachi, sDienthoai = @sDienthoai,  dNgayvaolam =  @dNgayvaolam, fLuongcoban = @fLuongcoban
	from tblNhanvien
	where sMaNV = @sMaNVcu
GO
/****** Object:  StoredProcedure [dbo].[sp_Themchitietdondathang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Themchitietdondathang]
@sohd varchar (10),
@loairem varchar(10),
@soluong float,
@gia float
as
begin
	insert into tblChiTietDatHang (sSohoadon ,sMaloairem,fGiaban,fSoluongmua)
	values (@sohd,@loairem,@gia,@soluong)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Themchitietdonnhaphang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Themchitietdonnhaphang]
@sohd varchar (10),
@loairem varchar(10),
@soluong float,
@gia float
as
begin
	insert into tblChiTietNhapHang (sSohoadon ,sMaloairem,fGianhap,fSoluongnhap)
	values (@sohd,@loairem,@gia,@soluong)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Themdondathang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Themdondathang]
@sSohoadon varchar(10), @sMaNV varchar(10), @sMaKH varchar(10), @dNgaydathang datetime, @dNgaygiaohang datetime, @sDiachigiaohang nvarchar(50)
as
insert into tblDondathang
values (@sSohoadon, @sMaNV, @sMaKH, @dNgaydathang, @dNgaygiaohang, @sDiachigiaohang)
GO
/****** Object:  StoredProcedure [dbo].[sp_Themdonnhaphang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Themdonnhaphang]
@sSohoadon varchar(10), @sMaNV varchar(10), @dNgaynhaphang datetime
as
insert into tblDonnhaphang
values (@sSohoadon, @sMaNV, @dNgaynhaphang)
GO
/****** Object:  StoredProcedure [dbo].[sp_Themkhachhang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Themkhachhang]
@sMaKH varchar(10), @sTenKH nvarchar(30), @sGioitinh nvarchar(5), @sDiachi nvarchar(30), @sDienthoai varchar(10)
as
insert into tblKhachhang
values (@sMaKH, @sTenKH, @sGioitinh, @sDiachi, @sDienthoai)
GO
/****** Object:  StoredProcedure [dbo].[sp_Themloairem]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Themloairem]
@sMaloairem varchar(10), @sTenloairem nvarchar(30), @sMaNcc varchar(10), @fSoluong float, @fDongia float
as
insert into tblLoairem
values (@sMaloairem, @sTenloairem, @sMancc, @fSoluong, @fDongia)
GO
/****** Object:  StoredProcedure [dbo].[sp_Themnhacungcap]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[sp_Themnhacungcap]
@sMaNCC varchar(10), @sTenNCC nvarchar(30), @sTengiaodich nvarchar(50), @sDiachi nvarchar(30), @sDienthoai varchar(10)
as
insert into tblNhacungcap
values (@sMaNCC, @sTenNCC, @sTengiaodich, @sDiachi, @sDienthoai)
GO
/****** Object:  StoredProcedure [dbo].[sp_Themnhanvien]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Themnhanvien]
@sMaNV varchar(10), @sTenNV nvarchar(30), @dNgaysinh datetime, @sGioitinh nvarchar(5), @sDiachi nvarchar(30), @sDienthoai varchar(10), @dNgayvaolam datetime, @fLuongcoban float
as
insert into tblNhanvien
values (@sMaNV, @sTenNV, @dNgaysinh, @sGioitinh, @sDiachi, @sDienthoai, @dNgayvaolam, @fLuongcoban)
GO
/****** Object:  StoredProcedure [dbo].[sp_Xoachitietdondathang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Xoachitietdondathang]
@sohd varchar(10),
@loairem varchar (10)
as
begin
	delete tblChiTietDatHang 
	where sSohoadon= @sohd and sMaloairem =@loairem
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Xoachitietdonnhaphang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Xoachitietdonnhaphang]
@sohd varchar(10),
@loairem varchar (10)
as
begin
	delete tblChiTietNhapHang 
	where sSohoadon= @sohd and sMaloairem =@loairem
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Xoadondathang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Xoadondathang]
@sSohoadon varchar(10)
as
delete from tblDondathang where sSohoadon = @sSohoadon

GO
/****** Object:  StoredProcedure [dbo].[sp_Xoadonnhaphang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Xoadonnhaphang]
@sSohoadon varchar(10)
as
delete from tblDonnhaphang where sSohoadon = @sSohoadon
GO
/****** Object:  StoredProcedure [dbo].[sp_Xoakhachhang]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Xoakhachhang]
@sMaKH varchar(10)
as
delete from tblKhachhang where sMaKH = @sMaKH

GO
/****** Object:  StoredProcedure [dbo].[sp_Xoaloairem]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Xoaloairem]
@sMaloairem varchar(10)
as
delete from tblLoairem where sMaloairem = @sMaloairem
GO
/****** Object:  StoredProcedure [dbo].[sp_Xoanhacungcap]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Xoanhacungcap]
@sMaNCC varchar(10)
as
delete from tblNhacungcap where sMaNcc = @sMaNCC
GO
/****** Object:  StoredProcedure [dbo].[sp_Xoanhanvien]    Script Date: 11/10/2021 1:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Xoanhanvien]
@sMaNV varchar(10)
as
delete from tblNhanvien where sMaNV = @sMaNV
GO
