--Kapasitesi en az olan salon
select min(s.Kapasite) from tbl_Salon s 
--Kapasitesi en fazla olan salon
select max(s.Kapasite) from tbl_Salon s 
-- Personellerde ad� b-s aras�nda olan ve do�um tarihi 1993'den �ncesi olan ka� personel vard�r?
select count(p.PersonelId) from tbl_Personel p 
where p.PersonelAd� like '[b-s]%' 
and YEAR(p.DogumTarihi) < 1993
-- Soyad� Aile ba�layan ka� oyuncu vard�r kolon ad� oyuncu say�s� olsun?
select COUNT(o.OyuncuSoyadi) as 'Oyuncu Say�s�' from tbl_Oyuncu o 
where o.OyuncuSoyadi like 'a%' 
-- Toplam bilet fiyatlar� 
select SUM(BiletFiyat) from tbl_bilet 
-- Ortalama bilet fiyat�?
select AVG(BiletFiyat) from tbl_bilet 
--Min ve max bilet fiyat� ?
select Min(BiletFiyat) from tbl_bilet 
select MAX(BiletFiyat) from tbl_bilet 
-- 1,3,6 nolu m��teririn toplam bilet fiyatlar�
select sum(BiletFiyat) from tbl_bilet 
where MusteriId in ('1','3','6')
-- oyuncular�n ortalama ya�� nedir?
select AVG(OyuncuYas) from tbl_Oyuncu 
--sinemalar�n toplam kapasitesinin sinema say�s�na oran�
select sum(Kapasite)/ COUNT(SalonId) from tbl_Salon --sum / count ile
select AVG(Kapasite) from tbl_Salon -- avg ile


