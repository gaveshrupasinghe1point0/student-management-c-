using System;

namespace StudentManagementSystem.Core.Models
{
    /// <summary>
    /// Abstract base class for anyone in the system (Student, Teacher, Admin).
    /// Demonstrates: Abstraction, Encapsulation, base for Inheritance.
    /// DO NOT instantiate this directly - always derive from it.
    /// </summary>
    public abstract class Person
    {
        // Encapsulated fields - accessed only through properties
        private string _fullName;
        private string _email;

        public int Id { get; set; }

        public string FullName
        {
            get => _fullName;
            set => _fullName = string.IsNullOrWhiteSpace(value)
                ? throw new ArgumentException("Full name cannot be empty.")
                : value;
        }

        public string Email
        {
            get => _email;
            set => _email = IsValidEmail(value)
                ? value
                : throw new ArgumentException("Invalid email format.");
        }

        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; } // Hash this in the real implementation (Auth module)

        protected Person(int id, string fullName, string email, DateTime dateOfBirth)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            DateOfBirth = dateOfBirth;
        }

        // Every derived class MUST provide its own role description.
        // This is the polymorphism hook - each subclass overrides this differently.
        public abstract string GetRole();

        // Virtual method - subclasses CAN override but don't have to.
        public virtual string GetSummary()
        {
            return $"[{GetRole()}] {FullName} (ID: {Id}) - {Email}";
        }

        private bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && email.Contains("@");
        }
    }
}
