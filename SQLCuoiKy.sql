ocreate database NguyenThiMaiDB
go
use NguyenThiMaiDB
go
create table TaiKhoanNguoiDung
(
	ID char(7) primary key,
	Ten varchar(255),
	MatKhau varchar(255),
	Trangthai varchar(255)
)
create table LoaiSP(
	ID char(7) primary key,
	TenLoai nvarchar(200),
	MoTa nvarchar(255)
)
go
create table SanPham(
	ID char(7) primary key,
	TenSP nvarchar(200),
	DonGia money,
	SoLuong int,
	image varchar(255),
	MoTa nvarchar(255),
	LoaiSP_ID char(7) foreign key references LoaiSP(ID),
	Trangthai varchar(255)
)
go

insert into TaiKhoanNguoiDung()
values('admin','Thi Mai','123456','active'),
		('user1','Thi Hong','123456','active'),
		('user2','Hoai Lam','123456','active'),
		('user3','Thu Trang','123456','active'),
		('user4','Van Tri','123456','active'),
		('user5','Huu Thong','123456','active'),
		('user6','Dinh Tien','123456','active'),
		('user7','Hai Thinh','123456','active')

insert into LoaiSP
	values	('LSP0001', N'Điện thoại di động', N'Thiết bị điện tử'),
			('LSP0002', N'Máy tính bảng', N'Thiết bị điện tử'),
			('LSP0003', N'Laptop', N'Thiết bị điện tử'),
			('LSP0004', N'Máy tính bàn', N'Thiết bị điện tử'),
			('LSP0005', N'Âm thanh', N'Thiết bị điện tử');
go
insert into SanPham(ID,TenSP,DonGia,SoLuong,MoTa,LoaiSP_ID)
	values	('SP10001',N'Điện Thoại Samsung Galaxy M30 64GB(4GB)', 3290000, 100, N'Màn hình tràn viền vô cực 6.4 SUPER AMOLED Full HD + Cụm 3 Camera sau + Siêu pin 5000 mAh + 2 Nano Sim - Hàng Phân Phối Chính Hãng', 'LSP0001'),
			('SP10002',N'Điện thoại Apple iPhone 11 Pro Max', 30990000, 100, N'Hàng Chính Hãng VN/A - Màn Hình Super Retina XDR 6.5inch, Face ID, Chống nước, Chip A13, 3 Camera, Đi Kèm Sạc Nhanh 18W', 'LSP0001'),
			('SP10003',N'Điện Thoại Samsung Galaxy M10 16GB (2GB RAM)', 2290000, 100, N'Màn hình tràn Infinity-V 6.2'' HD, camera kép góc siêu rộng 13MP/5MP + 2 SIM Nano + Pin 3400 mAh - Hàng Phân Phối Chính Hãng', 'LSP0001'),
			('SP10004',N'Điện thoại Apple iPhone 11', 2199000, 100, N'Màn hình tràn Infinity-V 6.2'' HD, camera kép góc siêu rộng 13MP/5MP + 2 SIM Nano + Pin 3400 mAh - Hàng Phân Phối Chính Hãng', 'LSP0001'),
			('SP10005',N'Xiaomi Redmi Note 8 Ram 4GB 64GB', 3299000, 100, N'Hàng Nhập Khẩu', 'LSP0001'),

			('SP20001',N'Máy Tỉnh Bảng iPad 10.2-inch Wi-Fi 2019', 8990000, 100, N'Màn Hình Tương Thích Apple Pencil thế hệ 1 - Chip A10 Mạnh Mẽ - Hệ điều hành iPadOS - Tương thích iPhone', 'LSP0002'),
			('SP20002',N'Máy Tính Bảng KingCom PiPHONE APUS', 899000, 100, N'Màn hình 7 inches, IPS, CPU 4 nhân, Ram 1 Gb', 'LSP0002'),
			('SP20003',N'Máy tính bảng Asus Zenpad z10 wifi', 3266000, 100, N'Độ phân giải 2K màn hình 9.7Inch, Chip xử lý Snapdragon 650, âm thanh stereo sống động mạnh mẽ tặng kèm bao da, cường lực, đế dựng, add sẵn thẻ tiếng Anh123, Toán, Tv pro', 'LSP0002'),
			('SP20004',N'Máy tính bảng 32Gb MATSUMA 10.1inch', 1720000, 100, N'4G-3G-Wifi-Bluetooth-GPS (Ram 2g, Rom 32G) Trắng nắp nhôm', 'LSP0002'),
			('SP20005',N'Máy tính bảng Samsung Galaxy Tab 4', 1790000, 100, N'(Wifi+4G)-(Màu Trắng)', 'LSP0002'),

			('SP30001',N'Laptop Acer Aspire 3 A315-54-57PJ', 12999000, 100, N'Core i5-8265U(1.60 GHz/6MB)/ 4GBRAM/256GBSSD/ Intel UHD Graphics/ 15.6FHD/ Webcam/ Wlan ac+BT/ 3cell/ Win 10 Home/ Đen (Shale Black)/ 1Y WTY_NX.HEFSV.004', 'LSP0003'),
			('SP30002',N'Laptop Dell G3 15 3590', 31990000, 100, N'Intel Core i7-9750H (2.60 GHz/12 MB/2x4GB RAM/512GB SSD/6GB NVIDIA GeForce GTX 1660Ti/15.6 FHD/Finger/WL+BT/McAfee MDS/Win 10 Home/1Yr) - Hàng Chính Hãng', 'LSP0003'),
			('SP30003',N'Laptop Acer Aspire A515-53-5112', 14990000, 100, N'Core i5-8265U(1.60 GHz/6MB)/ 4GBRAM/ 16GBOptane/ 1TBHDD/ DVDRW/ Intel UHD Graphics/ 15.6 FHD/ Webcam', 'LSP0003'),
			('SP30004',N'Laptop Dell Inspiron 7559 siêu gaming Core i7-6700HQ', 13890000, 100, N'8G/ 1TB/ VGA GTX 960M- 4G, màn 15.6″ Full HD 1920*1080, DÒNG MÁY CHUYÊN GAME', 'LSP0003'),
			('SP30005',N'Máy tính New Macbook 12-inch 512GB', 32000000, 100, N'Hàng chính hãng', 'LSP0003'),

			('SP40001',N'Máy tính để bàn Dell Vostro 3670', 9490000, 100, N'(Intel Core i3-9100/3.60 GHz/6 MB/4GB RAM/1TB HDD/DVDRW/WL+BT/Keyboard & Mouse/McAfee eCard/Ubuntu/1Yr) - Hàng Chính Hãng', 'LSP0004'),
			('SP40002',N'Máy tính để bàn HP 280 G4 PCI Microtower', 11690000, 100, N'(Core i5-8400/4GB RAM DDR4/1TB HDD/4LW11PA) - Hàng Chính Hãng', 'LSP0004'),
			('SP40003',N'Máy tính để bàn HP 280 G4 Microtower', 12290000, 100, N'(Intel Core I5-8500/ 8GB RAM DDR4/ 1TB HDD/DOS/8JU09PA) - Hàng Chính Hãng', 'LSP0004'),
			('SP40004',N'Máy tính chiến game core i7', 9558000, 100, N'(Intel Core I5-8500/ 8GB RAM DDR4/ 1TB HDD/DOS/8JU09PA) - Hàng Chính Hãng', 'LSP0004'),
			('SP40005',N'Combo Máy tính đồng bộ DELL OPTIPLEX 390 DT + Màn hình ASUS 27inch Full Viền', 15949220, 100, N'(Core i7 2600, Ram 12GB, HDD 2TB) + Quà Tặng - Hàng Nhập Khẩu', 'LSP0004'),

			('SP50001',N'Loa di động bluetooth JBL Go 2', 579000, 100, N'Chất âm trong trẻo - Tích hợp Bluetooth 4.1 cổng AUX 3.5mm và micro USB - Hàng Chính Hãng', 'LSP0005'),
			('SP50002',N'Tai Nghe True Wireless Defunc True Go Bluetooth v5.0', 1490000, 100, N' Chất âm trong trẻo - Tích hợp Bluetooth 4.1 cổng AUX 3.5mm và micro USB - Hàng Chính Hãng', 'LSP0005'),
			('SP50003',N'Tai nghe bluetooth chụp tai B39', 199000, 100, N'Hàng nhập ( Có hổ trợ thẻ nhớ + Dây jack 3.5mm)', 'LSP0005'),
			('SP50004',N'Tai nghe Mèo Tai Bluetooth 5.0', 261000, 100, N'Tai Nghe Có Thể Gập Lại Trên-Tai Nghe Không Dây Tai Nghe có Mic LED Hỗ Trợ FM đài phát thanh/Thẻ TF/AUX In cho Điện Thoại Thông Minh MÁY TÍNH Máy Tính Bảng', 'LSP0005'),
			('SP50005',N'Tai nghe bluetooth SONY D76 TWS', 175000, 100, N'Tự động kết nối-Chống ồn cực tốt-Tai nghe thể thao kèm cốc sạc nhanh-Tai nghe Blueooth 10m -Có quà tặng', 'LSP0005');
go
select * from LoaiSP
go
select * from SanPham
