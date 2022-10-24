go
create proc KategoriEkle
(
@adi nvarchar(45),
@aciklama text
)
as
insert into Categories (CategoryName,Description)  values  (@adi,@aciklama)
go
create proc KategoriSil
(
@id int
)
as 
delete Categories where CategoryID = @id
go
alter proc KategoriGuncelle
(
@id int,
@adi nvarchar(45),
@aciklama text
)
as
update Categories set CategoryName = @adi , Description = @aciklama where CategoryID = @id;
go
KategoriGuncelle 10,'asdsa','dsgfsdg'

create proc KategoriSec
as
select *from Categories
go