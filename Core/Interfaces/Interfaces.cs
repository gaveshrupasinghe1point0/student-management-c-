using System;
using System.Collections.Generic;
using StudentManagementSystem.Core.Models;

namespace StudentManagementSystem.Core.Interfaces
{
    /// <summary>Implemented by Student. Used by Member 4 (Attendance module).</summary>
    public interface IAttendable
    {
        List<AttendanceRecord> AttendanceHistory { get; set; }
        void MarkAttendance(DateTime date, bool present);
    }

    /// <summary>Implemented by Student. Used by Member 5 (Grades module).</summary>
    public interface IGradable
    {
        Dictionary<string, double> Grades { get; set; }
        void AddGrade(string courseCode, double grade);
        double GetGpa();
    }

    /// <summary>Implemented by Student. Used by Member 6 (Fees module).</summary>
    public interface IPayable
    {
        decimal OutstandingBalance { get; }
        void ChargeFee(decimal amount);
        void MakePayment(decimal amount);
    }
}
