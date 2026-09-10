using StudentManagementSystem.Core.Data;
using StudentManagementSystem.Core.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class StudentProfileForm : Form
    {
        private readonly User _currentUser;
        private Student _currentStudent;

        public StudentProfileForm(User user)
        {
            InitializeComponent();
            _currentUser = user ?? throw new ArgumentNullException(nameof(user));
        }

        private void StudentProfileForm_Load(object sender, EventArgs e)
        {
            LoadStudentDetails();
            LoadEnrolledCourses();
            LoadStudentGrades();
        }

        private void LoadStudentDetails()
        {
            lblWelcome.Text = $"Welcome, {_currentUser.FullName}";

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = @"
                        SELECT TOP 1 StudentID, RegNumber, FirstName, LastName, Email, Phone, Address, DateOfBirth, EnrollmentDate
                        FROM Students
                        WHERE IsActive = 1 
                          AND (RegNumber = @RegNumber OR Email = @Email)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RegNumber", _currentUser.IdNumber ?? string.Empty);
                        cmd.Parameters.AddWithValue("@Email", _currentUser.Email ?? string.Empty);

                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _currentStudent = new Student
                                {
                                    StudentID = Convert.ToInt32(reader["StudentID"]),
                                    RegNumber = reader["RegNumber"].ToString(),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : string.Empty,
                                    Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty,
                                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                                    EnrollmentDate = Convert.ToDateTime(reader["EnrollmentDate"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load student record: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_currentStudent != null)
            {
                lblNameVal.Text = $"{_currentStudent.FirstName} {_currentStudent.LastName}";
                lblRegNoVal.Text = _currentStudent.RegNumber;
                lblEmailVal.Text = _currentStudent.Email;
                lblPhoneVal.Text = string.IsNullOrWhiteSpace(_currentStudent.Phone) ? "Not provided" : _currentStudent.Phone;
            }
            else
            {
                lblNameVal.Text = _currentUser.FullName;
                lblRegNoVal.Text = string.IsNullOrWhiteSpace(_currentUser.IdNumber) ? "N/A" : _currentUser.IdNumber;
                lblEmailVal.Text = _currentUser.Email;
                lblPhoneVal.Text = string.IsNullOrWhiteSpace(_currentUser.Phone) ? "Not provided" : _currentUser.Phone;
            }
        }

        private void LoadEnrolledCourses()
        {
            if (_currentStudent == null)
            {
                return;
            }

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = @"
                        SELECT 
                            c.CourseCode AS [Course Code],
                            c.CourseName AS [Course Title],
                            c.Credits AS [Credits],
                            c.Department AS [Department],
                            sc.EnrollmentDate AS [Enrolled Date],
                            sc.Status AS [Status]
                        FROM StudentCourses sc
                        INNER JOIN Courses c ON sc.CourseID = c.CourseID
                        WHERE sc.StudentID = @StudentID
                        ORDER BY c.CourseCode ASC";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@StudentID", _currentStudent.StudentID);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvEnrolledCourses.DataSource = dt;

                        if (dgvEnrolledCourses.Columns["Enrolled Date"] != null)
                        {
                            dgvEnrolledCourses.Columns["Enrolled Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load enrolled courses: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentGrades()
        {
            if (_currentStudent == null)
            {
                return;
            }

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = @"
                        SELECT 
                            c.CourseCode AS [Course Code],
                            c.CourseName AS [Course Title],
                            g.GradeValue AS [Grade],
                            g.Remarks AS [Lecturer Remarks],
                            g.RecordedDate AS [Date Recorded]
                        FROM Grades g
                        INNER JOIN Courses c ON g.CourseID = c.CourseID
                        WHERE g.StudentID = @StudentID
                        ORDER BY g.RecordedDate DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@StudentID", _currentStudent.StudentID);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMyGrades.DataSource = dt;

                        if (dgvMyGrades.Columns["Date Recorded"] != null)
                        {
                            dgvMyGrades.Columns["Date Recorded"].DefaultCellStyle.Format = "yyyy-MM-dd";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load grades: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewReportCard_Click(object sender, EventArgs e)
        {
            if (_currentStudent == null)
            {
                MessageBox.Show("Your student record is not yet linked to an active student registration. Please contact the administrator.", "Report Card", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ReportCardForm reportCard = new ReportCardForm(_currentStudent);
            reportCard.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}
