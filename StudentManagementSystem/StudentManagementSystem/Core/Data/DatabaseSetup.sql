
-- Shared Database Initialization Script for SQL Server / LocalDB

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'StudentDB')
BEGIN
    CREATE DATABASE StudentDB;
END
GO

USE StudentDB;
GO

-- 1. Courses Table ( Course Management Module)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Courses')
BEGIN
    CREATE TABLE Courses (
        CourseID INT IDENTITY(1,1) PRIMARY KEY,
        CourseCode VARCHAR(20) NOT NULL UNIQUE,
        CourseName VARCHAR(150) NOT NULL,
        Credits INT NOT NULL CONSTRAINT CHK_Credits CHECK (Credits BETWEEN 1 AND 10),
        Department VARCHAR(100) NULL,
        AssignedTeacherID INT NULL,
        IsActive BIT NOT NULL DEFAULT 1,
        CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
    );
END
GO

-- 2.  Students Table ( Student Records Module)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Students')
BEGIN
    CREATE TABLE Students (
        StudentID INT IDENTITY(1,1) PRIMARY KEY,
        RegNumber VARCHAR(30) NOT NULL UNIQUE,
        FirstName VARCHAR(100) NOT NULL,
        LastName VARCHAR(100) NOT NULL,
        Email VARCHAR(150) NOT NULL,
        Phone VARCHAR(30) NULL,
        Address NVARCHAR(255) NULL,
        DateOfBirth DATE NOT NULL,
        EnrollmentDate DATETIME NOT NULL DEFAULT GETDATE(),
        IsActive BIT NOT NULL DEFAULT 1
    );
END
GO

-- 3.  StudentCourses Junction / Enrollment Table (Shared Enrollment Relationship)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'StudentCourses')
BEGIN
    CREATE TABLE StudentCourses (
        EnrollmentID INT IDENTITY(1,1) PRIMARY KEY,
        StudentID INT NOT NULL CONSTRAINT FK_StudentCourses_Students REFERENCES Students(StudentID),
        CourseID INT NOT NULL CONSTRAINT FK_StudentCourses_Courses REFERENCES Courses(CourseID),
        EnrollmentDate DATETIME NOT NULL DEFAULT GETDATE(),
        Status VARCHAR(20) NOT NULL DEFAULT 'Enrolled',
        CONSTRAINT UQ_Student_Course UNIQUE (StudentID, CourseID)
    );
END
GO

-- Seed Sample Courses
IF NOT EXISTS (SELECT * FROM Courses WHERE CourseCode = 'CS107.3')
BEGIN
    INSERT INTO Courses (CourseCode, CourseName, Credits, Department)
    VALUES 
    ('CS107.3', 'Object Oriented Programming with C#', 3, 'Faculty of Computing'),
    ('CS101.1', 'Introduction to Computer Science', 3, 'Faculty of Computing'),
    ('SE202.2', 'Software Architecture & Design', 4, 'Faculty of Computing');
END
GO

-- Seed Sample Students
IF NOT EXISTS (SELECT * FROM Students WHERE RegNumber = 'STU/2026/001')
BEGIN
    INSERT INTO Students (RegNumber, FirstName, LastName, Email, Phone, Address, DateOfBirth)
    VALUES 
    ('STU/2026/001', 'John', 'Doe', 'john.doe@student.nsbm.ac.lk', '+94771234567', 'Colombo, Sri Lanka', '2003-05-15'),
    ('STU/2026/002', 'Jane', 'Smith', 'jane.smith@student.nsbm.ac.lk', '+94779876543', 'Kandy, Sri Lanka', '2003-08-22');
END
GO

-- Seed Sample Course Enrollments
IF NOT EXISTS (SELECT * FROM StudentCourses)
BEGIN
    INSERT INTO StudentCourses (StudentID, CourseID, Status)
    VALUES 
    (1, 1, 'Enrolled'),
    (1, 2, 'Enrolled'),
    (2, 1, 'Enrolled');
END
GO

-- 4.  Users Table (  Auth / Roles Module)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
BEGIN
    CREATE TABLE Users (
        UserID       INT IDENTITY(1,1) PRIMARY KEY,
        Username     VARCHAR(100) NOT NULL UNIQUE,
        PasswordHash VARCHAR(256) NOT NULL,
        FullName     VARCHAR(200) NOT NULL,
        Email        VARCHAR(150) NOT NULL,
        IdNumber     VARCHAR(50)  NULL,
        AccountType  VARCHAR(20)  NOT NULL DEFAULT 'Student'
            CONSTRAINT CHK_AccountType CHECK (AccountType IN ('Admin', 'Student')),
        Age          INT          NULL,
        Gender       VARCHAR(20)  NULL,
        Phone        VARCHAR(30)  NULL,
        CreatedAt    DATETIME     NOT NULL DEFAULT GETDATE(),
        IsActive     BIT          NOT NULL DEFAULT 1
    );
END
GO

-- Seed Default Admin Account
IF NOT EXISTS (SELECT * FROM Users WHERE Username = 'admin')
BEGIN
    INSERT INTO Users (Username, PasswordHash, FullName, Email, IdNumber, AccountType)
    VALUES ('admin', 'admin123', 'System Administrator', 'admin@nsbm.ac.lk', 'ADM/001', 'Admin');
END
GO

-- 5. Create Attendance Table (Attendance Module)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Attendance')
BEGIN
    CREATE TABLE Attendance (
        AttendanceID INT IDENTITY(1,1) PRIMARY KEY,
        StudentID INT NOT NULL CONSTRAINT FK_Attendance_Students REFERENCES Students(StudentID),
        CourseID INT NOT NULL CONSTRAINT FK_Attendance_Courses REFERENCES Courses(CourseID),
        Date DATE NOT NULL,
        Status VARCHAR(20) NOT NULL CONSTRAINT CHK_Attendance_Status CHECK (Status IN ('Present', 'Absent', 'Late')),
        CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
    );
END
GO

-- Seed Sample Attendance Records
IF NOT EXISTS (SELECT * FROM Attendance)
BEGIN
    INSERT INTO Attendance (StudentID, CourseID, Date, Status)
    VALUES 
    (1, 1, CAST(GETDATE() AS DATE), 'Present'),
    (2, 1, CAST(GETDATE() AS DATE), 'Present'),
    (1, 2, CAST(GETDATE() AS DATE), 'Late');
END
GO

-- 6. Create Grades Table (Grades Module)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Grades')
BEGIN
    CREATE TABLE Grades (
        GradeID INT IDENTITY(1,1) PRIMARY KEY,
        StudentID INT NOT NULL CONSTRAINT FK_Grades_Students REFERENCES Students(StudentID),
        CourseID INT NOT NULL CONSTRAINT FK_Grades_Courses REFERENCES Courses(CourseID),
        GradeValue VARCHAR(10) NOT NULL,
        Remarks NVARCHAR(255) NULL,
        RecordedDate DATETIME NOT NULL DEFAULT GETDATE()
    );
END
GO

-- Seed Sample Grades Records
IF NOT EXISTS (SELECT * FROM Grades)
BEGIN
    INSERT INTO Grades (StudentID, CourseID, GradeValue, Remarks)
    VALUES 
    (1, 1, 'A', 'Excellent performance'),
    (1, 2, 'B+', 'Good effort in assignments'),
    (2, 1, 'A-', 'Active participation');
END
GO

-- 7. Create Fees Table (Fees Module)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Fees')
BEGIN
    CREATE TABLE Fees (
        FeeID INT IDENTITY(1,1) PRIMARY KEY,
        StudentID INT NOT NULL CONSTRAINT FK_Fees_Students REFERENCES Students(StudentID),
        Amount DECIMAL(10,2) NOT NULL,
        PaymentDate DATE NOT NULL,
        Status VARCHAR(20) NOT NULL CONSTRAINT CHK_Fees_Status CHECK (Status IN ('Paid', 'Pending', 'Partially Paid', 'Overdue')),
        CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
    );
END
GO

-- Seed Sample Fees Records
IF NOT EXISTS (SELECT * FROM Fees)
BEGIN
    INSERT INTO Fees (StudentID, Amount, PaymentDate, Status)
    VALUES 
    (1, 15000.00, CAST(GETDATE() AS DATE), 'Paid'),
    (2, 12500.00, CAST(GETDATE() AS DATE), 'Pending');
END
GO

