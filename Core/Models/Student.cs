using System;
using System.Collections.Generic;
using StudentManagementSystem.Core.Interfaces;

namespace StudentManagementSystem.Core.Models
{
    /// <summary>
    /// Owned primarily by: Member 2 (Student Records module).
    /// Also used by: Member 4 (Attendance), Member 5 (Grades), Member 6 (Fees).
    /// </summary>
    public class Student : Person, IAttendable, IGradable, IPayable
    {
        public string StudentNumber { get; set; }
        public List<Course> EnrolledCourses { get; set; } = new List<Course>();
        public decimal OutstandingBalance { get; private set; }

        public Student(int id, string fullName, string email, DateTime dob, string studentNumber)
            : base(id, fullName, email, dob)
        {
            StudentNumber = studentNumber;
        }

        public override string GetRole() => "Student";

        // ----- IAttendable (Member 4 implements the logic that calls this) -----
        public List<AttendanceRecord> AttendanceHistory { get; set; } = new List<AttendanceRecord>();

        public void MarkAttendance(DateTime date, bool present)
        {
            AttendanceHistory.Add(new AttendanceRecord(date, present));
        }

        // ----- IGradable (Member 5 implements the logic that calls this) -----
        public Dictionary<string, double> Grades { get; set; } = new Dictionary<string, double>();

        public void AddGrade(string courseCode, double grade)
        {
            if (grade < 0 || grade > 100)
                throw new Core.Exceptions.InvalidGradeException(
                    $"Grade {grade} for {courseCode} is out of the valid 0-100 range.");

            Grades[courseCode] = grade;
        }

        public double GetGpa()
        {
            if (Grades.Count == 0) return 0.0;
            double total = 0;
            foreach (var g in Grades.Values) total += g;
            return total / Grades.Count;
        }

        // ----- IPayable (Member 6 implements the logic that calls this) -----
        public void ChargeFee(decimal amount)
        {
            OutstandingBalance += amount;
        }

        public void MakePayment(decimal amount)
        {
            if (amount > OutstandingBalance)
                throw new InvalidOperationException("Payment exceeds outstanding balance.");
            OutstandingBalance -= amount;
        }
    }

    // Small supporting type used by the Attendance module (Member 4)
    public class AttendanceRecord
    {
        public DateTime Date { get; set; }
        public bool Present { get; set; }

        public AttendanceRecord(DateTime date, bool present)
        {
            Date = date;
            Present = present;
        }
    }
}
