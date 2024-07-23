USE DemoDB;
GO

-- Stored Procedures 

--Get Products
CREATE PROCEDURE GetAllProducts
AS
BEGIN
    SELECT * FROM Products
END
GO
--exec GetAllProducts
--Get Products By ID
CREATE PROCEDURE GetProductById
    @Id INT 
AS
BEGIN
    SELECT * FROM Products WHERE Id = @Id
END
GO
--exec GetProductById 1
--Insert Products 
CREATE PROCEDURE AddProduct
    @Name VARCHAR(100),
    @Description VARCHAR(500),
    @Price DECIMAL(18, 2),
    @ManufacturingDate DATE
AS
BEGIN
    INSERT INTO Products (Name, Description, Price, ManufacturingDate)
    VALUES (@Name, @Description, @Price, @ManufacturingDate)
END
GO
-- exec AddProduct 'GalaxyWatch', 'Digital', 5.55, '7-23-2024'
--Update Product
CREATE PROCEDURE UpdateProduct
    @Id INT,
    @Name NVARCHAR(100),
    @Description NVARCHAR(500),
    @Price DECIMAL(18, 2),
    @ManufacturingDate DATE
AS
BEGIN
    UPDATE Products
    SET Name = @Name,
        Description = @Description,
        Price = @Price,
        ManufacturingDate = @ManufacturingDate
    WHERE Id = @Id
END
GO

--Delete Product
CREATE PROCEDURE DeleteProduct
    @Id INT
AS
BEGIN
    DELETE FROM Products WHERE Id = @Id
END
GO