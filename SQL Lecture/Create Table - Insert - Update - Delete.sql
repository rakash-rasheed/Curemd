-- Step 1: CREATE Database
CREATE DATABASE [5586];


-- Use the database
USE [5586];


-- Step 2: CREATE the Products table
CREATE TABLE Products
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    Description VARCHAR(500),
    Price DECIMAL(18,2) NOT NULL,
    ManufacturingDate DATE NOT NULL
);


-- Insert data into the Products table
INSERT INTO Products (Name, Description, Price, ManufacturingDate)
VALUES
       ('MotorCycle', 'Latest model', 34999.9, GETDATE()),
       ('MotorBike', 'Efficient model', 39999.9, GETDATE()),
       ('Tablet', 'A portable tablet', 499.99, GETDATE()),
       ('ElectricBike', 'Environment friendly', 59999.9, GETDATE());


-- SELECT Command to view the inserted data
SELECT * FROM Products;


-- Step 3: CREATE another table for Product Categories
CREATE TABLE ProductCategories
(
    CategoryId INT PRIMARY KEY IDENTITY(1,1),
    CategoryName VARCHAR(100) NOT NULL
);


-- Step 4: Insert data into the ProductCategories table
INSERT INTO ProductCategories (CategoryName)
VALUES ('Electronics'),
       ('Accessories'),
       ('Wearables');


-- SELECT Command to view the inserted data in ProductCategories
SELECT * FROM ProductCategories;


-- Step 5: Add a foreign key column to the Products table
ALTER TABLE Products
ADD CategoryId INT;

select * from Products where name like '%phone';
-- Update existing data with a default category 
UPDATE Products SET CategoryId = 1 where name like '%smart%';

UPDATE Products SET CategoryId = 2 where id in (1, 4, 5); 


-- Step 6: Add a foreign key constraint to link Products to ProductCategories
ALTER TABLE Products
ADD CONSTRAINT FK_Products_ProductCategories
FOREIGN KEY (CategoryId) REFERENCES ProductCategories(CategoryId);


-- SELECT Command
SELECT * FROM Products ;
select * from ProductCategories;


-- 7. Aggregation Functions

-- COUNT Function
SELECT COUNT(*) as Counts FROM Products;

-- SUM Function
SELECT SUM(Price) [Total Sum] FROM Products;


-- 8. Queries and Filters
-- Simple Query
SELECT * FROM Products
WHERE Price < 500;
GO


-- JOIN Query
SELECT p.Name, p.Description, c.CategoryName FROM Products p
Inner JOIN ProductCategories c ON p.CategoryId = c.CategoryId;