
CREATE TABLE [dbo].[Orders](
    [OrderId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [CustomerId] INT NOT NULL,
    [OrderDate] DATETIME NOT NULL DEFAULT GETDATE(),
    [Amount] DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_Orders_Customers FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);
