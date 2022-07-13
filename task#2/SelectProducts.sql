use [TestDb]
go

Select p.Name as ProductName, c.Name as CategoryName
From 
  Products as p 
    Left join Intermediate_Product_Category as i on p.Id = i.ProductId
	Left join Categories as c on i.CategoryId = c.Id