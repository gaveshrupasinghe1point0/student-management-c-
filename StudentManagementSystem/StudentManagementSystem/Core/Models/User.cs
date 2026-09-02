using System;

namespace StudentManagementSystem.Core.Models
{
    /// <summary>
    /// Represents a system user (Admin or Student account).
    /// Maps to the Users table in StudentDB.
    /// </summary>
    public class User
    {
        public int    UserID   { get; set; }
        public string Username { get; set; }
        public string Role     { get; set; }   // "Admin" or "Student"
        public string FullName { get; set; }
        public string Email    { get; set; }
        public string IdNumber { get; set; }
        public int?   Age      { get; set; }
        public string Gender   { get; set; }
        public string Phone    { get; set; }
    }
}