select sum(o.Freight) as toplamUcret from Orders o 
where o.CustomerID in ('CACTU','DUMON','PERIC') 
and o.ShipVia != 2 
and o.Freight between 20 and 200


