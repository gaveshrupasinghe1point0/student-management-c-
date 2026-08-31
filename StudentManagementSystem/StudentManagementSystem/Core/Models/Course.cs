using System.Collections.Generic;

namespace StudentManagementSystem.Core.Models
{
    /// <summary>
    /// Owned by: Member 3 (Course Management module).
    /// Referenced by: Member 4 (Attendance), Member 5 (Grades), Member 7 (Timetable).
    /// </summary>
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public Teacher AssignedTeacher { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        public Course(string courseCode, string courseName, int credits)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Credits = credits;
        }

        public void Enroll(Student student)
        {
            if (EnrolledStudents.Contains(student))
                throw new Exceptions.DuplicateEnrollmentException(
                    $"{student.FullName} is already enrolled in {CourseCode}.");

            EnrolledStudents.Add(student);
        }
    }
}
