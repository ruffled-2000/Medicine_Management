create database QuanLyTiemThuocDongY
use QuanLyTiemThuocDongY
go
---------------------------------------------------------------------------------------------------------------
create table TaiKhoan
(
	TenDangNhap varchar(30) not null primary key,
	MatKhau varchar(300) not null,
	Ten nvarchar(30) not null,
	Loai bit --0 la nhan vien, 1 la quan tri vien
)
create table LoaiThuoc
(
	MaLT varchar(4) primary key,
	TenLT nvarchar(30)
)
create table Thuoc
(
	MaThuoc varchar(5) primary key,
	TenThuoc nvarchar(100) not null,
	GiaThuoc float not null default 0,
	SoLuongT int,
	MaLT varchar(4),
	constraint fk_Thuoc_LoaiThuoc foreign key(MaLT) references LoaiThuoc(MaLT) on update cascade on delete cascade
)
create table KhachHang
(
	MaKH int identity primary key,
	TenKH nvarchar(30),
	Tuoi int,
	GioiTinh nvarchar(10),
	SoDT varchar(12) not null,
	DiaChi nvarchar(30)
)
create table HoaDon
(
	MaHD int identity(1,1) primary key,
	MaKH int,
	NgayTao date,
	constraint fk_HD_KH foreign key(MaKH) references KhachHang(MaKH) on update cascade on delete cascade
)
create table ChiTietHD
(
	MaThuoc varchar(5),
	MaHD int,
	SoLuong int not null,
	constraint PK_ChiTietHD primary key(MaThuoc,MaHD),
	constraint fk_ChiTietHD_Thuoc foreign key(MaThuoc) references Thuoc(MaThuoc) on update cascade on delete cascade,
	constraint fk_ChiTietHD_HD foreign key(MaHD) references HoaDon(MaHD) on update cascade on delete cascade
)
---------------------------------------------------------------------------------------------------------------
insert into TaiKhoan values('LoNhatLong', '123456', N'Lò Nhật Long', 0)
insert into TaiKhoan values('LeVuLong', '123456', N'Lê Vũ Long', 0)
insert into TaiKhoan values('admin', 'admin', N'Admin', 1)

insert into LoaiThuoc values ('01', N'Thuốc trị gan')
insert into LoaiThuoc values ('02', N'Thuốc trị tiểu đường')
insert into LoaiThuoc values ('03', N'Thuốc cảm cúm')
insert into LoaiThuoc values ('04', N'Thuốc bổ')
insert into LoaiThuoc values ('05', N'Thuốc trị sốt rét')

insert into Thuoc values('T01', 'TG1', 25000, 40, '01')
insert into Thuoc values('T02', 'TG2', 50000, 50, '01')
insert into Thuoc values('T03', 'TD1', 60000, 50, '02')
insert into Thuoc values('T04', 'TD2', 30000, 80, '02')
insert into Thuoc values('T05', 'CC1', 50000, 25, '03')
insert into Thuoc values('T06', 'CC2', 21000, 90, '03')
insert into Thuoc values('T07', 'TB1', 40000, 40, '04')
insert into Thuoc values('T08', 'TB2', 10000, 100, '04')
insert into Thuoc values('T09', 'SR1', 900000, 50, '05')
insert into Thuoc values('T10', 'SR2', 20000, 80, '05')

insert into KhachHang values ( N'Lò Nhật Long', 20, 'Nam', '0147852369', N'Điện Biên')
insert into KhachHang values ( N'Lê Vũ Long', 20, 'Nam', '0123456789', N'Phú Thọ')
insert into KhachHang values ( N'Nguyễn Văn C', 21, 'Nam', '0951763248', N'Hà Nam')
insert into KhachHang values ( N'Nguyễn Thị D', 19, N'Nữ', '0951764477', N'Ninh Bình')
insert into KhachHang values ( N'Vũ Thị E', 21, N'Nữ', '0987654123', N'Thái Bình')

select * from TaiKhoan
select * from LoaiThuoc
select * from Thuoc
select * from KhachHang
select * from HoaDon
select * from ChiTietHD
---------------------------------------------------------------------------------------------------------------
create function KiemTraMaKH(@MaKH varchar(10))
returns bit
as
	begin
		declare @KQ bit
		if(not exists(select * from KhachHang where MaKH=@MaKH))
			set @KQ=0
		else
			set @KQ=1
		return @KQ
	end

create function KiemTraTaiKhoan(@TenDN varchar(30))
returns bit
as
	begin
		declare @KQ bit
		if(exists(select * from TaiKhoan where TenDangNhap=@TenDN))
			set @KQ=1
		else
			set @KQ=0
		return @KQ
	end

create function DangNhap(@TenDN varchar(30), @MatKhau varchar(300))
returns bit
as
	begin
		declare @KQ bit
		if(exists(select * from TaiKhoan where TenDangNhap=@TenDN and MatKhau=@MatKhau))
		begin
			set @KQ=1
		end
		else
		begin
			set @KQ=0
		end
		return @KQ
	end

create function LayMaHDVuaNhap()
returns int
as
	begin
		declare @MaHDLN int
		select @MaHDLN = MAX(MaHD) from HoaDon
		return @MaHDLN
	end

create function LayMaKHVuaNhap()
returns int
as
	begin
		declare @MaKHLN int
		select @MaKHLN = MAX(MaKH) from KhachHang
		return @MaKHLN
	end

create function TinhTien(@MaKH varchar(10))
returns float
as
	begin
		declare @TongTien float
		select @TongTien=SUM(GiaThuoc*ChiTietHD.SoLuong) 
		from ChiTietHD inner join Thuoc on ChiTietHD.MaThuoc=Thuoc.MaThuoc
					   inner join HoaDon on ChiTietHD.MaHD = HoaDon.MaHD, KhachHang
		where HoaDon.MaKH = KhachHang.MaKH and KhachHang.MaKH=@MaKH
		return @TongTien
	end

create function ThongKe(@NgayX date, @NgayY date)
returns @ThongKe table(
						MaHD int,
						TenKH nvarchar(30),
						Tuoi int,
						GioiTinh nvarchar(10),
						DiaChi nvarchar(30),
						TenThuoc nvarchar(30),
						SoLuongBan int,
						TongTien float
					  )
as
	begin
		insert into @ThongKe
		Select HoaDon.MaHD, TenKH, Tuoi, GioiTinh, DiaChi, TenThuoc, ChiTietHD.SoLuong, (ChiTietHD.SoLuong*Thuoc.GiaThuoc)
		from ChiTietHD inner join Thuoc on ChiTietHD.MaThuoc=Thuoc.MaThuoc
					   inner join HoaDon on ChiTietHD.MaHD = HoaDon.MaHD, KhachHang
		where HoaDon.MaKH=KhachHang.MaKH and HoaDon.NgayTao between @NgayX and @NgayY
		Return
	end

create function TongTienThongKe(@NgayX date, @NgayY date)
returns float
as
	begin
		declare @TongTien float
		select @TongTien=SUM(GiaThuoc*ChiTietHD.SoLuong) 
		from ChiTietHD inner join Thuoc on ChiTietHD.MaThuoc=Thuoc.MaThuoc
					   inner join HoaDon on ChiTietHD.MaHD = HoaDon.MaHD, KhachHang
		where HoaDon.MaKH = KhachHang.MaKH and HoaDon.NgayTao between @NgayX and @NgayY
		return @TongTien
	end

create function KiemTraMK(@TenDN varchar(30), @MatKhau varchar(300))
returns bit
as
	begin
		declare @KQ bit
		set @KQ=0
		if(exists(select * from TaiKhoan where TenDangNhap=TenDangNhap and MatKhau=@MatKhau))
			set @KQ=1
		return @KQ
	end

create function KiemTraMaLoaiThuoc(@MaLoaiThuoc varchar(30))
returns bit
as
	begin
		declare @KQ bit
		set @KQ=0
		if(exists(select * from LoaiThuoc where MaLT=@MaLoaiThuoc))
			set @KQ=1
		return @KQ
	end

create function KiemTraMaThuoc(@MaThuoc varchar(30))
returns bit
as
	begin
		declare @KQ bit
		set @KQ=0
		if(exists(select * from Thuoc where MaThuoc=@MaThuoc))
			set @KQ=1
		return @KQ
	end

create trigger TRG_XuatHang
on ChiTietHD
for insert
as
	begin
		if(not exists(select * from Thuoc inner join inserted on Thuoc.MaThuoc=inserted.MaThuoc where Thuoc.MaThuoc=inserted.MaThuoc))
		begin
			raiserror('Loi khong co thuoc nay',16,1)
			rollback transaction
			return
		end
		if(not exists(select * from HoaDon inner join inserted on HoaDon.MaHD=inserted.MaHD where HoaDon.MaHD=inserted.MaHD))
		begin
			raiserror('Loi khong co hoa don nay',16,1)
			rollback transaction
			return
		end
		declare @SoLuongBan int
		declare @SoLuongCo int
		select @SoLuongBan=SoLuong from inserted
		select @SoLuongCo=SoLuongT from Thuoc
		if(@SoLuongBan>@SoLuongCo)
		begin
			raiserror('Loi khong du hang',16,1)
			rollback transaction
			return
		end
		else
		begin
			update Thuoc set SoLuongT = SoLuongT-@SoLuongBan 
			from Thuoc inner join inserted on Thuoc.MaThuoc=inserted.MaThuoc
		end
	end

create trigger TRG_XoaChiTietHD
on ChiTietHD
for delete
as
	begin
		declare @SoLuongHuy int
		declare @SoLuongCo int
		select @SoLuongHuy=SoLuong from deleted
		select @SoLuongCo=SoLuongT from Thuoc
		begin
			update Thuoc set SoLuongT = SoLuongT+@SoLuongHuy 
			from Thuoc inner join deleted on Thuoc.MaThuoc=deleted.MaThuoc
		end
	end