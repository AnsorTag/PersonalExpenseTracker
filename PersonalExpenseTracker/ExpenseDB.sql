USE ExpenseTrackerDB;

CREATE TABLE Expenses (
    ExpenseID INT IDENTITY(1,1) PRIMARY KEY,
    Description VARCHAR(255) NOT NULL,
    Category VARCHAR(100) NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    Date DATE NOT NULL
);

CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName VARCHAR(100) NOT NULL UNIQUE
);

INSERT INTO Categories (CategoryName)
VALUES ('Food'), ('Transportation'), ('Utilities'), ('Entertainment'), ('Others');
