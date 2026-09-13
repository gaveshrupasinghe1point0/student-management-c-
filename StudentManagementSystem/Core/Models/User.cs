using System;

namespace StudentManagementSystem.Core.Models
{
    public class User
    {
        public int    UserID   { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role     { get; set; }   
        public string FullName { get; set; }
        public string Email    { get; set; }
        public string IdNumber { get; set; }
        public int?   Age      { get; set; }
        public string Gender   { get; set; }
        public string Phone    { get; set; }
    }
}