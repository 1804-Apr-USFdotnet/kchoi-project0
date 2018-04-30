use ProductsDb;
go

create schema Products;
go

--create tables
create table Products.Products (id int primary key identity (1,1), [name] varchar(50), price money);
create table Products.Orders (id int primary key identity (1,1), ProductID int, CustomerID int);
create table Products.Customers (id int primary key identity (1,1), FirstName varchar(50), LastName varchar(50), CardNumber int);
go

--add foreign keys
alter table Products.Orders
ADD CONSTRAINT FK_Orders_Products FOREIGN KEY (ProductID)
    REFERENCES Products.Products (id) ;
go

alter table Products.Orders
ADD CONSTRAINT FK_Orders_Customers FOREIGN KEY (CustomerID)
    REFERENCES Products.Customers (id) ;
go

--add items
insert into Products.Customers (FirstName, LastName, CardNumber) values ('John', 'Doe', 123456789);
insert into Products.Customers (FirstName, LastName, CardNumber) values ('Robert', 'Baratheon', 987654321);
insert into Products.Customers (FirstName, LastName, CardNumber) values ('James', 'Bond', 900000000);


insert into Products.Products ([name], price) values ('iPhone', 200);
insert into Products.Products ([name], price) values ('TV', 900);
insert into Products.Products ([name], price) values ('car', 24000);

insert into products.customers (FirstName, LastName, CardNumber) values ('Tina', 'Smith', 900000001);
insert into Products.Orders (ProductID, CustomerID) values (1,4);
/*
select * from Products.Customers;
select * from Products.Products;
select * from Products.Orders;
*/
