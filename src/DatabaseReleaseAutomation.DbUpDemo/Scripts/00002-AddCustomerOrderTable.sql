ALTER TABLE Customers ADD AddressLine1 VARCHAR(255);
ALTER TABLE Customers ADD AddressLine2 VARCHAR(255);
ALTER TABLE Customers ADD AddressLine3 VARCHAR(255);
ALTER TABLE Customers ADD Postcode VARCHAR(9);
GO;

INSERT INTO Customers (FirstName, LastName, AddressLine1, AddressLine2, AddressLine3, Postcode) 
VALUES ('Joe', 'Washington', 'AddressLine1', 'AddressLine2', 'AddressLine3', 'Postcode');
Go;

CREATE TABLE CustomerOrders
(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
	OrderDate DATETIME
);
Go;