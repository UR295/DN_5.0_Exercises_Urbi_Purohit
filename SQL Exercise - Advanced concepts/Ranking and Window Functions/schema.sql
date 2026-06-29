CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Products VALUES
(1,'Laptop','Electronics',70000),
(2,'Mobile','Electronics',50000),
(3,'Tablet','Electronics',50000),
(4,'TV','Electronics',90000),

(5,'Chair','Furniture',5000),
(6,'Table','Furniture',10000),
(7,'Sofa','Furniture',25000),
(8,'Bed','Furniture',25000),

(9,'Shirt','Clothing',2000),
(10,'Jeans','Clothing',3000),
(11,'Jacket','Clothing',3000),
(12,'Shoes','Clothing',5000);

-- ROW NUMBER --
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNum
FROM Products;

-- RANK --
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RankNo
FROM Products;

-- DENSE RANK --
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRank
FROM Products;

-- PARTION AND ORDER BY --
SELECT *FROM(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNum
    FROM Products
) AS Result
WHERE RowNum <= 3;

SELECT *FROM(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RankNo
    FROM Products
) AS Result
WHERE RankNo <= 3;

SELECT *FROM(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RankNo
    FROM Products
) AS Result
WHERE RankNo <= 3;
