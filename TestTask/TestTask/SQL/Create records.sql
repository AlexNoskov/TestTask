USE TestData
GO

INSERT INTO dbo.Sales
				(SaleID, ProductID, TimeLabel, CustomerID)
		VALUES (1, 1, '20160525', 1);

INSERT INTO dbo.Sales
				(SaleID, ProductID, TimeLabel, CustomerID)
		VALUES (2, 2, '20160525', 1);
GO

INSERT INTO dbo.Sales
				(SaleID, ProductID, TimeLabel, CustomerID)
		VALUES (3, 2, '20160526', 2);
GO

INSERT INTO dbo.Sales
				(SaleID, ProductID, TimeLabel, CustomerID)
		VALUES (4, 3, '20160526', 2);
GO

INSERT INTO dbo.Sales
				(SaleID, ProductID, TimeLabel, CustomerID)
		VALUES (5, 1, '20160527', 1);
GO

INSERT INTO dbo.Sales
				(SaleID, ProductID, TimeLabel, CustomerID)
		VALUES (6, 3, '20160527', 1);
GO

INSERT INTO dbo.Sales
				(SaleID, ProductID, TimeLabel, CustomerID)
		VALUES (7, 3, '20160528', 2);
GO

INSERT INTO dbo.Sales
				(SaleID, ProductID, TimeLabel, CustomerID)
		VALUES (8, 2, '20160528', 2);
GO