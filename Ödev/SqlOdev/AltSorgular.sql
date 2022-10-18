

--hangi m��teri ka�. kere al��veri� yapm���r	
select e.CustomerID, COUNT(e.OrderID) as 'Sipari� Say�s�' from Orders e group by e.CustomerID order by [Sipari� Say�s�] desc
--ghangi tedarik�i hangi kategorideki �r�nden ka� dolarl�k mevcuttur
select e.SupplierID,e.CategoryID, SUM(e.UnitsInStock * e.UnitPrice) as 'Sipari� Say�s�' from Products e group by e.SupplierID,e.CategoryID order by SupplierID
--�r�nlerle birlikte �r�n�n sat�� adedini listeleyen sorgu
select *,(select sum(Quantity) from [Order Details] o where p.ProductID = o.ProductID ) as SatisAdedi from Products p
--hangi sat��ta ka� adet �r�n sat�lm��t�r(orders ve order details)
select *,(select sum(Quantity) from [Order Details] o where p.OrderID = o.OrderID ) as Adet from Orders p
--vinet id li m��terinin sat��lar�n� listeliyiniz
select * ,(select o.CustomerID from Orders o where p.OrderID = o.OrderID) as Musteri 
from [Order Details] p where OrderID 
in ((select o.OrderID from Orders o where o.CustomerID = 'VINET' ))
--3 nolu �r�n�n sat�� yap�ld��� m��terilerin id lerini listeleyiniz
select *,(select o.ProductID from [Order Details] o where p.OrderID = o.OrderID and ProductID = 3 ) as ProductId from Orders p where p.OrderID in ((select OrderID from [Order Details] where ProductID = 3))



