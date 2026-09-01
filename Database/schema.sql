-- ============================================================
-- Student Management System - Database Schema
-- Matches the C# classes in Core/Models
-- Run this ONCE to create the database and all tables.
-- ============================================================

CREATE DATABASE StudentManagementDB;
GO

USE StudentManagementDB;
GO

-- ---------- Member 1: Auth / Roles ----------
-- Note: Password should store a HASH in the real implementation, not plain text.

CREATE TABLE Admins (
    Id            INT IDENTITY(1,1) PRIMARY KEY,
    FullName      NVARCHAR(100)  NOT NULL,
    Email         NVARCHAR(100)  NOT NULL UNIQUE,
    Password      NVARCHAR(255)  NOT NULL,
    DateOfBirth   DATE           NOT NULL
);

CREATE TABLE Teachers (
    Id            INT IDENTITY(1,1) PRIMARY KEY,
    FullName      NVARCHAR(100)  NOT NULL,
    Email         NVARCHAR(100)  NOT NULL UNIQUE,
    Password      NVARCHAR(255)  NOT NULL,
    DateOfBirth   DATE           NOT NULL,
    StaffNumber   NVARCHAR(20)   NOT NULL UNIQUE
);

-- ---------- Member 2: Student Records ----------

CREATE TABLE Students (
    Id                 INT IDENTITY(1,1) PRIMARY KEY,
    FullName           NVARCHAR(100)  NOT NULL,
    Email              NVARCHAR(100)  NOT NULL UNIQUE,
    Password           NVARCHAR(255)  NOT NULL,
    DateOfBirth        DATE           NOT NULL,
    StudentNumber      NVARCHAR(20)   NOT NULL UNIQUE,
    OutstandingBalance DECIMAL(10,2)  NOT NULL DEFAULT 0
);

-- ---------- Member 3: Course Management ----------

CREATE TABLE Courses (
    CourseCode    NVARCHAR(10)   PRIMARY KEY,
    CourseName    NVARCHAR(100)  NOT NULL,
    Credits       INT            NOT NULL,
    TeacherId     INT            NULL REFERENCES Teachers(Id)
);

-- Many-to-many: which students are enrolled in which courses
CREATE TABLE Enrollments (
    StudentId     INT            NOT NULL REFERENCES Students(Id),
    CourseCode    NVARCHAR(10)   NOT NULL REFERENCES Courses(CourseCode),
    PRIMARY KEY (StudentId, CourseCode)
);

-- ---------- Member 4: Attendance ----------

CREATE TABLE AttendanceRecords (
    Id            INT IDENTITY(1,1) PRIMARY KEY,
    StudentId     INT            NOT NULL REFERENCES Students(Id),
    CourseCode    NVARCHAR(10)   NOT NULL REFERENCES Courses(CourseCode),
    RecordDate    DATE           NOT NULL,
    Present       BIT            NOT NULL,
    CONSTRAINT UQ_Attendance UNIQUE (StudentId, CourseCode, RecordDate)
);

-- ---------- Member 5: Grades ----------

CREATE TABLE Grades (
    Id            INT IDENTITY(1,1) PRIMARY KEY,
    StudentId     INT            NOT NULL REFERENCES Students(Id),
    CourseCode    NVARCHAR(10)   NOT NULL REFERENCES Courses(CourseCode),
    GradeValue    FLOAT          NOT NULL CHECK (GradeValue BETWEEN 0 AND 100),
    CONSTRAINT UQ_Grade UNIQUE (StudentId, CourseCode)
);

-- ---------- Member 6: Fees ----------

CREATE TABLE Payments (
    Id            INT IDENTITY(1,1) PRIMARY KEY,
    StudentId     INT            NOT NULL REFERENCES Students(Id),
    Amount        DECIMAL(10,2)  NOT NULL,
    PaymentType   NVARCHAR(10)   NOT NULL CHECK (PaymentType IN ('Charge', 'Payment')),
    TransactionDate DATETIME     NOT NULL DEFAULT GETDATE()
);

-- ---------- Member 7: Timetable ----------

CREATE TABLE Timetable (
    Id            INT IDENTITY(1,1) PRIMARY KEY,
    CourseCode    NVARCHAR(10)   NOT NULL REFERENCES Courses(CourseCode),
    TeacherId     INT            NOT NULL REFERENCES Teachers(Id),
    DayOfWeek     NVARCHAR(10)   NOT NULL,
    StartTime     TIME           NOT NULL,
    EndTime       TIME           NOT NULL,
    Room          NVARCHAR(20)   NOT NULL
);

-- ---------- Member 8: Report Card Export ----------
-- No new table needed - this module only READS from Students, Grades,
-- AttendanceRecords, and Payments above.

-- ============================================================
-- Optional: a couple of sample rows so you can test forms
-- immediately without waiting for other modules to add data.
-- Delete before final submission if you don't want test data included.
-- ============================================================

INSERT INTO Teachers (FullName, Email, Password, DateOfBirth, StaffNumber)
VALUES ('Anton Jayakody', 'anton@nsbm.ac.lk', 'temp123', '1985-01-01', 'STF001');

INSERT INTO Students (FullName, Email, Password, DateOfBirth, StudentNumber)
VALUES ('Test Student', 'test.student@nsbm.ac.lk', 'temp123', '2003-05-14', 'STU001');

INSERT INTO Courses (CourseCode, CourseName, Credits, TeacherId)
VALUES ('CS107', 'Object Oriented Programming with C#', 4, 1);

INSERT INTO Enrollments (StudentId, CourseCode) VALUES (1, 'CS107');
