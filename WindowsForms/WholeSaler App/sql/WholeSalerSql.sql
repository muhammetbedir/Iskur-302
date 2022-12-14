USE [Whosaler ]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoriName] [nvarchar](50) NOT NULL,
	[Description] [ntext] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerFirstName] [nvarchar](50) NOT NULL,
	[CustomerLastName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](11) NULL,
	[Email] [nvarchar](50) NULL,
	[Age] [datetime] NULL,
	[Adress] [nvarchar](80) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Birthdate] [datetime] NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[Phone] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[Employee] [int] NULL,
	[OrderDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[ShipVia] [int] NULL,
	[Freight] [money] NULL,
	[ShipName] [nvarchar](50) NULL,
	[ShipAddress] [nvarchar](50) NULL,
	[ShipCity] [nvarchar](50) NULL,
	[ShipCountry] [nvarchar](50) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order Details]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order Details](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NULL,
	[Quantity] [smallint] NOT NULL,
	[Discount] [real] NULL,
 CONSTRAINT [PK_Order Details] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[SupplierID] [int] NULL,
	[CategoryID] [int] NULL,
	[UnitPrice] [money] NULL,
	[UnitsInStock] [smallint] NULL,
	[Discontinued] [bit] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shippers]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shippers](
	[ShipperID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[Phone] [nvarchar](11) NULL,
 CONSTRAINT [PK_Shippers] PRIMARY KEY CLUSTERED 
(
	[ShipperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[ContactName] [nvarchar](50) NULL,
	[Address] [nvarchar](80) NULL,
	[City] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[Phone] [nvarchar](11) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoriName], [Description]) VALUES (2, N'Home&
Furniture', N'decoration
')
INSERT [dbo].[Categories] ([CategoryID], [CategoriName], [Description]) VALUES (3, N'Electronic', N'Tecnology')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [CustomerFirstName], [CustomerLastName], [Phone], [Email], [Age], [Adress]) VALUES (1, N'Cihat Han', N'Toparlak', N'25478568', N'cht@gmail.com', CAST(N'1997-01-01T00:00:00.000' AS DateTime), N'Beykoz')
INSERT [dbo].[Customers] ([CustomerID], [CustomerFirstName], [CustomerLastName], [Phone], [Email], [Age], [Adress]) VALUES (2, N'Mısra', N'Yılmaz', N'54446465', N'msr@gmail.com', CAST(N'1999-09-08T00:00:00.000' AS DateTime), N'Pendik')
INSERT [dbo].[Customers] ([CustomerID], [CustomerFirstName], [CustomerLastName], [Phone], [Email], [Age], [Adress]) VALUES (3, N'İlker', N'Yüce', N'79898846', N'lkrr@gmail.com', CAST(N'2000-08-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Customers] ([CustomerID], [CustomerFirstName], [CustomerLastName], [Phone], [Email], [Age], [Adress]) VALUES (6, N'Selami', N'Layt', N'5151', N'layterkek@gmail.com', CAST(N'1900-01-02T00:31:39.937' AS DateTime), N'fdgdfg')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [FirstName], [LastName], [Title], [Birthdate], [Address], [City], [Country], [Phone]) VALUES (1, N'Neval     ', N'Türkdönmez', N'CEO       ', CAST(N'1996-09-09T00:00:00.000' AS DateTime), N'Ümraniye  ', N'İstanbul  ', N'Türkiye   ', N'65654165  ')
INSERT [dbo].[Employee] ([EmployeeID], [FirstName], [LastName], [Title], [Birthdate], [Address], [City], [Country], [Phone]) VALUES (8, N'Devrim Mehmet    ', N'Pattabanoğlu   ', N'Office Boy', CAST(N'1993-01-01T00:00:00.000' AS DateTime), N'Cide      ', N'Kastamonu', N'Türkiye   ', N'15414846  ')
INSERT [dbo].[Employee] ([EmployeeID], [FirstName], [LastName], [Title], [Birthdate], [Address], [City], [Country], [Phone]) VALUES (9, N'Muhammet', N'Bedir', N'General Manager', CAST(N'1997-03-02T00:00:00.000' AS DateTime), N'Güngören', N'İstanbul', N'Türkiye', N'51654516')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (1, 2, 8, CAST(N'2022-10-28T20:05:32.433' AS DateTime), NULL, 2, 10.0000, NULL, N'dfds', N'sdfsd', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (2, 1, 1, CAST(N'2022-10-28T20:08:15.570' AS DateTime), NULL, 2, 10.0000, NULL, N'dfsd', N'sfdgd', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (3, 1, 8, CAST(N'2022-10-28T22:05:48.683' AS DateTime), NULL, 1, 10.0000, NULL, N'dsgfsd', N'sdf', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (4, 1, 8, CAST(N'2022-10-28T20:13:19.243' AS DateTime), NULL, 2, 10.0000, NULL, N'fdg', N'fgeg', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (5, 1, 1, CAST(N'2022-10-28T20:14:25.110' AS DateTime), NULL, 3, 10.0000, NULL, N'fdg', N'fgeg', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (6, 1, 8, CAST(N'2022-10-28T20:16:22.240' AS DateTime), NULL, 2, 10.0000, NULL, N'fdg', N'gfdg', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (7, 1, 8, CAST(N'2022-10-28T22:07:48.127' AS DateTime), NULL, 1, 15.0000, NULL, N'dsgfsd', N'sdf', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (8, 1, 8, CAST(N'2022-10-28T22:09:34.240' AS DateTime), NULL, 1, 15.0000, NULL, N'dsgfsd', N'sdf', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (9, 3, 1, CAST(N'2022-10-28T22:17:09.927' AS DateTime), NULL, 3, 10.0000, NULL, N'dsfgd', N'gddf', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (10, 2, 8, CAST(N'2022-10-28T22:19:16.853' AS DateTime), NULL, 3, 262.0000, NULL, N'fgbfg', N'fgf', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (14, 2, 1, CAST(N'2022-10-29T22:23:59.690' AS DateTime), NULL, 1, 20.0000, NULL, N'sdf', N'Ankara', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (15, 3, 9, CAST(N'2022-10-28T23:12:52.730' AS DateTime), NULL, 1, 50.0000, NULL, N'fgd', N'fsd', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (19, 2, 8, CAST(N'2022-10-30T21:24:14.740' AS DateTime), NULL, 3, 10.0000, NULL, N'dfsd', N'dfgdf', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (20, 2, 8, CAST(N'2022-10-30T21:55:44.880' AS DateTime), NULL, 2, 10.0000, NULL, N'dsf', N'sdf', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (21, 1, 1, CAST(N'2022-10-30T22:11:47.150' AS DateTime), NULL, 3, 10.0000, NULL, N'dsf', N'sdf', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (22, 2, 8, CAST(N'2022-10-30T22:13:21.747' AS DateTime), NULL, 3, 10.0000, NULL, N'dsf', N'dsf', NULL)
INSERT [dbo].[Order] ([OrderID], [CustomerID], [Employee], [OrderDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipCountry]) VALUES (23, 2, 8, CAST(N'2022-10-30T22:14:15.987' AS DateTime), NULL, 2, 10.0000, NULL, N'dsf', N'sdf', NULL)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[Order Details] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (14, 1, 600.0000, 80, 0.25)
INSERT [dbo].[Order Details] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (15, 1, 45.0000, 5, 0.1)
INSERT [dbo].[Order Details] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (19, 1, 90.0000, 10, 0.1)
INSERT [dbo].[Order Details] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (20, 1, 450.0000, 50, 0.1)
INSERT [dbo].[Order Details] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (21, 1, 90.0000, 10, 0.1)
INSERT [dbo].[Order Details] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (22, 1, 90.0000, 10, 0.1)
INSERT [dbo].[Order Details] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (23, 1, 9.0000, 1, 0.1)
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [UnitPrice], [UnitsInStock], [Discontinued]) VALUES (1, N'Elma', 1, 2, 10.0000, 50, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Shippers] ON 

INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (1, N'Aras ', NULL)
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (2, N'MNG', NULL)
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (3, N'Sürat', NULL)
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (4, N'PTT', NULL)
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (5, N'UPS', NULL)
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (6, N'MRT', NULL)
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (7, N'TrendyolExpress', NULL)
SET IDENTITY_INSERT [dbo].[Shippers] OFF
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [City], [Country], [Phone]) VALUES (1, N'Penta', N'Mehmet Yılmaz', N'Kadıköy', N'İstanbul', N'Türkiye', N'54654465')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [City], [Country], [Phone]) VALUES (2, N'Ejoya', N'Yıldız Tilbe', N'Beyoğlu', N'İstanbul', N'Türkiye', N'65454544')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customers]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Employee] FOREIGN KEY([Employee])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Employee]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Shippers] FOREIGN KEY([ShipVia])
REFERENCES [dbo].[Shippers] ([ShipperID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Shippers]
GO
ALTER TABLE [dbo].[Order Details]  WITH CHECK ADD  CONSTRAINT [FK_Order Details_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[Order Details] CHECK CONSTRAINT [FK_Order Details_Order]
GO
ALTER TABLE [dbo].[Order Details]  WITH CHECK ADD  CONSTRAINT [FK_Order Details_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Order Details] CHECK CONSTRAINT [FK_Order Details_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
/****** Object:  StoredProcedure [dbo].[Calisan]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Calisan]
as
select FirstName + ' '+ LastName as 'EmplyeeName',EmployeeID from Employee
GO
/****** Object:  StoredProcedure [dbo].[CalisanEkle]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CalisanEkle]
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
GO
/****** Object:  StoredProcedure [dbo].[Calisanguncelle]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Calisanguncelle]
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
GO
/****** Object:  StoredProcedure [dbo].[CalisaniGor]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CalisaniGor]
as
select *from Employee
GO
/****** Object:  StoredProcedure [dbo].[CalisanSil]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CalisanSil]
(
@id int
)
as
declare @orderID int
set @orderID =(select OrderID from [Order] o where o.Employee = @id)
delete from [Order Details] where OrderID =@orderID
delete from [Order] where OrderID = @orderID
delete from Employee where EmployeeID = @id
GO
/****** Object:  StoredProcedure [dbo].[EmployeeIDBul]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EmployeeIDBul]
(
@id int
)
as
select Employee from [Order] where OrderID = @id
GO
/****** Object:  StoredProcedure [dbo].[KargocuBul]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KargocuBul]
(
@id int
)
as
select ShipVia from [Order] where OrderID = @id
GO
/****** Object:  StoredProcedure [dbo].[KargoFirma]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KargoFirma]
as
select s.CompanyName,s.ShipperID from Shippers s
GO
/****** Object:  StoredProcedure [dbo].[KategoriEkle]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KategoriEkle]
(
@adi nvarchar(50),
@aciklama ntext
)
as
insert into Categories(CategoriName,Description) values(@adi,@aciklama)
GO
/****** Object:  StoredProcedure [dbo].[KategoriGor]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KategoriGor]
as
select c.CategoryID,c.CategoriName from Categories c
GO
/****** Object:  StoredProcedure [dbo].[KategoriGoster]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KategoriGoster]
as
select c.CategoryID,c.CategoriName , c.Description from  Categories c
GO
/****** Object:  StoredProcedure [dbo].[KategoriGuncelle]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KategoriGuncelle]
(
@id int,
@adi nvarchar(50),
@aciklama ntext
)
as
update Categories set CategoriName = @adi , Description = @aciklama where CategoryID = @id
GO
/****** Object:  StoredProcedure [dbo].[KategoriSil]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KategoriSil]
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
GO
/****** Object:  StoredProcedure [dbo].[Musteri]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Musteri]
as 
select c.CustomerFirstName + ' '+ c.CustomerLastName as 'CustomerName', c.CustomerID from Customers c
GO
/****** Object:  StoredProcedure [dbo].[MusteriEkle]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[MusteriEkle]
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
GO
/****** Object:  StoredProcedure [dbo].[MusteriGoster]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MusteriGoster]
as
select * from Customers
GO
/****** Object:  StoredProcedure [dbo].[MusteriGuncelle]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MusteriGuncelle]
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
GO
/****** Object:  StoredProcedure [dbo].[MusteriIDBul]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MusteriIDBul]
(
@id int
)
as
select CustomerID from [Order] where OrderID = @id
GO
/****** Object:  StoredProcedure [dbo].[MusteriSil]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MusteriSil]
(
@id int
)
as
delete from Customers where CustomerID = @id
GO
/****** Object:  StoredProcedure [dbo].[Orderproc]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Orderproc]
as
select ord.OrderID, LEFT (e.FirstName,1)+'.'+e.LastName  as 'Employee', LEFT(cu.CustomerFirstName,1)+'.'+cu.CustomerLastName as 'Customer', p.ProductName, od.UnitPrice,od.Quantity,od.Discount, ord.Freight, ord.ShipAddress, ord.ShipCity, s.CompanyName as 'Shipper Company'
from Employee e inner join [Order] ord
on e.EmployeeID=ord.Employee inner join [Order Details] od 
on od.OrderID=ord.OrderID inner join Products p
on p.ProductID=od.ProductID inner join Categories c
on c.CategoryID=p.CategoryID inner join Shippers s
on s.ShipperID=ord.ShipVia inner join Customers cu
on cu.CustomerID=ord.CustomerID
GO
/****** Object:  StoredProcedure [dbo].[SiparisEkle]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SiparisEkle]
(
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
insert into [Order] (CustomerID,Employee,OrderDate,ShipVia,Freight,ShipAddress,ShipCity) values (@musteri,@calisan,GETDATE(),@kargocu,@kargoFiyati,@adres,@sehir)
declare @ucret money
set @ucret = (select UnitPrice from Products where ProductID = @urun)
insert into [Order Details] (OrderID,ProductID,Quantity,UnitPrice,Discount) values (@@IDENTITY,@urun,@sayi, @sayi * @ucret * (1-@indirim),@indirim)
GO
/****** Object:  StoredProcedure [dbo].[SiparisGuncelle]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SiparisGuncelle]
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
GO
/****** Object:  StoredProcedure [dbo].[SiparisSil]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SiparisSil]
(
@id int
)
as
delete from [Order Details] where OrderID = @id
delete from [Order] where OrderID = @id
GO
/****** Object:  StoredProcedure [dbo].[Tedarikci]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Tedarikci]
as
select s.SupplierID,s.CompanyName from Suppliers s
GO
/****** Object:  StoredProcedure [dbo].[ToplamKazanc]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ToplamKazanc]
as
select o.UnitPrice from [Order Details] o
GO
/****** Object:  StoredProcedure [dbo].[Urun]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Urun]
as
select p.ProductID, ProductName,p.UnitsInStock,p.Discontinued from Products p
GO
/****** Object:  StoredProcedure [dbo].[UrunBul]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UrunBul]
(
@id int
)
as
select ProductID from [Order Details] where OrderID = @id
GO
/****** Object:  StoredProcedure [dbo].[UrunDevam]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UrunDevam]
(
@id int
)
as
update Products set Discontinued = 0 where ProductID = @id
GO
/****** Object:  StoredProcedure [dbo].[UrunEkle]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UrunEkle]
(
@ad nvarchar(50),
@sID int,
@cID int,
@fiyat money,
@stok int
)
as
insert into Products(ProductName,SupplierID,CategoryID,UnitPrice,UnitsInStock) values (@ad,@sID,@cID,@fiyat,@stok)
GO
/****** Object:  StoredProcedure [dbo].[UrunGoster]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UrunGoster]
as
select p.ProductID,p.ProductName,s.CompanyName,p.SupplierID,p.UnitPrice,p.UnitsInStock,p.CategoryID ,c.CategoriName from Products p inner join Suppliers s on s.SupplierID = p.SupplierID inner join Categories c on c.CategoryID = p.CategoryID
GO
/****** Object:  StoredProcedure [dbo].[UrunGuncelle]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UrunGuncelle]
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
GO
/****** Object:  StoredProcedure [dbo].[UrunSil]    Script Date: 30.10.2022 22:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UrunSil]
(
@ID int 
)
as
declare @orderID int
set @orderID = (select OrderID from [Order Details] where ProductID = @ID)
delete from [Order Details] where ProductID = @ID
delete from [Order] where OrderID = @orderID
delete from Products where ProductID = @ID
GO
