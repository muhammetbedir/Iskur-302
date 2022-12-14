USE [Hospital]
GO
/****** Object:  Table [dbo].[Policlinic]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Policlinic](
	[PoliclinicID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Policlinic] PRIMARY KEY CLUSTERED 
(
	[PoliclinicID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[DoctorID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Phone] [nchar](11) NOT NULL,
	[Adress] [nvarchar](80) NOT NULL,
	[Tc] [nchar](11) NOT NULL,
	[Title] [int] NOT NULL,
	[PoliclinicID] [int] NOT NULL,
	[BirthDate] [datetime] NULL,
	[HireDate] [datetime] NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Professors]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Professors] 
as
select d.Name, d.Surname, p.Name as 'PoliclinicName' from Doctors d inner join Policlinic p on p.PoliclinicID = d.PoliclinicID where Title = 6 
GO
/****** Object:  Table [dbo].[AssayResult]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssayResult](
	[AssayResultID] [int] IDENTITY(1,1) NOT NULL,
	[Explanation] [ntext] NOT NULL,
	[Conclusion] [ntext] NOT NULL,
	[AssayID] [int] NOT NULL,
 CONSTRAINT [PK_AssayResult] PRIMARY KEY CLUSTERED 
(
	[AssayResultID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Assays]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assays](
	[AssayID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Assays] PRIMARY KEY CLUSTERED 
(
	[AssayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BloodTypes]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BloodTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Types] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_BloodTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inspection Result]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inspection Result](
	[ResulltID] [int] IDENTITY(1,1) NOT NULL,
	[InspectionsID] [int] NOT NULL,
	[Explanation] [ntext] NOT NULL,
	[RequestedAssaysID] [int] NOT NULL,
 CONSTRAINT [PK_Inspection Result] PRIMARY KEY CLUSTERED 
(
	[ResulltID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inspections]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inspections](
	[InspectionID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[PatientID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
	[PatientComplaint] [ntext] NOT NULL,
 CONSTRAINT [PK_Inspections] PRIMARY KEY CLUSTERED 
(
	[InspectionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [nchar](11) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Adress] [nvarchar](80) NOT NULL,
	[Phone] [nchar](11) NOT NULL,
	[RegistrationDate] [datetime] NULL,
	[BloodType] [int] NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Titles]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[TitleID] [int] IDENTITY(1,1) NOT NULL,
	[TitleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[TitleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AssayResult] ON 

INSERT [dbo].[AssayResult] ([AssayResultID], [Explanation], [Conclusion], [AssayID]) VALUES (1, N'Karnı ağrıyormuş', N'Gıda Zehirlenmesi', 2)
INSERT [dbo].[AssayResult] ([AssayResultID], [Explanation], [Conclusion], [AssayID]) VALUES (3, N'Migren', N'Migren', 3)
SET IDENTITY_INSERT [dbo].[AssayResult] OFF
GO
SET IDENTITY_INSERT [dbo].[Assays] ON 

INSERT [dbo].[Assays] ([AssayID], [Name], [Price]) VALUES (1, N'İdrar', 12.0000)
INSERT [dbo].[Assays] ([AssayID], [Name], [Price]) VALUES (2, N'Kan', 15.0000)
INSERT [dbo].[Assays] ([AssayID], [Name], [Price]) VALUES (3, N'Gaita', 12.0000)
INSERT [dbo].[Assays] ([AssayID], [Name], [Price]) VALUES (4, N'Ultrason', 30.0000)
INSERT [dbo].[Assays] ([AssayID], [Name], [Price]) VALUES (5, N'Röntgen', 25.0000)
INSERT [dbo].[Assays] ([AssayID], [Name], [Price]) VALUES (6, N'Tomografi', 50.0000)
SET IDENTITY_INSERT [dbo].[Assays] OFF
GO
SET IDENTITY_INSERT [dbo].[BloodTypes] ON 

INSERT [dbo].[BloodTypes] ([ID], [Types]) VALUES (1, N'A-')
INSERT [dbo].[BloodTypes] ([ID], [Types]) VALUES (2, N'A+')
INSERT [dbo].[BloodTypes] ([ID], [Types]) VALUES (3, N'O+')
INSERT [dbo].[BloodTypes] ([ID], [Types]) VALUES (4, N'O-')
INSERT [dbo].[BloodTypes] ([ID], [Types]) VALUES (5, N'B+')
INSERT [dbo].[BloodTypes] ([ID], [Types]) VALUES (6, N'B-')
INSERT [dbo].[BloodTypes] ([ID], [Types]) VALUES (7, N'AB+')
INSERT [dbo].[BloodTypes] ([ID], [Types]) VALUES (8, N'AB-')
SET IDENTITY_INSERT [dbo].[BloodTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Doctors] ON 

INSERT [dbo].[Doctors] ([DoctorID], [Name], [Surname], [Phone], [Adress], [Tc], [Title], [PoliclinicID], [BirthDate], [HireDate]) VALUES (2, N'Deniz', N'Seki', N'5151       ', N'edsfsdf', N'151        ', 3, 2, NULL, CAST(N'2022-11-20T22:11:53.853' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [Name], [Surname], [Phone], [Adress], [Tc], [Title], [PoliclinicID], [BirthDate], [HireDate]) VALUES (4, N'Serkan', N'Çağlayan', N'5          ', N'sfsa', N'152        ', 6, 3, CAST(N'2022-12-01T00:00:00.000' AS DateTime), CAST(N'2022-11-20T22:12:34.333' AS DateTime))
SET IDENTITY_INSERT [dbo].[Doctors] OFF
GO
SET IDENTITY_INSERT [dbo].[Inspection Result] ON 

INSERT [dbo].[Inspection Result] ([ResulltID], [InspectionsID], [Explanation], [RequestedAssaysID]) VALUES (1, 1, N'Hastanın karnı ağrıyormuş', 1)
SET IDENTITY_INSERT [dbo].[Inspection Result] OFF
GO
SET IDENTITY_INSERT [dbo].[Inspections] ON 

INSERT [dbo].[Inspections] ([InspectionID], [Date], [PatientID], [DoctorID], [PatientComplaint]) VALUES (1, CAST(N'2022-11-20T22:15:23.990' AS DateTime), 2, 2, N'Karın ağrısı')
INSERT [dbo].[Inspections] ([InspectionID], [Date], [PatientID], [DoctorID], [PatientComplaint]) VALUES (2, CAST(N'2022-11-20T22:15:42.907' AS DateTime), 1, 4, N'Baş Ağrısı')
SET IDENTITY_INSERT [dbo].[Inspections] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([PatientID], [TC], [Name], [Surname], [Adress], [Phone], [RegistrationDate], [BloodType]) VALUES (1, N'15151      ', N'Selami', N'Şahin', N'sdfsdf', N'262        ', CAST(N'2022-11-20T22:05:12.123' AS DateTime), 1)
INSERT [dbo].[Patient] ([PatientID], [TC], [Name], [Surname], [Adress], [Phone], [RegistrationDate], [BloodType]) VALUES (2, N'515        ', N'sads', N'sdf', N'dsfsd', N'626        ', CAST(N'2022-11-20T22:06:11.683' AS DateTime), 5)
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
SET IDENTITY_INSERT [dbo].[Policlinic] ON 

INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (1, N'GENEL CERRAHİ')
INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (2, N'GÖĞÜS HASTALIKLARI')
INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (3, N'GÖZ HASTALIKLARI')
INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (4, N'İÇ HASTALIKLARI')
INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (5, N'KADIN HASTALIKLARI VE DOĞUM')
INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (6, N'KALP VE DAMAR CERRAHİSİ')
INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (7, N'KARDİYOLOJİ')
INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (8, N'KULAK-BURUN-BOĞAZ HASTALIKLARI')
INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (9, N'NÖROLOJİ
')
INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (10, N'ORTOPEDİ VE TRAVMATOLOJİ')
INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (11, N'PSİKİYATRİ')
INSERT [dbo].[Policlinic] ([PoliclinicID], [Name]) VALUES (12, N'ÜROLOJİ')
SET IDENTITY_INSERT [dbo].[Policlinic] OFF
GO
SET IDENTITY_INSERT [dbo].[Titles] ON 

INSERT [dbo].[Titles] ([TitleID], [TitleName]) VALUES (1, N' Pratisyen Doktor')
INSERT [dbo].[Titles] ([TitleID], [TitleName]) VALUES (2, N'Uzman Doktor

')
INSERT [dbo].[Titles] ([TitleID], [TitleName]) VALUES (3, N'Operatör Doktor')
INSERT [dbo].[Titles] ([TitleID], [TitleName]) VALUES (4, N'Yardımcı doçent')
INSERT [dbo].[Titles] ([TitleID], [TitleName]) VALUES (5, N' Doçent')
INSERT [dbo].[Titles] ([TitleID], [TitleName]) VALUES (6, N'Profesör')
INSERT [dbo].[Titles] ([TitleID], [TitleName]) VALUES (7, N'Ordinaryüs')
SET IDENTITY_INSERT [dbo].[Titles] OFF
GO
ALTER TABLE [dbo].[AssayResult]  WITH CHECK ADD  CONSTRAINT [FK_AssayResult_Assays] FOREIGN KEY([AssayID])
REFERENCES [dbo].[Assays] ([AssayID])
GO
ALTER TABLE [dbo].[AssayResult] CHECK CONSTRAINT [FK_AssayResult_Assays]
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD  CONSTRAINT [FK_Doctors_Policlinic] FOREIGN KEY([PoliclinicID])
REFERENCES [dbo].[Policlinic] ([PoliclinicID])
GO
ALTER TABLE [dbo].[Doctors] CHECK CONSTRAINT [FK_Doctors_Policlinic]
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD  CONSTRAINT [FK_Doctors_Titles] FOREIGN KEY([Title])
REFERENCES [dbo].[Titles] ([TitleID])
GO
ALTER TABLE [dbo].[Doctors] CHECK CONSTRAINT [FK_Doctors_Titles]
GO
ALTER TABLE [dbo].[Inspection Result]  WITH CHECK ADD  CONSTRAINT [FK_Inspection Result_AssayResult] FOREIGN KEY([RequestedAssaysID])
REFERENCES [dbo].[AssayResult] ([AssayResultID])
GO
ALTER TABLE [dbo].[Inspection Result] CHECK CONSTRAINT [FK_Inspection Result_AssayResult]
GO
ALTER TABLE [dbo].[Inspection Result]  WITH CHECK ADD  CONSTRAINT [FK_Inspection Result_Inspections] FOREIGN KEY([InspectionsID])
REFERENCES [dbo].[Inspections] ([InspectionID])
GO
ALTER TABLE [dbo].[Inspection Result] CHECK CONSTRAINT [FK_Inspection Result_Inspections]
GO
ALTER TABLE [dbo].[Inspections]  WITH CHECK ADD  CONSTRAINT [FK_Inspections_Doctors] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctors] ([DoctorID])
GO
ALTER TABLE [dbo].[Inspections] CHECK CONSTRAINT [FK_Inspections_Doctors]
GO
ALTER TABLE [dbo].[Inspections]  WITH CHECK ADD  CONSTRAINT [FK_Inspections_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([PatientID])
GO
ALTER TABLE [dbo].[Inspections] CHECK CONSTRAINT [FK_Inspections_Patient]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_BloodTypes] FOREIGN KEY([BloodType])
REFERENCES [dbo].[BloodTypes] ([ID])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_BloodTypes]
GO
/****** Object:  StoredProcedure [dbo].[AddPatient]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddPatient]
(
@tc nchar(11),
@name nvarchar(50),
@surname nvarchar(50),
@adress nvarchar(80),
@phone nchar(11),
@blood int
)
as
insert into Patient (TC,Name,Surname,Adress,Phone,BloodType) values (@tc,@name,@surname,@adress,@phone,@blood)
GO
/****** Object:  StoredProcedure [dbo].[DeletePatient]    Script Date: 20.11.2022 22:41:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeletePatient]
(
@id int
)
as
delete from Patient where PatientID = @id
GO
