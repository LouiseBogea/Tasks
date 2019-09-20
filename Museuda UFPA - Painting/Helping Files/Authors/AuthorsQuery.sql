USE [MuseuDaUFPA]
Create Table tblAuthors(
ID int Primary Key, 
Name nvarchar(max)  , 
DOB  [datetime] NULL, 
PlaceOfBirth nvarchar(max)  , 
Address nvarchar(max)  , 
Biography nvarchar(max)  , 
SignImage [image] NULL  , 
ProfileImage [image] NULL, 
)
