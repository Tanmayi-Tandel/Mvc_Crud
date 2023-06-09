# Mvc_Crud
This project is about creating Product and Category using ASP.Net MVC, Entity framework.



#Database

#Category Table

create table Category (
CategoryId int primary key,
CategoryName varchar(100)
);




#Product Table

create table Product (
ProductId int primary key,
ProductName varchar(100),
ProductPrice decimal,
CategoryId int,
CategoryName varchar(100),
foreign key (CategoryId) references Category(CategoryId)
);

