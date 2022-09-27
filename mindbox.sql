USE testDB
CREATE TABLE Category
(  
    CategoryID int primary key 
    ,CategoryName varchar(20) NOT NULL  
); 



CREATE TABLE Products  
(  
    ProductsID int primary key  
    ,ProductName varchar(20) NOT NULL  
);


CREATE TABLE ProdAndCateg
(
	Category int,
	Product int
	FOREIGN KEY (Category)  REFERENCES Category (CategoryID),
	FOREIGN KEY (Product)  REFERENCES Products (ProductsID)
);



INSERT INTO Category VALUES (1,'Category1'),(2,'Category2'),(3,'Category3'),(4,'Category4')
INSERT INTO Products  VALUES (1,'Product1'),(2,'Product2'),(3,'Product3'),(4,'Product4')


INSERT INTO ProdAndCateg  VALUES (1,1),(2,2),(3,3)



SELECT ProductName, CategoryName FROM Products LEFT JOIN ProdAndCateg ON Products.ProductsID=ProdAndCateg.Product LEFT JOIN Category ON ProdAndCateg.Category = Category.CategoryID;