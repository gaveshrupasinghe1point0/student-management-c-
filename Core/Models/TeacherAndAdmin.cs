using System;
using System.Collections.Generic;

namespace StudentManagementSystem.Core.Models
{
    /// <summary>
    /// Owned by: Member 1 (Auth/Role module), used by Member 7 (Timetable).
    /// </summary>
    public class Teacher : Person
    {
        public string StaffNumber { get; set; }
        public List<Course> AssignedCourses { get; set; } = new List<Course>();

        public Teacher(int id, string fullName, string email, DateTime dob, string staffNumber)
            : base(id, fullName, email, dob)
        {
            StaffNumber = staffNumber;
        }

        public override string GetRole() => "Teacher";
    }

    /// <summary>
    /// Owned by: Member 1 (Auth/Role module).
    /// </summary>
    public class Admin : Person
    {
        public Admin(int id, string fullName, string email, DateTime dob)
            : base(id, fullName, email, dob) { }

        public override string GetRole() => "Admin";
    }
}
