--TRIGGER
create trigger tgThemChiTietPhieuNhap
on ChiTietPhieuNhap
for insert
as begin
	declare @soLuong float;
	declare @maPhieuNhap varchar(3);
	declare @maHangHoa varchar(3);
	declare @maDonViTinh varchar(3);
	declare @maKho varchar(3);
	declare @dem int;
	set @soLuong = (select SoLuong from inserted);
	set @maPhieuNhap = (select MaPhieuNhap from inserted);
	set @maKho = (select MaKho from PhieuNhap where MaPhieuNhap = @maPhieuNhap);
	set @maHangHoa = (select MaHangHoa from inserted);
	set @maDonViTinh = (select MaDonViTinh from inserted);
	set @dem = (select count(*) from ChiTietKho where MaKho=@maKho and MaHangHoa=@maHangHoa and MaDonViTinh=@maDonViTinh);
	if @dem>0
		update ChiTietKho set SoLuong = SoLuong + @soLuong where MaKho=@maKho and MaHangHoa=@maHangHoa and MaDonViTinh=@maDonViTinh;
	else 
		insert ChiTietKho values(@maKho,@maHangHoa,@maDonViTinh,@soLuong);
end
drop trigger tgXoaChiTietPhieuNhap
create trigger tgXoaChiTietPhieuNhap
on ChiTietPhieuNhap
for delete 
as begin 
	declare @soLuong float;
	declare @maHangHoa varchar(3);
	declare @maDonViTinh varchar(3);
	declare @maPhieuNhap varchar(3);
	declare @maKho varchar(3);
	declare @soLuongTon float;
	set @soLuong = (select SoLuong from deleted);
	set @maHangHoa = (select MaHangHoa from deleted);
	set @maDonViTinh = (select MaDonViTinh from deleted);
	set @maPhieuNhap = (select MaPhieuNhap from deleted);
	set @maKho = (select MaKho from PhieuNhap where MaPhieuNhap=@maPhieuNhap);
	set @soLuongTon = (select SoLuong from ChiTietKho where MaKho=@maKho and MaDonViTinh=@maDonViTinh and MaHangHoa=@maHangHoa);
	if @soLuongTon >= @soLuong
		update ChiTietKho set SoLuong = SoLuong - @soLuong where MaKho=@maKho and MaDonViTinh=@maDonViTinh and MaHangHoa=@maHangHoa;
	else
		throw 50000,N'So luong ton kho bi am',1;
end
drop trigger tgXoaChiTietPhieuNhap

