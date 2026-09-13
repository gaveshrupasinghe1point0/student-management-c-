using StudentManagementSystem.Core.Exceptions;
using StudentManagementSystem.Core.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementSystem.Core.Data
{
    public class UserRepository
    {
        public User Authenticate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new AuthenticationException("Username and password are required.");

            string query = @"SELECT UserID, Username, PasswordHash, FullName, Email,
                                    IdNumber, AccountType, Age, Gender, Phone
                             FROM Users
                             WHERE Username = @Username
                               AND IsActive = 1";

            SqlParameter[] parameters = {
                new SqlParameter("@Username", username.Trim())
            };

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count == 0)
                    throw new AuthenticationException("Invalid username or password.");

                DataRow row = dt.Rows[0];
                string storedHash = row["PasswordHash"].ToString();

                if (storedHash != password)
                    throw new AuthenticationException("Invalid username or password.");

                return MapRowToUser(row);
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Error during authentication.", ex);
            }
        }

        public void RegisterUser(User user, string password)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            if (string.IsNullOrWhiteSpace(user.Username))
                throw new ValidationException("Username is required.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ValidationException("Password is required.");

            if (string.IsNullOrWhiteSpace(user.FullName))
                throw new ValidationException("Full name is required.");

            if (UsernameExists(user.Username))
                throw new ValidationException($"Username '{user.Username}' is already taken.");

            string query = @"INSERT INTO Users
                                (Username, PasswordHash, FullName, Email, IdNumber, AccountType, Age, Gender, Phone)
                             VALUES
                                (@Username, @PasswordHash, @FullName, @Email, @IdNumber, @AccountType, @Age, @Gender, @Phone)";

            SqlParameter[] parameters = {
                new SqlParameter("@Username",     user.Username.Trim()),
                new SqlParameter("@PasswordHash", password),
                new SqlParameter("@FullName",     user.FullName.Trim()),
                new SqlParameter("@Email",        (object)user.Email    ?? DBNull.Value),
                new SqlParameter("@IdNumber",     (object)user.IdNumber ?? DBNull.Value),
                new SqlParameter("@AccountType",  user.Role ?? "Student"),
                new SqlParameter("@Age",          (object)user.Age      ?? DBNull.Value),
                new SqlParameter("@Gender",       (object)user.Gender   ?? DBNull.Value),
                new SqlParameter("@Phone",        (object)user.Phone    ?? DBNull.Value)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to register new user.", ex);
            }
        }

        public bool UsernameExists(string username, int excludeUserId = 0)
        {
            string query = @"SELECT COUNT(1) FROM Users
                             WHERE Username = @Username AND UserID <> @ExcludeUserID AND IsActive = 1";

            SqlParameter[] parameters = {
                new SqlParameter("@Username",      username.Trim()),
                new SqlParameter("@ExcludeUserID", excludeUserId)
            };

            try
            {
                object result = DatabaseHelper.ExecuteScalar(query, parameters);
                return Convert.ToInt32(result) > 0;
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Error checking username uniqueness.", ex);
            }
        }

        public User GetUserByIdNumber(string idNumber)
        {
            if (string.IsNullOrWhiteSpace(idNumber)) return null;

            string query = @"SELECT UserID, Username, PasswordHash, FullName, Email,
                                    IdNumber, AccountType, Age, Gender, Phone
                             FROM Users
                             WHERE IdNumber = @IdNumber AND IsActive = 1";

            SqlParameter[] parameters = {
                new SqlParameter("@IdNumber", idNumber.Trim())
            };

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                if (dt.Rows.Count == 0) return null;
                return MapRowToUser(dt.Rows[0]);
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Error retrieving user account by ID number.", ex);
            }
        }

        public void SaveOrUpdateStudentUser(string oldIdNumber, string newIdNumber, string username, string password, string fullName, string email, string phone)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ValidationException("Username is required.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ValidationException("Password is required.");

            if (password.Length < 8)
                throw new ValidationException("Password must be at least 8 characters long.");

            User existingUser = null;
            if (!string.IsNullOrWhiteSpace(oldIdNumber))
            {
                existingUser = GetUserByIdNumber(oldIdNumber);
            }
            if (existingUser == null && !string.IsNullOrWhiteSpace(newIdNumber))
            {
                existingUser = GetUserByIdNumber(newIdNumber);
            }

            if (existingUser != null)
            {
                if (UsernameExists(username, existingUser.UserID))
                    throw new ValidationException($"Username '{username}' is already taken.");

                string query = @"UPDATE Users
                                 SET Username = @Username,
                                     PasswordHash = @PasswordHash,
                                     FullName = @FullName,
                                     Email = @Email,
                                     Phone = @Phone,
                                     IdNumber = @NewIdNumber
                                 WHERE UserID = @UserID";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username",     username.Trim()),
                    new SqlParameter("@PasswordHash", password),
                    new SqlParameter("@FullName",     fullName.Trim()),
                    new SqlParameter("@Email",        (object)email ?? DBNull.Value),
                    new SqlParameter("@Phone",        (object)phone ?? DBNull.Value),
                    new SqlParameter("@NewIdNumber",  (object)newIdNumber ?? DBNull.Value),
                    new SqlParameter("@UserID",       existingUser.UserID)
                };

                try
                {
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                }
                catch (SqlException ex)
                {
                    throw new DatabaseException("Failed to update user account.", ex);
                }
            }
            else
            {
                var newUser = new User
                {
                    Username = username.Trim(),
                    FullName = fullName.Trim(),
                    Email    = email,
                    IdNumber = newIdNumber,
                    Role     = "Student",
                    Phone    = phone
                };
                RegisterUser(newUser, password);
            }
        }

        public void DeactivateUserByIdNumber(string idNumber)
        {
            if (string.IsNullOrWhiteSpace(idNumber)) return;

            string query = @"UPDATE Users SET IsActive = 0 WHERE IdNumber = @IdNumber";
            SqlParameter[] parameters = {
                new SqlParameter("@IdNumber", idNumber.Trim())
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to deactivate user account.", ex);
            }
        }

        private User MapRowToUser(DataRow row)
        {
            return new User
            {
                UserID   = Convert.ToInt32(row["UserID"]),
                Username = row["Username"].ToString(),
                Password = row.Table.Columns.Contains("PasswordHash") && row["PasswordHash"] != DBNull.Value ? row["PasswordHash"].ToString() : string.Empty,
                Role     = row["AccountType"].ToString(),
                FullName = row["FullName"].ToString(),
                Email    = row["Email"]    != DBNull.Value ? row["Email"].ToString()    : string.Empty,
                IdNumber = row["IdNumber"] != DBNull.Value ? row["IdNumber"].ToString() : string.Empty,
                Age      = row["Age"]      != DBNull.Value ? (int?)Convert.ToInt32(row["Age"]) : null,
                Gender   = row["Gender"]   != DBNull.Value ? row["Gender"].ToString()   : string.Empty,
                Phone    = row["Phone"]    != DBNull.Value ? row["Phone"].ToString()    : string.Empty
            };
        }
    }
}
