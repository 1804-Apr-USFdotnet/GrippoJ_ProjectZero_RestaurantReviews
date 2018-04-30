USE CC2;
GO

CREATE TABLE Orders (
	ID INT UNIQUE IDENTITY NOT NULL,
	ProductID INT,
	CustomerID INT,
	PRIMARY KEY(ID)
);

CREATE TABLE Products (
	ID INT UNIQUE IDENTITY NOT NULL,
	[Name] NVARCHAR(255),
	Price INT,
	PRIMARY KEY(ID)
	);

CREATE TABLE Customers (
	ID INT UNIQUE IDENTITY NOT NULL,
	Firstname NVARCHAR(255),
	Lastname NVARCHAR(255),
	CardNumber INT,
	PRIMARY KEY(ID)
);

GO

INSERT INTO Products([Name],Price) VALUES('p1',1),('p2',2),('p3',3);
INSERT INTO Customers(Firstname,Lastname,CardNumber) VALUES('John','Smith',10),('James','Watson',11),('Mary','Jane',13);
INSERT INTO Orders(ProductID,CustomerID) VALUES(1,1),(2,2),(3,3);

ALTER TABLE Orders WITH CHECK ADD
CONSTRAINT FK_Orders_Customer FOREIGN KEY(CustomerID) REFERENCES Customers(ID);

ALTER TABLE Orders WITH CHECK ADD
CONSTRAINT FK_Orders_Product FOREIGN KEY(ProductID) REFERENCES Products(ID);