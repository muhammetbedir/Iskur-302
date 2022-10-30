create proc EmployeeIDBul
(
@id int
)
as
select Employee from [Order] where OrderID = @id
go
create proc MusteriIDBul
(
@id int
)
as
select CustomerID from [Order] where OrderID = @id
go
create proc UrunBul
(
@id int
)
as
select ProductID from [Order Details] where OrderID = @id
go
create proc KargocuBul
(
@id int
)
as
select ShipVia from [Order] where OrderID = @id
go
alter proc SiparisGuncelle
(
@orderID int,
@musteri int,
@calisan int,
@kargocu int,
@kargoFiyati money,
@adres nvarchar(50),
@sehir nvarchar(50),
@urun int,
@sayi int,
@indirim real
)
as
update [Order] set CustomerID = @musteri, Employee= @calisan, OrderDate= GETDATE(), ShipVia=  @kargocu, Freight = @kargoFiyati, ShipAddress= @adres, ShipCity = @sehir where OrderID = @orderID
declare @ucret money
set @ucret = (select UnitPrice from Products where ProductID = @urun)
update [Order Details]  set OrderID = @orderID ,ProductID= @urun,Quantity= @sayi, UnitPrice= (@sayi * @ucret * (1-@indirim)),Discount=  @indirim where OrderID = @orderID

alter proc SiparisSil
(
@id int
)
as
delete from [Order Details] where OrderID = @id
delete from [Order] where OrderID = @id
go

create proc MusteriEkle
(
@ad nvarchar(50),
@soyad nvarchar(50),
@tel nvarchar(11),
@mail nvarchar(50),
@yas datetime,
@adres nvarchar(80)
)
as
insert into Customers (CustomerFirstName,CustomerLastName,Phone,Email,Age,Adress) values (@ad,@soyad,@tel,@mail,@yas,@adres)
go

create proc UrunEkle
(
@ad nvarchar(50),
@sID int,
@cID int,
@fiyat money,
@stok int
)
as
insert into Products(ProductName,SupplierID,CategoryID,UnitPrice,UnitsInStock) values (@ad,@sID,@cID,@fiyat,@stok)
go
create proc Tedarikci
as
select s.SupplierID,s.CompanyName from Suppliers s
go
create proc KategoriGor
as
select c.CategoryID,c.CategoriName from Categories c
go
alter proc UrunGoster
as
select p.ProductID,p.ProductName,s.CompanyName,p.SupplierID,p.UnitPrice,p.UnitsInStock,p.CategoryID ,c.CategoriName from Products p inner join Suppliers s on s.SupplierID = p.SupplierID inner join Categories c on c.CategoryID = p.CategoryID
go
alter proc UrunSil
(
@ID int 
)
as
declare @orderID int
set @orderID = (select OrderID from [Order Details] where ProductID = @ID)
delete from [Order Details] where ProductID = @ID
delete from [Order] where OrderID = @orderID
delete from Products where ProductID = @ID
go
create proc KategoriGoster
as
select c.CategoryID,c.CategoriName , c.Description from  Categories c
go
create proc KategoriEkle
(
@adi nvarchar(50),
@aciklama ntext
)
as
insert into Categories(CategoriName,Description) values(@adi,@aciklama)
go
create proc KategoriGuncelle
(
@id int,
@adi nvarchar(50),
@aciklama ntext
)
as
update Categories set CategoriName = @adi , Description = @aciklama where CategoryID = @id
go
alter proc KategoriSil
(
@id int
)
as
declare @urunID int
set @urunID = (select ProductID from Products where CategoryID = @id)
declare @orderID int
set @orderID = (select OrderID from [Order Details] where ProductID = @urunID)
delete from [Order Details] where ProductID = @urunID
delete from [Order] where OrderID = @orderID
delete from Products where ProductID = @urunID
delete from Categories where CategoryID = @id
go
create proc UrunGuncelle
(
@id int,
@isim nvarchar(50),
@tedarikci int,
@kategori int,
@fiyat money,
@stok int
)
as
update Products set ProductName = @isim , SupplierID = @tedarikci , CategoryID = @kategori, UnitPrice = @fiyat , UnitsInStock = @stok where ProductID = @id
go
create proc MusteriGoster
as
select * from Customers
go
alter proc MusteriGuncelle
(
@id int,
@adi nvarchar(50),
@soyad nvarchar(50),
@tel nvarchar(11),
@mail nvarchar(50),
@adres nvarchar(80)
)
as
update Customers set CustomerFirstName = @adi, CustomerLastName = @soyad, Phone = @tel, Email = @mail, Adress = @adres where CustomerID = @id
go
MusteriGuncelle 6,'Selami','Layt','5050','layterkek@gmail.com','fdgdfg'
create proc MusteriSil
(
@id int
)
as
delete from Customers where CustomerID = @id
go
create proc CalisaniGor
as
select *from Employee
go
alter proc CalisanEkle
(
@ad nvarchar(50),
@soyad nvarchar(50),
@rutbe nvarchar(50),
@adres nvarchar(50),
@sehir nvarchar(50),
@ulke nvarchar(50),
@tel nvarchar(11)
)
as
insert into Employee(FirstName,LastName,Title,Address,City,Country,Phone) values (@ad,@soyad,@rutbe,@adres,@sehir,@ulke,@tel)
go
create proc Calisanguncelle
(
@id int,
@ad nvarchar(50),
@soyad nvarchar(50),
@rutbe nvarchar(50),
@adres nvarchar(50),
@sehir nvarchar(50),
@ulke nvarchar(50),
@tel nvarchar(11)
)
as
update Employee set FirstName = @ad, LastName = @soyad, Title = @rutbe, Address = @adres, City = @sehir, Country = @ulke, Phone = @tel where EmployeeID = @id
go
alter proc CalisanSil
(
@id int
)
as
declare @orderID int
set @orderID =(select OrderID from [Order] o where o.Employee = @id)
delete from [Order Details] where OrderID =@orderID
delete from [Order] where OrderID = @orderID
delete from Employee where EmployeeID = @id
go
create trigger StokAzalt on [Order Details]
for insert as
declare @satis int
declare @id int
begin
select @satis = Quantity, @id = ProductID from inserted
update Products set UnitsInStock = UnitsInStock - @satis where ProductID =@id
end	
create proc UrunDevam
(
@id int
)
as
update Products set Discontinued = 0 where ProductID = @id
go
create proc ToplamKazanc
as
select o.UnitPrice from [Order Details] o
go