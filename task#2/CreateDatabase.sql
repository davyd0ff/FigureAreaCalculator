If not exists (select count(1) from sys.databases where name = 'TestDb') begin
  Create database TestDb;
end
go

use [TestDb]
go 


if Object_id('dbo.Intermediate_Product_Category') is not null begin Drop table [Intermediate_Product_Category] end
go
Create table [Intermediate_Product_Category] (
  [ProductId] int not null,
  [CategoryId] int not null
)
go

if Object_id('dbo.Products') is not null begin Drop table [Products] end
go
Create table [Products] (
  [Id] int identity(1,1) not null constraint PK_ProductId primary key,
  [Name] nvarchar(150) not null,
)
go

if Object_id('dbo.Categories') is not null begin Drop table [Categories] end
go 
Create table [Categories] (
  [Id] int identity(1,1) not null constraint PK_CategoryId primary key,
  [Name] nvarchar(50) not null
)
go


Alter table [Intermediate_Product_Category] add constraint FK_Product 
  foreign key (ProductId) 
  references [Products] (Id)
go  
Alter table [Intermediate_Product_Category] add constraint FK_Category
  foreign key (CategoryId)
  references [Categories] (Id)
go


Insert into [Products] ([Name])
  Values ('Product1'), ('Product2'), ('Product3')
go
Insert into [Categories] ([Name])
  Values ('Category1'), ('Category2'), ('Category3')
go
Insert into [Intermediate_Product_Category] ([ProductId], [CategoryId])
  Values ((select Id from Products where [Name] = 'Product1'), (select Id from Categories where [Name] = 'Category1')),
         ((select Id from Products where [Name] = 'Product3'), (select Id from Categories where [Name] = 'Category3'))
