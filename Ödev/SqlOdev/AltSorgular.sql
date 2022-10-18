

--hangi müþteri kaç. kere alýþveriþ yapmýþýr	
select e.CustomerID, COUNT(e.OrderID) as 'Sipariþ Sayýsý' from Orders e group by e.CustomerID order by [Sipariþ Sayýsý] desc
--ghangi tedarikçi hangi kategorideki üründen kaç dolarlýk mevcuttur
select e.SupplierID,e.CategoryID, SUM(e.UnitsInStock * e.UnitPrice) as 'Sipariþ Sayýsý' from Products e group by e.SupplierID,e.CategoryID order by SupplierID
--ürünlerle birlikte ürünün satýþ adedini listeleyen sorgu
select *,(select sum(Quantity) from [Order Details] o where p.ProductID = o.ProductID ) as SatisAdedi from Products p
--hangi satýþta kaç adet ürün satýlmýþtýr(orders ve order details)
select *,(select sum(Quantity) from [Order Details] o where p.OrderID = o.OrderID ) as Adet from Orders p
--vinet id li müþterinin satýþlarýný listeliyiniz
select * ,(select o.CustomerID from Orders o where p.OrderID = o.OrderID) as Musteri 
from [Order Details] p where OrderID 
in ((select o.OrderID from Orders o where o.CustomerID = 'VINET' ))
--3 nolu ürünün satýþ yapýldýðý müþterilerin id lerini listeleyiniz
select *,(select o.ProductID from [Order Details] o where p.OrderID = o.OrderID and ProductID = 3 ) as ProductId from Orders p where p.OrderID in ((select OrderID from [Order Details] where ProductID = 3))



