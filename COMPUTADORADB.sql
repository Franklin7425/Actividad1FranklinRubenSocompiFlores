
CREATE DATABASE ComputadoraDB;
USE ComputadoraDB;



CREATE TABLE Computadora (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(255),
    Precio DECIMAL(10,2),
    FechaFabricacion DATE
);



INSERT INTO Computadora (Nombre, Descripcion, Precio, FechaFabricacion) 
VALUES 
    ('Laptop HP', 'Laptop HP modelo ABC123', 799.99, '2023-05-10'),
    ('PC Gamer', 'PC Gamer de alta gama', 1499.50, '2023-02-28'),
    ('Desktop Lenovo', 'Desktop Lenovo ThinkCentre', 549.00, '2023-04-15'),
    ('MacBook Air', 'MacBook Air 13 pulgadas', 1099.99, '2023-03-20'),
    ('Tablet Samsung', 'Tablet Samsung Galaxy Tab S7', 649.99, '2023-06-05'),
    ('Ultrabook Dell', 'Ultrabook Dell XPS 13', 1199.00, '2023-01-15'),
    ('iMac', 'iMac 27 pulgadas', 1799.00, '2023-07-10'),
    ('Chromebook Asus', 'Chromebook Asus C302CA', 499.99, '2023-08-22'),
    ('Surface Pro', 'Microsoft Surface Pro 7', 899.00, '2023-09-17'),
    ('All-in-One HP', 'All-in-One HP 24-dp0165qe', 699.99, '2023-11-30'),
    ('Desktop Acer', 'Desktop Acer Aspire TC-895', 399.00, '2023-10-05'),
    ('iPad Pro', 'iPad Pro 12.9 pulgadas', 1099.00, '2023-12-25'),
    ('Chromebook Lenovo', 'Chromebook Lenovo Flex 5', 599.99, '2023-02-10'),
    ('Desktop HP', 'Desktop HP Pavilion TP01', 649.00, '2023-04-01'),
    ('MacBook Pro', 'MacBook Pro 16 pulgadas', 2399.00, '2023-03-15');


	select * from Computadora;