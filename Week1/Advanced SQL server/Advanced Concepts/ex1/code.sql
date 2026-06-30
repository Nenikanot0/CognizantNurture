-- Create the RetailStore database
CREATE DATABASE RetailStore;
GO

-- Use the RetailStore database
USE RetailStore;
GO

-- Create a table to store product details
CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

-- Add sample data to the Products table
INSERT INTO Products
(ProductID, ProductName, Category, Price)
VALUES
(101,'Laptop','Electronics',70000),
(102,'Smartphone','Electronics',50000),
(103,'Monitor','Electronics',15000),
(104,'Keyboard','Electronics',2500),
(105,'Mouse','Electronics',1200),

(201,'Jacket','Clothing',3500),
(202,'Sweater','Clothing',3500),
(203,'Jeans','Clothing',1800),
(204,'Shirt','Clothing',1200),
(205,'T-Shirt','Clothing',800),

(301,'Boots','Footwear',4500),
(302,'Sneakers','Footwear',4500),
(303,'Shoes','Footwear',3000),
(304,'Sandals','Footwear',1800),
(305,'Slippers','Footwear',900);

----------------------------------------------------------
-- Find the top 3 most expensive products in each category
-- using ROW_NUMBER().
-- Every product gets a unique number, even if prices are the same.
----------------------------------------------------------

WITH RankedProducts AS
(
    SELECT ProductID,
           ProductName,
           Category,
           Price,
           ROW_NUMBER() OVER
           (
               PARTITION BY Category
               ORDER BY Price DESC
           ) AS Row_Number
    FROM Products
)
SELECT *
FROM RankedProducts
WHERE Row_Number <= 3;

----------------------------------------------------------
-- Find the top 3 most expensive products in each category
-- using RANK().
-- Products with the same price get the same rank,
-- and the next rank is skipped.
----------------------------------------------------------

WITH RankedProducts AS
(
    SELECT ProductID,
           ProductName,
           Category,
           Price,
           RANK() OVER
           (
               PARTITION BY Category
               ORDER BY Price DESC
           ) AS Rank_No
    FROM Products
)
SELECT *
FROM RankedProducts
WHERE Rank_No <= 3;

----------------------------------------------------------
-- Find the top 3 most expensive products in each category
-- using DENSE_RANK().
-- Products with the same price get the same rank,
-- but the next rank is not skipped.
----------------------------------------------------------

WITH RankedProducts AS
(
    SELECT ProductID,
           ProductName,
           Category,
           Price,
           DENSE_RANK() OVER
           (
               PARTITION BY Category
               ORDER BY Price DESC
           ) AS Dense_Rank
    FROM Products
)
SELECT *
FROM RankedProducts
WHERE Dense_Rank <= 3;