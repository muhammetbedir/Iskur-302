create trigger PatientEntryDate on Patient
for insert as
begin 
declare @PatientID int
select @PatientID = PatientID from inserted
update Patient set RegistrationDate = GETDATE() where PatientID = @PatientID
end
go
create trigger DoctorHireDate on Doctors
for insert as
begin 
declare @DoctorID int
select @DoctorID = DoctorID from inserted
update Doctors set HireDate = GETDATE() where DoctorID = @DoctorID
end
go
create trigger InspectionDate on Inspections
for insert as
begin 
declare @InspectionID int
select @InspectionID = InspectionID from inserted
update Inspections set Date = GETDATE() where InspectionID = @InspectionID
end
go
create proc AddPatient
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
go
create proc DeletePatient
(
@id int
)
as
delete from Patient where PatientID = @id
go
create view Professors 
as
select d.Name, d.Surname, p.Name as 'PoliclinicName' from Doctors d inner join Policlinic p on p.PoliclinicID = d.PoliclinicID where Title = 6 
go