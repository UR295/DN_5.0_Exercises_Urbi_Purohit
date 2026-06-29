-- Create Departments Table --
CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

-- Create Employees Table --
CREATE TABLE Employees
(
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10,2),
    JoinDate DATE
);

-- Insert Sample Data into Departments --
INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');

-- Insert Sample Data into Employees --
INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05');

-- Stored Procedure to Retrieve Employee Details by Department
CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;

-- Execute Stored Procedure --
EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;

-- Stored Procedure to Insert Employee --
CREATE PROCEDURE sp_InsertEmployee
    @EmployeeID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees
    (
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        @EmployeeID,
        @FirstName,
        @LastName,
        @DepartmentID,
        @Salary,
        @JoinDate
    );
END;

-- Execute Insert Stored Procedure --
EXEC sp_InsertEmployee
    @EmployeeID = 5,
    @FirstName = 'David',
    @LastName = 'Wilson',
    @DepartmentID = 3,
    @Salary = 8000.00,
    @JoinDate = '2024-01-15';

SELECT * FROM Employees;
