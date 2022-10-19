

-- hangi müşteri hangi üründen kaç dolarlık satış almıştır

select c.CustomerID , p.ProductName , sum(od.Quantity * od.UnitPrice * (1- od.Discount)) as 'Satis Fiyat' from Customers c inner join Orders o on o.CustomerID = c.CustomerID inner join [Order Details] od on od.OrderID = o.OrderID inner join Products p on p.ProductID = od.ProductID group by c.CustomerID,p.ProductName

-- hangi personel hangi kategoriden hangi ürünleri satmıştır

select em.FirstName, c.CategoryName , p.ProductName from Employees em inner join orders o on o.EmployeeID = em.EmployeeID inner join [Order Details] od on od.OrderID = o.OrderID inner join Products p on p.ProductID = od.ProductID inner join Categories c on c.CategoryID = p.CategoryID

-- ürünlerimizin adlarını ve kategori adlarını tek raporda gösteriniz

select p.ProductName, c.CategoryName from Products p inner join Categories c on c.CategoryID = p.CategoryID

-- beverages katagorisine ait stoklarda bulunan ürünleri raporlayınız

select p.ProductName, c.CategoryName from Products p inner join Categories c on c.CategoryID = p.CategoryID where c.CategoryName = 'Beverages'

-- fedaral shipping ile taşınmış ve nancy nin almış olduğu siparişleri gösteriniz

select o.OrderID, o.CustomerID, o.OrderDate from Shippers s inner join Orders o on o.ShipVia = s.ShipperID inner join Employees em on em.EmployeeID = o.EmployeeID where em.FirstName = 'Nancy' and s.CompanyName = 'Federal Shipping'

-- company nameleri arasında a geçen müşterilerin vermiş olduğu nancy andrew ya da janet tarafından alınmış speedy express ile taşınmamış siparişlere toplam ne kadarlık kargo ödemesi yapılmıştır

select c.CustomerID, COUNT(o.OrderID) as 'Sipariş Sayısı', SUM(o.Freight) as 'Toplam Kargo Fiyat' from Shippers s inner join Orders o on o.ShipVia = s.ShipperID inner join Employees em on em.EmployeeID = o.EmployeeID inner join Customers c on c.CustomerID = o.CustomerID where em.FirstName in ('Nancy','janet','andrew') and s.CompanyName = 'Speedy Express' and c.CompanyName like '%a%' group by c.CustomerID

--en çok ürün aldığımız 3 toptancıyı almış olduğumuz ürün miktarlarına göre raporlayınız

select top 3 s.CompanyName as Toptanci, SUM(od.Quantity) as Toplam from Suppliers s inner join Products p on p.SupplierID = s.SupplierID inner join [Order Details] od on p.ProductID = od.ProductID group by s.CompanyName


-- her bir üründen toplam ne kadarlık satış yapılmıştır ve o ürünler hangi kategorilere aittir

select p.ProductName, SUM(od.Quantity*od.UnitPrice * (1 - od.Discount)) as 'Toplam Satis',c.CategoryName from Categories c inner join Products p on p.CategoryID = c.CategoryID inner join [Order Details] od on od.ProductID = p.ProductID group by p.ProductName,c.CategoryName