/*=========================================================
   Employee Management System
   Exercise 5: Return Data from a Stored Procedure
=========================================================*/

-- Create the database
CREATE DATABASE EmployeeDB;
GO

-- Use the database
USE EmployeeDB;
GO

/*=========================================================
   Create Tables
=========================================================*/

-- Create Departments table
CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

-- Create Employees table
CREATE TABLE Employees
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,

    FOREIGN KEY (DepartmentID)
    REFERENCES Departments(DepartmentID)
);

/*=========================================================
   Insert Sample Data
=========================================================*/

-- Insert department records
INSERT INTO Departments
VALUES
(1,'HR'),
(2,'Finance'),
(3,'IT'),
(4,'Marketing');

-- Insert employee records
INSERT INTO Employees
(FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
('John','Doe',1,5000,'2020-01-15'),
('Jane','Smith',2,6000,'2019-03-22'),
('Michael','Johnson',3,7000,'2018-07-30'),
('Emily','Davis',4,5500,'2021-11-05'),
('Robert','Brown',3,6500,'2024-01-10');


/*=========================================================
   Exercise 5
   Create a Stored Procedure to Return the
   Total Number of Employees in a Department
=========================================================*/

-- Create the stored procedure
SELECT * FROM Employees;
GO

CREATE PROCEDURE sp_TotalEmployees
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

-- Count employees in HR
EXEC sp_TotalEmployees 1;
GO

-- Count employees in Finance
EXEC sp_TotalEmployees 2;
GO

-- Count employees in IT
EXEC sp_TotalEmployees 3;
GO

-- Count employees in Marketing
EXEC sp_TotalEmployees 4;
GO