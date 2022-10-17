--Kapasitesi en az olan salon
select min(s.Kapasite) from tbl_Salon s 
--Kapasitesi en fazla olan salon
select max(s.Kapasite) from tbl_Salon s 
-- Personellerde adý b-s arasýnda olan ve doðum tarihi 1993'den öncesi olan kaç personel vardýr?
select count(p.PersonelId) from tbl_Personel p 
where p.PersonelAdý like '[b-s]%' 
and YEAR(p.DogumTarihi) < 1993
-- Soyadý Aile baþlayan kaç oyuncu vardýr kolon adý oyuncu sayýsý olsun?
select COUNT(o.OyuncuSoyadi) as 'Oyuncu Sayýsý' from tbl_Oyuncu o 
where o.OyuncuSoyadi like 'a%' 
-- Toplam bilet fiyatlarý 
select SUM(BiletFiyat) from tbl_bilet 
-- Ortalama bilet fiyatý?
select AVG(BiletFiyat) from tbl_bilet 
--Min ve max bilet fiyatý ?
select Min(BiletFiyat) from tbl_bilet 
select MAX(BiletFiyat) from tbl_bilet 
-- 1,3,6 nolu müþteririn toplam bilet fiyatlarý
select sum(BiletFiyat) from tbl_bilet 
where MusteriId in ('1','3','6')
-- oyuncularýn ortalama yaþý nedir?
select AVG(OyuncuYas) from tbl_Oyuncu 
--sinemalarýn toplam kapasitesinin sinema sayýsýna oraný
select sum(Kapasite)/ COUNT(SalonId) from tbl_Salon --sum / count ile
select AVG(Kapasite) from tbl_Salon -- avg ile


