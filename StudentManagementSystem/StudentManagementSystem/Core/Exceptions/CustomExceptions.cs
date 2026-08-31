using System;

namespace StudentManagementSystem.Core.Exceptions
{
    /// <summary>Used by: Member 5 (Grades module).</summary>
    public class InvalidGradeException : Exception
    {
        public InvalidGradeException(string message) : base(message) { }
    }

    /// <summary>Used by: Member 3 (Course module) / Member 2 (Student Records).</summary>
    public class DuplicateEnrollmentException : Exception
    {
        public DuplicateEnrollmentException(string message) : base(message) { }
    }

    /// <summary>Used by: any module doing DB lookups (all members).</summary>
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message) : base(message) { }
    }

    /// <summary>Used by: Member 7 (Timetable module).</summary>
    public class SchedulingConflictException : Exception
    {
        public SchedulingConflictException(string message) : base(message) { }
    }

    /// <summary>Used by: Member 6 (Fees module).</summary>
    public class InsufficientPaymentException : Exception
    {
        public InsufficientPaymentException(string message) : base(message) { }
    }
}
