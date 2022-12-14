USE [Sinema]
GO
/****** Object:  Table [dbo].[tbl_bilet]    Script Date: 18.10.2022 00:06:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_bilet](
	[MusteriId] [int] NOT NULL,
	[SalonSeansId] [int] NOT NULL,
	[KoltukId] [int] NOT NULL,
	[GörevliId] [int] NOT NULL,
	[BiletFiyat] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Film]    Script Date: 18.10.2022 00:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Film](
	[FilmId] [int] IDENTITY(1,1) NOT NULL,
	[FilmTurId] [int] NOT NULL,
	[FilmYonetmenId] [int] NOT NULL,
	[FilmAdı] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Film] PRIMARY KEY CLUSTERED 
(
	[FilmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Film_Oyuncu]    Script Date: 18.10.2022 00:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Film_Oyuncu](
	[FilmId] [int] NOT NULL,
	[OyuncuId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_FilmSeans]    Script Date: 18.10.2022 00:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_FilmSeans](
	[SeansId] [int] IDENTITY(1,1) NOT NULL,
	[FilmId] [int] NOT NULL,
	[SeansSaat] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_tbl_FilmSeans] PRIMARY KEY CLUSTERED 
(
	[SeansId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Koltuk]    Script Date: 18.10.2022 00:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Koltuk](
	[KoltukId] [int] IDENTITY(1,1) NOT NULL,
	[KoltukAdı] [nchar](10) NULL,
 CONSTRAINT [PK_tbl_Koltuk] PRIMARY KEY CLUSTERED 
(
	[KoltukId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Musteri]    Script Date: 18.10.2022 00:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Musteri](
	[MusteriId] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdı] [nvarchar](50) NOT NULL,
	[MusteriSoyadı] [nvarchar](50) NOT NULL,
	[MusteriMail] [nvarchar](50) NOT NULL,
	[MusteriTelefon] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_tbl_Musteri] PRIMARY KEY CLUSTERED 
(
	[MusteriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Oyuncu]    Script Date: 18.10.2022 00:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Oyuncu](
	[OyuncuId] [int] IDENTITY(1,1) NOT NULL,
	[OyuncuAdi] [nvarchar](50) NOT NULL,
	[OyuncuSoyadi] [nvarchar](50) NOT NULL,
	[OyuncuYas] [int] NULL,
 CONSTRAINT [PK_tbl_Oyuncu] PRIMARY KEY CLUSTERED 
(
	[OyuncuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Personel]    Script Date: 18.10.2022 00:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Personel](
	[PersonelId] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAdı] [nvarchar](50) NOT NULL,
	[PersonelSoyadı] [nvarchar](50) NOT NULL,
	[PersonelAdres] [nvarchar](50) NOT NULL,
	[PersonelTelefon] [nvarchar](11) NULL,
	[DogumTarihi] [datetime] NULL,
 CONSTRAINT [PK_tbl_Personel] PRIMARY KEY CLUSTERED 
(
	[PersonelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Salon]    Script Date: 18.10.2022 00:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Salon](
	[SalonId] [int] IDENTITY(1,1) NOT NULL,
	[SalonYeri] [nvarchar](50) NOT NULL,
	[Kapasite] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Salon] PRIMARY KEY CLUSTERED 
(
	[SalonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_SolonSeans]    Script Date: 18.10.2022 00:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_SolonSeans](
	[SalonSeansId] [int] IDENTITY(1,1) NOT NULL,
	[SalonId] [int] NOT NULL,
	[SaatId] [int] NULL,
 CONSTRAINT [PK_tbl_SolonSeans] PRIMARY KEY CLUSTERED 
(
	[SalonSeansId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Tur]    Script Date: 18.10.2022 00:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Tur](
	[TurId] [int] IDENTITY(1,1) NOT NULL,
	[TurAdı] [nvarchar](50) NOT NULL,
	[TurAcıklama] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Tur] PRIMARY KEY CLUSTERED 
(
	[TurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Yonetmen]    Script Date: 18.10.2022 00:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Yonetmen](
	[YonetmenId] [int] IDENTITY(1,1) NOT NULL,
	[YonetmenAdı] [nvarchar](50) NOT NULL,
	[YonetmenSoyadı] [nvarchar](50) NOT NULL,
	[YonetmenYas] [int] NULL,
 CONSTRAINT [PK_tbl_Yonetmen] PRIMARY KEY CLUSTERED 
(
	[YonetmenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_bilet] ([MusteriId], [SalonSeansId], [KoltukId], [GörevliId], [BiletFiyat]) VALUES (1, 2, 5, 1, 32.0000)
INSERT [dbo].[tbl_bilet] ([MusteriId], [SalonSeansId], [KoltukId], [GörevliId], [BiletFiyat]) VALUES (5, 5, 6, 2, 52.0000)
INSERT [dbo].[tbl_bilet] ([MusteriId], [SalonSeansId], [KoltukId], [GörevliId], [BiletFiyat]) VALUES (1, 2, 6, 2, 26.0000)
INSERT [dbo].[tbl_bilet] ([MusteriId], [SalonSeansId], [KoltukId], [GörevliId], [BiletFiyat]) VALUES (3, 8, 4, 3, 83.0000)
INSERT [dbo].[tbl_bilet] ([MusteriId], [SalonSeansId], [KoltukId], [GörevliId], [BiletFiyat]) VALUES (6, 1, 2, 4, 85.0000)
INSERT [dbo].[tbl_bilet] ([MusteriId], [SalonSeansId], [KoltukId], [GörevliId], [BiletFiyat]) VALUES (2, 5, 12, 3, 32.0000)
INSERT [dbo].[tbl_bilet] ([MusteriId], [SalonSeansId], [KoltukId], [GörevliId], [BiletFiyat]) VALUES (8, 5, 5, 1, 12.0000)
GO
SET IDENTITY_INSERT [dbo].[tbl_Film] ON 

INSERT [dbo].[tbl_Film] ([FilmId], [FilmTurId], [FilmYonetmenId], [FilmAdı]) VALUES (1, 2, 1, N'Susuz Yaz')
INSERT [dbo].[tbl_Film] ([FilmId], [FilmTurId], [FilmYonetmenId], [FilmAdı]) VALUES (2, 1, 3, N'Hababam Sınıfı')
INSERT [dbo].[tbl_Film] ([FilmId], [FilmTurId], [FilmYonetmenId], [FilmAdı]) VALUES (3, 3, 4, N'Babam ve Oğlum')
INSERT [dbo].[tbl_Film] ([FilmId], [FilmTurId], [FilmYonetmenId], [FilmAdı]) VALUES (4, 4, 4, N'Eşkiya')
INSERT [dbo].[tbl_Film] ([FilmId], [FilmTurId], [FilmYonetmenId], [FilmAdı]) VALUES (5, 5, 5, N'Canım Kardeşim')
INSERT [dbo].[tbl_Film] ([FilmId], [FilmTurId], [FilmYonetmenId], [FilmAdı]) VALUES (6, 1, 6, N'Selvi Boylum Al Yazmalım')
INSERT [dbo].[tbl_Film] ([FilmId], [FilmTurId], [FilmYonetmenId], [FilmAdı]) VALUES (7, 8, 7, N'Züğürt Ağa')
INSERT [dbo].[tbl_Film] ([FilmId], [FilmTurId], [FilmYonetmenId], [FilmAdı]) VALUES (8, 8, 2, N'Yol')
INSERT [dbo].[tbl_Film] ([FilmId], [FilmTurId], [FilmYonetmenId], [FilmAdı]) VALUES (9, 1, 5, N'Vizontele')
INSERT [dbo].[tbl_Film] ([FilmId], [FilmTurId], [FilmYonetmenId], [FilmAdı]) VALUES (10, 3, 2, N'Kibar Feyzo')
SET IDENTITY_INSERT [dbo].[tbl_Film] OFF
GO
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (1, 2)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (2, 5)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (5, 6)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (4, 2)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (4, 5)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (1, 3)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (1, 5)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (2, 6)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (8, 8)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (8, 7)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (7, 2)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (4, 4)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (3, 6)
INSERT [dbo].[tbl_Film_Oyuncu] ([FilmId], [OyuncuId]) VALUES (8, 1)
GO
SET IDENTITY_INSERT [dbo].[tbl_FilmSeans] ON 

INSERT [dbo].[tbl_FilmSeans] ([SeansId], [FilmId], [SeansSaat]) VALUES (1, 1, N'16.30')
INSERT [dbo].[tbl_FilmSeans] ([SeansId], [FilmId], [SeansSaat]) VALUES (2, 5, N'18.40')
INSERT [dbo].[tbl_FilmSeans] ([SeansId], [FilmId], [SeansSaat]) VALUES (3, 2, N'19.50')
INSERT [dbo].[tbl_FilmSeans] ([SeansId], [FilmId], [SeansSaat]) VALUES (4, 6, N'11.20')
INSERT [dbo].[tbl_FilmSeans] ([SeansId], [FilmId], [SeansSaat]) VALUES (5, 8, N'16.50')
INSERT [dbo].[tbl_FilmSeans] ([SeansId], [FilmId], [SeansSaat]) VALUES (6, 2, N'14.10')
INSERT [dbo].[tbl_FilmSeans] ([SeansId], [FilmId], [SeansSaat]) VALUES (7, 3, N'12.00')
SET IDENTITY_INSERT [dbo].[tbl_FilmSeans] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Koltuk] ON 

INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (1, N'k10       ')
INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (2, N'k25       ')
INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (3, N'j10       ')
INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (4, N'j11       ')
INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (5, N'j9        ')
INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (6, N'L1        ')
INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (7, N'S7        ')
INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (8, N'R15       ')
INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (9, N'D16       ')
INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (10, N'D17       ')
INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (11, N'F10       ')
INSERT [dbo].[tbl_Koltuk] ([KoltukId], [KoltukAdı]) VALUES (12, N'F11       ')
SET IDENTITY_INSERT [dbo].[tbl_Koltuk] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Musteri] ON 

INSERT [dbo].[tbl_Musteri] ([MusteriId], [MusteriAdı], [MusteriSoyadı], [MusteriMail], [MusteriTelefon]) VALUES (1, N'Samet', N'Semir', N'dsfdssd', N'2521515')
INSERT [dbo].[tbl_Musteri] ([MusteriId], [MusteriAdı], [MusteriSoyadı], [MusteriMail], [MusteriTelefon]) VALUES (2, N'Selim', N'Dere', N'dsfsdf', N'1515151')
INSERT [dbo].[tbl_Musteri] ([MusteriId], [MusteriAdı], [MusteriSoyadı], [MusteriMail], [MusteriTelefon]) VALUES (3, N'Selami', N'Şahin', N'dsfsdfgsd', N'152456325')
INSERT [dbo].[tbl_Musteri] ([MusteriId], [MusteriAdı], [MusteriSoyadı], [MusteriMail], [MusteriTelefon]) VALUES (4, N'Atalay', N'atabak', N'dsgfsdg', N'625451')
INSERT [dbo].[tbl_Musteri] ([MusteriId], [MusteriAdı], [MusteriSoyadı], [MusteriMail], [MusteriTelefon]) VALUES (5, N'Deniz ', N'Denmemiz', N'sdfsdfsdf', N'515151')
INSERT [dbo].[tbl_Musteri] ([MusteriId], [MusteriAdı], [MusteriSoyadı], [MusteriMail], [MusteriTelefon]) VALUES (6, N'Polat', N'Alemdar', N'sdgsdg', N'5662624')
INSERT [dbo].[tbl_Musteri] ([MusteriId], [MusteriAdı], [MusteriSoyadı], [MusteriMail], [MusteriTelefon]) VALUES (7, N'Vilademir', N'Putin', N'dsgdsgrds', N'25151')
INSERT [dbo].[tbl_Musteri] ([MusteriId], [MusteriAdı], [MusteriSoyadı], [MusteriMail], [MusteriTelefon]) VALUES (8, N'Kimyong', N'Jun', N'dsgsdagsdg', N'5151512')
INSERT [dbo].[tbl_Musteri] ([MusteriId], [MusteriAdı], [MusteriSoyadı], [MusteriMail], [MusteriTelefon]) VALUES (9, N'Deli', N'Deli', N'dsgsdg', N'51512')
SET IDENTITY_INSERT [dbo].[tbl_Musteri] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Oyuncu] ON 

INSERT [dbo].[tbl_Oyuncu] ([OyuncuId], [OyuncuAdi], [OyuncuSoyadi], [OyuncuYas]) VALUES (1, N'Kıvanç', N'Tatlıtuğ', 35)
INSERT [dbo].[tbl_Oyuncu] ([OyuncuId], [OyuncuAdi], [OyuncuSoyadi], [OyuncuYas]) VALUES (2, N'Hande ', N'Erçel', 28)
INSERT [dbo].[tbl_Oyuncu] ([OyuncuId], [OyuncuAdi], [OyuncuSoyadi], [OyuncuYas]) VALUES (3, N'Enis', N'Arıkan', 10)
INSERT [dbo].[tbl_Oyuncu] ([OyuncuId], [OyuncuAdi], [OyuncuSoyadi], [OyuncuYas]) VALUES (4, N'Ezgi ', N'Mola', 40)
INSERT [dbo].[tbl_Oyuncu] ([OyuncuId], [OyuncuAdi], [OyuncuSoyadi], [OyuncuYas]) VALUES (5, N'Faras Zeynep ', N'Abdullah', 34)
INSERT [dbo].[tbl_Oyuncu] ([OyuncuId], [OyuncuAdi], [OyuncuSoyadi], [OyuncuYas]) VALUES (6, N'Binnur', N'Kaya', 42)
INSERT [dbo].[tbl_Oyuncu] ([OyuncuId], [OyuncuAdi], [OyuncuSoyadi], [OyuncuYas]) VALUES (7, N'Engin Altan', N'Düzyatan', 41)
INSERT [dbo].[tbl_Oyuncu] ([OyuncuId], [OyuncuAdi], [OyuncuSoyadi], [OyuncuYas]) VALUES (8, N'Burhan ', N'Altıntop', 48)
SET IDENTITY_INSERT [dbo].[tbl_Oyuncu] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Personel] ON 

INSERT [dbo].[tbl_Personel] ([PersonelId], [PersonelAdı], [PersonelSoyadı], [PersonelAdres], [PersonelTelefon], [DogumTarihi]) VALUES (1, N'Salih', N'Toroman', N'sdfsdfd', N'51515', CAST(N'1990-05-17T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Personel] ([PersonelId], [PersonelAdı], [PersonelSoyadı], [PersonelAdres], [PersonelTelefon], [DogumTarihi]) VALUES (2, N'Seyhan', N'Derin', N'dsdgsd', N'151', CAST(N'1990-06-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Personel] ([PersonelId], [PersonelAdı], [PersonelSoyadı], [PersonelAdres], [PersonelTelefon], [DogumTarihi]) VALUES (3, N'Kerimcan', N'Durmaz', N'dsgsdgsdg', N'515451', CAST(N'1981-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Personel] ([PersonelId], [PersonelAdı], [PersonelSoyadı], [PersonelAdres], [PersonelTelefon], [DogumTarihi]) VALUES (4, N'Burak', N'kurak', N'dsgsg2', N'12121', CAST(N'1969-07-09T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Personel] ([PersonelId], [PersonelAdı], [PersonelSoyadı], [PersonelAdres], [PersonelTelefon], [DogumTarihi]) VALUES (5, N'Yeter', N'Yetmez', N'fdhfh', N'51512', CAST(N'2000-09-07T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Personel] ([PersonelId], [PersonelAdı], [PersonelSoyadı], [PersonelAdres], [PersonelTelefon], [DogumTarihi]) VALUES (6, N'Jenifer', N'Lavrance', N'sdgsdg651', N'515', CAST(N'1993-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Personel] ([PersonelId], [PersonelAdı], [PersonelSoyadı], [PersonelAdres], [PersonelTelefon], [DogumTarihi]) VALUES (7, N'Yıldız', N'Tilbe', N'fdgdfg', N'12516', CAST(N'1992-08-04T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Personel] ([PersonelId], [PersonelAdı], [PersonelSoyadı], [PersonelAdres], [PersonelTelefon], [DogumTarihi]) VALUES (8, N'John', N'Snow', N'dsgsdg', N'56556', CAST(N'1991-07-18T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Personel] ([PersonelId], [PersonelAdı], [PersonelSoyadı], [PersonelAdres], [PersonelTelefon], [DogumTarihi]) VALUES (9, N'Derin', N'Deniz', N'dgsdg', N'1515', CAST(N'1999-09-04T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Personel] ([PersonelId], [PersonelAdı], [PersonelSoyadı], [PersonelAdres], [PersonelTelefon], [DogumTarihi]) VALUES (10, N'Leyla', N'Nesir', N'dsgsdfg', N'5656', CAST(N'1989-01-05T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Salon] ON 

INSERT [dbo].[tbl_Salon] ([SalonId], [SalonYeri], [Kapasite]) VALUES (1, N'1.kat 2.Salon', 30)
INSERT [dbo].[tbl_Salon] ([SalonId], [SalonYeri], [Kapasite]) VALUES (2, N'1. kat 1.salon', 20)
INSERT [dbo].[tbl_Salon] ([SalonId], [SalonYeri], [Kapasite]) VALUES (3, N'2.kat 1.salon', 50)
INSERT [dbo].[tbl_Salon] ([SalonId], [SalonYeri], [Kapasite]) VALUES (4, N'2.kat 5.salon', 40)
INSERT [dbo].[tbl_Salon] ([SalonId], [SalonYeri], [Kapasite]) VALUES (5, N'2.kat 3.salon', 44)
INSERT [dbo].[tbl_Salon] ([SalonId], [SalonYeri], [Kapasite]) VALUES (6, N'2.kat 4.salon', 22)
SET IDENTITY_INSERT [dbo].[tbl_Salon] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_SolonSeans] ON 

INSERT [dbo].[tbl_SolonSeans] ([SalonSeansId], [SalonId], [SaatId]) VALUES (1, 1, 5)
INSERT [dbo].[tbl_SolonSeans] ([SalonSeansId], [SalonId], [SaatId]) VALUES (2, 2, 1)
INSERT [dbo].[tbl_SolonSeans] ([SalonSeansId], [SalonId], [SaatId]) VALUES (3, 3, 6)
INSERT [dbo].[tbl_SolonSeans] ([SalonSeansId], [SalonId], [SaatId]) VALUES (4, 2, 5)
INSERT [dbo].[tbl_SolonSeans] ([SalonSeansId], [SalonId], [SaatId]) VALUES (5, 5, 3)
INSERT [dbo].[tbl_SolonSeans] ([SalonSeansId], [SalonId], [SaatId]) VALUES (7, 6, 2)
INSERT [dbo].[tbl_SolonSeans] ([SalonSeansId], [SalonId], [SaatId]) VALUES (8, 4, 4)
INSERT [dbo].[tbl_SolonSeans] ([SalonSeansId], [SalonId], [SaatId]) VALUES (9, 5, 3)
SET IDENTITY_INSERT [dbo].[tbl_SolonSeans] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Tur] ON 

INSERT [dbo].[tbl_Tur] ([TurId], [TurAdı], [TurAcıklama]) VALUES (1, N'Korku', N'Korkarsın')
INSERT [dbo].[tbl_Tur] ([TurId], [TurAdı], [TurAcıklama]) VALUES (2, N'Gerilim', N'Gerilirsin')
INSERT [dbo].[tbl_Tur] ([TurId], [TurAdı], [TurAcıklama]) VALUES (3, N'Bilim Kurgu', N'Bilirsin')
INSERT [dbo].[tbl_Tur] ([TurId], [TurAdı], [TurAcıklama]) VALUES (4, N'Romantik', N'Romantirsin')
INSERT [dbo].[tbl_Tur] ([TurId], [TurAdı], [TurAcıklama]) VALUES (5, N'Romantik Komedi', N'Sevgilinle gelir gülersin')
INSERT [dbo].[tbl_Tur] ([TurId], [TurAdı], [TurAcıklama]) VALUES (6, N'Fantastik', N' Türk dizileri')
INSERT [dbo].[tbl_Tur] ([TurId], [TurAdı], [TurAcıklama]) VALUES (7, N'Dram', N'Türk dizileri(Ağlarsın)')
INSERT [dbo].[tbl_Tur] ([TurId], [TurAdı], [TurAcıklama]) VALUES (8, N'Biyografik', N'Kusarsın')
INSERT [dbo].[tbl_Tur] ([TurId], [TurAdı], [TurAcıklama]) VALUES (9, N'Belgesel', N'Tv de var ordan izle hıyar')
SET IDENTITY_INSERT [dbo].[tbl_Tur] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Yonetmen] ON 

INSERT [dbo].[tbl_Yonetmen] ([YonetmenId], [YonetmenAdı], [YonetmenSoyadı], [YonetmenYas]) VALUES (1, N'Fatih', N'Terim', 41)
INSERT [dbo].[tbl_Yonetmen] ([YonetmenId], [YonetmenAdı], [YonetmenSoyadı], [YonetmenYas]) VALUES (2, N'Nuri Bilge ', N'Ceylan', 50)
INSERT [dbo].[tbl_Yonetmen] ([YonetmenId], [YonetmenAdı], [YonetmenSoyadı], [YonetmenYas]) VALUES (3, N'Onur', N'Ünlü', 60)
INSERT [dbo].[tbl_Yonetmen] ([YonetmenId], [YonetmenAdı], [YonetmenSoyadı], [YonetmenYas]) VALUES (4, N'Zeki', N'Demirkubuz', 55)
INSERT [dbo].[tbl_Yonetmen] ([YonetmenId], [YonetmenAdı], [YonetmenSoyadı], [YonetmenYas]) VALUES (5, N'Fırat', N'Parlak', 45)
INSERT [dbo].[tbl_Yonetmen] ([YonetmenId], [YonetmenAdı], [YonetmenSoyadı], [YonetmenYas]) VALUES (6, N'Burak', N'Aksak', 40)
INSERT [dbo].[tbl_Yonetmen] ([YonetmenId], [YonetmenAdı], [YonetmenSoyadı], [YonetmenYas]) VALUES (7, N'Çağan', N'Irmak', 43)
INSERT [dbo].[tbl_Yonetmen] ([YonetmenId], [YonetmenAdı], [YonetmenSoyadı], [YonetmenYas]) VALUES (8, N'Cem', N'Yılmaz', 50)
SET IDENTITY_INSERT [dbo].[tbl_Yonetmen] OFF
GO
ALTER TABLE [dbo].[tbl_bilet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_bilet_tbl_Koltuk] FOREIGN KEY([KoltukId])
REFERENCES [dbo].[tbl_Koltuk] ([KoltukId])
GO
ALTER TABLE [dbo].[tbl_bilet] CHECK CONSTRAINT [FK_tbl_bilet_tbl_Koltuk]
GO
ALTER TABLE [dbo].[tbl_bilet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_bilet_tbl_Musteri] FOREIGN KEY([MusteriId])
REFERENCES [dbo].[tbl_Musteri] ([MusteriId])
GO
ALTER TABLE [dbo].[tbl_bilet] CHECK CONSTRAINT [FK_tbl_bilet_tbl_Musteri]
GO
ALTER TABLE [dbo].[tbl_bilet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_bilet_tbl_Personel] FOREIGN KEY([GörevliId])
REFERENCES [dbo].[tbl_Personel] ([PersonelId])
GO
ALTER TABLE [dbo].[tbl_bilet] CHECK CONSTRAINT [FK_tbl_bilet_tbl_Personel]
GO
ALTER TABLE [dbo].[tbl_bilet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_bilet_tbl_SolonSeans] FOREIGN KEY([SalonSeansId])
REFERENCES [dbo].[tbl_SolonSeans] ([SalonSeansId])
GO
ALTER TABLE [dbo].[tbl_bilet] CHECK CONSTRAINT [FK_tbl_bilet_tbl_SolonSeans]
GO
ALTER TABLE [dbo].[tbl_Film]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Film_tbl_Tur] FOREIGN KEY([FilmTurId])
REFERENCES [dbo].[tbl_Tur] ([TurId])
GO
ALTER TABLE [dbo].[tbl_Film] CHECK CONSTRAINT [FK_tbl_Film_tbl_Tur]
GO
ALTER TABLE [dbo].[tbl_Film]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Film_tbl_Yonetmen] FOREIGN KEY([FilmYonetmenId])
REFERENCES [dbo].[tbl_Yonetmen] ([YonetmenId])
GO
ALTER TABLE [dbo].[tbl_Film] CHECK CONSTRAINT [FK_tbl_Film_tbl_Yonetmen]
GO
ALTER TABLE [dbo].[tbl_Film_Oyuncu]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Film_Oyuncu_tbl_Film] FOREIGN KEY([FilmId])
REFERENCES [dbo].[tbl_Film] ([FilmId])
GO
ALTER TABLE [dbo].[tbl_Film_Oyuncu] CHECK CONSTRAINT [FK_tbl_Film_Oyuncu_tbl_Film]
GO
ALTER TABLE [dbo].[tbl_Film_Oyuncu]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Film_Oyuncu_tbl_Oyuncu] FOREIGN KEY([OyuncuId])
REFERENCES [dbo].[tbl_Oyuncu] ([OyuncuId])
GO
ALTER TABLE [dbo].[tbl_Film_Oyuncu] CHECK CONSTRAINT [FK_tbl_Film_Oyuncu_tbl_Oyuncu]
GO
ALTER TABLE [dbo].[tbl_FilmSeans]  WITH CHECK ADD  CONSTRAINT [FK_tbl_FilmSeans_tbl_Film] FOREIGN KEY([FilmId])
REFERENCES [dbo].[tbl_Film] ([FilmId])
GO
ALTER TABLE [dbo].[tbl_FilmSeans] CHECK CONSTRAINT [FK_tbl_FilmSeans_tbl_Film]
GO
ALTER TABLE [dbo].[tbl_SolonSeans]  WITH CHECK ADD  CONSTRAINT [FK_tbl_SolonSeans_tbl_FilmSeans] FOREIGN KEY([SaatId])
REFERENCES [dbo].[tbl_FilmSeans] ([SeansId])
GO
ALTER TABLE [dbo].[tbl_SolonSeans] CHECK CONSTRAINT [FK_tbl_SolonSeans_tbl_FilmSeans]
GO
ALTER TABLE [dbo].[tbl_SolonSeans]  WITH CHECK ADD  CONSTRAINT [FK_tbl_SolonSeans_tbl_Salon] FOREIGN KEY([SalonId])
REFERENCES [dbo].[tbl_Salon] ([SalonId])
GO
ALTER TABLE [dbo].[tbl_SolonSeans] CHECK CONSTRAINT [FK_tbl_SolonSeans_tbl_Salon]
GO
