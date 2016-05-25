USE TestData
GO

SELECT DecartCustomProduct.CustomerID, DecartCustomProduct.ProductID, CountFirstSale FROM
( SELECT CustomerID, ProductID FROM	
	(SELECT DISTINCT(CustomerID) FROM dbo.Sales) Customers,
	(SELECT DISTINCT(ProductID) FROM dbo.Sales) Products
) DecartCustomProduct

LEFT OUTER JOIN

( SELECT CustomerID, ProductID, COUNT(ProductID) AS CountFirstSale
	FROM dbo.Sales 
		WHERE SaleID IN 
			(SELECT MIN(SaleID) FROM dbo.Sales 
				GROUP BY CustomerID, TimeLabel)
		GROUP BY ProductID, CustomerID
) CustomFirstProductSaleCount

ON 
	DecartCustomProduct.CustomerID = CustomFirstProductSaleCount.CustomerID 
	AND
	DecartCustomProduct.ProductID = CustomFirstProductSaleCount.ProductID;
